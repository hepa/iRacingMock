using iRacingSdkWrapper;
using iRSDKSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRacingMock.ClassLibrary
{
    class MockTelemetryValue<T> : ITelemetryValue<T>
    {
        public bool Exists { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Unit { get; set; }

        public CVarHeader.VarType Type { get; set; }

        public T Value {get;set;}

        public object GetValue()
        {
            throw new NotImplementedException();
        }
    }
}
