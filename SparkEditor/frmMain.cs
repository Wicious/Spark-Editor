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
using System.IO;
using SparkEditor.Controls;
using SparkEditor.Forms.Options;
using SparkEditor.FiestaLib.Quest;
using SparkEditor.FiestaLib.SHN;
using SparkEditor.FiestaLib.Shine;
using SparkEditor.Forms;
using SparkEditor.Forms.NewFile;

namespace SparkEditor
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            checkForParams();
        }

        void checkForParams()
        {
            string[] args = Environment.GetCommandLineArgs();

            if (args.Length == 1) return;
            string filePath = args[1];
            openFile(filePath);
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
                dynamic file = null;
                var dgv = new DataGridView();

                // Display the hidden progressbar in the statusbar.
                pbProgress.Visible = true;

                // Determine what file type it is and cast to the appropriate type.
                switch (Path.GetExtension(fileName))
                {
                    case ".shn":
                        if (Path.GetFileNameWithoutExtension(fileName).ToLower() == "questdata")
                        {
                            file = new QuestFile(fileName);
                            Program.LoadedFiles.Add(file);
                            Extensions.FileType = FileType.QuestFile;

                            var mainTab = new TabPage("QuestFile");
                            var qTab = new TabPage("Quests");
                            var dTab = new TabPage("Dialouges");
                            mainTab.BackColor = Color.White;
                            dTab.BackColor = Color.White;
                            qTab.BackColor = Color.White;

                            var tc = new TabControl();
                            tc.Dock = DockStyle.Fill;
                            qTab.Padding = new Padding(0, 5, 0, 0);
                            dTab.Padding = new Padding(0, 5, 0, 0);
                            mainTab.Padding = new Padding(0, 5, 0, 0);

                            tc.TabPages.Add(qTab);
                            tc.TabPages.Add(dTab);

                            mainTab.Controls.Add(tc);

                            var qPanel = new QuestPanel(file);
                            qPanel.Dock = DockStyle.Fill;
                            qTab.BackColor = Color.White;
                            qTab.Controls.Add(qPanel);

                            tcFiles.TabPages.Add(mainTab);
                            tcFiles.SelectedIndex = tcFiles.TabPages.Count - 1;

                            pbProgress.Visible = false;
                            pbProgress.Value = 0;
                            lblStatus.Text = "Ready";
                            updateFileInfo();

                            return;
                        }

                        file = new SHNFile(fileName);
                        Extensions.FileType = FileType.SHNFile;

                        break;

                    case ".txt":
                        file = new ShineFile(fileName);
                        Extensions.FileType = FileType.ShineFile;

                        break;

                    default:
                        throw new Exception("File type not supported");
                }

                lblStatus.Text = "Reading " + Path.GetFileName(fileName);

                // Await the asynchronous Load method and display the reported progress in our progressbar.
                await Task.Run(() => file.Load(new Progress<int>(value =>
                    mainStatusStrip.Invoke(new MethodInvoker(() =>
                    {
                        pbProgress.Value = value;
                    }))
                )));

                Program.LoadedFiles.Add(file);

                if (file.GetType() == typeof(SHNFile))
                {
                    dgv = new DataGridView();
                    dgv.Dock = DockStyle.Fill;
                    dgv.BackgroundColor = Color.WhiteSmoke;
                    dgv.DoubleBuffered(true);
                    dgv.DataSource = file;

                    dgv.CellEnter += File_CellEnter;

                    var tab = new TabPage(file.TableName);
                    file.RowChanged += new DataRowChangeEventHandler(File_RowChanged);
                    tab.Controls.Add(dgv);

                    tcFiles.TabPages.Add(tab);
                    tcFiles.SelectedIndex = tcFiles.TabPages.Count - 1;
                }

                else if (file.GetType() == typeof(ShineFile))
                {
                    var mainTab = new TabPage(file.DataSetName);
                    var tcTables = new TabControl();
                    tcTables.Dock = DockStyle.Fill;

                    tcTables.SelectedIndexChanged += new EventHandler((object s, EventArgs e) =>
                    {
                        file.SelectedIndex = tcTables.SelectedIndex;
                    });

                    mainTab.Controls.Add(tcTables);
                    tcFiles.TabPages.Add(mainTab);
                    mainTab.BackColor = Color.White;

                    tcFiles.SelectedIndex = tcFiles.TabCount - 1;

                    foreach (var table in file.Tables)
                    {
                        dgv = new DataGridView();
                        dgv.Dock = DockStyle.Fill;
                        dgv.BackgroundColor = Color.WhiteSmoke;
                        dgv.DoubleBuffered(true);
                        dgv.DataSource = table;

                        dgv.CellEnter += File_CellEnter;

                        var tab = new TabPage(table.TableName);
                        table.RowChanged += new DataRowChangeEventHandler(File_RowChanged);
                        tab.Controls.Add(dgv);

                        tcTables.TabPages.Add(tab);
                    }
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

        private async void createFile(IFile file)
        {
            try
            {
                var dgv = new DataGridView();

                if (file.GetType() == typeof(QuestFile))
                {
                    file = new QuestFile("");
                    Program.LoadedFiles.Add(file);
                    Extensions.FileType = FileType.QuestFile;

                    var tab = new TabPage(Path.GetFileName(file.FilePath));
                    var qPanel = new QuestPanel((QuestFile)file);
                    qPanel.Dock = DockStyle.Fill;
                    tab.BackColor = Color.White;
                    tab.Controls.Add(qPanel);

                    tcFiles.TabPages.Add(tab);
                    tcFiles.SelectedIndex = tcFiles.TabPages.Count - 1;
                }

                else if (file.GetType() == typeof(SHNFile))
                {
                    dgv = new DataGridView();
                    dgv.Dock = DockStyle.Fill;
                    dgv.BackgroundColor = Color.WhiteSmoke;
                    dgv.DoubleBuffered(true);
                    dgv.DataSource = file;

                    ((SHNFile)file).CreateFile();

                    dgv.CellEnter += File_CellEnter;

                    var tab = new TabPage(((DataTable)file).TableName);
                    ((DataTable)file).RowChanged += new DataRowChangeEventHandler(File_RowChanged);
                    tab.Controls.Add(dgv);

                    tcFiles.TabPages.Add(tab);
                    tcFiles.SelectedIndex = tcFiles.TabPages.Count - 1;
                }

                else if (file.GetType() == typeof(ShineFile))
                {
                    var mainTab = new TabPage(((ShineFile)file).DataSetName);
                    var tcTables = new TabControl();
                    tcTables.Dock = DockStyle.Fill;

                    tcTables.SelectedIndexChanged += new EventHandler((object s, EventArgs e) =>
                    {
                        ((ShineFile)file).SelectedIndex = tcTables.SelectedIndex;
                    });

                    mainTab.Controls.Add(tcTables);
                    tcFiles.TabPages.Add(mainTab);
                    mainTab.BackColor = Color.White;

                    tcFiles.SelectedIndex = tcFiles.TabCount - 1;

                    foreach (var table in ((ShineFile)file).Tables)
                    {
                        dgv = new DataGridView();
                        dgv.Dock = DockStyle.Fill;
                        dgv.BackgroundColor = Color.WhiteSmoke;
                        dgv.DoubleBuffered(true);
                        dgv.DataSource = table;

                        dgv.CellEnter += File_CellEnter;

                        var tab = new TabPage(((DataTable)table).TableName);
                        ((DataTable)table).RowChanged += new DataRowChangeEventHandler(File_RowChanged);
                        tab.Controls.Add(dgv);

                        tcTables.TabPages.Add(tab);
                    }
                }

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
                Program.LoadedFiles[tcFiles.SelectedIndex].IsSaved = false;
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

                var file = Program.LoadedFiles[tcFiles.SelectedIndex];

                lblStatus.Text = "Saving " + Path.GetFileName(file.FilePath);

                // Await the asynchronous Save method and display the reported progress in our progressbar.
                await Task.Run(() => file.Save(filePath, new Progress<int>(value =>
                    mainStatusStrip.Invoke(new MethodInvoker(() =>
                    {
                        pbProgress.Value = value;
                    }))
                )));

                Program.LoadedFiles[tcFiles.SelectedIndex].IsSaved = true;

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
                if (Program.LoadedFiles.Count == 0)
                    throw new Exception("No files are opened.");

                saveFile(Program.LoadedFiles[tcFiles.SelectedIndex].FilePath);
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
                if (Program.LoadedFiles.Count == 0)
                    throw new Exception("No files are opened.");

                using (var frm = new SaveFileDialog())
                {
                    var file = Program.LoadedFiles[tcFiles.SelectedIndex];
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
                if (Program.LoadedFiles.Count == 0)
                    throw new Exception("No files are opened.");

                Program.LoadedFiles.RemoveAt(tcFiles.SelectedIndex);
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
                if (Program.LoadedFiles.Count == 0)
                {
                    lblFileInfo.Text = "";
                    lblCellInfo.Text = "";
                    return;
                }

                dynamic file = Program.LoadedFiles[tcFiles.SelectedIndex];

                if (file.GetType() == typeof(SHNFile))
                    file = (SHNFile)file;

                else if (file.GetType() == typeof(QuestFile))
                {
                    file = (QuestFile)file;
                    lblFileInfo.Text = String.Format("Quests: {1}  |  {0}",
                        file.IsSaved ? "Saved" : "Dirty",
                        file.QuestCount);

                    return;
                }

                else if (file.GetType() == typeof(ShineFile))
                {
                    file = (ShineFile)file;
                    var table = file.Tables[((ShineFile)file).SelectedIndex];

                    lblFileInfo.Text = String.Format("Rows: {1}, Columns: {2}  |  {0}",
                        file.IsSaved ? "Saved" : "Dirty",
                        table.RowCount, table.ColumnCount);

                    return;
                }

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
            foreach (var file in Program.LoadedFiles)
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
                        return;
                    }
                }
            }

            Environment.Exit(0);
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            using (var frm = new frmOptions())
            {
                frm.ShowDialog(this);
            }
        }

        private void btnNewFile_Click(object sender, EventArgs e)
        {
            using (var frm = new frmNewFile())
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    createFile(Program.LoadedFiles.Last());
                }
            }
        }

        private void btnMassEditor_Click(object sender, EventArgs e)
        {
            if (Program.LoadedFiles.Count == 0) return;

            var frm = new frmMassEditor(Program.LoadedFiles[tcFiles.SelectedIndex]);
            frm.Show(this);
            frm.FormClosed += ((ew, args) =>
            {
                if (Program.LoadedFiles[tcFiles.SelectedIndex].GetType() == typeof(SHNFile))
                    ((SHNFile)Program.LoadedFiles[tcFiles.SelectedIndex]).DefaultView.RowFilter = "";
            });
        }
    }
}
