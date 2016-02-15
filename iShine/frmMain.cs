using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iShine.FiestaLib;
using System.IO;

namespace iShine
{
    public partial class frmMain : Form
    {
        // Put all files in here for access.
        private List<IFile> LoadedFiles = new List<IFile>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            using (var frm = new OpenFileDialog())
            {
                frm.Title = "Open File";
                frm.Filter = "SHN File|*.shn|Shine File|*.txt";

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    openFile(frm.FileName);
                }
            }
        }

        private async void openFile(string fileName)
        {
            try
            {
                // Display the hidden progressbar in the statusbar.
                pbProgress.Visible = true;

                // Determine what file type it is and perform the appropriate action.
                switch (Path.GetExtension(fileName))
                {
                    case ".shn":
                        var shnFile = new SHNFile(fileName);

                        var dgv = new DataGridView();
                        dgv.DoubleBuffered(true);

                        lblStatus.Text = "Reading " + Path.GetFileName(fileName);

                        // Await the asynchronous Load method and display the reported progress in our progressbar.
                        await Task.Run(() => shnFile.Load(new Progress<int>(value =>
                            mainStatusStrip.Invoke(new MethodInvoker(() =>
                            {
                                pbProgress.Value = value;
                            }))
                        )));

                        var tab = new TabPage(shnFile.TableName);
                        dgv.Dock = DockStyle.Fill;
                        dgv.BackgroundColor = Color.WhiteSmoke;
                        dgv.DataSource = shnFile;
                        tab.Controls.Add(dgv);

                        shnFile.RowChanged += File_RowChanged;
                        dgv.CellEnter += File_CellEnter;

                        LoadedFiles.Add(shnFile);


                        tcFiles.TabPages.Add(tab);
                        tcFiles.SelectedTab = tab;

                        break;

                    default:
                        throw new Exception("File type not supported");
                }

                // Hide and reset the progressbar.
                pbProgress.Visible = false;
                pbProgress.Value = 0;
                lblStatus.Text = "Ready";
                updateFileInfo();
            }
            catch (Exception ex)
            {
                pbProgress.Visible = false;
                pbProgress.Value = 0;
                lblStatus.Text = "Ready";
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void File_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblCellInfo.Text = String.Format("(Row: {0}, Column: {1})", e.RowIndex + 1, e.ColumnIndex + 1);
            }
            catch (Exception)
            { }
        }

        private void File_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            try
            {
                LoadedFiles[tcFiles.SelectedIndex].IsSaved = false;
                updateFileInfo();
            }
            catch (Exception ex)
            { }
        }

        private async void saveFile(string filePath)
        {
            try
            {
                // Display the hidden progressbar in the statusbar.
                pbProgress.Visible = true;

                var file = LoadedFiles[tcFiles.SelectedIndex];

                lblStatus.Text = "Saving " + Path.GetFileName(file.FilePath);

                // Await the asynchronous Save method and display the reported progress in our progressbar.
                await Task.Run(() => file.Save(filePath, new Progress<int>(value =>
                    mainStatusStrip.Invoke(new MethodInvoker(() =>
                    {
                        pbProgress.Value = value;
                    }))
                )));

                LoadedFiles[tcFiles.SelectedIndex].IsSaved = true;

                // Hide and reset the progressbar.
                pbProgress.Visible = false;
                pbProgress.Value = 0;

                updateFileInfo();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoadedFiles.Count == 0)
                    throw new Exception("No files are opened.");

                saveFile(LoadedFiles[tcFiles.SelectedIndex].FilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoadedFiles.Count == 0)
                    throw new Exception("No files are opened.");

                using (var frm = new SaveFileDialog())
                {
                    var file = LoadedFiles[tcFiles.SelectedIndex];
                    frm.InitialDirectory = file.FilePath;

                    if (file.GetType() == typeof(SHNFile))
                        frm.Filter = "SHN File|*.shn";

                    else if (file.GetType() == typeof(ShineFile))
                        frm.Filter = "Shine File|*.txt";

                    else if (file.GetType() == typeof(QuestFile))
                    {
                        frm.Filter = "Quest File|*.shn";
                        frm.FileName = "QuestData.shn";
                    }

                    frm.FileName = Path.GetFileName(file.FilePath);


                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        saveFile(frm.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void frmMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void frmMain_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach (string file in files)
                {
                    openFile(file);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCloseTab_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoadedFiles.Count == 0)
                    throw new Exception("No files are opened.");

                LoadedFiles.RemoveAt(tcFiles.SelectedIndex);
                tcFiles.TabPages.RemoveAt(tcFiles.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateFileInfo()
        {
            try
            {
                if (LoadedFiles.Count == 0)
                {
                    lblFileInfo.Text = "";
                    lblCellInfo.Text = "";
                    return;
                }

                dynamic file = LoadedFiles[tcFiles.SelectedIndex];

                if (file.GetType() == typeof(SHNFile))
                    file = (SHNFile)file;

                else if (file.GetType() == typeof(ShineFile))
                    file = (ShineFile)file;

                else if (file.GetType() == typeof(QuestFile))
                    file = (QuestFile)file;

                lblFileInfo.Text = String.Format("Rows: {1}, Columns: {2}  |  {0}",
                    file.IsSaved ? "Saved" : "Dirty",
                    file.RowCount, file.ColumnCount);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tcFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateFileInfo();
        }

        private async void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var file in LoadedFiles)
            {
                if (!file.IsSaved)
                {

                    var result = MessageBox.Show(Path.GetFileName(file.FilePath) + " has unsaved changes. Do you want to save the file?",
                                    "Unsaved changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        e.Cancel = true;
                        await Task.Run(() => file.Save(file.FilePath, new Progress<int>(value =>
                            mainStatusStrip.Invoke(new MethodInvoker(() =>
                            {
                                pbProgress.Value = value;
                            }))
                        )));
                    }

                    else if (result == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
            }

            Environment.Exit(0);
        }
    }
}
