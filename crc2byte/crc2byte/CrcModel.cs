using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crc2byte
{
    class CrcModel
    {
        public ushort Polynomial { get; private set; }
        public ushort Initial { get; private set; }
        public ushort FinalXor { get; private set; }
        public bool InputReflected { get; private set; }
        public bool ResultReflected { get; private set; }

        public CrcModel(ushort polynomial, ushort initialVal, ushort finalXorVal, bool inputReflected, bool resultReflected)
        {
            this.Polynomial = polynomial;
            this.Initial = initialVal;
            this.FinalXor = finalXorVal;
            this.InputReflected = inputReflected;
            this.ResultReflected = resultReflected;
        }

        public static CrcModel GetReflectedCrcModel(CrcModel model)
        {
            return new CrcModel(
                CrcUtil.Reflect(model.Polynomial),
                CrcUtil.Reflect(model.Initial),
                model.FinalXor,
                !model.InputReflected,
                !model.ResultReflected
            );
        }
    }
}
