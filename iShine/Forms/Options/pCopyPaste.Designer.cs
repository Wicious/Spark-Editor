namespace iShine.Forms.Options
{
    partial class pCopyPaste
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbGenerateValue = new System.Windows.Forms.CheckBox();
            this.cbOnlyIfSameFile = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDefaultStringValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudDefaultNumericValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefaultNumericValue)).BeginInit();
            this.SuspendLayout();
            // 
            // cbGenerateValue
            // 
            this.cbGenerateValue.AutoSize = true;
            this.cbGenerateValue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenerateValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbGenerateValue.Location = new System.Drawing.Point(43, 28);
            this.cbGenerateValue.Name = "cbGenerateValue";
            this.cbGenerateValue.Size = new System.Drawing.Size(195, 18);
            this.cbGenerateValue.TabIndex = 0;
            this.cbGenerateValue.Text = "Generate available ID for each row";
            this.cbGenerateValue.UseVisualStyleBackColor = true;
            this.cbGenerateValue.CheckedChanged += new System.EventHandler(this.cbGenerateValue_CheckedChanged);
            // 
            // cbOnlyIfSameFile
            // 
            this.cbOnlyIfSameFile.AutoSize = true;
            this.cbOnlyIfSameFile.Enabled = false;
            this.cbOnlyIfSameFile.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOnlyIfSameFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbOnlyIfSameFile.Location = new System.Drawing.Point(61, 51);
            this.cbOnlyIfSameFile.Name = "cbOnlyIfSameFile";
            this.cbOnlyIfSameFile.Size = new System.Drawing.Size(114, 18);
            this.cbOnlyIfSameFile.TabIndex = 0;
            this.cbOnlyIfSameFile.Text = "Only if in same file";
            this.cbOnlyIfSameFile.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Default String Value:";
            // 
            // txtDefaultStringValue
            // 
            this.txtDefaultStringValue.Location = new System.Drawing.Point(61, 115);
            this.txtDefaultStringValue.Name = "txtDefaultStringValue";
            this.txtDefaultStringValue.Size = new System.Drawing.Size(144, 20);
            this.txtDefaultStringValue.TabIndex = 2;
            this.txtDefaultStringValue.Text = "-";
            this.txtDefaultStringValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Default Numeric Value:";
            // 
            // nudDefaultNumericValue
            // 
            this.nudDefaultNumericValue.Location = new System.Drawing.Point(61, 166);
            this.nudDefaultNumericValue.Name = "nudDefaultNumericValue";
            this.nudDefaultNumericValue.Size = new System.Drawing.Size(144, 20);
            this.nudDefaultNumericValue.TabIndex = 3;
            this.nudDefaultNumericValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pCopyPaste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.nudDefaultNumericValue);
            this.Controls.Add(this.txtDefaultStringValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbOnlyIfSameFile);
            this.Controls.Add(this.cbGenerateValue);
            this.Name = "pCopyPaste";
            this.Size = new System.Drawing.Size(272, 265);
            ((System.ComponentModel.ISupportInitialize)(this.nudDefaultNumericValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbGenerateValue;
        private System.Windows.Forms.CheckBox cbOnlyIfSameFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDefaultStringValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudDefaultNumericValue;
    }
}
