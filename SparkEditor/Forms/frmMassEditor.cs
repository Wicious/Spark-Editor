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

namespace SparkEditor.Forms
{
    public partial class frmMassEditor : Form
    {
        private IFile file;
        private Type fileType;

        public frmMassEditor(IFile file)
        {
            InitializeComponent();
            this.file = file;
            fileType = file.GetType();

            switch (fileType.Name)
            {
                case "SHNFile":
                    cbGetColumn.DataSource = ((SHNFile)file).Columns.Cast<DataColumn>().AsEnumerable().ToList();
                    cbWhere.DataSource = ((SHNFile)file).Columns.Cast<DataColumn>().AsEnumerable().ToList();

                    cbGetColumn.DisplayMember = "ColumnName";
                    cbWhere.DisplayMember = "ColumnName";
                    break;

                case "ShineFile":

                    break;
            }

            cbSetAction.SelectedIndex = 0;
            cbGetType.SelectedIndex = 0;
            txtGetValue.PlaceHolder("Value");
            txtSetValue.PlaceHolder("Value");
        }

        private void textBoxEnter(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;

            if (textBox.Text == textBox.PlaceHolder())
            {
                textBox.ForeColor = Color.Black;
                textBox.Clear();
            }
        }

        private void textBoxLeave(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;

            if (textBox.Text == String.Empty)
            {
                textBox.ForeColor = Color.FromArgb(170, 170, 170);
                textBox.Text = textBox.PlaceHolder();
            }
        }

        private void cbSetAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSetAction.SelectedItem.ToString() == "Row Tally")
            {
                pTally.Show();
            }
            else
            {
                pTally.Hide();
            }
        }

        private void cbFiltered_CheckedChanged(object sender, EventArgs e)
        {
            pFilter.Enabled = cbFiltered.Checked;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                switch (fileType.Name)
                {
                    case "SHNFile":
                        if (!cbFiltered.Checked)
                        {
                            ((SHNFile)file).DefaultView.RowFilter = "";
                        }

                        int rowid = 0;
                        int value = Convert.ToInt32(numStartValue.Value);
                        foreach (DataRow row in ((SHNFile)file).Rows)
                        {
                            switch (cbSetAction.SelectedItem.ToString())
                            {
                                case "New Value":
                                    row[cbGetColumn.SelectedIndex] = txtSetValue.Text;
                                    break;

                                case "Add":
                                    row[cbGetColumn.SelectedIndex] = txtSetValue.Text;
                                    break;

                                case "Subtract":
                                    row[cbGetColumn.SelectedIndex] = txtSetValue.Text;
                                    break;

                                case "Multiply":
                                    row[cbGetColumn.SelectedIndex] = txtSetValue.Text;
                                    break;

                                case "Divide":
                                    row[cbGetColumn.SelectedIndex] = txtSetValue.Text;
                                    break;

                                case "Prefix":
                                    row[cbGetColumn.SelectedIndex] = txtSetValue.Text;
                                    break;

                                case "Suffix":
                                    row[cbGetColumn.SelectedIndex] = txtSetValue.Text;
                                    break;

                                case "Remove":
                                    row[cbGetColumn.SelectedIndex] = txtSetValue.Text;
                                    break;

                                case "Row Tally":
                                    if (rowid < numStartRow.Value - 1 || rowid > numEndRow.Value - 1)
                                    {
                                        rowid++;
                                        continue;
                                    }
                                    rowid++;

                                    row[cbGetColumn.SelectedIndex] = value++;
                                    break;
                            }

                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void numStartRow_ValueChanged(object sender, EventArgs e)
        {
            if (numStartRow.Value > numEndRow.Value)
                numEndRow.Value = numStartRow.Value;

            numEndRow.Minimum = numStartRow.Value;
        }

        private void frmMassEditor_Load(object sender, EventArgs e)
        {
        }

        private void btnSetFilter_Click(object sender, EventArgs e)
        {
            switch (cbGetType.SelectedItem.ToString())
            {
                case "Equals":
                    ((SHNFile)file).DefaultView.RowFilter = String.Format("CONVERT({1}, System.String) = '{0}'", txtGetValue.Text, ((DataColumn)cbWhere.SelectedItem).ColumnName);
                    break;

                case "Contains":
                    ((SHNFile)file).DefaultView.RowFilter = String.Format("CONVERT({1}, System.String) LIKE '%{0}%'", txtGetValue.Text, ((DataColumn)cbWhere.SelectedItem).ColumnName);
                    break;

                case "Starts With":
                    ((SHNFile)file).DefaultView.RowFilter = String.Format("CONVERT({1}, System.String) LIKE '{0}%'", txtGetValue.Text, ((DataColumn)cbWhere.SelectedItem).ColumnName);
                    break;

                case "Ends With":
                    ((SHNFile)file).DefaultView.RowFilter = String.Format("CONVERT({1}, System.String) LIKE '%{0}'", txtGetValue.Text, ((DataColumn)cbWhere.SelectedItem).ColumnName);
                    break;

                case "More Than":
                    ((SHNFile)file).DefaultView.RowFilter = String.Format("CONVERT({1}, System.String) > '{0}'", txtGetValue.Text, ((DataColumn)cbWhere.SelectedItem).ColumnName);
                    break;

                case "Less Than":
                    ((SHNFile)file).DefaultView.RowFilter = String.Format("CONVERT({1}, System.String) < '{0}'", txtGetValue.Text, ((DataColumn)cbWhere.SelectedItem).ColumnName);
                    break;
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            ((SHNFile)file).DefaultView.RowFilter = "";
        }
    }
}
