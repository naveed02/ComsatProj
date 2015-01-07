﻿namespace GUI_Task
{
    partial class frmPurchaseOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseOrder));
            this.txtDNNo = new System.Windows.Forms.TextBox();
            this.cboEmpCode = new System.Windows.Forms.ComboBox();
            this.dtpDN = new System.Windows.Forms.DateTimePicker();
            this.lblDateBottom = new System.Windows.Forms.Label();
            this.dtpPO = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.mskPurchaseCode = new System.Windows.Forms.MaskedTextBox();
            this.mskVenderCode = new System.Windows.Forms.MaskedTextBox();
            this.cboItemGroup = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameDataUp = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnHelp3 = new System.Windows.Forms.Button();
            this.btnHelp2 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grd = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColorColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.UnitColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblPurchaseOrder = new System.Windows.Forms.Label();
            this.lblDemandNote = new System.Windows.Forms.Label();
            this.lblEmpCode = new System.Windows.Forms.Label();
            this.blVenderCode = new System.Windows.Forms.Label();
            this.lblPurchaseCode = new System.Windows.Forms.Label();
            this.lblItemGroup = new System.Windows.Forms.Label();
            this.listBox21 = new System.Windows.Forms.ListBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.lst = new System.Windows.Forms.ListBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblNameBottom = new System.Windows.Forms.Label();
            this.lblNameUp = new System.Windows.Forms.Label();
            this.btnHelp4 = new System.Windows.Forms.Button();
            this.txtPONo = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDNQty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPOQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemQty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbo_I_UOM = new System.Windows.Forms.ComboBox();
            this.cbo_I_Color = new System.Windows.Forms.ComboBox();
            this.cbo_I_Size = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_I_ItemName = new System.Windows.Forms.Label();
            this.lbl_I_ItemCode = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_I_ItemID = new System.Windows.Forms.TextBox();
            this.sSMaster = new System.Windows.Forms.StatusStrip();
            this.tSlblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tStextUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSlblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tStextStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSlblTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.tStextTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSlblAlert = new System.Windows.Forms.ToolStripStatusLabel();
            this.textAlert = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.sSMaster.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDNNo
            // 
            this.txtDNNo.Location = new System.Drawing.Point(121, 29);
            this.txtDNNo.Name = "txtDNNo";
            this.txtDNNo.Size = new System.Drawing.Size(158, 20);
            this.txtDNNo.TabIndex = 128;
            this.txtDNNo.DoubleClick += new System.EventHandler(this.txtDemandNote_DoubleClick);
            this.txtDNNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDNNo_KeyDown);
            // 
            // cboEmpCode
            // 
            this.cboEmpCode.FormattingEnabled = true;
            this.cboEmpCode.Location = new System.Drawing.Point(121, 53);
            this.cboEmpCode.Name = "cboEmpCode";
            this.cboEmpCode.Size = new System.Drawing.Size(265, 21);
            this.cboEmpCode.TabIndex = 129;
            // 
            // dtpDN
            // 
            this.dtpDN.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDN.Location = new System.Drawing.Point(398, 31);
            this.dtpDN.Name = "dtpDN";
            this.dtpDN.Size = new System.Drawing.Size(122, 21);
            this.dtpDN.TabIndex = 131;
            // 
            // lblDateBottom
            // 
            this.lblDateBottom.AllowDrop = true;
            this.lblDateBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDateBottom.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateBottom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDateBottom.Location = new System.Drawing.Point(301, 34);
            this.lblDateBottom.Name = "lblDateBottom";
            this.lblDateBottom.Size = new System.Drawing.Size(82, 17);
            this.lblDateBottom.TabIndex = 130;
            this.lblDateBottom.Text = " Date";
            this.lblDateBottom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpPO
            // 
            this.dtpPO.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPO.Location = new System.Drawing.Point(398, 9);
            this.dtpPO.Name = "dtpPO";
            this.dtpPO.Size = new System.Drawing.Size(122, 21);
            this.dtpPO.TabIndex = 133;
            // 
            // lblDate
            // 
            this.lblDate.AllowDrop = true;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDate.Location = new System.Drawing.Point(301, 10);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(82, 17);
            this.lblDate.TabIndex = 132;
            this.lblDate.Text = " Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mskPurchaseCode
            // 
            this.mskPurchaseCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPurchaseCode.Location = new System.Drawing.Point(121, 102);
            this.mskPurchaseCode.Mask = "0-0-00-00-0000";
            this.mskPurchaseCode.Name = "mskPurchaseCode";
            this.mskPurchaseCode.Size = new System.Drawing.Size(150, 22);
            this.mskPurchaseCode.TabIndex = 134;
            this.mskPurchaseCode.DoubleClick += new System.EventHandler(this.mskPurchaseCode_DoubleClick);
            this.mskPurchaseCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskPurchaseCode_KeyDown);
            // 
            // mskVenderCode
            // 
            this.mskVenderCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskVenderCode.Location = new System.Drawing.Point(121, 77);
            this.mskVenderCode.Mask = "0-0-00-00-0000";
            this.mskVenderCode.Name = "mskVenderCode";
            this.mskVenderCode.Size = new System.Drawing.Size(150, 22);
            this.mskVenderCode.TabIndex = 135;
            this.mskVenderCode.DoubleClick += new System.EventHandler(this.mskVenderCode_DoubleClick);
            this.mskVenderCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskVenderCode_KeyDown);
            // 
            // cboItemGroup
            // 
            this.cboItemGroup.FormattingEnabled = true;
            this.cboItemGroup.Items.AddRange(new object[] {
            "Buckle",
            "Chemical PU",
            "Eva Shoes",
            "General ",
            "Leather And Rexine",
            "PCU Shoes",
            "PPC Patawa Cutting"});
            this.cboItemGroup.Location = new System.Drawing.Point(121, 127);
            this.cboItemGroup.Name = "cboItemGroup";
            this.cboItemGroup.Size = new System.Drawing.Size(327, 21);
            this.cboItemGroup.TabIndex = 136;
            this.cboItemGroup.Text = "-";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AllowDrop = true;
            this.lblDepartment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDepartment.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDepartment.Location = new System.Drawing.Point(2, 151);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(114, 17);
            this.lblDepartment.TabIndex = 114;
            this.lblDepartment.Text = "Department  ";
            this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(122, 150);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(327, 20);
            this.txtDepartment.TabIndex = 138;
            // 
            // lblName
            // 
            this.lblName.AllowDrop = true;
            this.lblName.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(389, 107);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(367, 17);
            this.lblName.TabIndex = 141;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNameDataUp
            // 
            this.lblNameDataUp.AllowDrop = true;
            this.lblNameDataUp.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblNameDataUp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNameDataUp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameDataUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNameDataUp.Location = new System.Drawing.Point(392, 80);
            this.lblNameDataUp.Name = "lblNameDataUp";
            this.lblNameDataUp.Size = new System.Drawing.Size(367, 17);
            this.lblNameDataUp.TabIndex = 142;
            this.lblNameDataUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(535, 5);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(78, 22);
            this.btnHelp.TabIndex = 118;
            this.btnHelp.Text = "F1=Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnHelp3
            // 
            this.btnHelp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp3.Location = new System.Drawing.Point(762, 104);
            this.btnHelp3.Name = "btnHelp3";
            this.btnHelp3.Size = new System.Drawing.Size(78, 22);
            this.btnHelp3.TabIndex = 144;
            this.btnHelp3.Text = "F1=Help";
            this.btnHelp3.UseVisualStyleBackColor = true;
            this.btnHelp3.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHelp2
            // 
            this.btnHelp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp2.Location = new System.Drawing.Point(535, 29);
            this.btnHelp2.Name = "btnHelp2";
            this.btnHelp2.Size = new System.Drawing.Size(78, 22);
            this.btnHelp2.TabIndex = 145;
            this.btnHelp2.Text = "F1=Help";
            this.btnHelp2.UseVisualStyleBackColor = true;
            this.btnHelp2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(407, 54);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 25);
            this.btnAdd.TabIndex = 146;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // grd
            // 
            this.grd.AllowUserToOrderColumns = true;
            this.grd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.SizeColumn,
            this.ColorColumn,
            this.UnitColumn,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            this.grd.Location = new System.Drawing.Point(-1, 3);
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(931, 184);
            this.grd.TabIndex = 147;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Code";
            this.Column1.Name = "Column1";
            this.Column1.Width = 57;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Item Code";
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Name";
            this.Column3.Name = "Column3";
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Description ";
            this.Column4.Name = "Column4";
            this.Column4.Width = 88;
            // 
            // SizeColumn
            // 
            this.SizeColumn.Frozen = true;
            this.SizeColumn.HeaderText = "Size";
            this.SizeColumn.Name = "SizeColumn";
            this.SizeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SizeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SizeColumn.Width = 52;
            // 
            // ColorColumn
            // 
            this.ColorColumn.Frozen = true;
            this.ColorColumn.HeaderText = "Colour ";
            this.ColorColumn.Name = "ColorColumn";
            this.ColorColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColorColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColorColumn.Width = 65;
            // 
            // UnitColumn
            // 
            this.UnitColumn.Frozen = true;
            this.UnitColumn.HeaderText = "UOM";
            this.UnitColumn.Name = "UnitColumn";
            this.UnitColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UnitColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.UnitColumn.Width = 57;
            // 
            // Column8
            // 
            this.Column8.Frozen = true;
            this.Column8.HeaderText = "Stock";
            this.Column8.Name = "Column8";
            this.Column8.Width = 60;
            // 
            // Column9
            // 
            this.Column9.Frozen = true;
            this.Column9.HeaderText = "DN Qty";
            this.Column9.Name = "Column9";
            this.Column9.Width = 67;
            // 
            // Column10
            // 
            this.Column10.Frozen = true;
            this.Column10.HeaderText = "PO Qty";
            this.Column10.Name = "Column10";
            this.Column10.Width = 66;
            // 
            // Column11
            // 
            this.Column11.Frozen = true;
            this.Column11.HeaderText = "Remaining Qty";
            this.Column11.Name = "Column11";
            this.Column11.Width = 101;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Last Rate";
            this.Column12.Name = "Column12";
            this.Column12.Width = 78;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Amount";
            this.Column13.Name = "Column13";
            this.Column13.Width = 68;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(4, 398);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 27);
            this.btnSave.TabIndex = 149;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(92, 428);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(327, 20);
            this.txtNote.TabIndex = 151;
            // 
            // lblNote
            // 
            this.lblNote.AllowDrop = true;
            this.lblNote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNote.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNote.Location = new System.Drawing.Point(4, 431);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(82, 17);
            this.lblNote.TabIndex = 152;
            this.lblNote.Text = "Note ";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPurchaseOrder
            // 
            this.lblPurchaseOrder.AllowDrop = true;
            this.lblPurchaseOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPurchaseOrder.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPurchaseOrder.Location = new System.Drawing.Point(0, 8);
            this.lblPurchaseOrder.Name = "lblPurchaseOrder";
            this.lblPurchaseOrder.Size = new System.Drawing.Size(114, 17);
            this.lblPurchaseOrder.TabIndex = 153;
            this.lblPurchaseOrder.Text = "Purchase Order #";
            this.lblPurchaseOrder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDemandNote
            // 
            this.lblDemandNote.AllowDrop = true;
            this.lblDemandNote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDemandNote.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemandNote.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDemandNote.Location = new System.Drawing.Point(0, 31);
            this.lblDemandNote.Name = "lblDemandNote";
            this.lblDemandNote.Size = new System.Drawing.Size(114, 17);
            this.lblDemandNote.TabIndex = 154;
            this.lblDemandNote.Text = "Demand Note #";
            this.lblDemandNote.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEmpCode
            // 
            this.lblEmpCode.AllowDrop = true;
            this.lblEmpCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmpCode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEmpCode.Location = new System.Drawing.Point(0, 52);
            this.lblEmpCode.Name = "lblEmpCode";
            this.lblEmpCode.Size = new System.Drawing.Size(114, 17);
            this.lblEmpCode.TabIndex = 155;
            this.lblEmpCode.Text = "Emp Code";
            this.lblEmpCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // blVenderCode
            // 
            this.blVenderCode.AllowDrop = true;
            this.blVenderCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.blVenderCode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blVenderCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.blVenderCode.Location = new System.Drawing.Point(1, 77);
            this.blVenderCode.Name = "blVenderCode";
            this.blVenderCode.Size = new System.Drawing.Size(114, 17);
            this.blVenderCode.TabIndex = 156;
            this.blVenderCode.Text = "Vender Code";
            this.blVenderCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPurchaseCode
            // 
            this.lblPurchaseCode.AllowDrop = true;
            this.lblPurchaseCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPurchaseCode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPurchaseCode.Location = new System.Drawing.Point(1, 102);
            this.lblPurchaseCode.Name = "lblPurchaseCode";
            this.lblPurchaseCode.Size = new System.Drawing.Size(115, 17);
            this.lblPurchaseCode.TabIndex = 157;
            this.lblPurchaseCode.Text = "Purchase code";
            this.lblPurchaseCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblItemGroup
            // 
            this.lblItemGroup.AllowDrop = true;
            this.lblItemGroup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblItemGroup.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemGroup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblItemGroup.Location = new System.Drawing.Point(2, 128);
            this.lblItemGroup.Name = "lblItemGroup";
            this.lblItemGroup.Size = new System.Drawing.Size(114, 17);
            this.lblItemGroup.TabIndex = 158;
            this.lblItemGroup.Text = "Item Group";
            this.lblItemGroup.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBox21
            // 
            this.listBox21.BackColor = System.Drawing.Color.NavajoWhite;
            this.listBox21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listBox21.FormattingEnabled = true;
            this.listBox21.Location = new System.Drawing.Point(798, 402);
            this.listBox21.Name = "listBox21";
            this.listBox21.Size = new System.Drawing.Size(144, 17);
            this.listBox21.TabIndex = 166;
            // 
            // lblValue
            // 
            this.lblValue.AllowDrop = true;
            this.lblValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValue.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblValue.Location = new System.Drawing.Point(727, 402);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(65, 17);
            this.lblValue.TabIndex = 165;
            this.lblValue.Text = "Value";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lst
            // 
            this.lst.BackColor = System.Drawing.Color.NavajoWhite;
            this.lst.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lst.FormattingEnabled = true;
            this.lst.Location = new System.Drawing.Point(557, 402);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(160, 17);
            this.lst.TabIndex = 164;
            // 
            // lblQty
            // 
            this.lblQty.AllowDrop = true;
            this.lblQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQty.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblQty.Location = new System.Drawing.Point(458, 401);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(93, 17);
            this.lblQty.TabIndex = 163;
            this.lblQty.Text = "Qty";
            this.lblQty.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNameBottom
            // 
            this.lblNameBottom.AllowDrop = true;
            this.lblNameBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNameBottom.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameBottom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNameBottom.Location = new System.Drawing.Point(272, 107);
            this.lblNameBottom.Name = "lblNameBottom";
            this.lblNameBottom.Size = new System.Drawing.Size(114, 17);
            this.lblNameBottom.TabIndex = 167;
            this.lblNameBottom.Text = "Name";
            this.lblNameBottom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNameUp
            // 
            this.lblNameUp.AllowDrop = true;
            this.lblNameUp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNameUp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNameUp.Location = new System.Drawing.Point(272, 77);
            this.lblNameUp.Name = "lblNameUp";
            this.lblNameUp.Size = new System.Drawing.Size(114, 17);
            this.lblNameUp.TabIndex = 168;
            this.lblNameUp.Text = "Name";
            this.lblNameUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnHelp4
            // 
            this.btnHelp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp4.Location = new System.Drawing.Point(762, 77);
            this.btnHelp4.Name = "btnHelp4";
            this.btnHelp4.Size = new System.Drawing.Size(78, 22);
            this.btnHelp4.TabIndex = 171;
            this.btnHelp4.Text = "F1=Help";
            this.btnHelp4.UseVisualStyleBackColor = true;
            this.btnHelp4.Click += new System.EventHandler(this.button7_Click);
            // 
            // txtPONo
            // 
            this.txtPONo.Location = new System.Drawing.Point(120, 7);
            this.txtPONo.Name = "txtPONo";
            this.txtPONo.Size = new System.Drawing.Size(158, 20);
            this.txtPONo.TabIndex = 172;
            this.txtPONo.DoubleClick += new System.EventHandler(this.txtPONo_DoubleClick);
            this.txtPONo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPONo_KeyDown);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(4, 176);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(941, 216);
            this.tabControl1.TabIndex = 173;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grd);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(933, 190);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Grid View";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(933, 190);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add New";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDNQty);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPOQty);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtRemQty);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtLastRate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cbo_I_UOM);
            this.groupBox1.Controls.Add(this.cbo_I_Color);
            this.groupBox1.Controls.Add(this.cbo_I_Size);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lbl_I_ItemName);
            this.groupBox1.Controls.Add(this.lbl_I_ItemCode);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txt_I_ItemID);
            this.groupBox1.Location = new System.Drawing.Point(18, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(908, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Entry";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(100, 134);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(198, 21);
            this.txtAmount.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 55;
            this.label1.Text = "Amount";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDNQty
            // 
            this.txtDNQty.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNQty.Location = new System.Drawing.Point(99, 76);
            this.txtDNQty.Name = "txtDNQty";
            this.txtDNQty.Size = new System.Drawing.Size(199, 21);
            this.txtDNQty.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(12, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 21);
            this.label6.TabIndex = 53;
            this.label6.Text = "DN Qty";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPOQty
            // 
            this.txtPOQty.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPOQty.Location = new System.Drawing.Point(412, 76);
            this.txtPOQty.Name = "txtPOQty";
            this.txtPOQty.Size = new System.Drawing.Size(124, 21);
            this.txtPOQty.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(311, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 51;
            this.label5.Text = "PO Qty";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtRemQty
            // 
            this.txtRemQty.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemQty.Location = new System.Drawing.Point(127, 108);
            this.txtRemQty.Name = "txtRemQty";
            this.txtRemQty.Size = new System.Drawing.Size(171, 21);
            this.txtRemQty.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 49;
            this.label3.Text = "Remaining Qty";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtLastRate
            // 
            this.txtLastRate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastRate.Location = new System.Drawing.Point(412, 106);
            this.txtLastRate.Name = "txtLastRate";
            this.txtLastRate.Size = new System.Drawing.Size(124, 21);
            this.txtLastRate.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(311, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 47;
            this.label2.Text = "Last Rate";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::GUI_Task.Properties.Resources.image12;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(658, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 21);
            this.button1.TabIndex = 43;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(335, 44);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(199, 21);
            this.txtStock.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AllowDrop = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(246, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 21);
            this.label13.TabIndex = 40;
            this.label13.Text = "Stock";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbo_I_UOM
            // 
            this.cbo_I_UOM.FormattingEnabled = true;
            this.cbo_I_UOM.Items.AddRange(new object[] {
            ""});
            this.cbo_I_UOM.Location = new System.Drawing.Point(99, 46);
            this.cbo_I_UOM.Name = "cbo_I_UOM";
            this.cbo_I_UOM.Size = new System.Drawing.Size(124, 21);
            this.cbo_I_UOM.TabIndex = 35;
            // 
            // cbo_I_Color
            // 
            this.cbo_I_Color.FormattingEnabled = true;
            this.cbo_I_Color.Items.AddRange(new object[] {
            ""});
            this.cbo_I_Color.Location = new System.Drawing.Point(755, 16);
            this.cbo_I_Color.Name = "cbo_I_Color";
            this.cbo_I_Color.Size = new System.Drawing.Size(108, 21);
            this.cbo_I_Color.TabIndex = 32;
            // 
            // cbo_I_Size
            // 
            this.cbo_I_Size.FormattingEnabled = true;
            this.cbo_I_Size.Items.AddRange(new object[] {
            ""});
            this.cbo_I_Size.Location = new System.Drawing.Point(566, 16);
            this.cbo_I_Size.Name = "cbo_I_Size";
            this.cbo_I_Size.Size = new System.Drawing.Size(130, 21);
            this.cbo_I_Size.TabIndex = 30;
            // 
            // label29
            // 
            this.label29.AllowDrop = true;
            this.label29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label29.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label29.Location = new System.Drawing.Point(511, 16);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(49, 21);
            this.label29.TabIndex = 31;
            this.label29.Text = "Size";
            this.label29.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AllowDrop = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(702, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 21);
            this.label11.TabIndex = 34;
            this.label11.Text = "Color";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AllowDrop = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(10, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 21);
            this.label12.TabIndex = 37;
            this.label12.Text = "UOM";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_I_ItemName
            // 
            this.lbl_I_ItemName.AllowDrop = true;
            this.lbl_I_ItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_I_ItemName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_I_ItemName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_I_ItemName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_I_ItemName.Location = new System.Drawing.Point(287, 16);
            this.lbl_I_ItemName.Name = "lbl_I_ItemName";
            this.lbl_I_ItemName.Size = new System.Drawing.Size(218, 21);
            this.lbl_I_ItemName.TabIndex = 29;
            this.lbl_I_ItemName.Text = "Item Name";
            this.lbl_I_ItemName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_I_ItemCode
            // 
            this.lbl_I_ItemCode.AllowDrop = true;
            this.lbl_I_ItemCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_I_ItemCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_I_ItemCode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_I_ItemCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_I_ItemCode.Location = new System.Drawing.Point(181, 16);
            this.lbl_I_ItemCode.Name = "lbl_I_ItemCode";
            this.lbl_I_ItemCode.Size = new System.Drawing.Size(100, 21);
            this.lbl_I_ItemCode.TabIndex = 28;
            this.lbl_I_ItemCode.Text = "Item Code";
            this.lbl_I_ItemCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.AllowDrop = true;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(10, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 21);
            this.label14.TabIndex = 26;
            this.label14.Text = "Item ID";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_I_ItemID
            // 
            this.txt_I_ItemID.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_I_ItemID.Location = new System.Drawing.Point(99, 16);
            this.txt_I_ItemID.Name = "txt_I_ItemID";
            this.txt_I_ItemID.Size = new System.Drawing.Size(76, 21);
            this.txt_I_ItemID.TabIndex = 1;
            this.txt_I_ItemID.Text = "1";
            this.txt_I_ItemID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_I_ItemID_KeyDown);
            this.txt_I_ItemID.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txt_I_ItemID_MouseDoubleClick);
            // 
            // sSMaster
            // 
            this.sSMaster.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSlblUser,
            this.tStextUser,
            this.tSlblStatus,
            this.tStextStatus,
            this.tSlblTotal,
            this.tStextTotal,
            this.tSlblAlert,
            this.textAlert});
            this.sSMaster.Location = new System.Drawing.Point(0, 464);
            this.sSMaster.Name = "sSMaster";
            this.sSMaster.Size = new System.Drawing.Size(946, 22);
            this.sSMaster.TabIndex = 611;
            this.sSMaster.Text = "statusStrip1";
            // 
            // tSlblUser
            // 
            this.tSlblUser.Name = "tSlblUser";
            this.tSlblUser.Size = new System.Drawing.Size(33, 17);
            this.tSlblUser.Text = "User:";
            // 
            // tStextUser
            // 
            this.tStextUser.AutoSize = false;
            this.tStextUser.Name = "tStextUser";
            this.tStextUser.Size = new System.Drawing.Size(70, 17);
            this.tStextUser.Text = "User...";
            this.tStextUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tSlblStatus
            // 
            this.tSlblStatus.Name = "tSlblStatus";
            this.tSlblStatus.Size = new System.Drawing.Size(42, 17);
            this.tSlblStatus.Text = "Status:";
            this.tSlblStatus.ToolTipText = "Status of this form: Read = Ready to Accept ID, New = ID is new, Modify = Updatin" +
                "g/Modifying an existing ID\' s data";
            // 
            // tStextStatus
            // 
            this.tStextStatus.AutoSize = false;
            this.tStextStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tStextStatus.ForeColor = System.Drawing.Color.Teal;
            this.tStextStatus.Name = "tStextStatus";
            this.tStextStatus.Size = new System.Drawing.Size(75, 17);
            this.tStextStatus.Text = "Ready";
            this.tStextStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tSlblTotal
            // 
            this.tSlblTotal.Name = "tSlblTotal";
            this.tSlblTotal.Size = new System.Drawing.Size(40, 17);
            this.tSlblTotal.Text = "Total :";
            this.tSlblTotal.ToolTipText = "Total Number of Records already saved";
            // 
            // tStextTotal
            // 
            this.tStextTotal.AutoSize = false;
            this.tStextTotal.ForeColor = System.Drawing.Color.Teal;
            this.tStextTotal.Name = "tStextTotal";
            this.tStextTotal.Size = new System.Drawing.Size(50, 17);
            this.tStextTotal.Text = "0";
            this.tStextTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tSlblAlert
            // 
            this.tSlblAlert.AutoSize = false;
            this.tSlblAlert.Name = "tSlblAlert";
            this.tSlblAlert.Size = new System.Drawing.Size(40, 17);
            this.tSlblAlert.Text = "Alert :";
            this.tSlblAlert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textAlert
            // 
            this.textAlert.AutoSize = false;
            this.textAlert.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAlert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.textAlert.Name = "textAlert";
            this.textAlert.Size = new System.Drawing.Size(500, 17);
            this.textAlert.Text = "Ready";
            this.textAlert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 486);
            this.Controls.Add(this.sSMaster);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtPONo);
            this.Controls.Add(this.btnHelp4);
            this.Controls.Add(this.lblNameUp);
            this.Controls.Add(this.lblNameBottom);
            this.Controls.Add(this.listBox21);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lst);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblItemGroup);
            this.Controls.Add(this.lblPurchaseCode);
            this.Controls.Add(this.blVenderCode);
            this.Controls.Add(this.lblEmpCode);
            this.Controls.Add(this.lblDemandNote);
            this.Controls.Add(this.lblPurchaseOrder);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnHelp2);
            this.Controls.Add(this.btnHelp3);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblNameDataUp);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.cboItemGroup);
            this.Controls.Add(this.mskVenderCode);
            this.Controls.Add(this.mskPurchaseCode);
            this.Controls.Add(this.dtpPO);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDN);
            this.Controls.Add(this.lblDateBottom);
            this.Controls.Add(this.cboEmpCode);
            this.Controls.Add(this.txtDNNo);
            this.Controls.Add(this.lblDepartment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmPurchaseOrder";
            this.Text = "Purchase Order";
            this.Load += new System.EventHandler(this.Purchase_Order_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPurchaseOrder_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.sSMaster.ResumeLayout(false);
            this.sSMaster.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDNNo;
        private System.Windows.Forms.ComboBox cboEmpCode;
        private System.Windows.Forms.DateTimePicker dtpDN;
        private System.Windows.Forms.Label lblDateBottom;
        private System.Windows.Forms.DateTimePicker dtpPO;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.MaskedTextBox mskPurchaseCode;
        private System.Windows.Forms.MaskedTextBox mskVenderCode;
        private System.Windows.Forms.ComboBox cboItemGroup;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNameDataUp;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnHelp3;
        private System.Windows.Forms.Button btnHelp2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblPurchaseOrder;
        private System.Windows.Forms.Label lblDemandNote;
        private System.Windows.Forms.Label lblEmpCode;
        private System.Windows.Forms.Label blVenderCode;
        private System.Windows.Forms.Label lblPurchaseCode;
        private System.Windows.Forms.Label lblItemGroup;
        private System.Windows.Forms.ListBox listBox21;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblNameBottom;
        private System.Windows.Forms.Label lblNameUp;
        private System.Windows.Forms.Button btnHelp4;
        private System.Windows.Forms.TextBox txtPONo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbo_I_UOM;
        private System.Windows.Forms.ComboBox cbo_I_Color;
        private System.Windows.Forms.ComboBox cbo_I_Size;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_I_ItemName;
        private System.Windows.Forms.Label lbl_I_ItemCode;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_I_ItemID;
        private System.Windows.Forms.TextBox txtDNQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPOQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRemQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewComboBoxColumn SizeColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColorColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn UnitColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.StatusStrip sSMaster;
        private System.Windows.Forms.ToolStripStatusLabel tSlblUser;
        private System.Windows.Forms.ToolStripStatusLabel tStextUser;
        private System.Windows.Forms.ToolStripStatusLabel tSlblStatus;
        private System.Windows.Forms.ToolStripStatusLabel tStextStatus;
        private System.Windows.Forms.ToolStripStatusLabel tSlblTotal;
        private System.Windows.Forms.ToolStripStatusLabel tStextTotal;
        private System.Windows.Forms.ToolStripStatusLabel tSlblAlert;
        private System.Windows.Forms.ToolStripStatusLabel textAlert;
    }
}