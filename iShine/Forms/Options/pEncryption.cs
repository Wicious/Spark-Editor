using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iShine.Cryptography;

namespace iShine.Forms.Options
{
    public partial class pEncryption : UserControl
    {
        public byte Xor00 { get { return Convert.ToByte(nudXor00.Value); } }
        public byte Xor01 { get { return Convert.ToByte(nudXor01.Value); } }
        public byte Xor02 { get { return Convert.ToByte(nudXor02.Value); } }
        public byte Xor03 { get { return Convert.ToByte(nudXor03.Value); } }

        public pEncryption()
        {
            InitializeComponent();

            nudXor00.Value = Crypter.DefaultEncryption[0];
            nudXor01.Value = Crypter.DefaultEncryption[1];
            nudXor02.Value = Crypter.DefaultEncryption[2];
            nudXor03.Value = Crypter.DefaultEncryption[3];
        }
    }
}
