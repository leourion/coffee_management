namespace PBL3_QuanLyQuanCafe
{
    partial class BillForm
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
            this.txtFill = new System.Windows.Forms.TextBox();
            this.radTable = new System.Windows.Forms.RadioButton();
            this.radIdBill = new System.Windows.Forms.RadioButton();
            this.lblSearch = new System.Windows.Forms.Label();
            this.drvBill = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Search = new FontAwesome.Sharp.IconButton();
            this.dtpkDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpkDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtCashierName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtIdBill = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.drvBill)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFill
            // 
            this.txtFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFill.Location = new System.Drawing.Point(185, 83);
            this.txtFill.Name = "txtFill";
            this.txtFill.Size = new System.Drawing.Size(460, 30);
            this.txtFill.TabIndex = 5;
            this.txtFill.TextChanged += new System.EventHandler(this.txtFill_TextChanged);
            // 
            // radTable
            // 
            this.radTable.AutoSize = true;
            this.radTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTable.Location = new System.Drawing.Point(867, 85);
            this.radTable.Name = "radTable";
            this.radTable.Size = new System.Drawing.Size(60, 24);
            this.radTable.TabIndex = 13;
            this.radTable.TabStop = true;
            this.radTable.Text = "Bàn";
            this.radTable.UseVisualStyleBackColor = true;
            this.radTable.Click += new System.EventHandler(this.radTable_Click);
            // 
            // radIdBill
            // 
            this.radIdBill.AutoSize = true;
            this.radIdBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radIdBill.Location = new System.Drawing.Point(696, 85);
            this.radIdBill.Name = "radIdBill";
            this.radIdBill.Size = new System.Drawing.Size(117, 24);
            this.radIdBill.TabIndex = 12;
            this.radIdBill.TabStop = true;
            this.radIdBill.Text = "Mã hóa đơn";
            this.radIdBill.UseVisualStyleBackColor = true;
            this.radIdBill.Click += new System.EventHandler(this.radIdBill_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(44, 85);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(92, 24);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Tìm kiếm:";
            // 
            // drvBill
            // 
            this.drvBill.AllowUserToAddRows = false;
            this.drvBill.AllowUserToDeleteRows = false;
            this.drvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvBill.Location = new System.Drawing.Point(48, 196);
            this.drvBill.Name = "drvBill";
            this.drvBill.ReadOnly = true;
            this.drvBill.RowHeadersWidth = 62;
            this.drvBill.RowTemplate.Height = 28;
            this.drvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drvBill.Size = new System.Drawing.Size(766, 464);
            this.drvBill.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Controls.Add(this.dtpkDateTo);
            this.panel1.Controls.Add(this.dtpkDateFrom);
            this.panel1.Location = new System.Drawing.Point(47, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 72);
            this.panel1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(354, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Từ ngày";
            // 
            // Search
            // 
            this.Search.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.Search.IconColor = System.Drawing.Color.Peru;
            this.Search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Search.Location = new System.Drawing.Point(555, 6);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(132, 55);
            this.Search.TabIndex = 9;
            this.Search.Text = "Tìm kiếm";
            this.Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // dtpkDateTo
            // 
            this.dtpkDateTo.CustomFormat = "dd/MM/yyyy";
            this.dtpkDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkDateTo.Location = new System.Drawing.Point(359, 32);
            this.dtpkDateTo.Name = "dtpkDateTo";
            this.dtpkDateTo.Size = new System.Drawing.Size(163, 28);
            this.dtpkDateTo.TabIndex = 4;
            // 
            // dtpkDateFrom
            // 
            this.dtpkDateFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpkDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkDateFrom.Location = new System.Drawing.Point(138, 33);
            this.dtpkDateFrom.Name = "dtpkDateFrom";
            this.dtpkDateFrom.Size = new System.Drawing.Size(152, 28);
            this.dtpkDateFrom.TabIndex = 3;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(3, 2);
            this.lsvBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(557, 464);
            this.lsvBill.TabIndex = 16;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 116;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Đơn giá";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            this.columnHeader3.Width = 118;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 138;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(1009, 705);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(130, 30);
            this.txtDiscount.TabIndex = 22;
            // 
            // txtCashierName
            // 
            this.txtCashierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashierName.Location = new System.Drawing.Point(696, 706);
            this.txtCashierName.Name = "txtCashierName";
            this.txtCashierName.ReadOnly = true;
            this.txtCashierName.Size = new System.Drawing.Size(260, 30);
            this.txtCashierName.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(478, 711);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nhân viên thu tiền:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(1005, 678);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(84, 24);
            this.lblDiscount.TabIndex = 19;
            this.lblDiscount.Text = "Giảm giá";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(1193, 678);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(90, 24);
            this.lblTotalPrice.TabIndex = 18;
            this.lblTotalPrice.Text = "Tổng tiền";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(1197, 705);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(130, 30);
            this.txtTotalPrice.TabIndex = 17;
            // 
            // txtIdBill
            // 
            this.txtIdBill.Location = new System.Drawing.Point(968, 427);
            this.txtIdBill.Name = "txtIdBill";
            this.txtIdBill.Size = new System.Drawing.Size(121, 22);
            this.txtIdBill.TabIndex = 23;
            this.txtIdBill.TextChanged += new System.EventHandler(this.txtIdBill_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(836, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 464);
            this.panel2.TabIndex = 24;
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 767);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtIdBill);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtCashierName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.drvBill);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radTable);
            this.Controls.Add(this.radIdBill);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtFill);
            this.Name = "BillForm";
            this.Text = "BillForm";
            ((System.ComponentModel.ISupportInitialize)(this.drvBill)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFill;
        private System.Windows.Forms.RadioButton radTable;
        private System.Windows.Forms.RadioButton radIdBill;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView drvBill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpkDateTo;
        private System.Windows.Forms.DateTimePicker dtpkDateFrom;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtCashierName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtIdBill;
        private FontAwesome.Sharp.IconButton Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
    }
}