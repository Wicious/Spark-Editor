using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iShine.Cryptography
{
    public class Encryption
    {
        public byte[] XorTable = new byte[4];

        public Encryption()
        {
            XorTable = new byte[] { Properties.Settings.Default.Xor00,
                                        Properties.Settings.Default.Xor01,
                                        Properties.Settings.Default.Xor02,
                                        Properties.Settings.Default.Xor03 };
        }

        public Encryption(byte value0, byte value1, byte value2, byte value3)
        {
            XorTable = new byte[] { value0, value1, value2, value3 };
        }

        public byte this[byte i]
        {
            get
            {
                return XorTable[i];
            }

            set
            {
                XorTable[i] = value; 
            }
        }
    }
}
