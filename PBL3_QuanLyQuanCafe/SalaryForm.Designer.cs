namespace PBL3_QuanLyQuanCafe
{
    partial class SalaryForm
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
            this.lblTotalSalary = new System.Windows.Forms.Label();
            this.drvPersonalSalary = new System.Windows.Forms.DataGridView();
            this.cbbYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cbbMonth = new System.Windows.Forms.ComboBox();
            this.drvTotalSalary = new System.Windows.Forms.DataGridView();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalPrice1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.drvPersonalSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drvTotalSalary)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalSalary
            // 
            this.lblTotalSalary.AutoSize = true;
            this.lblTotalSalary.Location = new System.Drawing.Point(53, 991);
            this.lblTotalSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalSalary.Name = "lblTotalSalary";
            this.lblTotalSalary.Size = new System.Drawing.Size(189, 22);
            this.lblTotalSalary.TabIndex = 18;
            this.lblTotalSalary.Text = "Tổng lương nhân viên:";
            // 
            // drvPersonalSalary
            // 
            this.drvPersonalSalary.AllowUserToAddRows = false;
            this.drvPersonalSalary.AllowUserToDeleteRows = false;
            this.drvPersonalSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drvPersonalSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvPersonalSalary.Location = new System.Drawing.Point(0, 26);
            this.drvPersonalSalary.Margin = new System.Windows.Forms.Padding(4);
            this.drvPersonalSalary.MultiSelect = false;
            this.drvPersonalSalary.Name = "drvPersonalSalary";
            this.drvPersonalSalary.ReadOnly = true;
            this.drvPersonalSalary.RowHeadersVisible = false;
            this.drvPersonalSalary.RowHeadersWidth = 62;
            this.drvPersonalSalary.RowTemplate.Height = 28;
            this.drvPersonalSalary.Size = new System.Drawing.Size(693, 564);
            this.drvPersonalSalary.TabIndex = 17;
            // 
            // cbbYear
            // 
            this.cbbYear.FormattingEnabled = true;
            this.cbbYear.Location = new System.Drawing.Point(178, 96);
            this.cbbYear.Margin = new System.Windows.Forms.Padding(4);
            this.cbbYear.Name = "cbbYear";
            this.cbbYear.Size = new System.Drawing.Size(189, 30);
            this.cbbYear.TabIndex = 16;
            this.cbbYear.SelectedIndexChanged += new System.EventHandler(this.cbbYear_SelectedIndexChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(103, 98);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(52, 22);
            this.lblYear.TabIndex = 15;
            this.lblYear.Text = "Năm:";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(-70, 37);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(67, 22);
            this.lblMonth.TabIndex = 14;
            this.lblMonth.Text = "Tháng:";
            // 
            // cbbMonth
            // 
            this.cbbMonth.FormattingEnabled = true;
            this.cbbMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbbMonth.Location = new System.Drawing.Point(178, 44);
            this.cbbMonth.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMonth.Name = "cbbMonth";
            this.cbbMonth.Size = new System.Drawing.Size(189, 30);
            this.cbbMonth.TabIndex = 13;
            this.cbbMonth.SelectedIndexChanged += new System.EventHandler(this.cbbMonth_SelectedIndexChanged);
            // 
            // drvTotalSalary
            // 
            this.drvTotalSalary.AllowUserToAddRows = false;
            this.drvTotalSalary.AllowUserToDeleteRows = false;
            this.drvTotalSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drvTotalSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvTotalSalary.Location = new System.Drawing.Point(13, 133);
            this.drvTotalSalary.Margin = new System.Windows.Forms.Padding(4);
            this.drvTotalSalary.MultiSelect = false;
            this.drvTotalSalary.Name = "drvTotalSalary";
            this.drvTotalSalary.ReadOnly = true;
            this.drvTotalSalary.RowHeadersVisible = false;
            this.drvTotalSalary.RowHeadersWidth = 62;
            this.drvTotalSalary.RowTemplate.Height = 28;
            this.drvTotalSalary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drvTotalSalary.Size = new System.Drawing.Size(694, 566);
            this.drvTotalSalary.TabIndex = 12;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(1470, 94);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(144, 28);
            this.txtUserName.TabIndex = 23;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDisplayName.Location = new System.Drawing.Point(938, 42);
            this.txtDisplayName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(353, 30);
            this.txtDisplayName.TabIndex = 22;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(786, 44);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(130, 22);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Tên nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tháng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.drvPersonalSalary);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(714, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 610);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng Lương Nhân Viên";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(249, 991);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(45, 22);
            this.lblTotalPrice.TabIndex = 26;
            this.lblTotalPrice.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 728);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tổng lương nhân viên:";
            // 
            // lblTotalPrice1
            // 
            this.lblTotalPrice1.Location = new System.Drawing.Point(254, 729);
            this.lblTotalPrice1.Name = "lblTotalPrice1";
            this.lblTotalPrice1.ReadOnly = true;
            this.lblTotalPrice1.Size = new System.Drawing.Size(134, 28);
            this.lblTotalPrice1.TabIndex = 29;
            this.lblTotalPrice1.Text = "0.00";
            // 
            // SalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 793);
            this.Controls.Add(this.lblTotalPrice1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalSalary);
            this.Controls.Add(this.cbbYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.cbbMonth);
            this.Controls.Add(this.drvTotalSalary);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtDisplayName);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SalaryForm";
            this.Text = "SalaryForm";
            ((System.ComponentModel.ISupportInitialize)(this.drvPersonalSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drvTotalSalary)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTotalSalary;
        private System.Windows.Forms.DataGridView drvPersonalSalary;
        private System.Windows.Forms.ComboBox cbbYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cbbMonth;
        private System.Windows.Forms.DataGridView drvTotalSalary;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lblTotalPrice1;
    }
}