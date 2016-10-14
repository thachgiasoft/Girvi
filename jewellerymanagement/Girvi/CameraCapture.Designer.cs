namespace JewelleryManagement.Girvi
{
    partial class CameraCapture
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttn_Start = new System.Windows.Forms.Button();
            this.bttn_SaveProfilePic = new System.Windows.Forms.Button();
            this.bttn_capture = new System.Windows.Forms.Button();
            this.cmbCameraDevice = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bttn_SaveDoc1 = new System.Windows.Forms.Button();
            this.bttn_SaveDoc2 = new System.Windows.Forms.Button();
            this.bttn_SaveDoc3 = new System.Windows.Forms.Button();
            this.bttn_Stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(724, 316);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bttn_Start
            // 
            this.bttn_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_Start.Location = new System.Drawing.Point(9, 363);
            this.bttn_Start.Name = "bttn_Start";
            this.bttn_Start.Size = new System.Drawing.Size(99, 42);
            this.bttn_Start.TabIndex = 1;
            this.bttn_Start.Text = "Start";
            this.bttn_Start.UseVisualStyleBackColor = true;
            this.bttn_Start.Click += new System.EventHandler(this.bttn_Start_Click);
            // 
            // bttn_SaveProfilePic
            // 
            this.bttn_SaveProfilePic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_SaveProfilePic.Location = new System.Drawing.Point(219, 363);
            this.bttn_SaveProfilePic.Name = "bttn_SaveProfilePic";
            this.bttn_SaveProfilePic.Size = new System.Drawing.Size(99, 42);
            this.bttn_SaveProfilePic.TabIndex = 2;
            this.bttn_SaveProfilePic.Text = "Save Profile Photo";
            this.bttn_SaveProfilePic.UseVisualStyleBackColor = true;
            this.bttn_SaveProfilePic.Click += new System.EventHandler(this.bttn_SaveProfilePic_Click);
            // 
            // bttn_capture
            // 
            this.bttn_capture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_capture.Location = new System.Drawing.Point(114, 363);
            this.bttn_capture.Name = "bttn_capture";
            this.bttn_capture.Size = new System.Drawing.Size(99, 42);
            this.bttn_capture.TabIndex = 3;
            this.bttn_capture.Text = "Capture";
            this.bttn_capture.UseVisualStyleBackColor = true;
            this.bttn_capture.Click += new System.EventHandler(this.bttn_capture_Click);
            // 
            // cmbCameraDevice
            // 
            this.cmbCameraDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCameraDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCameraDevice.FormattingEnabled = true;
            this.cmbCameraDevice.Location = new System.Drawing.Point(36, 335);
            this.cmbCameraDevice.Name = "cmbCameraDevice";
            this.cmbCameraDevice.Size = new System.Drawing.Size(669, 21);
            this.cmbCameraDevice.TabIndex = 4;
            // 
            // bttn_SaveDoc1
            // 
            this.bttn_SaveDoc1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_SaveDoc1.Location = new System.Drawing.Point(324, 363);
            this.bttn_SaveDoc1.Name = "bttn_SaveDoc1";
            this.bttn_SaveDoc1.Size = new System.Drawing.Size(99, 42);
            this.bttn_SaveDoc1.TabIndex = 5;
            this.bttn_SaveDoc1.Text = "Save Document1 Photo";
            this.bttn_SaveDoc1.UseVisualStyleBackColor = true;
            this.bttn_SaveDoc1.Click += new System.EventHandler(this.bttn_SaveDoc1_Click);
            // 
            // bttn_SaveDoc2
            // 
            this.bttn_SaveDoc2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_SaveDoc2.Location = new System.Drawing.Point(429, 363);
            this.bttn_SaveDoc2.Name = "bttn_SaveDoc2";
            this.bttn_SaveDoc2.Size = new System.Drawing.Size(99, 42);
            this.bttn_SaveDoc2.TabIndex = 6;
            this.bttn_SaveDoc2.Text = "Save Document2 Photo";
            this.bttn_SaveDoc2.UseVisualStyleBackColor = true;
            this.bttn_SaveDoc2.Click += new System.EventHandler(this.bttn_SaveDoc2_Click);
            // 
            // bttn_SaveDoc3
            // 
            this.bttn_SaveDoc3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_SaveDoc3.Location = new System.Drawing.Point(534, 363);
            this.bttn_SaveDoc3.Name = "bttn_SaveDoc3";
            this.bttn_SaveDoc3.Size = new System.Drawing.Size(99, 42);
            this.bttn_SaveDoc3.TabIndex = 7;
            this.bttn_SaveDoc3.Text = "Save Document3 Photo";
            this.bttn_SaveDoc3.UseVisualStyleBackColor = true;
            this.bttn_SaveDoc3.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttn_Stop
            // 
            this.bttn_Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_Stop.Location = new System.Drawing.Point(639, 363);
            this.bttn_Stop.Name = "bttn_Stop";
            this.bttn_Stop.Size = new System.Drawing.Size(99, 42);
            this.bttn_Stop.TabIndex = 8;
            this.bttn_Stop.Text = "Stop";
            this.bttn_Stop.UseVisualStyleBackColor = true;
            this.bttn_Stop.Click += new System.EventHandler(this.bttn_Stop_Click);
            // 
            // CameraCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 416);
            this.Controls.Add(this.bttn_Stop);
            this.Controls.Add(this.bttn_SaveDoc3);
            this.Controls.Add(this.bttn_SaveDoc2);
            this.Controls.Add(this.bttn_SaveDoc1);
            this.Controls.Add(this.cmbCameraDevice);
            this.Controls.Add(this.bttn_capture);
            this.Controls.Add(this.bttn_SaveProfilePic);
            this.Controls.Add(this.bttn_Start);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CameraCapture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camera";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttn_Start;
        private System.Windows.Forms.Button bttn_SaveProfilePic;
        private System.Windows.Forms.Button bttn_capture;
        private System.Windows.Forms.ComboBox cmbCameraDevice;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button bttn_SaveDoc1;
        private System.Windows.Forms.Button bttn_SaveDoc2;
        private System.Windows.Forms.Button bttn_SaveDoc3;
        private System.Windows.Forms.Button bttn_Stop;
    }
}

