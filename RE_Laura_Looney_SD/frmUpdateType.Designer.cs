namespace RE_Laura_Looney_SD
{
    partial class frmUpdateType
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
            this.mnuOrderMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStockmnu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubtnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpStockType = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnUpdateStockType = new System.Windows.Forms.Button();
            this.cboDescription = new System.Windows.Forms.TextBox();
            this.cboTypeCode = new System.Windows.Forms.TextBox();
            this.lblUpdateStockType = new System.Windows.Forms.Label();
            this.DGVStockType = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboSearch = new System.Windows.Forms.TextBox();
            this.lblStock_List = new System.Windows.Forms.Label();
            this.TypeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuOrderMenu.SuspendLayout();
            this.grpStockType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStockType)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuOrderMenu
            // 
            this.mnuOrderMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuOrderMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.mnuStockmnu,
            this.mnubtnExit});
            this.mnuOrderMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuOrderMenu.Name = "mnuOrderMenu";
            this.mnuOrderMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuOrderMenu.Size = new System.Drawing.Size(800, 24);
            this.mnuOrderMenu.TabIndex = 49;
            this.mnuOrderMenu.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(80, 20);
            this.toolStripMenuItem1.Text = "Main Menu";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // mnuStockmnu
            // 
            this.mnuStockmnu.Name = "mnuStockmnu";
            this.mnuStockmnu.Size = new System.Drawing.Size(82, 20);
            this.mnuStockmnu.Text = "Stock Menu";
            this.mnuStockmnu.Click += new System.EventHandler(this.mnuStockmnu_Click);
            // 
            // mnubtnExit
            // 
            this.mnubtnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnubtnExit.Name = "mnubtnExit";
            this.mnubtnExit.Size = new System.Drawing.Size(38, 20);
            this.mnubtnExit.Text = "Exit";
            this.mnubtnExit.Click += new System.EventHandler(this.mnubtnExit_Click);
            // 
            // grpStockType
            // 
            this.grpStockType.Controls.Add(this.lblStatus);
            this.grpStockType.Controls.Add(this.cboStatus);
            this.grpStockType.Controls.Add(this.lblName);
            this.grpStockType.Controls.Add(this.lblDescription);
            this.grpStockType.Controls.Add(this.btnUpdateStockType);
            this.grpStockType.Controls.Add(this.cboDescription);
            this.grpStockType.Controls.Add(this.cboTypeCode);
            this.grpStockType.Location = new System.Drawing.Point(433, 176);
            this.grpStockType.Name = "grpStockType";
            this.grpStockType.Size = new System.Drawing.Size(322, 198);
            this.grpStockType.TabIndex = 48;
            this.grpStockType.TabStop = false;
            this.grpStockType.Text = "Enter Stock Type Details";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblStatus.Location = new System.Drawing.Point(45, 97);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 15);
            this.lblStatus.TabIndex = 39;
            this.lblStatus.Text = "Status:";
            // 
            // cboStatus
            // 
            this.cboStatus.Location = new System.Drawing.Point(153, 99);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cboStatus.MaxLength = 3;
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(48, 20);
            this.cboStatus.TabIndex = 38;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblName.Location = new System.Drawing.Point(47, 45);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 15);
            this.lblName.TabIndex = 30;
            this.lblName.Text = "Type Code:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(45, 71);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(72, 15);
            this.lblDescription.TabIndex = 31;
            this.lblDescription.Text = "Description:";
            // 
            // btnUpdateStockType
            // 
            this.btnUpdateStockType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpdateStockType.Location = new System.Drawing.Point(90, 152);
            this.btnUpdateStockType.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateStockType.Name = "btnUpdateStockType";
            this.btnUpdateStockType.Size = new System.Drawing.Size(134, 26);
            this.btnUpdateStockType.TabIndex = 8;
            this.btnUpdateStockType.Text = "Update Stock Type";
            this.btnUpdateStockType.UseVisualStyleBackColor = true;
            this.btnUpdateStockType.Click += new System.EventHandler(this.btnUpdateStockType_Click);
            // 
            // cboDescription
            // 
            this.cboDescription.Location = new System.Drawing.Point(153, 71);
            this.cboDescription.Margin = new System.Windows.Forms.Padding(2);
            this.cboDescription.MaxLength = 20;
            this.cboDescription.Name = "cboDescription";
            this.cboDescription.Size = new System.Drawing.Size(120, 20);
            this.cboDescription.TabIndex = 2;
            // 
            // cboTypeCode
            // 
            this.cboTypeCode.Location = new System.Drawing.Point(153, 40);
            this.cboTypeCode.Margin = new System.Windows.Forms.Padding(2);
            this.cboTypeCode.MaxLength = 3;
            this.cboTypeCode.Name = "cboTypeCode";
            this.cboTypeCode.Size = new System.Drawing.Size(71, 20);
            this.cboTypeCode.TabIndex = 1;
            this.cboTypeCode.TextChanged += new System.EventHandler(this.cboTypeCode_TextChanged);
            // 
            // lblUpdateStockType
            // 
            this.lblUpdateStockType.AutoSize = true;
            this.lblUpdateStockType.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateStockType.Location = new System.Drawing.Point(261, 59);
            this.lblUpdateStockType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateStockType.Name = "lblUpdateStockType";
            this.lblUpdateStockType.Size = new System.Drawing.Size(285, 36);
            this.lblUpdateStockType.TabIndex = 47;
            this.lblUpdateStockType.Text = "Update Stock Type";
            // 
            // DGVStockType
            // 
            this.DGVStockType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStockType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeCode,
            this.Description,
            this.Status});
            this.DGVStockType.Location = new System.Drawing.Point(48, 190);
            this.DGVStockType.Name = "DGVStockType";
            this.DGVStockType.ReadOnly = true;
            this.DGVStockType.Size = new System.Drawing.Size(343, 184);
            this.DGVStockType.TabIndex = 73;
            this.DGVStockType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVStockType_CellContentClick);
            this.DGVStockType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVStockType_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSearch.Location = new System.Drawing.Point(48, 156);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 23);
            this.btnSearch.TabIndex = 70;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboSearch
            // 
            this.cboSearch.Location = new System.Drawing.Point(48, 131);
            this.cboSearch.Margin = new System.Windows.Forms.Padding(2);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(132, 20);
            this.cboSearch.TabIndex = 71;
            // 
            // lblStock_List
            // 
            this.lblStock_List.AutoSize = true;
            this.lblStock_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblStock_List.Location = new System.Drawing.Point(45, 114);
            this.lblStock_List.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStock_List.Name = "lblStock_List";
            this.lblStock_List.Size = new System.Drawing.Size(105, 15);
            this.lblStock_List.TabIndex = 72;
            this.lblStock_List.Text = "Enter Type Name:";
            // 
            // TypeCode
            // 
            this.TypeCode.HeaderText = "Type Code";
            this.TypeCode.Name = "TypeCode";
            this.TypeCode.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // frmUpdateType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVStockType);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.lblStock_List);
            this.Controls.Add(this.mnuOrderMenu);
            this.Controls.Add(this.grpStockType);
            this.Controls.Add(this.lblUpdateStockType);
            this.Name = "frmUpdateType";
            this.Text = "Update Type";
            this.mnuOrderMenu.ResumeLayout(false);
            this.mnuOrderMenu.PerformLayout();
            this.grpStockType.ResumeLayout(false);
            this.grpStockType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStockType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuOrderMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuStockmnu;
        private System.Windows.Forms.ToolStripMenuItem mnubtnExit;
        private System.Windows.Forms.GroupBox grpStockType;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox cboStatus;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnUpdateStockType;
        private System.Windows.Forms.TextBox cboDescription;
        private System.Windows.Forms.TextBox cboTypeCode;
        private System.Windows.Forms.Label lblUpdateStockType;
        private System.Windows.Forms.DataGridView DGVStockType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox cboSearch;
        private System.Windows.Forms.Label lblStock_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}