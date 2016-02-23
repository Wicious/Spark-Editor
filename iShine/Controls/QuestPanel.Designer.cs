namespace iShine.Controls
{
    partial class QuestPanel
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbQuests = new System.Windows.Forms.ListBox();
            this.tcQuest = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.pgQuestProperties = new System.Windows.Forms.PropertyGrid();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.tpScript = new System.Windows.Forms.TabPage();
            this.tpObjectives = new System.Windows.Forms.TabPage();
            this.tpRewards = new System.Windows.Forms.TabPage();
            this.lblQuestName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tcQuest.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 216F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tcQuest, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbQuests, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQuestName, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(836, 548);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbQuests
            // 
            this.lbQuests.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbQuests.FormattingEnabled = true;
            this.lbQuests.Location = new System.Drawing.Point(3, 3);
            this.lbQuests.Name = "lbQuests";
            this.tableLayoutPanel1.SetRowSpan(this.lbQuests, 2);
            this.lbQuests.Size = new System.Drawing.Size(210, 542);
            this.lbQuests.TabIndex = 2;
            // 
            // tcQuest
            // 
            this.tcQuest.Controls.Add(this.tpGeneral);
            this.tcQuest.Controls.Add(this.tpScript);
            this.tcQuest.Controls.Add(this.tpObjectives);
            this.tcQuest.Controls.Add(this.tpRewards);
            this.tcQuest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcQuest.Location = new System.Drawing.Point(219, 24);
            this.tcQuest.Name = "tcQuest";
            this.tcQuest.SelectedIndex = 0;
            this.tcQuest.Size = new System.Drawing.Size(614, 521);
            this.tcQuest.TabIndex = 3;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.groupBox1);
            this.tpGeneral.Controls.Add(this.pgQuestProperties);
            this.tpGeneral.Controls.Add(this.txtDescription);
            this.tpGeneral.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(606, 495);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "General";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // pgQuestProperties
            // 
            this.pgQuestProperties.BackColor = System.Drawing.Color.White;
            this.pgQuestProperties.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pgQuestProperties.Dock = System.Windows.Forms.DockStyle.Right;
            this.pgQuestProperties.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgQuestProperties.HelpBackColor = System.Drawing.Color.White;
            this.pgQuestProperties.Location = new System.Drawing.Point(358, 3);
            this.pgQuestProperties.Name = "pgQuestProperties";
            this.pgQuestProperties.Size = new System.Drawing.Size(245, 393);
            this.pgQuestProperties.TabIndex = 0;
            this.pgQuestProperties.ToolbarVisible = false;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDescription.Location = new System.Drawing.Point(3, 396);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(600, 96);
            this.txtDescription.TabIndex = 1;
            // 
            // tpScript
            // 
            this.tpScript.Location = new System.Drawing.Point(4, 22);
            this.tpScript.Name = "tpScript";
            this.tpScript.Padding = new System.Windows.Forms.Padding(3);
            this.tpScript.Size = new System.Drawing.Size(606, 495);
            this.tpScript.TabIndex = 1;
            this.tpScript.Text = "Script";
            this.tpScript.UseVisualStyleBackColor = true;
            // 
            // tpObjectives
            // 
            this.tpObjectives.Location = new System.Drawing.Point(4, 22);
            this.tpObjectives.Name = "tpObjectives";
            this.tpObjectives.Size = new System.Drawing.Size(606, 495);
            this.tpObjectives.TabIndex = 2;
            this.tpObjectives.Text = "Objectives";
            this.tpObjectives.UseVisualStyleBackColor = true;
            // 
            // tpRewards
            // 
            this.tpRewards.Location = new System.Drawing.Point(4, 22);
            this.tpRewards.Name = "tpRewards";
            this.tpRewards.Size = new System.Drawing.Size(606, 495);
            this.tpRewards.TabIndex = 3;
            this.tpRewards.Text = "Rewards";
            this.tpRewards.UseVisualStyleBackColor = true;
            // 
            // lblQuestName
            // 
            this.lblQuestName.AutoSize = true;
            this.lblQuestName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblQuestName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblQuestName.Location = new System.Drawing.Point(219, 0);
            this.lblQuestName.Name = "lblQuestName";
            this.lblQuestName.Size = new System.Drawing.Size(614, 21);
            this.lblQuestName.TabIndex = 4;
            this.lblQuestName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBox1.Location = new System.Drawing.Point(50, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 160);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quest Info";
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBox2.Location = new System.Drawing.Point(3, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 58);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rewards";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 36);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(247, 63);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "-";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "-";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "-";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "-";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kill List";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuestPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "QuestPanel";
            this.Size = new System.Drawing.Size(836, 548);
            this.Load += new System.EventHandler(this.QuestPanel_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tcQuest.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.tpGeneral.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox lbQuests;
        private System.Windows.Forms.TabControl tcQuest;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.PropertyGrid pgQuestProperties;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TabPage tpScript;
        private System.Windows.Forms.TabPage tpObjectives;
        private System.Windows.Forms.TabPage tpRewards;
        private System.Windows.Forms.Label lblQuestName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
    }
}
