using SparkEditor.FiestaLib.Shine;
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
    public partial class frmTableEditor : Form
    {
        public BindingList<ShineTable> Tables;

        public frmTableEditor(DataTableCollection tables)
        {
            InitializeComponent();
            Tables = new BindingList<ShineTable>();
            
            foreach(DataTable table in tables)
            {
                Tables.Add(new ShineTable(table.TableName));
            }

            lbTables.DataSource = Tables;
            lbTables.DisplayMember = "TableName";
        }

        private void linkAddTable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (Tables.Where(t => t.TableName == txtTableName.Text).Count() > 0)
                    throw new Exception("A table with the same name already exists in this collection.");

                if (txtTableName.Text.Length == 0)
                    throw new Exception("Name cannot be empty.");

                Tables.Add(new ShineTable(txtTableName.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkRemoveSelected_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (lbTables.SelectedItem == null)
                    throw new Exception("You have to select a table in the list first.");

                Tables.RemoveAt(lbTables.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void linkMoveUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }
    }
}
