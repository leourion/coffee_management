namespace PBL3_QuanLyQuanCafe
{
    partial class fSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSanPham));
            this.dataGridViewSanPham = new System.Windows.Forms.DataGridView();
            this.textBoxFoodName = new System.Windows.Forms.TextBox();
            this.comboBoxDanhMuc = new System.Windows.Forms.ComboBox();
            this.iconButtonTimkiem = new FontAwesome.Sharp.IconButton();
            this.iconButtonXoaSP = new FontAwesome.Sharp.IconButton();
            this.iconButtonCapnhatSP = new FontAwesome.Sharp.IconButton();
            this.iconButtonThemSP = new FontAwesome.Sharp.IconButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Colunm5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSanPham
            // 
            this.dataGridViewSanPham.AllowUserToAddRows = false;
            this.dataGridViewSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Colunm5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column8});
            this.dataGridViewSanPham.Location = new System.Drawing.Point(12, 88);
            this.dataGridViewSanPham.Name = "dataGridViewSanPham";
            this.dataGridViewSanPham.RowHeadersWidth = 51;
            this.dataGridViewSanPham.RowTemplate.Height = 120;
            this.dataGridViewSanPham.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSanPham.Size = new System.Drawing.Size(1388, 685);
            this.dataGridViewSanPham.TabIndex = 0;
            // 
            // textBoxFoodName
            // 
            this.textBoxFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFoodName.ForeColor = System.Drawing.Color.Gray;
            this.textBoxFoodName.Location = new System.Drawing.Point(12, 38);
            this.textBoxFoodName.Name = "textBoxFoodName";
            this.textBoxFoodName.Size = new System.Drawing.Size(424, 34);
            this.textBoxFoodName.TabIndex = 5;
            this.textBoxFoodName.Text = "Nhập ID hoặc tên sản phẩm";
            this.textBoxFoodName.Click += new System.EventHandler(this.textBoxFoodName_Click);
            this.textBoxFoodName.TextChanged += new System.EventHandler(this.textBoxFoodName_TextChanged);
            // 
            // comboBoxDanhMuc
            // 
            this.comboBoxDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDanhMuc.FormattingEnabled = true;
            this.comboBoxDanhMuc.Location = new System.Drawing.Point(451, 38);
            this.comboBoxDanhMuc.Name = "comboBoxDanhMuc";
            this.comboBoxDanhMuc.Size = new System.Drawing.Size(201, 34);
            this.comboBoxDanhMuc.TabIndex = 6;
            this.comboBoxDanhMuc.SelectedIndexChanged += new System.EventHandler(this.comboBoxDanhMuc_SelectedIndexChanged);
            // 
            // iconButtonTimkiem
            // 
            this.iconButtonTimkiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButtonTimkiem.IconColor = System.Drawing.Color.Peru;
            this.iconButtonTimkiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonTimkiem.Location = new System.Drawing.Point(671, 21);
            this.iconButtonTimkiem.Name = "iconButtonTimkiem";
            this.iconButtonTimkiem.Size = new System.Drawing.Size(138, 51);
            this.iconButtonTimkiem.TabIndex = 7;
            this.iconButtonTimkiem.Text = "Tìm kiếm";
            this.iconButtonTimkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonTimkiem.UseVisualStyleBackColor = true;
            this.iconButtonTimkiem.Click += new System.EventHandler(this.iconButtonTimkiem_Click);
            // 
            // iconButtonXoaSP
            // 
            this.iconButtonXoaSP.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconButtonXoaSP.IconColor = System.Drawing.Color.Maroon;
            this.iconButtonXoaSP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonXoaSP.Location = new System.Drawing.Point(1247, 21);
            this.iconButtonXoaSP.Name = "iconButtonXoaSP";
            this.iconButtonXoaSP.Size = new System.Drawing.Size(138, 51);
            this.iconButtonXoaSP.TabIndex = 4;
            this.iconButtonXoaSP.Text = "Xoá ";
            this.iconButtonXoaSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonXoaSP.UseVisualStyleBackColor = true;
            this.iconButtonXoaSP.Click += new System.EventHandler(this.iconButtonXoaSP_Click);
            // 
            // iconButtonCapnhatSP
            // 
            this.iconButtonCapnhatSP.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.iconButtonCapnhatSP.IconColor = System.Drawing.Color.DodgerBlue;
            this.iconButtonCapnhatSP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCapnhatSP.Location = new System.Drawing.Point(1094, 21);
            this.iconButtonCapnhatSP.Name = "iconButtonCapnhatSP";
            this.iconButtonCapnhatSP.Size = new System.Drawing.Size(138, 51);
            this.iconButtonCapnhatSP.TabIndex = 3;
            this.iconButtonCapnhatSP.Text = "Cập nhật ";
            this.iconButtonCapnhatSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCapnhatSP.UseVisualStyleBackColor = true;
            this.iconButtonCapnhatSP.Click += new System.EventHandler(this.iconButtonCapnhatSP_Click);
            // 
            // iconButtonThemSP
            // 
            this.iconButtonThemSP.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButtonThemSP.IconColor = System.Drawing.Color.Green;
            this.iconButtonThemSP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonThemSP.Location = new System.Drawing.Point(940, 21);
            this.iconButtonThemSP.Name = "iconButtonThemSP";
            this.iconButtonThemSP.Size = new System.Drawing.Size(138, 51);
            this.iconButtonThemSP.TabIndex = 2;
            this.iconButtonThemSP.Text = "Thêm ";
            this.iconButtonThemSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonThemSP.UseVisualStyleBackColor = true;
            this.iconButtonThemSP.Click += new System.EventHandler(this.iconButtonThemSP_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // Colunm5
            // 
            this.Colunm5.FillWeight = 70F;
            this.Colunm5.HeaderText = "ID";
            this.Colunm5.MinimumWidth = 6;
            this.Colunm5.Name = "Colunm5";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 120F;
            this.Column1.HeaderText = "Tên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 70F;
            this.Column2.HeaderText = "Danh mục";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Đơn vị";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giá";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column8
            // 
            this.Column8.FillWeight = 50F;
            this.Column8.HeaderText = "Hình ảnh";
            this.Column8.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // fSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 793);
            this.Controls.Add(this.iconButtonTimkiem);
            this.Controls.Add(this.comboBoxDanhMuc);
            this.Controls.Add(this.textBoxFoodName);
            this.Controls.Add(this.iconButtonXoaSP);
            this.Controls.Add(this.iconButtonCapnhatSP);
            this.Controls.Add(this.iconButtonThemSP);
            this.Controls.Add(this.dataGridViewSanPham);
            this.Name = "fSanPham";
            this.Text = "fSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSanPham;
        private FontAwesome.Sharp.IconButton iconButtonThemSP;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private FontAwesome.Sharp.IconButton iconButtonCapnhatSP;
        private FontAwesome.Sharp.IconButton iconButtonXoaSP;
        private System.Windows.Forms.TextBox textBoxFoodName;
        private System.Windows.Forms.ComboBox comboBoxDanhMuc;
        private FontAwesome.Sharp.IconButton iconButtonTimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colunm5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column8;
    }
}