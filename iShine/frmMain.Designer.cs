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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCloseTab = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditColumns = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditEncryption = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCutRows = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCopyRows = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPasteRows = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnQuickFind = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuickReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSetRowFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.massEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.translatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.fastTasksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.lblCellInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFileInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tcFiles = new System.Windows.Forms.TabControl();
            this.extrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assertHelperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnContribute = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.White;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.fastTasksToolStripMenuItem,
            this.contactToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(894, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnOpenFile,
            this.menuItemSave,
            this.toolStripMenuItem1,
            this.btnCloseTab,
            this.btnExit});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(29, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.Control;
            this.btnNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.btnNew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(171, 22);
            this.btnNew.Text = "New";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.fileToolStripMenuItem1.Text = "File..";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOpenFile.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.menuItemSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuItemSave.Name = "menuItemSave";
            this.menuItemSave.Size = new System.Drawing.Size(171, 22);
            this.menuItemSave.Text = "Save";
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveAs.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Name = "btnSave";
            this.btnSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.btnSave.Size = new System.Drawing.Size(183, 22);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(168, 6);
            // 
            // btnCloseTab
            // 
            this.btnCloseTab.BackColor = System.Drawing.SystemColors.Control;
            this.btnCloseTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCloseTab.Name = "btnCloseTab";
            this.btnCloseTab.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.btnCloseTab.Size = new System.Drawing.Size(171, 22);
            this.btnCloseTab.Text = "Close Tab";
            this.btnCloseTab.Click += new System.EventHandler(this.btnCloseTab_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(171, 22);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.editToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // btnEditColumns
            // 
            this.btnEditColumns.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditColumns.Name = "btnEditColumns";
            this.btnEditColumns.Size = new System.Drawing.Size(192, 22);
            this.btnEditColumns.Text = "Columns..";
            // 
            // btnEditHeader
            // 
            this.btnEditHeader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditHeader.Name = "btnEditHeader";
            this.btnEditHeader.Size = new System.Drawing.Size(192, 22);
            this.btnEditHeader.Text = "Header..";
            // 
            // btnEditEncryption
            // 
            this.btnEditEncryption.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditEncryption.Name = "btnEditEncryption";
            this.btnEditEncryption.Size = new System.Drawing.Size(192, 22);
            this.btnEditEncryption.Text = "Encryption..";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(189, 6);
            // 
            // btnCutRows
            // 
            this.btnCutRows.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCutRows.Name = "btnCutRows";
            this.btnCutRows.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.btnCutRows.Size = new System.Drawing.Size(192, 22);
            this.btnCutRows.Text = "Cut";
            // 
            // btnCopyRows
            // 
            this.btnCopyRows.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCopyRows.Name = "btnCopyRows";
            this.btnCopyRows.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.btnCopyRows.Size = new System.Drawing.Size(192, 22);
            this.btnCopyRows.Text = "Copy";
            // 
            // btnPasteRows
            // 
            this.btnPasteRows.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPasteRows.Name = "btnPasteRows";
            this.btnPasteRows.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.btnPasteRows.Size = new System.Drawing.Size(192, 22);
            this.btnPasteRows.Text = "Paste";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(189, 6);
            // 
            // btnQuickFind
            // 
            this.btnQuickFind.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQuickFind.Name = "btnQuickFind";
            this.btnQuickFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.btnQuickFind.Size = new System.Drawing.Size(192, 22);
            this.btnQuickFind.Text = "Quick Find";
            // 
            // btnQuickReplace
            // 
            this.btnQuickReplace.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQuickReplace.Name = "btnQuickReplace";
            this.btnQuickReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.btnQuickReplace.Size = new System.Drawing.Size(192, 22);
            this.btnQuickReplace.Text = "Quick Replace";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(189, 6);
            // 
            // btnSetRowFilter
            // 
            this.btnSetRowFilter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetRowFilter.Name = "btnSetRowFilter";
            this.btnSetRowFilter.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F)));
            this.btnSetRowFilter.Size = new System.Drawing.Size(192, 22);
            this.btnSetRowFilter.Text = "Row Filter";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sQLOutputToolStripMenuItem,
            this.fileTreeToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // sQLOutputToolStripMenuItem
            // 
            this.sQLOutputToolStripMenuItem.Name = "sQLOutputToolStripMenuItem";
            this.sQLOutputToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sQLOutputToolStripMenuItem.Text = "SQL Output";
            // 
            // fileTreeToolStripMenuItem
            // 
            this.fileTreeToolStripMenuItem.Name = "fileTreeToolStripMenuItem";
            this.fileTreeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fileTreeToolStripMenuItem.Text = "File Tree";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.massEditorToolStripMenuItem,
            this.translatorToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // massEditorToolStripMenuItem
            // 
            this.massEditorToolStripMenuItem.Name = "massEditorToolStripMenuItem";
            this.massEditorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.massEditorToolStripMenuItem.Text = "Mass Editor";
            // 
            // translatorToolStripMenuItem
            // 
            this.translatorToolStripMenuItem.Name = "translatorToolStripMenuItem";
            this.translatorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.translatorToolStripMenuItem.Text = "Translator";
            // 
            // fastTasksToolStripMenuItem
            // 
            this.fastTasksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOptions,
            this.fastTasksToolStripMenuItem1,
            this.extrasToolStripMenuItem});
            this.fastTasksToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fastTasksToolStripMenuItem.Name = "fastTasksToolStripMenuItem";
            this.fastTasksToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.fastTasksToolStripMenuItem.Text = "Application";
            // 
            // btnOptions
            // 
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(152, 22);
            this.btnOptions.Text = "Options..";
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // fastTasksToolStripMenuItem1
            // 
            this.fastTasksToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fastTasksToolStripMenuItem1.Name = "fastTasksToolStripMenuItem1";
            this.fastTasksToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.fastTasksToolStripMenuItem1.Text = "Fast Tasks..";
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactToolStripMenuItem1,
            this.creditsToolStripMenuItem,
            this.btnContribute});
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.contactToolStripMenuItem.Text = "Help";
            // 
            // contactToolStripMenuItem1
            // 
            this.contactToolStripMenuItem1.Name = "contactToolStripMenuItem1";
            this.contactToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.contactToolStripMenuItem1.Text = "Contact..";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.creditsToolStripMenuItem.Text = "Credits..";
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.pbProgress,
            this.lblCellInfo,
            this.lblFileInfo});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 604);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(894, 22);
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
            // lblCellInfo
            // 
            this.lblCellInfo.ForeColor = System.Drawing.Color.White;
            this.lblCellInfo.Name = "lblCellInfo";
            this.lblCellInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // lblFileInfo
            // 
            this.lblFileInfo.ForeColor = System.Drawing.Color.White;
            this.lblFileInfo.Name = "lblFileInfo";
            this.lblFileInfo.Size = new System.Drawing.Size(840, 17);
            this.lblFileInfo.Spring = true;
            this.lblFileInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tcFiles
            // 
            this.tcFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcFiles.Location = new System.Drawing.Point(0, 24);
            this.tcFiles.Name = "tcFiles";
            this.tcFiles.SelectedIndex = 0;
            this.tcFiles.Size = new System.Drawing.Size(894, 580);
            this.tcFiles.TabIndex = 2;
            this.tcFiles.SelectedIndexChanged += new System.EventHandler(this.tcFiles_SelectedIndexChanged);
            // 
            // extrasToolStripMenuItem
            // 
            this.extrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assertHelperToolStripMenuItem});
            this.extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
            this.extrasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.extrasToolStripMenuItem.Text = "Extras";
            // 
            // assertHelperToolStripMenuItem
            // 
            this.assertHelperToolStripMenuItem.Name = "assertHelperToolStripMenuItem";
            this.assertHelperToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.assertHelperToolStripMenuItem.Text = "Assert Helper..";
            // 
            // btnContribute
            // 
            this.btnContribute.Name = "btnContribute";
            this.btnContribute.Size = new System.Drawing.Size(152, 22);
            this.btnContribute.Text = "Contribute..";
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(894, 626);
            this.Controls.Add(this.tcFiles);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "frmMain";
            this.Text = "iShine - Fiesta Editor";
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
        private System.Windows.Forms.ToolStripMenuItem btnNew;
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
        private System.Windows.Forms.ToolStripMenuItem fastTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fastTasksToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnOptions;
        private System.Windows.Forms.ToolStripMenuItem massEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem translatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLOutputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem extrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assertHelperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnContribute;
    }
}

