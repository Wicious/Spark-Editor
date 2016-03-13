using SparkEditor.FiestaLib;
using SparkEditor.FiestaLib.SHN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SparkEditor.Forms.NewFile
{
    public partial class frmNewColumn : Form
    {
        public string ColumnName { get { return txtColumnName.Text; } }
        public Type ColumnType { get { return Type.GetType("System." + cbColumnType.SelectedItem.ToString()); } }
        public SHNType ColumnSHNType { get { return ((SHNType)cbColumnType.SelectedItem); } }
        public int ColumnLength { get { return Convert.ToInt32(nudColumnLength.Value); } }

        public frmNewColumn(IFile file)
        {
            InitializeComponent();
        }

        private void frmNewColumn_Load(object sender, EventArgs e)
        {
            cbColumnType.DataSource = Enum.GetValues(typeof(SHNType));
        }

        private void cbColumnType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((SHNType)cbColumnType.SelectedItem) != SHNType.String)
            {
                nudColumnLength.Minimum = -1;
                nudColumnLength.Maximum = -1;
                nudColumnLength.Value = -1;
            }
            else
            {
                nudColumnLength.Minimum = 0;
                nudColumnLength.Maximum = 255;
                nudColumnLength.Value = 32;
            }
        }
    }
}
