namespace PBL3_QuanLyQuanCafe
{
    partial class fBan
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
            this.iconButtonTimkiem = new FontAwesome.Sharp.IconButton();
            this.comboBoxTrangThai = new System.Windows.Forms.ComboBox();
            this.textBoxTableName = new System.Windows.Forms.TextBox();
            this.iconButtonXoaBan = new FontAwesome.Sharp.IconButton();
            this.iconButtonThemBan = new FontAwesome.Sharp.IconButton();
            this.dataGridViewBan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBan)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButtonTimkiem
            // 
            this.iconButtonTimkiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButtonTimkiem.IconColor = System.Drawing.Color.Peru;
            this.iconButtonTimkiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonTimkiem.Location = new System.Drawing.Point(671, 20);
            this.iconButtonTimkiem.Name = "iconButtonTimkiem";
            this.iconButtonTimkiem.Size = new System.Drawing.Size(138, 51);
            this.iconButtonTimkiem.TabIndex = 14;
            this.iconButtonTimkiem.Text = "Tìm kiếm";
            this.iconButtonTimkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonTimkiem.UseVisualStyleBackColor = true;
            this.iconButtonTimkiem.Click += new System.EventHandler(this.iconButtonTimkiem_Click);
            // 
            // comboBoxTrangThai
            // 
            this.comboBoxTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTrangThai.FormattingEnabled = true;
            this.comboBoxTrangThai.Location = new System.Drawing.Point(451, 37);
            this.comboBoxTrangThai.Name = "comboBoxTrangThai";
            this.comboBoxTrangThai.Size = new System.Drawing.Size(201, 34);
            this.comboBoxTrangThai.TabIndex = 13;
            // 
            // textBoxTableName
            // 
            this.textBoxTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTableName.ForeColor = System.Drawing.Color.Gray;
            this.textBoxTableName.Location = new System.Drawing.Point(12, 37);
            this.textBoxTableName.Name = "textBoxTableName";
            this.textBoxTableName.Size = new System.Drawing.Size(424, 34);
            this.textBoxTableName.TabIndex = 12;
            this.textBoxTableName.Text = "Nhập ID hoặc tên bàn";
            this.textBoxTableName.Click += new System.EventHandler(this.textBoxTableName_Click);
            this.textBoxTableName.TextChanged += new System.EventHandler(this.textBoxTableName_TextChanged);
            // 
            // iconButtonXoaBan
            // 
            this.iconButtonXoaBan.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconButtonXoaBan.IconColor = System.Drawing.Color.Maroon;
            this.iconButtonXoaBan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonXoaBan.Location = new System.Drawing.Point(1183, 20);
            this.iconButtonXoaBan.Name = "iconButtonXoaBan";
            this.iconButtonXoaBan.Size = new System.Drawing.Size(138, 51);
            this.iconButtonXoaBan.TabIndex = 11;
            this.iconButtonXoaBan.Text = "Xoá ";
            this.iconButtonXoaBan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonXoaBan.UseVisualStyleBackColor = true;
            this.iconButtonXoaBan.Click += new System.EventHandler(this.iconButtonXoaBan_Click);
            // 
            // iconButtonThemBan
            // 
            this.iconButtonThemBan.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButtonThemBan.IconColor = System.Drawing.Color.Green;
            this.iconButtonThemBan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonThemBan.Location = new System.Drawing.Point(1013, 20);
            this.iconButtonThemBan.Name = "iconButtonThemBan";
            this.iconButtonThemBan.Size = new System.Drawing.Size(138, 51);
            this.iconButtonThemBan.TabIndex = 9;
            this.iconButtonThemBan.Text = "Thêm ";
            this.iconButtonThemBan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonThemBan.UseVisualStyleBackColor = true;
            this.iconButtonThemBan.Click += new System.EventHandler(this.iconButtonThemBan_Click);
            // 
            // dataGridViewBan
            // 
            this.dataGridViewBan.AllowUserToAddRows = false;
            this.dataGridViewBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewBan.Location = new System.Drawing.Point(12, 87);
            this.dataGridViewBan.Name = "dataGridViewBan";
            this.dataGridViewBan.RowHeadersWidth = 51;
            this.dataGridViewBan.RowTemplate.Height = 45;
            this.dataGridViewBan.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBan.Size = new System.Drawing.Size(1388, 685);
            this.dataGridViewBan.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 60F;
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên bàn";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Trạng thái";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // fBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 793);
            this.Controls.Add(this.iconButtonTimkiem);
            this.Controls.Add(this.comboBoxTrangThai);
            this.Controls.Add(this.textBoxTableName);
            this.Controls.Add(this.iconButtonXoaBan);
            this.Controls.Add(this.iconButtonThemBan);
            this.Controls.Add(this.dataGridViewBan);
            this.Name = "fBan";
            this.Text = "fBan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonTimkiem;
        private System.Windows.Forms.ComboBox comboBoxTrangThai;
        private System.Windows.Forms.TextBox textBoxTableName;
        private FontAwesome.Sharp.IconButton iconButtonXoaBan;
        private FontAwesome.Sharp.IconButton iconButtonThemBan;
        private System.Windows.Forms.DataGridView dataGridViewBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}