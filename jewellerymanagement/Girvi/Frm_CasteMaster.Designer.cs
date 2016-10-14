namespace JewelleryManagement.Girvi
{
    partial class Frm_CasteMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CasteMaster));
            this.txt_Caste = new System.Windows.Forms.TextBox();
            this.lbl_CasteNo = new System.Windows.Forms.Label();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.dgv_CasteDetail = new System.Windows.Forms.DataGridView();
            this.srno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttn_add = new System.Windows.Forms.Button();
            this.bttn_update = new System.Windows.Forms.Button();
            this.bttn_reset = new System.Windows.Forms.Button();
            this.bttn_delete = new System.Windows.Forms.Button();
            this.pnl_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CasteDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Caste
            // 
            this.txt_Caste.Font = new System.Drawing.Font("Mangal", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Caste.Location = new System.Drawing.Point(99, 40);
            this.txt_Caste.Name = "txt_Caste";
            this.txt_Caste.Size = new System.Drawing.Size(215, 28);
            this.txt_Caste.TabIndex = 354;
            // 
            // lbl_CasteNo
            // 
            this.lbl_CasteNo.AutoSize = true;
            this.lbl_CasteNo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CasteNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_CasteNo.Location = new System.Drawing.Point(46, 43);
            this.lbl_CasteNo.Name = "lbl_CasteNo";
            this.lbl_CasteNo.Size = new System.Drawing.Size(43, 16);
            this.lbl_CasteNo.TabIndex = 353;
            this.lbl_CasteNo.Text = "Caste";
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Bottom.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.pnl_Bottom.Controls.Add(this.bttn_Close);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 342);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(343, 32);
            this.pnl_Bottom.TabIndex = 352;
            // 
            // bttn_Close
            // 
            this.bttn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_Close.BackColor = System.Drawing.Color.Transparent;
            this.bttn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Close.BackgroundImage")));
            this.bttn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Close.FlatAppearance.BorderSize = 0;
            this.bttn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Close.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Close.ForeColor = System.Drawing.Color.White;
            this.bttn_Close.Location = new System.Drawing.Point(269, 3);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(71, 27);
            this.bttn_Close.TabIndex = 371;
            this.bttn_Close.Text = "CLOSE";
            this.bttn_Close.UseVisualStyleBackColor = false;
            this.bttn_Close.Click += new System.EventHandler(this.bttn_Close_Click);
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Header.BackgroundImage = global::JewelleryManagement.Properties.Resources._742828_jewelry_wallpaper;
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(343, 32);
            this.pnl_Header.TabIndex = 351;
            // 
            // dgv_CasteDetail
            // 
            this.dgv_CasteDetail.AllowUserToAddRows = false;
            this.dgv_CasteDetail.AllowUserToDeleteRows = false;
            this.dgv_CasteDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_CasteDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CasteDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(232)))));
            this.dgv_CasteDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_CasteDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CasteDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.srno,
            this.Id,
            this.Caste});
            this.dgv_CasteDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(232)))));
            this.dgv_CasteDetail.Location = new System.Drawing.Point(15, 121);
            this.dgv_CasteDetail.Name = "dgv_CasteDetail";
            this.dgv_CasteDetail.ReadOnly = true;
            this.dgv_CasteDetail.Size = new System.Drawing.Size(312, 203);
            this.dgv_CasteDetail.TabIndex = 355;
            this.dgv_CasteDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CasteDetail_CellClick);
            // 
            // srno
            // 
            this.srno.HeaderText = "Sr No";
            this.srno.Name = "srno";
            this.srno.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Caste
            // 
            this.Caste.HeaderText = "Caste";
            this.Caste.Name = "Caste";
            this.Caste.ReadOnly = true;
            // 
            // bttn_add
            // 
            this.bttn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_add.BackgroundImage")));
            this.bttn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_add.FlatAppearance.BorderSize = 0;
            this.bttn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_add.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_add.ForeColor = System.Drawing.Color.White;
            this.bttn_add.Location = new System.Drawing.Point(18, 87);
            this.bttn_add.Name = "bttn_add";
            this.bttn_add.Size = new System.Drawing.Size(71, 28);
            this.bttn_add.TabIndex = 372;
            this.bttn_add.Text = "Add";
            this.bttn_add.UseVisualStyleBackColor = true;
            this.bttn_add.Click += new System.EventHandler(this.bttn_add_Click);
            // 
            // bttn_update
            // 
            this.bttn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_update.BackgroundImage")));
            this.bttn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_update.FlatAppearance.BorderSize = 0;
            this.bttn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_update.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_update.ForeColor = System.Drawing.Color.White;
            this.bttn_update.Location = new System.Drawing.Point(95, 89);
            this.bttn_update.Name = "bttn_update";
            this.bttn_update.Size = new System.Drawing.Size(71, 25);
            this.bttn_update.TabIndex = 371;
            this.bttn_update.Text = "Update";
            this.bttn_update.UseVisualStyleBackColor = true;
            this.bttn_update.Click += new System.EventHandler(this.bttn_update_Click);
            // 
            // bttn_reset
            // 
            this.bttn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_reset.BackgroundImage")));
            this.bttn_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_reset.FlatAppearance.BorderSize = 0;
            this.bttn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_reset.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_reset.ForeColor = System.Drawing.Color.White;
            this.bttn_reset.Location = new System.Drawing.Point(257, 88);
            this.bttn_reset.Name = "bttn_reset";
            this.bttn_reset.Size = new System.Drawing.Size(71, 25);
            this.bttn_reset.TabIndex = 373;
            this.bttn_reset.Text = "Reset";
            this.bttn_reset.UseVisualStyleBackColor = true;
            this.bttn_reset.Click += new System.EventHandler(this.bttn_reset_Click);
            // 
            // bttn_delete
            // 
            this.bttn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_delete.BackColor = System.Drawing.Color.Transparent;
            this.bttn_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_delete.BackgroundImage")));
            this.bttn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_delete.FlatAppearance.BorderSize = 0;
            this.bttn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_delete.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_delete.ForeColor = System.Drawing.Color.White;
            this.bttn_delete.Location = new System.Drawing.Point(172, 88);
            this.bttn_delete.Name = "bttn_delete";
            this.bttn_delete.Size = new System.Drawing.Size(71, 27);
            this.bttn_delete.TabIndex = 372;
            this.bttn_delete.Text = "Delete";
            this.bttn_delete.UseVisualStyleBackColor = false;
            this.bttn_delete.Click += new System.EventHandler(this.bttn_delete_Click);
            // 
            // Frm_CasteMaster
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(343, 374);
            this.Controls.Add(this.bttn_delete);
            this.Controls.Add(this.bttn_reset);
            this.Controls.Add(this.bttn_add);
            this.Controls.Add(this.bttn_update);
            this.Controls.Add(this.dgv_CasteDetail);
            this.Controls.Add(this.txt_Caste);
            this.Controls.Add(this.lbl_CasteNo);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.pnl_Header);
            this.KeyPreview = true;
            this.Name = "Frm_CasteMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caste Master";
            this.Load += new System.EventHandler(this.Frm_CasteMaster_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_CasteMaster_KeyDown);
            this.pnl_Bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CasteDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Caste;
        private System.Windows.Forms.Label lbl_CasteNo;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Button bttn_Close;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.DataGridView dgv_CasteDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn srno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caste;
        private System.Windows.Forms.Button bttn_add;
        private System.Windows.Forms.Button bttn_update;
        private System.Windows.Forms.Button bttn_reset;
        private System.Windows.Forms.Button bttn_delete;
    }
}