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
            this.tcQuest = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMob00 = new System.Windows.Forms.Label();
            this.lblMob01 = new System.Windows.Forms.Label();
            this.lblMob02 = new System.Windows.Forms.Label();
            this.lblMob03 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pgQuestProperties = new System.Windows.Forms.PropertyGrid();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.tpScript = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSaveScripts = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtScriptStart = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtScriptInProgress = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtScriptFinish = new System.Windows.Forms.RichTextBox();
            this.tpObjectives = new System.Windows.Forms.TabPage();
            this.tpRewards = new System.Windows.Forms.TabPage();
            this.lbQuests = new System.Windows.Forms.ListBox();
            this.lblQuestName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tcQuest.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tpScript.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblMob00, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblMob01, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblMob02, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblMob03, 0, 3);
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
            // lblMob00
            // 
            this.lblMob00.AutoSize = true;
            this.lblMob00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMob00.Location = new System.Drawing.Point(3, 0);
            this.lblMob00.Name = "lblMob00";
            this.lblMob00.Size = new System.Drawing.Size(241, 15);
            this.lblMob00.TabIndex = 0;
            this.lblMob00.Text = "-";
            this.lblMob00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMob01
            // 
            this.lblMob01.AutoSize = true;
            this.lblMob01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMob01.Location = new System.Drawing.Point(3, 15);
            this.lblMob01.Name = "lblMob01";
            this.lblMob01.Size = new System.Drawing.Size(241, 15);
            this.lblMob01.TabIndex = 0;
            this.lblMob01.Text = "-";
            this.lblMob01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMob02
            // 
            this.lblMob02.AutoSize = true;
            this.lblMob02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMob02.Location = new System.Drawing.Point(3, 30);
            this.lblMob02.Name = "lblMob02";
            this.lblMob02.Size = new System.Drawing.Size(241, 15);
            this.lblMob02.TabIndex = 0;
            this.lblMob02.Text = "-";
            this.lblMob02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMob03
            // 
            this.lblMob03.AutoSize = true;
            this.lblMob03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMob03.Location = new System.Drawing.Point(3, 45);
            this.lblMob03.Name = "lblMob03";
            this.lblMob03.Size = new System.Drawing.Size(241, 18);
            this.lblMob03.TabIndex = 0;
            this.lblMob03.Text = "-";
            this.lblMob03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tpScript.Controls.Add(this.tableLayoutPanel3);
            this.tpScript.Location = new System.Drawing.Point(4, 22);
            this.tpScript.Name = "tpScript";
            this.tpScript.Padding = new System.Windows.Forms.Padding(3);
            this.tpScript.Size = new System.Drawing.Size(606, 495);
            this.tpScript.TabIndex = 1;
            this.tpScript.Text = "Script";
            this.tpScript.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnSaveScripts, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 2, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(600, 489);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Start";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(202, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "In Progress";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(402, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Finish";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaveScripts
            // 
            this.btnSaveScripts.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSaveScripts.Location = new System.Drawing.Point(484, 464);
            this.btnSaveScripts.Margin = new System.Windows.Forms.Padding(0);
            this.btnSaveScripts.Name = "btnSaveScripts";
            this.btnSaveScripts.Size = new System.Drawing.Size(116, 25);
            this.btnSaveScripts.TabIndex = 3;
            this.btnSaveScripts.Text = "Save Scripts";
            this.btnSaveScripts.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtScriptStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 438);
            this.panel1.TabIndex = 4;
            // 
            // txtScriptStart
            // 
            this.txtScriptStart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtScriptStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtScriptStart.Location = new System.Drawing.Point(0, 0);
            this.txtScriptStart.Name = "txtScriptStart";
            this.txtScriptStart.Size = new System.Drawing.Size(191, 436);
            this.txtScriptStart.TabIndex = 0;
            this.txtScriptStart.Text = "";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtScriptInProgress);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(202, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 438);
            this.panel2.TabIndex = 5;
            // 
            // txtScriptInProgress
            // 
            this.txtScriptInProgress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtScriptInProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtScriptInProgress.Location = new System.Drawing.Point(0, 0);
            this.txtScriptInProgress.Name = "txtScriptInProgress";
            this.txtScriptInProgress.Size = new System.Drawing.Size(192, 436);
            this.txtScriptInProgress.TabIndex = 0;
            this.txtScriptInProgress.Text = "";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtScriptFinish);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(402, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(195, 438);
            this.panel3.TabIndex = 6;
            // 
            // txtScriptFinish
            // 
            this.txtScriptFinish.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtScriptFinish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtScriptFinish.Location = new System.Drawing.Point(0, 0);
            this.txtScriptFinish.Name = "txtScriptFinish";
            this.txtScriptFinish.Size = new System.Drawing.Size(193, 436);
            this.txtScriptFinish.TabIndex = 0;
            this.txtScriptFinish.Text = "";
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
            // lbQuests
            // 
            this.lbQuests.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbQuests.FormattingEnabled = true;
            this.lbQuests.Location = new System.Drawing.Point(3, 3);
            this.lbQuests.Name = "lbQuests";
            this.tableLayoutPanel1.SetRowSpan(this.lbQuests, 2);
            this.lbQuests.Size = new System.Drawing.Size(210, 537);
            this.lbQuests.TabIndex = 2;
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
            this.tpScript.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblMob00;
        private System.Windows.Forms.Label lblMob01;
        private System.Windows.Forms.Label lblMob02;
        private System.Windows.Forms.Label lblMob03;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSaveScripts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtScriptStart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox txtScriptInProgress;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox txtScriptFinish;
    }
}
