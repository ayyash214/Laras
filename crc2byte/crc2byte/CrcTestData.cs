using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crc2byte
{
    class CrcTestData
    {
        public CrcModel CrcModel { get; private set; }
        public byte[] InputBytes { get; private set; }
        public ushort ResultCrc { get; private set; }

        public CrcTestData(CrcModel model, byte[] inputbytes, ushort result)
        {
            this.CrcModel = model;
            this.InputBytes = inputbytes;
            this.ResultCrc = result;
        }
    }
}
