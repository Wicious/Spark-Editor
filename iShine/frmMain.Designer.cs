namespace iShine
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCloseTab = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tcFiles = new System.Windows.Forms.TabControl();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditColumns = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCutRows = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCopyRows = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPasteRows = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditEncryption = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnQuickFind = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuickReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSetRowFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFileInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCellInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenu.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.White;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(932, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewFile,
            this.btnOpenFile,
            this.menuItemSave,
            this.toolStripMenuItem1,
            this.btnCloseTab,
            this.btnExit});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(29, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btnNewFile
            // 
            this.btnNewFile.BackColor = System.Drawing.SystemColors.Control;
            this.btnNewFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnNewFile.Name = "btnNewFile";
            this.btnNewFile.Size = new System.Drawing.Size(171, 22);
            this.btnNewFile.Text = "New..";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOpenFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.btnOpenFile.Size = new System.Drawing.Size(171, 22);
            this.btnOpenFile.Text = "Open..";
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // menuItemSave
            // 
            this.menuItemSave.BackColor = System.Drawing.SystemColors.Control;
            this.menuItemSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveAs,
            this.btnSave});
            this.menuItemSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.menuItemSave.Name = "menuItemSave";
            this.menuItemSave.Size = new System.Drawing.Size(171, 22);
            this.menuItemSave.Text = "Save";
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveAs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.btnSaveAs.Size = new System.Drawing.Size(183, 22);
            this.btnSaveAs.Text = "Save As..";
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSave.Name = "btnSave";
            this.btnSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.btnSave.Size = new System.Drawing.Size(183, 22);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(168, 6);
            // 
            // btnCloseTab
            // 
            this.btnCloseTab.BackColor = System.Drawing.SystemColors.Control;
            this.btnCloseTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnCloseTab.Name = "btnCloseTab";
            this.btnCloseTab.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.btnCloseTab.Size = new System.Drawing.Size(171, 22);
            this.btnCloseTab.Text = "Close Tab";
            this.btnCloseTab.Click += new System.EventHandler(this.btnCloseTab_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(171, 22);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.pbProgress,
            this.lblCellInfo,
            this.lblFileInfo});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 560);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(932, 22);
            this.mainStatusStrip.SizingGrip = false;
            this.mainStatusStrip.TabIndex = 1;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 17);
            this.lblStatus.Text = "Ready";
            // 
            // pbProgress
            // 
            this.pbProgress.Margin = new System.Windows.Forms.Padding(10, 3, 1, 3);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(100, 16);
            this.pbProgress.Visible = false;
            // 
            // tcFiles
            // 
            this.tcFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcFiles.Location = new System.Drawing.Point(0, 24);
            this.tcFiles.Name = "tcFiles";
            this.tcFiles.SelectedIndex = 0;
            this.tcFiles.Size = new System.Drawing.Size(932, 536);
            this.tcFiles.TabIndex = 2;
            this.tcFiles.SelectedIndexChanged += new System.EventHandler(this.tcFiles_SelectedIndexChanged);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditColumns,
            this.btnEditHeader,
            this.btnEditEncryption,
            this.toolStripMenuItem2,
            this.btnCutRows,
            this.btnCopyRows,
            this.btnPasteRows,
            this.toolStripMenuItem3,
            this.btnQuickFind,
            this.btnQuickReplace,
            this.toolStripMenuItem4,
            this.btnSetRowFilter});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // btnEditColumns
            // 
            this.btnEditColumns.Name = "btnEditColumns";
            this.btnEditColumns.Size = new System.Drawing.Size(192, 22);
            this.btnEditColumns.Text = "Columns..";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(189, 6);
            // 
            // btnCutRows
            // 
            this.btnCutRows.Name = "btnCutRows";
            this.btnCutRows.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.btnCutRows.Size = new System.Drawing.Size(192, 22);
            this.btnCutRows.Text = "Cut";
            // 
            // btnCopyRows
            // 
            this.btnCopyRows.Name = "btnCopyRows";
            this.btnCopyRows.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.btnCopyRows.Size = new System.Drawing.Size(192, 22);
            this.btnCopyRows.Text = "Copy";
            // 
            // btnPasteRows
            // 
            this.btnPasteRows.Name = "btnPasteRows";
            this.btnPasteRows.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.btnPasteRows.Size = new System.Drawing.Size(192, 22);
            this.btnPasteRows.Text = "Paste";
            // 
            // btnEditHeader
            // 
            this.btnEditHeader.Name = "btnEditHeader";
            this.btnEditHeader.Size = new System.Drawing.Size(192, 22);
            this.btnEditHeader.Text = "Header..";
            // 
            // btnEditEncryption
            // 
            this.btnEditEncryption.Name = "btnEditEncryption";
            this.btnEditEncryption.Size = new System.Drawing.Size(192, 22);
            this.btnEditEncryption.Text = "Encryption..";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(189, 6);
            // 
            // btnQuickFind
            // 
            this.btnQuickFind.Name = "btnQuickFind";
            this.btnQuickFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.btnQuickFind.Size = new System.Drawing.Size(192, 22);
            this.btnQuickFind.Text = "Quick Find";
            // 
            // btnQuickReplace
            // 
            this.btnQuickReplace.Name = "btnQuickReplace";
            this.btnQuickReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.btnQuickReplace.Size = new System.Drawing.Size(192, 22);
            this.btnQuickReplace.Text = "Quick Replace";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(189, 6);
            // 
            // btnSetRowFilter
            // 
            this.btnSetRowFilter.Name = "btnSetRowFilter";
            this.btnSetRowFilter.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F)));
            this.btnSetRowFilter.Size = new System.Drawing.Size(192, 22);
            this.btnSetRowFilter.Text = "Row Filter";
            // 
            // lblFileInfo
            // 
            this.lblFileInfo.ForeColor = System.Drawing.Color.White;
            this.lblFileInfo.Name = "lblFileInfo";
            this.lblFileInfo.Size = new System.Drawing.Size(736, 17);
            this.lblFileInfo.Spring = true;
            this.lblFileInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCellInfo
            // 
            this.lblCellInfo.ForeColor = System.Drawing.Color.White;
            this.lblCellInfo.Name = "lblCellInfo";
            this.lblCellInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(932, 582);
            this.Controls.Add(this.tcFiles);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "frmMain";
            this.Text = "iShine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmMain_DragEnter);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.TabControl tcFiles;
        private System.Windows.Forms.ToolStripMenuItem btnOpenFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemSave;
        private System.Windows.Forms.ToolStripProgressBar pbProgress;
        private System.Windows.Forms.ToolStripMenuItem btnNewFile;
        private System.Windows.Forms.ToolStripMenuItem btnSaveAs;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnCloseTab;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnEditColumns;
        private System.Windows.Forms.ToolStripMenuItem btnEditHeader;
        private System.Windows.Forms.ToolStripMenuItem btnEditEncryption;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem btnCutRows;
        private System.Windows.Forms.ToolStripMenuItem btnCopyRows;
        private System.Windows.Forms.ToolStripMenuItem btnPasteRows;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem btnQuickFind;
        private System.Windows.Forms.ToolStripMenuItem btnQuickReplace;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem btnSetRowFilter;
        private System.Windows.Forms.ToolStripStatusLabel lblFileInfo;
        private System.Windows.Forms.ToolStripStatusLabel lblCellInfo;
    }
}

