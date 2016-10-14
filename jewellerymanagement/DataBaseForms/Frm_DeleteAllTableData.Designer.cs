namespace JewelleryManagement.DataBaseForms
{
    partial class Frm_DeleteAllTableData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DeleteAllTableData));
            this.grp_Select = new System.Windows.Forms.GroupBox();
            this.rbn_SelectAll = new System.Windows.Forms.RadioButton();
            this.rbn_CustomSelect = new System.Windows.Forms.RadioButton();
            this.dgv_BalanceReport = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Table_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttn_Delete = new System.Windows.Forms.Button();
            this.grp_Select.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BalanceReport)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_Select
            // 
            this.grp_Select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(232)))));
            this.grp_Select.Controls.Add(this.rbn_SelectAll);
            this.grp_Select.Controls.Add(this.rbn_CustomSelect);
            this.grp_Select.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Select.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grp_Select.Location = new System.Drawing.Point(12, 2);
            this.grp_Select.Name = "grp_Select";
            this.grp_Select.Size = new System.Drawing.Size(200, 79);
            this.grp_Select.TabIndex = 274;
            this.grp_Select.TabStop = false;
            this.grp_Select.Text = "Select";
            // 
            // rbn_SelectAll
            // 
            this.rbn_SelectAll.AutoSize = true;
            this.rbn_SelectAll.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbn_SelectAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbn_SelectAll.Location = new System.Drawing.Point(22, 21);
            this.rbn_SelectAll.Name = "rbn_SelectAll";
            this.rbn_SelectAll.Size = new System.Drawing.Size(87, 20);
            this.rbn_SelectAll.TabIndex = 1;
            this.rbn_SelectAll.TabStop = true;
            this.rbn_SelectAll.Text = "Select All";
            this.rbn_SelectAll.UseVisualStyleBackColor = true;
            this.rbn_SelectAll.CheckedChanged += new System.EventHandler(this.rbn_SelectAll_CheckedChanged);
            // 
            // rbn_CustomSelect
            // 
            this.rbn_CustomSelect.AutoSize = true;
            this.rbn_CustomSelect.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbn_CustomSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbn_CustomSelect.Location = new System.Drawing.Point(22, 47);
            this.rbn_CustomSelect.Name = "rbn_CustomSelect";
            this.rbn_CustomSelect.Size = new System.Drawing.Size(117, 20);
            this.rbn_CustomSelect.TabIndex = 2;
            this.rbn_CustomSelect.TabStop = true;
            this.rbn_CustomSelect.Text = "Custom Select";
            this.rbn_CustomSelect.UseVisualStyleBackColor = true;
            this.rbn_CustomSelect.CheckedChanged += new System.EventHandler(this.rbn_CustomSelect_CheckedChanged);
            // 
            // dgv_BalanceReport
            // 
            this.dgv_BalanceReport.AllowUserToAddRows = false;
            this.dgv_BalanceReport.AllowUserToDeleteRows = false;
            this.dgv_BalanceReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_BalanceReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_BalanceReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(232)))));
            this.dgv_BalanceReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BalanceReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.Table_Name});
            this.dgv_BalanceReport.Location = new System.Drawing.Point(12, 87);
            this.dgv_BalanceReport.Name = "dgv_BalanceReport";
            this.dgv_BalanceReport.Size = new System.Drawing.Size(1007, 412);
            this.dgv_BalanceReport.TabIndex = 275;
            // 
            // Select
            // 
            this.Select.FillWeight = 25.38071F;
            this.Select.HeaderText = "";
            this.Select.Name = "Select";
            this.Select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Table_Name
            // 
            this.Table_Name.FillWeight = 118.6548F;
            this.Table_Name.HeaderText = "Name";
            this.Table_Name.Name = "Table_Name";
            // 
            // bttn_Delete
            // 
            this.bttn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.bttn_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Delete.BackgroundImage")));
            this.bttn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Delete.FlatAppearance.BorderSize = 0;
            this.bttn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Delete.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Delete.ForeColor = System.Drawing.Color.White;
            this.bttn_Delete.Location = new System.Drawing.Point(948, 505);
            this.bttn_Delete.Name = "bttn_Delete";
            this.bttn_Delete.Size = new System.Drawing.Size(71, 28);
            this.bttn_Delete.TabIndex = 276;
            this.bttn_Delete.Text = "DELETE";
            this.bttn_Delete.UseVisualStyleBackColor = false;
            this.bttn_Delete.Click += new System.EventHandler(this.bttn_Delete_Click);
            // 
            // Frm_DeleteAllTableData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 545);
            this.Controls.Add(this.bttn_Delete);
            this.Controls.Add(this.dgv_BalanceReport);
            this.Controls.Add(this.grp_Select);
            this.Name = "Frm_DeleteAllTableData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_DeleteAllTableData";
            this.Load += new System.EventHandler(this.Frm_DeleteAllTableData_Load);
            this.grp_Select.ResumeLayout(false);
            this.grp_Select.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BalanceReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Select;
        private System.Windows.Forms.RadioButton rbn_SelectAll;
        private System.Windows.Forms.RadioButton rbn_CustomSelect;
        private System.Windows.Forms.DataGridView dgv_BalanceReport;
        private System.Windows.Forms.Button bttn_Delete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_Name;

    }
}