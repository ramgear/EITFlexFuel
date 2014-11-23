using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace EITFlex.Datas
{
    public class DataUtils
    {
        public static Byte[] StructToBytes<T>(T src) where T : struct
        {
            int objsize = Marshal.SizeOf(typeof(T));
            Byte[] ret = new Byte[objsize];
            IntPtr buff = Marshal.AllocHGlobal(objsize);
            Marshal.StructureToPtr(src, buff, true);
            Marshal.Copy(buff, ret, 0, objsize);
            Marshal.FreeHGlobal(buff);
            return ret;
        }

        public static T BytesToStruct<T>(Byte[] src) where T : struct
        {
            int objsize = Marshal.SizeOf(typeof(T));
            IntPtr buff = Marshal.AllocHGlobal(objsize);

            // avoid array index out of range
            if (objsize > src.Length)
                objsize = src.Length;

            Marshal.Copy(src, 0, buff, objsize);
            T retStruct = (T)Marshal.PtrToStructure(buff, typeof(T));
            Marshal.FreeHGlobal(buff);
            return retStruct;
        }

        const Byte ChkSumMask = 0x55;
        public static Byte CalCheckSum(CommandData cmd)
        {
            // no include CheckSum value 
            Byte tmp = cmd.CheckSum;
            cmd.CheckSum = 0;
            Byte[] data = cmd;
            cmd.CheckSum = tmp;

            Byte sum = 0;
            int count = 0;

            while (count < data.Length)
                sum += data[count++];

            sum += ChkSumMask;

            return sum;
        }
    }
}
