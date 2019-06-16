using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace crc2byte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string ToHex(ushort val)
        {
            return String.Format("0x{0:X4}", val);
        }

        public void LogFailedTest(ushort actualValue, ushort expectedValue)
        {
            textBox4.Text += "\r\n F: Actual: " + ToHex(actualValue) + " Expected: " + ToHex(expectedValue);
        }

        public void LogSucceededTest()
        {
            textBox4.Text += "\r\n x";
        }

        public bool Assert(ushort actualValue, ushort expectedValue)
        {
            if (actualValue != expectedValue)
            {
                LogFailedTest(actualValue, expectedValue);
                return false;
            }
            else
            {
                LogSucceededTest();
                return true;
            }
        }

        private static byte[] StandardTestDataInput = new byte[] { 0x7E, 0x7E, 0xFA, 0xFF, 0x02, 0x01, 0x00 };

        private static CrcTestData[] testdataEntries = new CrcTestData[]  
        {
            //new CrcTestData(CrcDatabase.CRC_ARC, StandardTestDataInput, 0xBB3D),
            //new CrcTestData(CrcDatabase.CRC_AUG_CCITT, StandardTestDataInput, 0xE5CC),
            //new CrcTestData(CrcDatabase.CRC_BUYPASS, StandardTestDataInput, 0xFEE8),
            //new CrcTestData(CrcDatabase.CRC_CCITT_FALSE, StandardTestDataInput, 0x29B1),
            //new CrcTestData(CrcDatabase.CRC_CDMA2000, StandardTestDataInput, 0x4C06),
            //new CrcTestData(CrcDatabase.CRC_DDS_110, StandardTestDataInput, 0x9ECF),
            //new CrcTestData(CrcDatabase.CRC_DECT_R, StandardTestDataInput, 0x007E),
            //new CrcTestData(CrcDatabase.CRC_DECT_X, StandardTestDataInput, 0x007F),
            //new CrcTestData(CrcDatabase.CRC_DNP, StandardTestDataInput, 0xEA82),
            //new CrcTestData(CrcDatabase.CRC_EN_13757, StandardTestDataInput, 0xC2B7),
            //new CrcTestData(CrcDatabase.CRC_GENIBUS, StandardTestDataInput, 0xD64E),
            //new CrcTestData(CrcDatabase.CRC_MAXIM, StandardTestDataInput, 0x44C2),
            //new CrcTestData(CrcDatabase.CRC_MCRF4XX, StandardTestDataInput, 0x6F91),
            //new CrcTestData(CrcDatabase.CRC_RIELLO, StandardTestDataInput, 0x63D0),
            //new CrcTestData(CrcDatabase.CRC_T10_DIF, StandardTestDataInput, 0xD0DB),
            //new CrcTestData(CrcDatabase.CRC_TELEDISK, StandardTestDataInput, 0x0FB3), 
            //new CrcTestData(CrcDatabase.CRC_TMS37157, StandardTestDataInput, 0x26B1), 
            new CrcTestData(CrcDatabase.CRC_USB, StandardTestDataInput, 0xB4C8),
            //new CrcTestData(CrcDatabase.CRC_A, StandardTestDataInput, 0xBF05),
            //new CrcTestData(CrcDatabase.CRC_KERMIT, StandardTestDataInput, 0x2189),
            //new CrcTestData(CrcDatabase.CRC_MODBUS, StandardTestDataInput, 0x4B37),
            //new CrcTestData(CrcDatabase.CRC_X_25, StandardTestDataInput, 0x906E),
            //new CrcTestData(CrcDatabase.CRC_XMODEM, StandardTestDataInput, 0x31C3),
            //success login
            new CrcTestData(CrcDatabase.CRC_USB, StandardTestDataInput, 0xB638),
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Text = "0x" + BitConverter.ToString(StandardTestDataInput).Replace("-"," 0x");
            foreach (CrcTestData testEntry in testdataEntries)
            {
                Crc crcAlgo = new Crc(testEntry.CrcModel);
                Assert(crcAlgo.Compute_Simple(testEntry.InputBytes), testEntry.ResultCrc);
            }
        }
    }
}
