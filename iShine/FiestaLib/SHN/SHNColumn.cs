using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iShine.FiestaLib.SHN
{
    public class SHNColumn : DataColumn
    {
        public int Length { get; set; }
        public SHNType SHNType { get; set; }

        public SHNColumn(string name, int length, SHNType shnType, Type dataType)
            : base(name, dataType)
        {
            Length = length;
            SHNType = shnType;
        }
    }
}
