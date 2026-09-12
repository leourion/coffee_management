namespace PBL3_QuanLyQuanCafe
{
    partial class fDanhMuc
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
            this.dataGridViewDanhMuc = new System.Windows.Forms.DataGridView();
            this.iconButtonTimkiem = new FontAwesome.Sharp.IconButton();
            this.textBoxCateName = new System.Windows.Forms.TextBox();
            this.iconButtonXoaDM = new FontAwesome.Sharp.IconButton();
            this.iconButtonCapnhatDM = new FontAwesome.Sharp.IconButton();
            this.iconButtonThemDM = new FontAwesome.Sharp.IconButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDanhMuc
            // 
            this.dataGridViewDanhMuc.AllowUserToAddRows = false;
            this.dataGridViewDanhMuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewDanhMuc.Location = new System.Drawing.Point(12, 169);
            this.dataGridViewDanhMuc.Name = "dataGridViewDanhMuc";
            this.dataGridViewDanhMuc.RowHeadersWidth = 51;
            this.dataGridViewDanhMuc.RowTemplate.Height = 45;
            this.dataGridViewDanhMuc.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDanhMuc.Size = new System.Drawing.Size(1388, 556);
            this.dataGridViewDanhMuc.TabIndex = 0;
            // 
            // iconButtonTimkiem
            // 
            this.iconButtonTimkiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButtonTimkiem.IconColor = System.Drawing.Color.Peru;
            this.iconButtonTimkiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonTimkiem.Location = new System.Drawing.Point(513, 80);
            this.iconButtonTimkiem.Name = "iconButtonTimkiem";
            this.iconButtonTimkiem.Size = new System.Drawing.Size(138, 51);
            this.iconButtonTimkiem.TabIndex = 13;
            this.iconButtonTimkiem.Text = "Tìm kiếm";
            this.iconButtonTimkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonTimkiem.UseVisualStyleBackColor = true;
            this.iconButtonTimkiem.Click += new System.EventHandler(this.iconButtonTimkiem_Click);
            // 
            // textBoxCateName
            // 
            this.textBoxCateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCateName.ForeColor = System.Drawing.Color.Gray;
            this.textBoxCateName.Location = new System.Drawing.Point(20, 97);
            this.textBoxCateName.Name = "textBoxCateName";
            this.textBoxCateName.Size = new System.Drawing.Size(474, 34);
            this.textBoxCateName.TabIndex = 11;
            this.textBoxCateName.Text = "Nhập ID hoặc tên danh mục";
            this.textBoxCateName.Click += new System.EventHandler(this.textBoxCateName_Click);
            this.textBoxCateName.TextChanged += new System.EventHandler(this.textBoxCateName_TextChanged);
            // 
            // iconButtonXoaDM
            // 
            this.iconButtonXoaDM.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconButtonXoaDM.IconColor = System.Drawing.Color.Maroon;
            this.iconButtonXoaDM.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonXoaDM.Location = new System.Drawing.Point(1255, 80);
            this.iconButtonXoaDM.Name = "iconButtonXoaDM";
            this.iconButtonXoaDM.Size = new System.Drawing.Size(138, 51);
            this.iconButtonXoaDM.TabIndex = 10;
            this.iconButtonXoaDM.Text = "Xoá ";
            this.iconButtonXoaDM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonXoaDM.UseVisualStyleBackColor = true;
            this.iconButtonXoaDM.Click += new System.EventHandler(this.iconButtonXoaDM_Click);
            // 
            // iconButtonCapnhatDM
            // 
            this.iconButtonCapnhatDM.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.iconButtonCapnhatDM.IconColor = System.Drawing.Color.DodgerBlue;
            this.iconButtonCapnhatDM.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCapnhatDM.Location = new System.Drawing.Point(1102, 80);
            this.iconButtonCapnhatDM.Name = "iconButtonCapnhatDM";
            this.iconButtonCapnhatDM.Size = new System.Drawing.Size(138, 51);
            this.iconButtonCapnhatDM.TabIndex = 9;
            this.iconButtonCapnhatDM.Text = "Cập nhật ";
            this.iconButtonCapnhatDM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCapnhatDM.UseVisualStyleBackColor = true;
            this.iconButtonCapnhatDM.Click += new System.EventHandler(this.iconButtonCapnhatDM_Click);
            // 
            // iconButtonThemDM
            // 
            this.iconButtonThemDM.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButtonThemDM.IconColor = System.Drawing.Color.Green;
            this.iconButtonThemDM.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonThemDM.Location = new System.Drawing.Point(948, 80);
            this.iconButtonThemDM.Name = "iconButtonThemDM";
            this.iconButtonThemDM.Size = new System.Drawing.Size(138, 51);
            this.iconButtonThemDM.TabIndex = 8;
            this.iconButtonThemDM.Text = "Thêm ";
            this.iconButtonThemDM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonThemDM.UseVisualStyleBackColor = true;
            this.iconButtonThemDM.Click += new System.EventHandler(this.iconButtonThemDM_Click);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 30F;
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số lượng sản phẩm";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // fDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 793);
            this.Controls.Add(this.iconButtonTimkiem);
            this.Controls.Add(this.textBoxCateName);
            this.Controls.Add(this.iconButtonXoaDM);
            this.Controls.Add(this.iconButtonCapnhatDM);
            this.Controls.Add(this.iconButtonThemDM);
            this.Controls.Add(this.dataGridViewDanhMuc);
            this.Name = "fDanhMuc";
            this.Text = "fDanhMuc";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhMuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDanhMuc;
        private FontAwesome.Sharp.IconButton iconButtonTimkiem;
        private System.Windows.Forms.TextBox textBoxCateName;
        private FontAwesome.Sharp.IconButton iconButtonXoaDM;
        private FontAwesome.Sharp.IconButton iconButtonCapnhatDM;
        private FontAwesome.Sharp.IconButton iconButtonThemDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}