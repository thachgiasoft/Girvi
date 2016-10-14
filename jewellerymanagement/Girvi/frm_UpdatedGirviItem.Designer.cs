namespace JewelleryManagement.Girvi
{
    partial class frm_UpdatedGirviItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_UpdatedGirviItem));
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_GirviNo = new System.Windows.Forms.Label();
            this.txt_GirviNo = new System.Windows.Forms.TextBox();
            this.dgv_ItemDetail = new System.Windows.Forms.DataGridView();
            this.InvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MetalType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrossWt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReduceWt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalWt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalWtInPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FineWt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.bttn_Update = new System.Windows.Forms.Button();
            this.bttn_Reset = new System.Windows.Forms.Button();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblsrno = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_TotalAmount = new System.Windows.Forms.Label();
            this.lbl_CurrentPrice = new System.Windows.Forms.Label();
            this.lbl_FineWt = new System.Windows.Forms.Label();
            this.lbl_WtInPercent = new System.Windows.Forms.Label();
            this.lbl_ReduceWt = new System.Windows.Forms.Label();
            this.lbl_MetalType = new System.Windows.Forms.Label();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.txt_GrossWt = new System.Windows.Forms.TextBox();
            this.txt_NetWeight = new System.Windows.Forms.TextBox();
            this.lbl_GrossWt = new System.Windows.Forms.Label();
            this.lbl_NetWt = new System.Windows.Forms.Label();
            this.lbl_ItemType = new System.Windows.Forms.Label();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.txt_FineWt = new System.Windows.Forms.TextBox();
            this.txt_CurrentRate = new System.Windows.Forms.TextBox();
            this.txt_WtInPercent = new System.Windows.Forms.TextBox();
            this.txt_ReduceWt = new System.Windows.Forms.TextBox();
            this.Cmb_MetalType = new System.Windows.Forms.ComboBox();
            this.pnl_languageRbts = new System.Windows.Forms.Panel();
            this.rbt_English = new System.Windows.Forms.RadioButton();
            this.rbt_Hindi = new System.Windows.Forms.RadioButton();
            this.rbt_Marathi = new System.Windows.Forms.RadioButton();
            this.pnl_LanguageOther = new System.Windows.Forms.Panel();
            this.rbt_OtherFalse = new System.Windows.Forms.RadioButton();
            this.rbt_OtherTrue = new System.Windows.Forms.RadioButton();
            this.Cmb_ItemType = new System.Windows.Forms.ComboBox();
            this.pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemDetail)).BeginInit();
            this.pnl_Bottom.SuspendLayout();
            this.pnl_languageRbts.SuspendLayout();
            this.pnl_LanguageOther.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Header.Controls.Add(this.label11);
            this.pnl_Header.Controls.Add(this.dateTimePicker2);
            this.pnl_Header.Controls.Add(this.lbl_Date);
            this.pnl_Header.Controls.Add(this.dtp_Date);
            this.pnl_Header.Controls.Add(this.lbl_GirviNo);
            this.pnl_Header.Controls.Add(this.txt_GirviNo);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(806, 38);
            this.pnl_Header.TabIndex = 76;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(655, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 19);
            this.label11.TabIndex = 363;
            this.label11.Text = "Date";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(700, 7);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(100, 27);
            this.dateTimePicker2.TabIndex = 362;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Date.Location = new System.Drawing.Point(1096, 7);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(40, 19);
            this.lbl_Date.TabIndex = 360;
            this.lbl_Date.Text = "Date";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(1140, 5);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(100, 27);
            this.dtp_Date.TabIndex = 359;
            // 
            // lbl_GirviNo
            // 
            this.lbl_GirviNo.AutoSize = true;
            this.lbl_GirviNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GirviNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_GirviNo.Location = new System.Drawing.Point(20, 12);
            this.lbl_GirviNo.Name = "lbl_GirviNo";
            this.lbl_GirviNo.Size = new System.Drawing.Size(64, 16);
            this.lbl_GirviNo.TabIndex = 384;
            this.lbl_GirviNo.Text = "Girvi No";
            // 
            // txt_GirviNo
            // 
            this.txt_GirviNo.Location = new System.Drawing.Point(94, 9);
            this.txt_GirviNo.Name = "txt_GirviNo";
            this.txt_GirviNo.Size = new System.Drawing.Size(100, 20);
            this.txt_GirviNo.TabIndex = 369;
            this.txt_GirviNo.Enter += new System.EventHandler(this.txt_GirviNo_Enter);
            // 
            // dgv_ItemDetail
            // 
            this.dgv_ItemDetail.AllowUserToAddRows = false;
            this.dgv_ItemDetail.AllowUserToDeleteRows = false;
            this.dgv_ItemDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ItemDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(232)))));
            this.dgv_ItemDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ItemDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceNo,
            this.ID,
            this.MetalType,
            this.ItemType,
            this.GrossWt,
            this.ReduceWt,
            this.FinalWt,
            this.FinalWtInPer,
            this.FineWt,
            this.Quantity,
            this.CurrentPrice,
            this.TotalAmount});
            this.dgv_ItemDetail.Location = new System.Drawing.Point(3, 44);
            this.dgv_ItemDetail.Name = "dgv_ItemDetail";
            this.dgv_ItemDetail.ReadOnly = true;
            this.dgv_ItemDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ItemDetail.Size = new System.Drawing.Size(803, 145);
            this.dgv_ItemDetail.TabIndex = 77;
            this.dgv_ItemDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ItemDetail_CellClick);
            this.dgv_ItemDetail.Enter += new System.EventHandler(this.dgv_ItemDetail_Enter);
            // 
            // InvoiceNo
            // 
            this.InvoiceNo.HeaderText = "Invoice No";
            this.InvoiceNo.Name = "InvoiceNo";
            this.InvoiceNo.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // MetalType
            // 
            this.MetalType.HeaderText = "Metal Type";
            this.MetalType.Name = "MetalType";
            this.MetalType.ReadOnly = true;
            // 
            // ItemType
            // 
            this.ItemType.HeaderText = "Item Type";
            this.ItemType.Name = "ItemType";
            this.ItemType.ReadOnly = true;
            // 
            // GrossWt
            // 
            this.GrossWt.HeaderText = "Gross Wt";
            this.GrossWt.Name = "GrossWt";
            this.GrossWt.ReadOnly = true;
            // 
            // ReduceWt
            // 
            this.ReduceWt.HeaderText = "Reduce Wt";
            this.ReduceWt.Name = "ReduceWt";
            this.ReduceWt.ReadOnly = true;
            // 
            // FinalWt
            // 
            this.FinalWt.HeaderText = "FinalWt";
            this.FinalWt.Name = "FinalWt";
            this.FinalWt.ReadOnly = true;
            // 
            // FinalWtInPer
            // 
            this.FinalWtInPer.HeaderText = "FinalWt InPer";
            this.FinalWtInPer.Name = "FinalWtInPer";
            this.FinalWtInPer.ReadOnly = true;
            // 
            // FineWt
            // 
            this.FineWt.HeaderText = "Fine Wt";
            this.FineWt.Name = "FineWt";
            this.FineWt.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // CurrentPrice
            // 
            this.CurrentPrice.HeaderText = "Current Price";
            this.CurrentPrice.Name = "CurrentPrice";
            this.CurrentPrice.ReadOnly = true;
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "Total Amount";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Bottom.Controls.Add(this.bttn_Update);
            this.pnl_Bottom.Controls.Add(this.bttn_Reset);
            this.pnl_Bottom.Controls.Add(this.bttn_Close);
            this.pnl_Bottom.Controls.Add(this.label1);
            this.pnl_Bottom.Controls.Add(this.dateTimePicker1);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 385);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(806, 38);
            this.pnl_Bottom.TabIndex = 78;
            // 
            // bttn_Update
            // 
            this.bttn_Update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Update.BackgroundImage")));
            this.bttn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Update.FlatAppearance.BorderSize = 0;
            this.bttn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Update.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Update.ForeColor = System.Drawing.Color.White;
            this.bttn_Update.Location = new System.Drawing.Point(539, 5);
            this.bttn_Update.Name = "bttn_Update";
            this.bttn_Update.Size = new System.Drawing.Size(71, 28);
            this.bttn_Update.TabIndex = 373;
            this.bttn_Update.Text = "UPDATE";
            this.bttn_Update.UseVisualStyleBackColor = true;
            this.bttn_Update.Click += new System.EventHandler(this.bttn_Update_Click);
            // 
            // bttn_Reset
            // 
            this.bttn_Reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Reset.BackgroundImage")));
            this.bttn_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Reset.FlatAppearance.BorderSize = 0;
            this.bttn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Reset.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Reset.ForeColor = System.Drawing.Color.White;
            this.bttn_Reset.Location = new System.Drawing.Point(629, 7);
            this.bttn_Reset.Name = "bttn_Reset";
            this.bttn_Reset.Size = new System.Drawing.Size(71, 25);
            this.bttn_Reset.TabIndex = 371;
            this.bttn_Reset.Text = "RESET";
            this.bttn_Reset.UseVisualStyleBackColor = true;
            this.bttn_Reset.Click += new System.EventHandler(this.bttn_Reset_Click);
            // 
            // bttn_Close
            // 
            this.bttn_Close.BackColor = System.Drawing.Color.Transparent;
            this.bttn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Close.BackgroundImage")));
            this.bttn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Close.FlatAppearance.BorderSize = 0;
            this.bttn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Close.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Close.ForeColor = System.Drawing.Color.White;
            this.bttn_Close.Location = new System.Drawing.Point(719, 7);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(71, 25);
            this.bttn_Close.TabIndex = 372;
            this.bttn_Close.Text = "CLOSE";
            this.bttn_Close.UseVisualStyleBackColor = false;
            this.bttn_Close.Click += new System.EventHandler(this.bttn_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(1096, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 360;
            this.label1.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(1140, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 27);
            this.dateTimePicker1.TabIndex = 359;
            // 
            // lblsrno
            // 
            this.lblsrno.AutoSize = true;
            this.lblsrno.Location = new System.Drawing.Point(67, 207);
            this.lblsrno.Name = "lblsrno";
            this.lblsrno.Size = new System.Drawing.Size(41, 13);
            this.lblsrno.TabIndex = 392;
            this.lblsrno.Text = "label10";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 391;
            this.label10.Text = "SrNo";
            // 
            // lbl_TotalAmount
            // 
            this.lbl_TotalAmount.AutoSize = true;
            this.lbl_TotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalAmount.Location = new System.Drawing.Point(239, 356);
            this.lbl_TotalAmount.Name = "lbl_TotalAmount";
            this.lbl_TotalAmount.Size = new System.Drawing.Size(59, 16);
            this.lbl_TotalAmount.TabIndex = 390;
            this.lbl_TotalAmount.Text = "Amount";
            // 
            // lbl_CurrentPrice
            // 
            this.lbl_CurrentPrice.AutoSize = true;
            this.lbl_CurrentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentPrice.Location = new System.Drawing.Point(9, 356);
            this.lbl_CurrentPrice.Name = "lbl_CurrentPrice";
            this.lbl_CurrentPrice.Size = new System.Drawing.Size(94, 16);
            this.lbl_CurrentPrice.TabIndex = 389;
            this.lbl_CurrentPrice.Text = "Current Rate";
            // 
            // lbl_FineWt
            // 
            this.lbl_FineWt.AutoSize = true;
            this.lbl_FineWt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FineWt.Location = new System.Drawing.Point(239, 320);
            this.lbl_FineWt.Name = "lbl_FineWt";
            this.lbl_FineWt.Size = new System.Drawing.Size(60, 16);
            this.lbl_FineWt.TabIndex = 388;
            this.lbl_FineWt.Text = "Fine Wt";
            // 
            // lbl_WtInPercent
            // 
            this.lbl_WtInPercent.AutoSize = true;
            this.lbl_WtInPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WtInPercent.Location = new System.Drawing.Point(11, 321);
            this.lbl_WtInPercent.Name = "lbl_WtInPercent";
            this.lbl_WtInPercent.Size = new System.Drawing.Size(73, 16);
            this.lbl_WtInPercent.TabIndex = 387;
            this.lbl_WtInPercent.Text = "Weight %";
            // 
            // lbl_ReduceWt
            // 
            this.lbl_ReduceWt.AutoSize = true;
            this.lbl_ReduceWt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReduceWt.Location = new System.Drawing.Point(239, 276);
            this.lbl_ReduceWt.Name = "lbl_ReduceWt";
            this.lbl_ReduceWt.Size = new System.Drawing.Size(97, 16);
            this.lbl_ReduceWt.TabIndex = 386;
            this.lbl_ReduceWt.Text = "Reduce Wait";
            // 
            // lbl_MetalType
            // 
            this.lbl_MetalType.AutoSize = true;
            this.lbl_MetalType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MetalType.Location = new System.Drawing.Point(10, 238);
            this.lbl_MetalType.Name = "lbl_MetalType";
            this.lbl_MetalType.Size = new System.Drawing.Size(86, 16);
            this.lbl_MetalType.TabIndex = 385;
            this.lbl_MetalType.Text = "Metal Type";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.BackColor = System.Drawing.Color.White;
            this.txt_Quantity.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantity.Location = new System.Drawing.Point(524, 316);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(108, 23);
            this.txt_Quantity.TabIndex = 380;
            this.txt_Quantity.Text = "1";
            this.txt_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Quantity.Enter += new System.EventHandler(this.dgv_ItemDetail_Enter);
            this.txt_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Quantity_KeyPress);
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.ForeColor = System.Drawing.Color.Black;
            this.lbl_Quantity.Location = new System.Drawing.Point(451, 317);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(69, 19);
            this.lbl_Quantity.TabIndex = 383;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // txt_GrossWt
            // 
            this.txt_GrossWt.BackColor = System.Drawing.Color.White;
            this.txt_GrossWt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GrossWt.Location = new System.Drawing.Point(106, 274);
            this.txt_GrossWt.Name = "txt_GrossWt";
            this.txt_GrossWt.Size = new System.Drawing.Size(100, 23);
            this.txt_GrossWt.TabIndex = 378;
            this.txt_GrossWt.TextChanged += new System.EventHandler(this.txt_GrossWt_TextChanged);
            this.txt_GrossWt.Enter += new System.EventHandler(this.dgv_ItemDetail_Enter);
            this.txt_GrossWt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_GrossWt_KeyPress);
            // 
            // txt_NetWeight
            // 
            this.txt_NetWeight.BackColor = System.Drawing.Color.White;
            this.txt_NetWeight.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NetWeight.Location = new System.Drawing.Point(524, 273);
            this.txt_NetWeight.Name = "txt_NetWeight";
            this.txt_NetWeight.Size = new System.Drawing.Size(108, 23);
            this.txt_NetWeight.TabIndex = 379;
            this.txt_NetWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_NetWeight.Enter += new System.EventHandler(this.dgv_ItemDetail_Enter);
            this.txt_NetWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NetWeight_KeyPress);
            // 
            // lbl_GrossWt
            // 
            this.lbl_GrossWt.AutoSize = true;
            this.lbl_GrossWt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GrossWt.ForeColor = System.Drawing.Color.Black;
            this.lbl_GrossWt.Location = new System.Drawing.Point(10, 279);
            this.lbl_GrossWt.Name = "lbl_GrossWt";
            this.lbl_GrossWt.Size = new System.Drawing.Size(85, 16);
            this.lbl_GrossWt.TabIndex = 382;
            this.lbl_GrossWt.Text = "Gross W.T.";
            // 
            // lbl_NetWt
            // 
            this.lbl_NetWt.AutoSize = true;
            this.lbl_NetWt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NetWt.ForeColor = System.Drawing.Color.Black;
            this.lbl_NetWt.Location = new System.Drawing.Point(448, 276);
            this.lbl_NetWt.Name = "lbl_NetWt";
            this.lbl_NetWt.Size = new System.Drawing.Size(72, 16);
            this.lbl_NetWt.TabIndex = 381;
            this.lbl_NetWt.Text = "Net W.T. ";
            // 
            // lbl_ItemType
            // 
            this.lbl_ItemType.AutoSize = true;
            this.lbl_ItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemType.ForeColor = System.Drawing.Color.Black;
            this.lbl_ItemType.Location = new System.Drawing.Point(242, 236);
            this.lbl_ItemType.Name = "lbl_ItemType";
            this.lbl_ItemType.Size = new System.Drawing.Size(77, 16);
            this.lbl_ItemType.TabIndex = 375;
            this.lbl_ItemType.Text = "ItemType ";
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(342, 355);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(100, 20);
            this.txt_Amount.TabIndex = 373;
            this.txt_Amount.Enter += new System.EventHandler(this.dgv_ItemDetail_Enter);
            this.txt_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Amount_KeyPress);
            // 
            // txt_FineWt
            // 
            this.txt_FineWt.Location = new System.Drawing.Point(342, 319);
            this.txt_FineWt.Name = "txt_FineWt";
            this.txt_FineWt.Size = new System.Drawing.Size(100, 20);
            this.txt_FineWt.TabIndex = 372;
            this.txt_FineWt.Enter += new System.EventHandler(this.dgv_ItemDetail_Enter);
            this.txt_FineWt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_FineWt_KeyDown);
            this.txt_FineWt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_FineWt_KeyPress);
            // 
            // txt_CurrentRate
            // 
            this.txt_CurrentRate.Location = new System.Drawing.Point(106, 355);
            this.txt_CurrentRate.Name = "txt_CurrentRate";
            this.txt_CurrentRate.Size = new System.Drawing.Size(100, 20);
            this.txt_CurrentRate.TabIndex = 371;
            this.txt_CurrentRate.TextChanged += new System.EventHandler(this.txt_CurrentRate_TextChanged);
            this.txt_CurrentRate.Enter += new System.EventHandler(this.dgv_ItemDetail_Enter);
            this.txt_CurrentRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CurrentRate_KeyPress);
            // 
            // txt_WtInPercent
            // 
            this.txt_WtInPercent.Location = new System.Drawing.Point(106, 320);
            this.txt_WtInPercent.Name = "txt_WtInPercent";
            this.txt_WtInPercent.Size = new System.Drawing.Size(100, 20);
            this.txt_WtInPercent.TabIndex = 370;
            this.txt_WtInPercent.TextChanged += new System.EventHandler(this.txt_WtInPercent_TextChanged);
            this.txt_WtInPercent.Enter += new System.EventHandler(this.dgv_ItemDetail_Enter);
            this.txt_WtInPercent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_WtInPercent_KeyDown);
            this.txt_WtInPercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_WtInPercent_KeyPress);
            // 
            // txt_ReduceWt
            // 
            this.txt_ReduceWt.Location = new System.Drawing.Point(342, 274);
            this.txt_ReduceWt.Name = "txt_ReduceWt";
            this.txt_ReduceWt.Size = new System.Drawing.Size(100, 20);
            this.txt_ReduceWt.TabIndex = 374;
            this.txt_ReduceWt.TextChanged += new System.EventHandler(this.txt_ReduceWt_TextChanged);
            this.txt_ReduceWt.Enter += new System.EventHandler(this.dgv_ItemDetail_Enter);
            this.txt_ReduceWt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ReduceWt_KeyPress);
            // 
            // Cmb_MetalType
            // 
            this.Cmb_MetalType.AllowDrop = true;
            this.Cmb_MetalType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_MetalType.DisplayMember = "MetalName";
            this.Cmb_MetalType.Font = new System.Drawing.Font("Mangal", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_MetalType.FormattingEnabled = true;
            this.Cmb_MetalType.Items.AddRange(new object[] {
            "सोना",
            "चांदी"});
            this.Cmb_MetalType.Location = new System.Drawing.Point(106, 235);
            this.Cmb_MetalType.Name = "Cmb_MetalType";
            this.Cmb_MetalType.Size = new System.Drawing.Size(100, 25);
            this.Cmb_MetalType.TabIndex = 393;
            this.Cmb_MetalType.ValueMember = "MetalId";
            this.Cmb_MetalType.Enter += new System.EventHandler(this.txt_ItemType_Enter_1);
            this.Cmb_MetalType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmb_MetalType_KeyPress);
            // 
            // pnl_languageRbts
            // 
            this.pnl_languageRbts.Controls.Add(this.rbt_English);
            this.pnl_languageRbts.Controls.Add(this.rbt_Hindi);
            this.pnl_languageRbts.Controls.Add(this.rbt_Marathi);
            this.pnl_languageRbts.Location = new System.Drawing.Point(551, 201);
            this.pnl_languageRbts.Name = "pnl_languageRbts";
            this.pnl_languageRbts.Size = new System.Drawing.Size(200, 26);
            this.pnl_languageRbts.TabIndex = 394;
            // 
            // rbt_English
            // 
            this.rbt_English.AutoSize = true;
            this.rbt_English.Location = new System.Drawing.Point(12, 3);
            this.rbt_English.Name = "rbt_English";
            this.rbt_English.Size = new System.Drawing.Size(59, 17);
            this.rbt_English.TabIndex = 363;
            this.rbt_English.TabStop = true;
            this.rbt_English.Text = "English";
            this.rbt_English.UseVisualStyleBackColor = true;
            this.rbt_English.Visible = false;
            // 
            // rbt_Hindi
            // 
            this.rbt_Hindi.AutoSize = true;
            this.rbt_Hindi.Location = new System.Drawing.Point(85, 3);
            this.rbt_Hindi.Name = "rbt_Hindi";
            this.rbt_Hindi.Size = new System.Drawing.Size(49, 17);
            this.rbt_Hindi.TabIndex = 364;
            this.rbt_Hindi.TabStop = true;
            this.rbt_Hindi.Text = "Hindi";
            this.rbt_Hindi.UseVisualStyleBackColor = true;
            this.rbt_Hindi.Visible = false;
            // 
            // rbt_Marathi
            // 
            this.rbt_Marathi.AutoSize = true;
            this.rbt_Marathi.Location = new System.Drawing.Point(137, 3);
            this.rbt_Marathi.Name = "rbt_Marathi";
            this.rbt_Marathi.Size = new System.Drawing.Size(60, 17);
            this.rbt_Marathi.TabIndex = 371;
            this.rbt_Marathi.TabStop = true;
            this.rbt_Marathi.Text = "Marathi";
            this.rbt_Marathi.UseVisualStyleBackColor = true;
            this.rbt_Marathi.Visible = false;
            this.rbt_Marathi.CheckedChanged += new System.EventHandler(this.rbt_Marathi_CheckedChanged);
            // 
            // pnl_LanguageOther
            // 
            this.pnl_LanguageOther.Controls.Add(this.rbt_OtherFalse);
            this.pnl_LanguageOther.Controls.Add(this.rbt_OtherTrue);
            this.pnl_LanguageOther.Location = new System.Drawing.Point(563, 230);
            this.pnl_LanguageOther.Name = "pnl_LanguageOther";
            this.pnl_LanguageOther.Size = new System.Drawing.Size(181, 30);
            this.pnl_LanguageOther.TabIndex = 395;
            // 
            // rbt_OtherFalse
            // 
            this.rbt_OtherFalse.AutoSize = true;
            this.rbt_OtherFalse.Location = new System.Drawing.Point(102, 3);
            this.rbt_OtherFalse.Name = "rbt_OtherFalse";
            this.rbt_OtherFalse.Size = new System.Drawing.Size(76, 17);
            this.rbt_OtherFalse.TabIndex = 373;
            this.rbt_OtherFalse.Text = "OtherFalse";
            this.rbt_OtherFalse.UseVisualStyleBackColor = true;
            // 
            // rbt_OtherTrue
            // 
            this.rbt_OtherTrue.AutoSize = true;
            this.rbt_OtherTrue.Location = new System.Drawing.Point(3, 3);
            this.rbt_OtherTrue.Name = "rbt_OtherTrue";
            this.rbt_OtherTrue.Size = new System.Drawing.Size(76, 17);
            this.rbt_OtherTrue.TabIndex = 374;
            this.rbt_OtherTrue.Text = "Other True";
            this.rbt_OtherTrue.UseVisualStyleBackColor = true;
            // 
            // Cmb_ItemType
            // 
            this.Cmb_ItemType.DisplayMember = "item_type";
            this.Cmb_ItemType.Font = new System.Drawing.Font("Mangal", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_ItemType.FormattingEnabled = true;
            this.Cmb_ItemType.Location = new System.Drawing.Point(342, 235);
            this.Cmb_ItemType.Name = "Cmb_ItemType";
            this.Cmb_ItemType.Size = new System.Drawing.Size(188, 25);
            this.Cmb_ItemType.TabIndex = 396;
            this.Cmb_ItemType.ValueMember = "item_type";
            this.Cmb_ItemType.Enter += new System.EventHandler(this.txt_ItemType_Enter_1);
            this.Cmb_ItemType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ItemType_KeyPress);
            // 
            // frm_UpdatedGirviItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(806, 423);
            this.Controls.Add(this.Cmb_ItemType);
            this.Controls.Add(this.pnl_LanguageOther);
            this.Controls.Add(this.pnl_languageRbts);
            this.Controls.Add(this.Cmb_MetalType);
            this.Controls.Add(this.lblsrno);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_TotalAmount);
            this.Controls.Add(this.lbl_CurrentPrice);
            this.Controls.Add(this.lbl_FineWt);
            this.Controls.Add(this.lbl_WtInPercent);
            this.Controls.Add(this.lbl_ReduceWt);
            this.Controls.Add(this.lbl_MetalType);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.txt_GrossWt);
            this.Controls.Add(this.txt_NetWeight);
            this.Controls.Add(this.lbl_GrossWt);
            this.Controls.Add(this.lbl_NetWt);
            this.Controls.Add(this.lbl_ItemType);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.txt_FineWt);
            this.Controls.Add(this.txt_CurrentRate);
            this.Controls.Add(this.txt_WtInPercent);
            this.Controls.Add(this.txt_ReduceWt);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.dgv_ItemDetail);
            this.Controls.Add(this.pnl_Header);
            this.KeyPreview = true;
            this.Name = "frm_UpdatedGirviItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Updated Girvi Item";
            this.Load += new System.EventHandler(this.frm_UpdatedGirviItem_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_UpdatedGirviItem_KeyDown);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemDetail)).EndInit();
            this.pnl_Bottom.ResumeLayout(false);
            this.pnl_Bottom.PerformLayout();
            this.pnl_languageRbts.ResumeLayout(false);
            this.pnl_languageRbts.PerformLayout();
            this.pnl_LanguageOther.ResumeLayout(false);
            this.pnl_LanguageOther.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Date;
        public System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.DataGridView dgv_ItemDetail;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblsrno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_TotalAmount;
        private System.Windows.Forms.Label lbl_CurrentPrice;
        private System.Windows.Forms.Label lbl_FineWt;
        private System.Windows.Forms.Label lbl_WtInPercent;
        private System.Windows.Forms.Label lbl_ReduceWt;
        private System.Windows.Forms.Label lbl_MetalType;
        private System.Windows.Forms.Label lbl_GirviNo;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.TextBox txt_GrossWt;
        private System.Windows.Forms.TextBox txt_NetWeight;
        private System.Windows.Forms.Label lbl_GrossWt;
        private System.Windows.Forms.Label lbl_NetWt;
        private System.Windows.Forms.Label lbl_ItemType;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.TextBox txt_FineWt;
        private System.Windows.Forms.TextBox txt_CurrentRate;
        private System.Windows.Forms.TextBox txt_WtInPercent;
        private System.Windows.Forms.TextBox txt_ReduceWt;
        private System.Windows.Forms.TextBox txt_GirviNo;
        private System.Windows.Forms.Button bttn_Reset;
        private System.Windows.Forms.Button bttn_Close;
        private System.Windows.Forms.Button bttn_Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MetalType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrossWt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReduceWt;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalWt;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalWtInPer;
        private System.Windows.Forms.DataGridViewTextBoxColumn FineWt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.ComboBox Cmb_MetalType;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Panel pnl_languageRbts;
        public System.Windows.Forms.RadioButton rbt_English;
        public System.Windows.Forms.RadioButton rbt_Hindi;
        public System.Windows.Forms.RadioButton rbt_Marathi;
        private System.Windows.Forms.Panel pnl_LanguageOther;
        public System.Windows.Forms.RadioButton rbt_OtherFalse;
        public System.Windows.Forms.RadioButton rbt_OtherTrue;
        private System.Windows.Forms.ComboBox Cmb_ItemType;
    }
}