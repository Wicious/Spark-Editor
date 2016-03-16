namespace SparkEditor.Forms.NewFile
{
    partial class frmQuestDependencies
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseItemInfo = new System.Windows.Forms.Button();
            this.btnBrowseMobInfo = new System.Windows.Forms.Button();
            this.txtItemInfo = new System.Windows.Forms.TextBox();
            this.txtMobInfo = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Some extra files need to be located in order to display information properly.\r\nPl" +
    "ease specify them below.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBrowseItemInfo
            // 
            this.btnBrowseItemInfo.Location = new System.Drawing.Point(328, 69);
            this.btnBrowseItemInfo.Name = "btnBrowseItemInfo";
            this.btnBrowseItemInfo.Size = new System.Drawing.Size(49, 23);
            this.btnBrowseItemInfo.TabIndex = 1;
            this.btnBrowseItemInfo.Text = "...";
            this.btnBrowseItemInfo.UseVisualStyleBackColor = true;
            this.btnBrowseItemInfo.Click += new System.EventHandler(this.btnBrowseItemInfo_Click);
            // 
            // btnBrowseMobInfo
            // 
            this.btnBrowseMobInfo.Location = new System.Drawing.Point(328, 93);
            this.btnBrowseMobInfo.Name = "btnBrowseMobInfo";
            this.btnBrowseMobInfo.Size = new System.Drawing.Size(49, 23);
            this.btnBrowseMobInfo.TabIndex = 1;
            this.btnBrowseMobInfo.Text = "...";
            this.btnBrowseMobInfo.UseVisualStyleBackColor = true;
            this.btnBrowseMobInfo.Click += new System.EventHandler(this.btnBrowseMobInfo_Click);
            // 
            // txtItemInfo
            // 
            this.txtItemInfo.Location = new System.Drawing.Point(76, 71);
            this.txtItemInfo.Name = "txtItemInfo";
            this.txtItemInfo.Size = new System.Drawing.Size(246, 20);
            this.txtItemInfo.TabIndex = 2;
            this.txtItemInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMobInfo
            // 
            this.txtMobInfo.Location = new System.Drawing.Point(76, 95);
            this.txtMobInfo.Name = "txtMobInfo";
            this.txtMobInfo.Size = new System.Drawing.Size(246, 20);
            this.txtMobInfo.TabIndex = 2;
            this.txtMobInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(132, 148);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(125, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ItemInfo.shn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(5, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "MobInfo.shn:";
            // 
            // frmQuestDependencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(389, 183);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtMobInfo);
            this.Controls.Add(this.txtItemInfo);
            this.Controls.Add(this.btnBrowseMobInfo);
            this.Controls.Add(this.btnBrowseItemInfo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmQuestDependencies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "File Locations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseItemInfo;
        private System.Windows.Forms.Button btnBrowseMobInfo;
        private System.Windows.Forms.TextBox txtItemInfo;
        private System.Windows.Forms.TextBox txtMobInfo;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}