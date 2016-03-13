namespace SparkEditor.Forms.NewFile
{
    partial class frmTableEditor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbTables = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.linkAddTable = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkRemoveSelected = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 46);
            this.panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(93, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(174, 11);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbTables
            // 
            this.lbTables.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTables.FormattingEnabled = true;
            this.lbTables.Location = new System.Drawing.Point(134, 0);
            this.lbTables.Name = "lbTables";
            this.lbTables.Size = new System.Drawing.Size(127, 166);
            this.lbTables.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTableName);
            this.groupBox1.Controls.Add(this.linkAddTable);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 84);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(10, 31);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(116, 20);
            this.txtTableName.TabIndex = 0;
            // 
            // linkAddTable
            // 
            this.linkAddTable.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.linkAddTable.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkAddTable.Location = new System.Drawing.Point(10, 53);
            this.linkAddTable.Name = "linkAddTable";
            this.linkAddTable.Size = new System.Drawing.Size(116, 23);
            this.linkAddTable.TabIndex = 0;
            this.linkAddTable.TabStop = true;
            this.linkAddTable.Text = "Add Table";
            this.linkAddTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkAddTable.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAddTable_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkRemoveSelected);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 82);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // linkRemoveSelected
            // 
            this.linkRemoveSelected.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.linkRemoveSelected.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkRemoveSelected.Location = new System.Drawing.Point(9, 13);
            this.linkRemoveSelected.Name = "linkRemoveSelected";
            this.linkRemoveSelected.Size = new System.Drawing.Size(116, 23);
            this.linkRemoveSelected.TabIndex = 0;
            this.linkRemoveSelected.TabStop = true;
            this.linkRemoveSelected.Text = "Remove Selected";
            this.linkRemoveSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkRemoveSelected.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRemoveSelected_LinkClicked);
            // 
            // frmTableEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(261, 212);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbTables);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmTableEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Table Collection Editor";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbTables;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkRemoveSelected;
        private System.Windows.Forms.LinkLabel linkAddTable;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}