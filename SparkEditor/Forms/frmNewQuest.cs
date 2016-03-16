using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SparkEditor.Forms
{
    public partial class frmNewQuest : Form
    {
        public string Title { get { return txtTitle.Text; } }
        public string Description { get { return txtDescription.Text; } }

        public frmNewQuest()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
        }
    }
}
