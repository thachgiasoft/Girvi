namespace JewelleryManagement.Common
{
    partial class frm_UpdateQuery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Execute = new System.Windows.Forms.Button();
            this.dgv_UpdateQuery = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UpdateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Query = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_selectall = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UpdateQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Execute
            // 
            this.btn_Execute.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Execute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Execute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Execute.Location = new System.Drawing.Point(686, 9);
            this.btn_Execute.Name = "btn_Execute";
            this.btn_Execute.Size = new System.Drawing.Size(104, 37);
            this.btn_Execute.TabIndex = 1;
            this.btn_Execute.Text = "Execute";
            this.btn_Execute.UseVisualStyleBackColor = false;
            this.btn_Execute.Click += new System.EventHandler(this.btn_Execute_Click);
            // 
            // dgv_UpdateQuery
            // 
            this.dgv_UpdateQuery.AllowUserToAddRows = false;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.dgv_UpdateQuery.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_UpdateQuery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_UpdateQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UpdateQuery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.UpdateName,
            this.Query,
            this.Date});
            this.dgv_UpdateQuery.Location = new System.Drawing.Point(12, 55);
            this.dgv_UpdateQuery.Name = "dgv_UpdateQuery";
            this.dgv_UpdateQuery.Size = new System.Drawing.Size(778, 295);
            this.dgv_UpdateQuery.TabIndex = 2;
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            // 
            // UpdateName
            // 
            this.UpdateName.HeaderText = "UpdateName";
            this.UpdateName.Name = "UpdateName";
            // 
            // Query
            // 
            this.Query.HeaderText = "Query";
            this.Query.Name = "Query";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // chk_selectall
            // 
            this.chk_selectall.AutoSize = true;
            this.chk_selectall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_selectall.Location = new System.Drawing.Point(41, 12);
            this.chk_selectall.Name = "chk_selectall";
            this.chk_selectall.Size = new System.Drawing.Size(86, 19);
            this.chk_selectall.TabIndex = 3;
            this.chk_selectall.Text = "Select All";
            this.chk_selectall.UseVisualStyleBackColor = true;
            this.chk_selectall.CheckedChanged += new System.EventHandler(this.chk_selectall_CheckedChanged);
            // 
            // frm_UpdateQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 362);
            this.Controls.Add(this.chk_selectall);
            this.Controls.Add(this.dgv_UpdateQuery);
            this.Controls.Add(this.btn_Execute);
            this.Name = "frm_UpdateQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_UpdateQuery";
            this.Load += new System.EventHandler(this.frm_UpdateQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UpdateQuery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Execute;
        private System.Windows.Forms.DataGridView dgv_UpdateQuery;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Query;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.CheckBox chk_selectall;
    }
}