using PBL3_QuanLyQuanCafe.BLL;
using PBL3_QuanLyQuanCafe.DAL;
using PBL3_QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_QuanLyQuanCafe
{
    public partial class ChartForm : Form
    {
        List<string> months = new List<string>();
        List<float> values = new List<float>();
        DataTable numberFoodSource = new DataTable();
        public ChartForm()
        {
            InitializeComponent();
            LoadCbbRevenueYear();
            cbbRevenueYear.SelectedItem = "2022";
            LoadDataTabPage1("2022");
            LoadDataTabPage2();
        }
        private void LoadDataTabPage1(string year)
        {
            LoadToalRevenue(year);
            LoadRevenueChart();
        }
        private void LoadToalRevenue(string year)
        {
            drvTotalRevenue.DataSource = null;
            drvTotalRevenue.DataSource = BillDAL.Instance.GetTotalRevenue(year);
            DataTable dt = (DataTable)drvTotalRevenue.DataSource;
            months.Clear();
            values.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                months.Add(dr["Tháng"].ToString());
                values.Add(float.Parse(dr["Tổng thu"].ToString()));
            }
        }
        private void LoadCbbRevenueYear()
        {
            cbbRevenueYear.DataSource = TimeKeepingBLL.Instance.GetListYear();
        }
        private void LoadRevenueChart()
        {
            int index = 0;
            chartRevenue.Series["Tổng thu"].Points.Clear();
            for (int i = 1; i <= 12; i++)
            {
                String month = i.ToString();
                if (months.Contains(i.ToString()))
                {
                    chartRevenue.Series["Tổng thu"].Points.AddXY(month, values[index]);
                    index++;
                }
                else
                {
                    chartRevenue.Series["Tổng thu"].Points.AddXY(month, 0);
                }
            }
        }

        private void cbbRevenueYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            string year = (string)cbbRevenueYear.SelectedValue;
            LoadDataTabPage1(year);
        }
        private void LoadDataTabPage2()
        {
            LoadCbbCategory();
            LoadTableFood();
            LoadFoodChart();
        }
        private void LoadCbbCategory()
        {
            List<FoodCategory> categorys = FoodCategoryDAL.Instance.GetListCategory();
            categorys.Insert(0, new FoodCategory("", "Tất cả"));
            cbbCategory.DataSource = categorys;
            cbbCategory.DisplayMember = "name";
            cbbCategory.SelectedIndex = 0;
        }
        private void LoadTableFood()
        {
            string idCategory = (cbbCategory.SelectedItem as FoodCategory).Id;
            drvFood.DataSource = BillInfoDAL.Instance.GetNumberFood(idCategory);
            numberFoodSource.Clear();
            numberFoodSource = BillInfoDAL.Instance.GetNumberFood(idCategory);
        }
        private void LoadFoodChart()
        {
            chartFood.Series[0].Points.Clear();
            if (numberFoodSource != null)
            {
                foreach (DataRow dr in numberFoodSource.Rows)
                {
                    string name = dr["Tên món ăn"].ToString();
                    string number = dr["Số lần gọi"].ToString();
                    chartFood.Series[0].Points.AddXY(name, number);
                }
            }

        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTableFood();
            LoadFoodChart();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
