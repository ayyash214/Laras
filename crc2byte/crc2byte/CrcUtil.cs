using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crc2byte
{
    class CrcUtil
    {
        public static byte Reflect8(byte val)
        {
            byte resByte = 0;

            for (int i = 0; i < 8; i++)
            {
                if ((val & (1 << i)) != 0)
                {
                    resByte |= (byte)(1 << (7 - i));
                }
            }

            return resByte;
        }

        public static ushort Reflect(ushort val)
        {
            ushort resVal = 0;

            for (int i = 0; i < 16; i++)
            {
                if ((val & (1 << i)) != 0)
                {
                    resVal |= (ushort)(1 << (15 - i));
                }
            }

            return resVal;
        }
    }
}
