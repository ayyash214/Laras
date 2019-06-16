using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crc2byte
{
    class CrcDatabase
    {
        public static CrcModel CRC_CCIT_ZERO = new CrcModel(0x1021, 0x0000, 0x0000, false, false);

        public static CrcModel CRC_ARC = new CrcModel(0x8005, 0x0000, 0x0000, true, true);
        public static CrcModel CRC_AUG_CCITT = new CrcModel(0x1021, 0x1D0F, 0x0000, false, false);
        public static CrcModel CRC_BUYPASS = new CrcModel(0x8005, 0x0000, 0x0000, false, false);
        public static CrcModel CRC_CCITT_FALSE = new CrcModel(0x1021, 0xFFFF, 0x0000, false, false);
        public static CrcModel CRC_CDMA2000 = new CrcModel(0xC867, 0xFFFF, 0x0000, false, false);
        public static CrcModel CRC_DDS_110 = new CrcModel(0x8005, 0x800D, 0x0000, false, false);
        public static CrcModel CRC_DECT_R = new CrcModel(0x0589, 0x0000, 0x0001, false, false);
        public static CrcModel CRC_DECT_X = new CrcModel(0x0589, 0x0000, 0x0000, false, false);
        public static CrcModel CRC_DNP = new CrcModel(0x3D65, 0x0000, 0xFFFF, true, true);
        public static CrcModel CRC_EN_13757 = new CrcModel(0x3D65, 0x0000, 0xFFFF, false, false);
        public static CrcModel CRC_GENIBUS = new CrcModel(0x1021, 0xFFFF, 0xFFFF, false, false);
        public static CrcModel CRC_MAXIM = new CrcModel(0x8005, 0x0000, 0xFFFF, true, true);
        public static CrcModel CRC_MCRF4XX = new CrcModel(0x1021, 0xFFFF, 0x0000, true, true);
        public static CrcModel CRC_RIELLO = new CrcModel(0x1021, 0xB2AA, 0x0000, true, true);
        public static CrcModel CRC_T10_DIF = new CrcModel(0x8BB7, 0x0000, 0x0000, false, false);
        public static CrcModel CRC_TELEDISK = new CrcModel(0xA097, 0x0000, 0x0000, false, false);
        public static CrcModel CRC_TMS37157 = new CrcModel(0x1021, 0x89EC, 0x0000, true, true);
        public static CrcModel CRC_USB = new CrcModel(0x8005, 0xFFFF, 0xFFFF, true, true);
        public static CrcModel CRC_A = new CrcModel(0x1021, 0xC6C6, 0x0000, true, true);
        public static CrcModel CRC_KERMIT = new CrcModel(0x1021, 0x0000, 0x0000, true, true);
        public static CrcModel CRC_MODBUS = new CrcModel(0x8005, 0xFFFF, 0x0000, true, true);
        public static CrcModel CRC_X_25 = new CrcModel(0x1021, 0xFFFF, 0xFFFF, true, true);
        public static CrcModel CRC_XMODEM = new CrcModel(0x1021, 0x0000, 0x0000, false, false);
    }
}
