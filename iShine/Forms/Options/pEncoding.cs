using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iShine.Forms.Options
{
    public partial class pEncoding : UserControl
    {
        public EncodingInfo Encoding { get { return (EncodingInfo)cbEncodings.SelectedItem; } }

        public pEncoding()
        {
            InitializeComponent();

            var encodings = System.Text.Encoding.GetEncodings();
            Array.Sort(encodings, (x, y) => x.Name.CompareTo(y.Name));

            cbEncodings.DataSource = encodings;
            cbEncodings.DisplayMember = "Name";

            cbEncodings.SelectedItem = cbEncodings.Items
                .Cast<EncodingInfo>()
                .AsEnumerable()
                .First(ei => ei.Name == Program.DefaultEncodingInfo.Name);
        }
    }
}
