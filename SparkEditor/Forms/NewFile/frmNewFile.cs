using SparkEditor.FiestaLib.SHN;
using SparkEditor.FiestaLib.Shine;
using SparkEditor.FiestaLib.Quest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SparkEditor.FiestaLib;

namespace SparkEditor.Forms.NewFile
{
    public partial class frmNewFile : Form
    {
        public IFile file;
        public frmNewFile()
        {
            InitializeComponent();
            cbFileType.SelectedIndex = 0;
            file = new SHNFile(txtFileName.Text + ".shn");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            file = file ?? new SHNFile(txtFileName.Text + ".shn");
            file.FilePath = txtFileName.Text + (file.GetType() == typeof(ShineFile) ? ".txt" : ".shn");
            file.IsSaved = false;

            if (cbFileType.SelectedIndex == 2)
            {
                using (var frm = new frmQuestDependencies())
                {
                    if (frm.ShowDialog(this) == DialogResult.OK)
                    {
                        file = new QuestFile(txtFileName.Text + ".shn", true, frm.MobInfoPath, frm.ItemInfoPath);
                    }
                }

                using (var frm = new frmChooseQuestVersion((QuestFile)file))
                {
                    if (frm.ShowDialog(this) != DialogResult.OK)
                    {
                        ((QuestFile)file).QuestFileVersion = QuestFileVersion.NA11;
                    }
                }
            }

            if (file.GetType() == typeof(SHNFile))
                ((SHNFile)file).CreateFile();

            Program.LoadedFiles.Add(file);
        }

        private void linkAddColumn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var frm = new frmNewColumn(file))
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    lvColumns.Items.Add(new ListViewItem(new string[] { frm.ColumnName, frm.ColumnType.Name, frm.ColumnLength.ToString() }));

                    if (file.GetType() == typeof(SHNFile))
                    {
                        ((DataTable)file).Columns.Add(new SHNColumn(frm.ColumnName, frm.ColumnLength, frm.ColumnSHNType, frm.ColumnType));
                    }
                    else if (file.GetType() == typeof(ShineFile))
                    {
                        ((DataSet)file).Tables[cbTables.SelectedIndex].Columns.Add(new DataColumn(frm.ColumnName, frm.ColumnType));
                        ((ShineTable)((ShineFile)file).Tables[cbTables.SelectedIndex]).ColumnTypes.Add(frm.ColumnType.Name + (frm.ColumnType == typeof(string) ? "[" + frm.ColumnLength + "]" : ""));
                    }
                }
            }
        }

        private void cbFileType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvColumns.Items.Clear();
            try
            {
                switch (cbFileType.SelectedIndex)
                {
                    // SHN File
                    case 0:
                        file = new SHNFile(txtFileName.Text + ".shn");

                        gbColumns.Enabled = true;
                        cbTables.Enabled = false;
                        linkTableEditor.Enabled = false;
                        lblFileType.Text = ".shn";
                        break;

                    // Shine File
                    case 1:
                        file = new ShineFile(txtFileName.Text + ".txt");
                        gbColumns.Enabled = true;
                        cbTables.Enabled = true;
                        linkTableEditor.Enabled = true;
                        lblFileType.Text = ".txt";

                        ((ShineFile)file).Tables.Add(new ShineTable("Table1"));
                        cbTables.DataSource = ((ShineFile)file).Tables.Cast<DataTable>().AsEnumerable().ToList();
                        cbTables.DisplayMember = "TableName";
                        break;

                    // Quest File
                    case 2:
                        txtFileName.Text = "QuestData";
                        lblFileType.Text = ".shn";
                        gbColumns.Enabled = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkRemoveColumn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lvColumns.SelectedItems.Count != 0)
            {
                if (file.GetType() == typeof(SHNFile))
                {
                    ((DataTable)file).Columns.RemoveAt(lvColumns.SelectedIndices[0]);
                    lvColumns.Items.RemoveAt(lvColumns.SelectedIndices[0]);
                }
            }
        }

        private void frmNewFile_Load(object sender, EventArgs e)
        {

        }

        private void linkTableEditor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var frm = new frmTableEditor(((ShineFile)file).Tables))
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    ((ShineFile)file).Tables.Clear();
                    ((ShineFile)file).Tables.AddRange(frm.Tables.Cast<ShineTable>().ToArray());
                    cbTables.DataSource = ((ShineFile)file).Tables.Cast<ShineTable>().AsEnumerable().ToList();
                }
            }
        }

        private void cbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvColumns.Items.Clear();

            foreach (DataColumn col in ((ShineFile)file).Tables[cbTables.SelectedIndex].Columns)
            {
                lvColumns.Items.Add(new ListViewItem(new string[] { col.ColumnName, col.DataType.Name, col.MaxLength.ToString() }));
            }
        }
    }
}
