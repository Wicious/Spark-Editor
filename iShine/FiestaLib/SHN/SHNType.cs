using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iShine.FiestaLib.SHN
{
    public enum SHNType
    {

        [SHNType(typeof(string), 0x09, 0x18)]
        String,

        [SHNType(typeof(byte), 0x01, 0x0C, 0x10)]
        Byte,

        [SHNType(typeof(ushort), 0x02)]
        UShort,

        [SHNType(typeof(string), 0x1A)]
        UnknownLengthString,

        [SHNType(typeof(uint), 0x03, 0x0B, 0x12, 0x1B)]
        UInt,

        [SHNType(typeof(Single), 0x05)]
        Single,

        [SHNType(typeof(short), 0x15, 0x0D)]
        Short,

        [SHNType(typeof(sbyte), 0x14)]
        SByte,

        [SHNType(typeof(int), 0x16)]
        Int,

        [SHNType(typeof(object))]
        Default
    }
}
