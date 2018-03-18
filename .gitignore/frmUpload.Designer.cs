namespace upload_to_temperatur.nu
{
    partial class frmSettings
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
            this.components = new System.ComponentModel.Container();
            this.txtDecimaler = new System.Windows.Forms.TextBox();
            this.tmrUploadInterval = new System.Windows.Forms.Timer(this.components);
            this.lblDecimal = new System.Windows.Forms.Label();
            this.lblDirectory = new System.Windows.Forms.Label();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblInterval = new System.Windows.Forms.Label();
            this.txtUploadInterval = new System.Windows.Forms.TextBox();
            this.lblHash = new System.Windows.Forms.Label();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.webUpload = new System.Windows.Forms.WebBrowser();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblLastUploaded = new System.Windows.Forms.Label();
            this.btnTest1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDecimaler
            // 
            this.txtDecimaler.Location = new System.Drawing.Point(126, 6);
            this.txtDecimaler.Name = "txtDecimaler";
            this.txtDecimaler.Size = new System.Drawing.Size(35, 20);
            this.txtDecimaler.TabIndex = 1;
            this.txtDecimaler.Text = "1";
            this.txtDecimaler.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDecimaler_KeyPress);
            // 
            // tmrUploadInterval
            // 
            this.tmrUploadInterval.Tick += new System.EventHandler(this.tmrUploadInterval_Tick);
            // 
            // lblDecimal
            // 
            this.lblDecimal.AutoSize = true;
            this.lblDecimal.Location = new System.Drawing.Point(38, 9);
            this.lblDecimal.Name = "lblDecimal";
            this.lblDecimal.Size = new System.Drawing.Size(82, 13);
            this.lblDecimal.TabIndex = 2;
            this.lblDecimal.Text = "Antal decimaler:";
            // 
            // lblDirectory
            // 
            this.lblDirectory.AutoSize = true;
            this.lblDirectory.Location = new System.Drawing.Point(73, 35);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(47, 13);
            this.lblDirectory.TabIndex = 4;
            this.lblDirectory.Text = "Sökväg:";
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(126, 32);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(208, 20);
            this.txtDirectory.TabIndex = 3;
            this.txtDirectory.Text = "F:\\Temperatur.nu\\Värden\\";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(71, 61);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(49, 13);
            this.lblFileName.TabIndex = 6;
            this.lblFileName.Text = "Fil namn:";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(126, 58);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(208, 20);
            this.txtFileName.TabIndex = 5;
            this.txtFileName.Text = "last.htm";
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(12, 87);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(108, 13);
            this.lblInterval.TabIndex = 8;
            this.lblInterval.Text = "Uppladdings intervall:";
            // 
            // txtUploadInterval
            // 
            this.txtUploadInterval.Location = new System.Drawing.Point(126, 84);
            this.txtUploadInterval.Name = "txtUploadInterval";
            this.txtUploadInterval.Size = new System.Drawing.Size(208, 20);
            this.txtUploadInterval.TabIndex = 7;
            this.txtUploadInterval.Text = "60";
            // 
            // lblHash
            // 
            this.lblHash.AutoSize = true;
            this.lblHash.Location = new System.Drawing.Point(67, 113);
            this.lblHash.Name = "lblHash";
            this.lblHash.Size = new System.Drawing.Size(53, 13);
            this.lblHash.TabIndex = 10;
            this.lblHash.Text = "Hashkod:";
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(126, 110);
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(208, 20);
            this.txtHash.TabIndex = 9;
            this.txtHash.Text = "0c4e88a2b432146501c63d9182d9aaf9";
            // 
            // webUpload
            // 
            this.webUpload.Location = new System.Drawing.Point(12, 12);
            this.webUpload.MinimumSize = new System.Drawing.Size(20, 20);
            this.webUpload.Name = "webUpload";
            this.webUpload.Size = new System.Drawing.Size(250, 114);
            this.webUpload.TabIndex = 11;
            this.webUpload.Visible = false;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(45, 136);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 12;
            this.btnApply.Text = "Tillämpa";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(126, 136);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblLastUploaded
            // 
            this.lblLastUploaded.AutoSize = true;
            this.lblLastUploaded.Location = new System.Drawing.Point(12, 162);
            this.lblLastUploaded.Name = "lblLastUploaded";
            this.lblLastUploaded.Size = new System.Drawing.Size(0, 13);
            this.lblLastUploaded.TabIndex = 14;
            // 
            // btnTest1
            // 
            this.btnTest1.Location = new System.Drawing.Point(258, 189);
            this.btnTest1.Name = "btnTest1";
            this.btnTest1.Size = new System.Drawing.Size(75, 23);
            this.btnTest1.TabIndex = 15;
            this.btnTest1.Text = "Test1";
            this.btnTest1.UseVisualStyleBackColor = true;
            this.btnTest1.Click += new System.EventHandler(this.btnTest1_Click_1);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 304);
            this.Controls.Add(this.btnTest1);
            this.Controls.Add(this.lblLastUploaded);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lblHash);
            this.Controls.Add(this.txtHash);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.txtUploadInterval);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblDirectory);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.lblDecimal);
            this.Controls.Add(this.txtDecimaler);
            this.Controls.Add(this.webUpload);
            this.Name = "frmSettings";
            this.Text = "Uploading data to temperatur.nu";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDecimaler;
        private System.Windows.Forms.Timer tmrUploadInterval;
        private System.Windows.Forms.Label lblDecimal;
        private System.Windows.Forms.Label lblDirectory;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.TextBox txtUploadInterval;
        private System.Windows.Forms.Label lblHash;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.WebBrowser webUpload;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblLastUploaded;
        private System.Windows.Forms.Button btnTest1;
    }
}

