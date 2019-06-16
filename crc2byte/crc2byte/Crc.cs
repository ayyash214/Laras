using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crc2byte
{
    class Crc
    {
        private CrcModel crcModel;
        private ushort[] crcTable;

        public Crc(CrcModel model)
        {
            this.crcModel = model;
            CalculateCrcTable();
        }

        private void CalculateCrcTable()
        {
            crcTable = new ushort[256];

            for (int divident = 0; divident < 256; divident++)
            {
                ushort curByte = (ushort)(divident << 8);
                for (byte bit = 0; bit < 8; bit++)
                {
                    if ((curByte & 0x8000) != 0)
                    {
                        curByte <<= 1;
                        curByte ^= crcModel.Polynomial;
                    }
                    else
                    {
                        curByte <<= 1;
                    }
                }

                crcTable[divident] = curByte;
            }
        }

        public ushort Compute_Simple(byte[] bytes)
        {
            ushort crc = crcModel.Initial;

            foreach (byte b in bytes)
            {
                byte curByte = (crcModel.InputReflected ? CrcUtil.Reflect8(b) : b);
                crc ^= (ushort)(curByte << 8); /* move byte into MSB of 16bit CRC */

                for (int i = 0; i < 8; i++)
                {
                    if ((crc & 0x8000) != 0)
                    {
                        crc = (ushort)((crc << 1) ^ crcModel.Polynomial);
                    }
                    else
                    {
                        crc <<= 1;
                    }
                }
            }

            crc = (crcModel.ResultReflected ? CrcUtil.Reflect(crc) : crc);
            return (ushort)(crc ^ crcModel.FinalXor);
        }
    }
}
