using System;
using System.Diagnostics;

namespace iShine.Cryptography
{
    public static class Crypter
    {
        public static byte[] XorTable = new byte[] { 15, 0x55, 11, 170 };

        [DebuggerStepThrough]
        public static void Crypt(byte[] data, int startIndex, int length)
        {
            if (((startIndex < 0) | (length < 1)) | ((startIndex + length) > data.Length))
            {
                throw new IndexOutOfRangeException();
            }

            byte xorBy = (byte)length;
            for (int i = length - 1; i >= 0; i--)
            {
                data[i] = (byte)(data[i] ^ xorBy);
                byte xorByNext = (byte)i;
                xorByNext = (byte)(xorByNext & XorTable[0]);
                xorByNext = (byte)(xorByNext + XorTable[1]);
                xorByNext = (byte)(xorByNext ^ ((byte)(((byte)i) * XorTable[2])));
                xorByNext = (byte)(xorByNext ^ xorBy);
                xorByNext = (byte)(xorByNext ^ XorTable[3]);
                xorBy = xorByNext;
            }
        }
    }
}
