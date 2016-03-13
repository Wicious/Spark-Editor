namespace SparkEditor.Forms.NewFile
{
    partial class frmNewFile
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
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.linkAddColumn = new System.Windows.Forms.LinkLabel();
            this.linkRemoveColumn = new System.Windows.Forms.LinkLabel();
            this.lvColumns = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.cbFileType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pBottom = new System.Windows.Forms.Panel();
            this.gbColumns = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbTables = new System.Windows.Forms.ComboBox();
            this.linkTableEditor = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.pBottom.SuspendLayout();
            this.gbColumns.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(76, 34);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(0);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(192, 20);
            this.txtFileName.TabIndex = 11;
            this.txtFileName.Text = "NewFile";
            // 
            // linkAddColumn
            // 
            this.linkAddColumn.AutoSize = true;
            this.linkAddColumn.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkAddColumn.Location = new System.Drawing.Point(20, 21);
            this.linkAddColumn.Margin = new System.Windows.Forms.Padding(0);
            this.linkAddColumn.Name = "linkAddColumn";
            this.linkAddColumn.Size = new System.Drawing.Size(32, 13);
            this.linkAddColumn.TabIndex = 14;
            this.linkAddColumn.TabStop = true;
            this.linkAddColumn.Text = "Add..";
            this.linkAddColumn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkAddColumn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAddColumn_LinkClicked);
            // 
            // linkRemoveColumn
            // 
            this.linkRemoveColumn.AutoSize = true;
            this.linkRemoveColumn.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkRemoveColumn.Location = new System.Drawing.Point(11, 36);
            this.linkRemoveColumn.Margin = new System.Windows.Forms.Padding(0);
            this.linkRemoveColumn.Name = "linkRemoveColumn";
            this.linkRemoveColumn.Size = new System.Drawing.Size(47, 13);
            this.linkRemoveColumn.TabIndex = 15;
            this.linkRemoveColumn.TabStop = true;
            this.linkRemoveColumn.Text = "Remove";
            this.linkRemoveColumn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkRemoveColumn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRemoveColumn_LinkClicked);
            // 
            // lvColumns
            // 
            this.lvColumns.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chType,
            this.chLength});
            this.lvColumns.Dock = System.Windows.Forms.DockStyle.Right;
            this.lvColumns.FullRowSelect = true;
            this.lvColumns.Location = new System.Drawing.Point(71, 0);
            this.lvColumns.Margin = new System.Windows.Forms.Padding(0);
            this.lvColumns.MultiSelect = false;
            this.lvColumns.Name = "lvColumns";
            this.lvColumns.Size = new System.Drawing.Size(223, 109);
            this.lvColumns.TabIndex = 16;
            this.lvColumns.UseCompatibleStateImageBehavior = false;
            this.lvColumns.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            // 
            // chType
            // 
            this.chType.Text = "Type";
            // 
            // chLength
            // 
            this.chLength.Text = "Length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(21, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "File Type:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbFileType
            // 
            this.cbFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFileType.FormattingEnabled = true;
            this.cbFileType.Items.AddRange(new object[] {
            "SHN File",
            "Shine File",
            "Quest File"});
            this.cbFileType.Location = new System.Drawing.Point(76, 8);
            this.cbFileType.Margin = new System.Windows.Forms.Padding(0);
            this.cbFileType.Name = "cbFileType";
            this.cbFileType.Size = new System.Drawing.Size(192, 21);
            this.cbFileType.TabIndex = 18;
            this.cbFileType.SelectedIndexChanged += new System.EventHandler(this.cbFileType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "File Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.Location = new System.Drawing.Point(229, 0);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 30);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(129, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(270, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = ".shn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(10, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "Columns:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBottom
            // 
            this.pBottom.Controls.Add(this.btnOK);
            this.pBottom.Controls.Add(this.btnCancel);
            this.pBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBottom.Location = new System.Drawing.Point(6, 245);
            this.pBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pBottom.Name = "pBottom";
            this.pBottom.Size = new System.Drawing.Size(304, 30);
            this.pBottom.TabIndex = 19;
            // 
            // gbColumns
            // 
            this.gbColumns.Controls.Add(this.label5);
            this.gbColumns.Controls.Add(this.linkTableEditor);
            this.gbColumns.Controls.Add(this.cbTables);
            this.gbColumns.Controls.Add(this.panel1);
            this.gbColumns.Location = new System.Drawing.Point(8, 69);
            this.gbColumns.Name = "gbColumns";
            this.gbColumns.Size = new System.Drawing.Size(300, 161);
            this.gbColumns.TabIndex = 20;
            this.gbColumns.TabStop = false;
            this.gbColumns.Text = "Columns";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.linkAddColumn);
            this.panel1.Controls.Add(this.lvColumns);
            this.panel1.Controls.Add(this.linkRemoveColumn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 109);
            this.panel1.TabIndex = 0;
            // 
            // cbTables
            // 
            this.cbTables.Enabled = false;
            this.cbTables.FormattingEnabled = true;
            this.cbTables.Location = new System.Drawing.Point(43, 20);
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(133, 21);
            this.cbTables.TabIndex = 1;
            this.cbTables.SelectedIndexChanged += new System.EventHandler(this.cbTables_SelectedIndexChanged);
            // 
            // linkTableEditor
            // 
            this.linkTableEditor.AutoSize = true;
            this.linkTableEditor.Enabled = false;
            this.linkTableEditor.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkTableEditor.Location = new System.Drawing.Point(183, 23);
            this.linkTableEditor.Margin = new System.Windows.Forms.Padding(0);
            this.linkTableEditor.Name = "linkTableEditor";
            this.linkTableEditor.Size = new System.Drawing.Size(110, 13);
            this.linkTableEditor.TabIndex = 15;
            this.linkTableEditor.TabStop = true;
            this.linkTableEditor.Text = "Edit Table Collection..";
            this.linkTableEditor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkTableEditor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTableEditor_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(3, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Table:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmNewFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(316, 281);
            this.Controls.Add(this.gbColumns);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbFileType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmNewFile";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New File";
            this.Load += new System.EventHandler(this.frmNewFile_Load);
            this.pBottom.ResumeLayout(false);
            this.gbColumns.ResumeLayout(false);
            this.gbColumns.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.LinkLabel linkAddColumn;
        private System.Windows.Forms.LinkLabel linkRemoveColumn;
        private System.Windows.Forms.ListView lvColumns;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ColumnHeader chLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFileType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pBottom;
        private System.Windows.Forms.GroupBox gbColumns;
        private System.Windows.Forms.LinkLabel linkTableEditor;
        private System.Windows.Forms.ComboBox cbTables;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}