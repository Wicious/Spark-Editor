using System;
using System.Diagnostics;

namespace iShine.Cryptography
{
    public static class Crypter
    {
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
                xorByNext = (byte)(xorByNext & 15);
                xorByNext = (byte)(xorByNext + 0x55);
                xorByNext = (byte)(xorByNext ^ ((byte)(((byte)i) * 11)));
                xorByNext = (byte)(xorByNext ^ xorBy);
                xorByNext = (byte)(xorByNext ^ 170);
                xorBy = xorByNext;
            }
        }
    }
}
