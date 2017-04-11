namespace YoutubeDownloader
{
    partial class DownloadForm
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
            this.txtDownloadUrl = new System.Windows.Forms.TextBox();
            this.Download = new System.Windows.Forms.Button();
            this.QueueProcessing_1 = new System.ComponentModel.BackgroundWorker();
            this.QueueProcessing_2 = new System.ComponentModel.BackgroundWorker();
            this.QueueProcessing_3 = new System.ComponentModel.BackgroundWorker();
            this.QueueProcessing_4 = new System.ComponentModel.BackgroundWorker();
            this.pnlBackground_1 = new System.Windows.Forms.Panel();
            this.lblError1 = new System.Windows.Forms.Label();
            this.pbProgress1 = new System.Windows.Forms.ProgressBar();
            this.lblFileName1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblError2 = new System.Windows.Forms.Label();
            this.pbProgressBar2 = new System.Windows.Forms.ProgressBar();
            this.lblFileName2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblError3 = new System.Windows.Forms.Label();
            this.pbProgressBar3 = new System.Windows.Forms.ProgressBar();
            this.lblFileName3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblError4 = new System.Windows.Forms.Label();
            this.pbProgressBar4 = new System.Windows.Forms.ProgressBar();
            this.lblFileName4 = new System.Windows.Forms.Label();
            this.lvLog = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlBackground_1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File";
            // 
            // txtDownloadUrl
            // 
            this.txtDownloadUrl.Location = new System.Drawing.Point(139, 39);
            this.txtDownloadUrl.Name = "txtDownloadUrl";
            this.txtDownloadUrl.Size = new System.Drawing.Size(186, 20);
            this.txtDownloadUrl.TabIndex = 1;
            // 
            // Download
            // 
            this.Download.Location = new System.Drawing.Point(348, 34);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(103, 26);
            this.Download.TabIndex = 2;
            this.Download.Text = "Add to Queue";
            this.Download.UseVisualStyleBackColor = true;
            this.Download.Click += new System.EventHandler(this.AddToQueue_Click);
            // 
            // QueueProcessing_1
            // 
            this.QueueProcessing_1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.QueueProcessing_1_DoWork);
            this.QueueProcessing_1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.QueueProcessing_1_ProgressChanged);
            this.QueueProcessing_1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.QueueProcessing_1_RunWorkerCompleted);
            // 
            // QueueProcessing_2
            // 
            this.QueueProcessing_2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.QueueProcessing_2_DoWork);
            this.QueueProcessing_2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.QueueProcessing_2_ProgressChanged);
            this.QueueProcessing_2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.QueueProcessing_2_RunWorkerCompleted);
            // 
            // QueueProcessing_3
            // 
            this.QueueProcessing_3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.QueueProcessing_3_DoWork);
            this.QueueProcessing_3.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.QueueProcessing_3_ProgressChanged);
            this.QueueProcessing_3.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.QueueProcessing_3_RunWorkerCompleted);
            // 
            // QueueProcessing_4
            // 
            this.QueueProcessing_4.DoWork += new System.ComponentModel.DoWorkEventHandler(this.QueueProcessing_4_DoWork);
            this.QueueProcessing_4.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.QueueProcessing_4_ProgressChanged);
            this.QueueProcessing_4.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.QueueProcessing_4_RunWorkerCompleted);
            // 
            // pnlBackground_1
            // 
            this.pnlBackground_1.Controls.Add(this.lblError1);
            this.pnlBackground_1.Controls.Add(this.pbProgress1);
            this.pnlBackground_1.Controls.Add(this.lblFileName1);
            this.pnlBackground_1.Location = new System.Drawing.Point(31, 66);
            this.pnlBackground_1.Name = "pnlBackground_1";
            this.pnlBackground_1.Size = new System.Drawing.Size(420, 58);
            this.pnlBackground_1.TabIndex = 3;
            // 
            // lblError1
            // 
            this.lblError1.AutoSize = true;
            this.lblError1.ForeColor = System.Drawing.Color.Red;
            this.lblError1.Location = new System.Drawing.Point(3, 42);
            this.lblError1.Name = "lblError1";
            this.lblError1.Size = new System.Drawing.Size(45, 13);
            this.lblError1.TabIndex = 2;
            this.lblError1.Text = "lblError1";
            this.lblError1.Visible = false;
            // 
            // pbProgress1
            // 
            this.pbProgress1.Location = new System.Drawing.Point(3, 16);
            this.pbProgress1.Name = "pbProgress1";
            this.pbProgress1.Size = new System.Drawing.Size(387, 23);
            this.pbProgress1.TabIndex = 1;
            // 
            // lblFileName1
            // 
            this.lblFileName1.AutoSize = true;
            this.lblFileName1.Location = new System.Drawing.Point(3, 0);
            this.lblFileName1.Name = "lblFileName1";
            this.lblFileName1.Size = new System.Drawing.Size(54, 13);
            this.lblFileName1.TabIndex = 0;
            this.lblFileName1.Text = "Progress: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblError2);
            this.panel1.Controls.Add(this.pbProgressBar2);
            this.panel1.Controls.Add(this.lblFileName2);
            this.panel1.Location = new System.Drawing.Point(31, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 58);
            this.panel1.TabIndex = 4;
            // 
            // lblError2
            // 
            this.lblError2.AutoSize = true;
            this.lblError2.ForeColor = System.Drawing.Color.Red;
            this.lblError2.Location = new System.Drawing.Point(3, 42);
            this.lblError2.Name = "lblError2";
            this.lblError2.Size = new System.Drawing.Size(45, 13);
            this.lblError2.TabIndex = 2;
            this.lblError2.Text = "lblError1";
            this.lblError2.Visible = false;
            // 
            // pbProgressBar2
            // 
            this.pbProgressBar2.Location = new System.Drawing.Point(3, 16);
            this.pbProgressBar2.Name = "pbProgressBar2";
            this.pbProgressBar2.Size = new System.Drawing.Size(387, 23);
            this.pbProgressBar2.TabIndex = 1;
            // 
            // lblFileName2
            // 
            this.lblFileName2.AutoSize = true;
            this.lblFileName2.Location = new System.Drawing.Point(3, 0);
            this.lblFileName2.Name = "lblFileName2";
            this.lblFileName2.Size = new System.Drawing.Size(57, 13);
            this.lblFileName2.TabIndex = 0;
            this.lblFileName2.Text = "Progress : ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblError3);
            this.panel2.Controls.Add(this.pbProgressBar3);
            this.panel2.Controls.Add(this.lblFileName3);
            this.panel2.Location = new System.Drawing.Point(31, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 58);
            this.panel2.TabIndex = 5;
            // 
            // lblError3
            // 
            this.lblError3.AutoSize = true;
            this.lblError3.ForeColor = System.Drawing.Color.Red;
            this.lblError3.Location = new System.Drawing.Point(3, 42);
            this.lblError3.Name = "lblError3";
            this.lblError3.Size = new System.Drawing.Size(45, 13);
            this.lblError3.TabIndex = 2;
            this.lblError3.Text = "lblError1";
            this.lblError3.Visible = false;
            // 
            // pbProgressBar3
            // 
            this.pbProgressBar3.Location = new System.Drawing.Point(3, 16);
            this.pbProgressBar3.Name = "pbProgressBar3";
            this.pbProgressBar3.Size = new System.Drawing.Size(387, 23);
            this.pbProgressBar3.TabIndex = 1;
            // 
            // lblFileName3
            // 
            this.lblFileName3.AutoSize = true;
            this.lblFileName3.Location = new System.Drawing.Point(3, 0);
            this.lblFileName3.Name = "lblFileName3";
            this.lblFileName3.Size = new System.Drawing.Size(57, 13);
            this.lblFileName3.TabIndex = 0;
            this.lblFileName3.Text = "Progress : ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblError4);
            this.panel3.Controls.Add(this.pbProgressBar4);
            this.panel3.Controls.Add(this.lblFileName4);
            this.panel3.Location = new System.Drawing.Point(31, 258);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 58);
            this.panel3.TabIndex = 6;
            // 
            // lblError4
            // 
            this.lblError4.AutoSize = true;
            this.lblError4.ForeColor = System.Drawing.Color.Red;
            this.lblError4.Location = new System.Drawing.Point(3, 42);
            this.lblError4.Name = "lblError4";
            this.lblError4.Size = new System.Drawing.Size(45, 13);
            this.lblError4.TabIndex = 2;
            this.lblError4.Text = "lblError1";
            this.lblError4.Visible = false;
            // 
            // pbProgressBar4
            // 
            this.pbProgressBar4.Location = new System.Drawing.Point(3, 16);
            this.pbProgressBar4.Name = "pbProgressBar4";
            this.pbProgressBar4.Size = new System.Drawing.Size(387, 23);
            this.pbProgressBar4.TabIndex = 1;
            // 
            // lblFileName4
            // 
            this.lblFileName4.AutoSize = true;
            this.lblFileName4.Location = new System.Drawing.Point(3, 0);
            this.lblFileName4.Name = "lblFileName4";
            this.lblFileName4.Size = new System.Drawing.Size(57, 13);
            this.lblFileName4.TabIndex = 0;
            this.lblFileName4.Text = "Progress : ";
            // 
            // lvLog
            // 
            this.lvLog.Location = new System.Drawing.Point(492, 52);
            this.lvLog.Name = "lvLog";
            this.lvLog.Size = new System.Drawing.Size(312, 260);
            this.lvLog.TabIndex = 7;
            this.lvLog.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Output Folder";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 9;
            // 
            // DownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 324);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvLog);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBackground_1);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.txtDownloadUrl);
            this.Controls.Add(this.label1);
            this.Name = "DownloadForm";
            this.Text = "Para vos RARFI!!";
            this.pnlBackground_1.ResumeLayout(false);
            this.pnlBackground_1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDownloadUrl;
        private System.Windows.Forms.Button Download;
        private System.ComponentModel.BackgroundWorker QueueProcessing_1;
        private System.ComponentModel.BackgroundWorker QueueProcessing_2;
        private System.ComponentModel.BackgroundWorker QueueProcessing_3;
        private System.ComponentModel.BackgroundWorker QueueProcessing_4;
        private System.Windows.Forms.Panel pnlBackground_1;
        private System.Windows.Forms.Label lblError1;
        private System.Windows.Forms.ProgressBar pbProgress1;
        private System.Windows.Forms.Label lblFileName1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblError2;
        private System.Windows.Forms.ProgressBar pbProgressBar2;
        private System.Windows.Forms.Label lblFileName2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblError3;
        private System.Windows.Forms.ProgressBar pbProgressBar3;
        private System.Windows.Forms.Label lblFileName3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblError4;
        private System.Windows.Forms.ProgressBar pbProgressBar4;
        private System.Windows.Forms.Label lblFileName4;
        private System.Windows.Forms.ListView lvLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

