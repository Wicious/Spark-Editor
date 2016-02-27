namespace SparkEditor.Forms.Options
{
    partial class frmOptions
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
            this.lbOptions = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pWindowBar = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pOptionPage = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.pWindowBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbOptions
            // 
            this.lbOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOptions.Items.AddRange(new object[] {
            "Encoding",
            "Default Encryption",
            "Copy & Paste"});
            this.lbOptions.Location = new System.Drawing.Point(0, 0);
            this.lbOptions.Margin = new System.Windows.Forms.Padding(0);
            this.lbOptions.Name = "lbOptions";
            this.lbOptions.Size = new System.Drawing.Size(118, 265);
            this.lbOptions.TabIndex = 0;
            this.lbOptions.SelectedIndexChanged += new System.EventHandler(this.lbOptions_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.51282F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.48718F));
            this.tableLayoutPanel1.Controls.Add(this.lbOptions, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pWindowBar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pOptionPage, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.45763F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.54237F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(390, 304);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pWindowBar
            // 
            this.pWindowBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tableLayoutPanel1.SetColumnSpan(this.pWindowBar, 2);
            this.pWindowBar.Controls.Add(this.btnSave);
            this.pWindowBar.Controls.Add(this.btnCancel);
            this.pWindowBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pWindowBar.Location = new System.Drawing.Point(0, 265);
            this.pWindowBar.Margin = new System.Windows.Forms.Padding(0);
            this.pWindowBar.Name = "pWindowBar";
            this.pWindowBar.Size = new System.Drawing.Size(390, 39);
            this.pWindowBar.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(221, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(302, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pOptionPage
            // 
            this.pOptionPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pOptionPage.Location = new System.Drawing.Point(118, 0);
            this.pOptionPage.Margin = new System.Windows.Forms.Padding(0);
            this.pOptionPage.Name = "pOptionPage";
            this.pOptionPage.Size = new System.Drawing.Size(272, 265);
            this.pOptionPage.TabIndex = 2;
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(390, 304);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pWindowBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbOptions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pWindowBar;
        private System.Windows.Forms.Panel pOptionPage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}