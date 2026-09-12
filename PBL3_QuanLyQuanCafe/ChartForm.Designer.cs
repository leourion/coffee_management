namespace PBL3_QuanLyQuanCafe
{
    partial class ChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblRevenueYear = new System.Windows.Forms.Label();
            this.cbbRevenueYear = new System.Windows.Forms.ComboBox();
            this.drvTotalRevenue = new System.Windows.Forms.DataGridView();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.drvFood = new System.Windows.Forms.DataGridView();
            this.chartFood = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drvTotalRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drvFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFood)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(110, 50);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1412, 767);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.lblRevenueYear);
            this.tabPage1.Controls.Add(this.cbbRevenueYear);
            this.tabPage1.Controls.Add(this.drvTotalRevenue);
            this.tabPage1.Controls.Add(this.chartRevenue);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 54);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1404, 709);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Doanh thu";
            // 
            // lblRevenueYear
            // 
            this.lblRevenueYear.AutoSize = true;
            this.lblRevenueYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueYear.Location = new System.Drawing.Point(37, 48);
            this.lblRevenueYear.Name = "lblRevenueYear";
            this.lblRevenueYear.Size = new System.Drawing.Size(53, 25);
            this.lblRevenueYear.TabIndex = 10;
            this.lblRevenueYear.Text = "Năm";
            // 
            // cbbRevenueYear
            // 
            this.cbbRevenueYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbRevenueYear.FormattingEnabled = true;
            this.cbbRevenueYear.Location = new System.Drawing.Point(96, 46);
            this.cbbRevenueYear.Name = "cbbRevenueYear";
            this.cbbRevenueYear.Size = new System.Drawing.Size(133, 33);
            this.cbbRevenueYear.TabIndex = 9;
            this.cbbRevenueYear.SelectedIndexChanged += new System.EventHandler(this.cbbRevenueYear_SelectedIndexChanged);
            // 
            // drvTotalRevenue
            // 
            this.drvTotalRevenue.AllowUserToAddRows = false;
            this.drvTotalRevenue.AllowUserToDeleteRows = false;
            this.drvTotalRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drvTotalRevenue.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.drvTotalRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvTotalRevenue.Location = new System.Drawing.Point(42, 105);
            this.drvTotalRevenue.MultiSelect = false;
            this.drvTotalRevenue.Name = "drvTotalRevenue";
            this.drvTotalRevenue.ReadOnly = true;
            this.drvTotalRevenue.RowHeadersVisible = false;
            this.drvTotalRevenue.RowHeadersWidth = 51;
            this.drvTotalRevenue.RowTemplate.Height = 24;
            this.drvTotalRevenue.Size = new System.Drawing.Size(556, 586);
            this.drvTotalRevenue.TabIndex = 8;
            // 
            // chartRevenue
            // 
            this.chartRevenue.BorderlineColor = System.Drawing.Color.Transparent;
            this.chartRevenue.BorderlineWidth = 3;
            chartArea1.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend1);
            this.chartRevenue.Location = new System.Drawing.Point(586, 105);
            this.chartRevenue.Name = "chartRevenue";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Tổng thu";
            this.chartRevenue.Series.Add(series1);
            this.chartRevenue.Size = new System.Drawing.Size(786, 547);
            this.chartRevenue.TabIndex = 7;
            this.chartRevenue.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.cbbCategory);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.drvFood);
            this.tabPage2.Controls.Add(this.chartFood);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 54);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1404, 709);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Món ";
            // 
            // cbbCategory
            // 
            this.cbbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(168, 48);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(148, 30);
            this.cbbCategory.TabIndex = 6;
            this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.cbbCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh mục:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // drvFood
            // 
            this.drvFood.AllowUserToAddRows = false;
            this.drvFood.AllowUserToDeleteRows = false;
            this.drvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drvFood.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.drvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvFood.Location = new System.Drawing.Point(43, 101);
            this.drvFood.MultiSelect = false;
            this.drvFood.Name = "drvFood";
            this.drvFood.ReadOnly = true;
            this.drvFood.RowHeadersVisible = false;
            this.drvFood.RowHeadersWidth = 51;
            this.drvFood.RowTemplate.Height = 24;
            this.drvFood.Size = new System.Drawing.Size(612, 586);
            this.drvFood.TabIndex = 4;
            // 
            // chartFood
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFood.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFood.Legends.Add(legend2);
            this.chartFood.Location = new System.Drawing.Point(698, 62);
            this.chartFood.Name = "chartFood";
            this.chartFood.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFood.Series.Add(series2);
            this.chartFood.Size = new System.Drawing.Size(698, 625);
            this.chartFood.TabIndex = 2;
            this.chartFood.Text = "chart1";
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 767);
            this.Controls.Add(this.tabControl1);
            this.Name = "ChartForm";
            this.Text = "ChartForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drvTotalRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drvFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblRevenueYear;
        private System.Windows.Forms.ComboBox cbbRevenueYear;
        private System.Windows.Forms.DataGridView drvTotalRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView drvFood;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFood;
    }
}