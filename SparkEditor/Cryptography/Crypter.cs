using System;
using System.Diagnostics;

namespace SparkEditor.Cryptography
{
    public static class Crypter
    {
        public static Encryption DefaultEncryption = new Encryption();

        [DebuggerStepThrough]
        public static void Crypt(Encryption encryption, byte[] data, int startIndex, int length)
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
                xorByNext = (byte)(xorByNext & encryption[0]);
                xorByNext = (byte)(xorByNext + encryption[1]);
                xorByNext = (byte)(xorByNext ^ ((byte)(((byte)i) * encryption[2])));
                xorByNext = (byte)(xorByNext ^ xorBy);
                xorByNext = (byte)(xorByNext ^ encryption[3]);
                xorBy = xorByNext;
            }
        }

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
                xorByNext = (byte)(xorByNext & DefaultEncryption[0]);
                xorByNext = (byte)(xorByNext + DefaultEncryption[1]);
                xorByNext = (byte)(xorByNext ^ ((byte)(((byte)i) * DefaultEncryption[2])));
                xorByNext = (byte)(xorByNext ^ xorBy);
                xorByNext = (byte)(xorByNext ^ DefaultEncryption[3]);
                xorBy = xorByNext;
            }
        }
    }
}
