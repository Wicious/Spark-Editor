namespace SparkEditor.Forms
{
    partial class frmMassEditor
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
            this.btnExecute = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbFiltered = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbGetColumn = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pTally = new System.Windows.Forms.Panel();
            this.numEndRow = new System.Windows.Forms.NumericUpDown();
            this.numStartValue = new System.Windows.Forms.NumericUpDown();
            this.numStartRow = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSetValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSetAction = new System.Windows.Forms.ComboBox();
            this.txtGetValue = new System.Windows.Forms.TextBox();
            this.cbGetType = new System.Windows.Forms.ComboBox();
            this.cbWhere = new System.Windows.Forms.ComboBox();
            this.btnSetFilter = new System.Windows.Forms.Button();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pFilter = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pTally.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEndRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartRow)).BeginInit();
            this.pFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(14, 168);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(124, 23);
            this.btnExecute.TabIndex = 0;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pFilter);
            this.groupBox1.Controls.Add(this.cbFiltered);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 202);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // cbFiltered
            // 
            this.cbFiltered.AutoSize = true;
            this.cbFiltered.Location = new System.Drawing.Point(158, 17);
            this.cbFiltered.Name = "cbFiltered";
            this.cbFiltered.Size = new System.Drawing.Size(60, 17);
            this.cbFiltered.TabIndex = 7;
            this.cbFiltered.Text = "Filtered";
            this.cbFiltered.UseVisualStyleBackColor = true;
            this.cbFiltered.CheckedChanged += new System.EventHandler(this.cbFiltered_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(4, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Column:";
            // 
            // cbGetColumn
            // 
            this.cbGetColumn.FormattingEnabled = true;
            this.cbGetColumn.Location = new System.Drawing.Point(51, 24);
            this.cbGetColumn.Name = "cbGetColumn";
            this.cbGetColumn.Size = new System.Drawing.Size(94, 21);
            this.cbGetColumn.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pTally);
            this.groupBox2.Controls.Add(this.cbGetColumn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnExecute);
            this.groupBox2.Controls.Add(this.txtSetValue);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbSetAction);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBox2.Location = new System.Drawing.Point(228, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 202);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit";
            // 
            // pTally
            // 
            this.pTally.Controls.Add(this.numEndRow);
            this.pTally.Controls.Add(this.numStartValue);
            this.pTally.Controls.Add(this.numStartRow);
            this.pTally.Controls.Add(this.label6);
            this.pTally.Controls.Add(this.label7);
            this.pTally.Controls.Add(this.label4);
            this.pTally.Location = new System.Drawing.Point(7, 76);
            this.pTally.Name = "pTally";
            this.pTally.Size = new System.Drawing.Size(138, 82);
            this.pTally.TabIndex = 10;
            this.pTally.Visible = false;
            // 
            // numEndRow
            // 
            this.numEndRow.Location = new System.Drawing.Point(66, 54);
            this.numEndRow.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numEndRow.Name = "numEndRow";
            this.numEndRow.Size = new System.Drawing.Size(69, 20);
            this.numEndRow.TabIndex = 11;
            this.numEndRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numStartValue
            // 
            this.numStartValue.Location = new System.Drawing.Point(66, 8);
            this.numStartValue.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numStartValue.Name = "numStartValue";
            this.numStartValue.Size = new System.Drawing.Size(69, 20);
            this.numStartValue.TabIndex = 11;
            this.numStartValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numStartRow
            // 
            this.numStartRow.Location = new System.Drawing.Point(66, 31);
            this.numStartRow.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numStartRow.Name = "numStartRow";
            this.numStartRow.Size = new System.Drawing.Size(69, 20);
            this.numStartRow.TabIndex = 11;
            this.numStartRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numStartRow.ValueChanged += new System.EventHandler(this.numStartRow_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(10, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "End Row:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label7.Location = new System.Drawing.Point(2, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Start Value:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(7, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Start Row:";
            // 
            // txtSetValue
            // 
            this.txtSetValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.txtSetValue.Location = new System.Drawing.Point(7, 76);
            this.txtSetValue.Name = "txtSetValue";
            this.txtSetValue.Size = new System.Drawing.Size(138, 20);
            this.txtSetValue.TabIndex = 9;
            this.txtSetValue.Text = "Value";
            this.txtSetValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSetValue.Enter += new System.EventHandler(this.textBoxEnter);
            this.txtSetValue.Leave += new System.EventHandler(this.textBoxLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(10, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Action:";
            // 
            // cbSetAction
            // 
            this.cbSetAction.FormattingEnabled = true;
            this.cbSetAction.Items.AddRange(new object[] {
            "New Value",
            "Add",
            "Subtract",
            "Multiply",
            "Divide",
            "Prefix",
            "Suffix",
            "Remove",
            "Row Tally"});
            this.cbSetAction.Location = new System.Drawing.Point(51, 48);
            this.cbSetAction.Name = "cbSetAction";
            this.cbSetAction.Size = new System.Drawing.Size(94, 21);
            this.cbSetAction.TabIndex = 7;
            this.cbSetAction.SelectedIndexChanged += new System.EventHandler(this.cbSetAction_SelectedIndexChanged);
            // 
            // txtGetValue
            // 
            this.txtGetValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGetValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.txtGetValue.Location = new System.Drawing.Point(16, 67);
            this.txtGetValue.Name = "txtGetValue";
            this.txtGetValue.Size = new System.Drawing.Size(191, 20);
            this.txtGetValue.TabIndex = 7;
            this.txtGetValue.Text = "Value";
            this.txtGetValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGetValue.Enter += new System.EventHandler(this.textBoxEnter);
            this.txtGetValue.Leave += new System.EventHandler(this.textBoxLeave);
            // 
            // cbGetType
            // 
            this.cbGetType.FormattingEnabled = true;
            this.cbGetType.Items.AddRange(new object[] {
            "Equals",
            "Contains",
            "Starts With",
            "Ends With",
            "More Than",
            "Less Than"});
            this.cbGetType.Location = new System.Drawing.Point(60, 40);
            this.cbGetType.Name = "cbGetType";
            this.cbGetType.Size = new System.Drawing.Size(147, 21);
            this.cbGetType.TabIndex = 8;
            // 
            // cbWhere
            // 
            this.cbWhere.FormattingEnabled = true;
            this.cbWhere.Location = new System.Drawing.Point(60, 14);
            this.cbWhere.Name = "cbWhere";
            this.cbWhere.Size = new System.Drawing.Size(147, 21);
            this.cbWhere.TabIndex = 10;
            // 
            // btnSetFilter
            // 
            this.btnSetFilter.Location = new System.Drawing.Point(115, 98);
            this.btnSetFilter.Name = "btnSetFilter";
            this.btnSetFilter.Size = new System.Drawing.Size(100, 23);
            this.btnSetFilter.TabIndex = 0;
            this.btnSetFilter.Text = "Set Filter";
            this.btnSetFilter.UseVisualStyleBackColor = true;
            this.btnSetFilter.Click += new System.EventHandler(this.btnSetFilter_Click);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(9, 98);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(100, 23);
            this.btnClearFilter.TabIndex = 0;
            this.btnClearFilter.Text = "Clear Filter";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(24, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Column:";
            // 
            // pFilter
            // 
            this.pFilter.Controls.Add(this.label1);
            this.pFilter.Controls.Add(this.label3);
            this.pFilter.Controls.Add(this.btnClearFilter);
            this.pFilter.Controls.Add(this.btnSetFilter);
            this.pFilter.Controls.Add(this.cbWhere);
            this.pFilter.Controls.Add(this.cbGetType);
            this.pFilter.Controls.Add(this.txtGetValue);
            this.pFilter.Enabled = false;
            this.pFilter.Location = new System.Drawing.Point(3, 35);
            this.pFilter.Name = "pFilter";
            this.pFilter.Size = new System.Drawing.Size(222, 134);
            this.pFilter.TabIndex = 8;
            // 
            // frmMassEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(379, 202);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmMassEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mass Editor";
            this.Load += new System.EventHandler(this.frmMassEditor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pTally.ResumeLayout(false);
            this.pTally.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEndRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartRow)).EndInit();
            this.pFilter.ResumeLayout(false);
            this.pFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbGetColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSetAction;
        private System.Windows.Forms.TextBox txtSetValue;
        private System.Windows.Forms.Panel pTally;
        private System.Windows.Forms.NumericUpDown numEndRow;
        private System.Windows.Forms.NumericUpDown numStartRow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numStartValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbFiltered;
        private System.Windows.Forms.Panel pFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnSetFilter;
        private System.Windows.Forms.ComboBox cbWhere;
        private System.Windows.Forms.ComboBox cbGetType;
        private System.Windows.Forms.TextBox txtGetValue;
    }
}