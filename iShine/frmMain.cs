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
                frm.Filter = "SHN File|*.shn";

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

                        tcFiles.TabPages.Add(tab);
                        tcFiles.SelectedTab = tab;

                        LoadedFiles.Add(shnFile);
                        break;
                }

                // Hide and reset the progressbar.
                pbProgress.Visible = false;
                pbProgress.Value = 0;
                lblStatus.Text = "Ready";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                // Hide and reset the progressbar.
                pbProgress.Visible = false;
                pbProgress.Value = 0;
                lblStatus.Text = "Ready";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFile(LoadedFiles[tcFiles.SelectedIndex].FilePath);
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {

        }
    }
}
