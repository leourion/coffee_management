using PBL3_QuanLyQuanCafe.BLL;
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
    public partial class fSanPham : Form
    {
        public fSanPham()
        {
            InitializeComponent();
            loadDataGrid();
            loadComboboxCategory();
        }
        private void loadComboboxCategory()
        {
            List<FoodCategory> listCategory = FoodCategoryBLL.Instance.GetListFoodCategory();
            listCategory.Insert(0, new FoodCategory("-1", "Tất cả"));
                
            comboBoxDanhMuc.DataSource = listCategory;
            comboBoxDanhMuc.DisplayMember = "Name";
        }
        public void loadDataGrid()
        {
            dataGridViewSanPham.Rows.Clear();
            DataTable dt = FoodBLL.Instance.GetListFood();
            foreach (DataRow row in dt.Rows)
            {
                dataGridViewSanPham.Rows.Add(row["id"], row["name"],FoodCategoryBLL.Instance.GetNameCategorybyIDcate(row["idcategory"].ToString()), row["unit"], row["price"], row["image"]);
            }
        }

        private void iconButtonThemSP_Click(object sender, EventArgs e)
        {
            fThemSanPham f = new fThemSanPham(this);
            f.ShowDialog();
        }
        
        private void iconButtonCapnhatSP_Click(object sender, EventArgs e)
        {
            if(dataGridViewSanPham.SelectedCells.Count > 0)
            {


                /*
                string name = dataGridViewSanPham.SelectedCells[0].OwningRow.Cells[1].Value.ToString();
                int idcategory = (int)dataGridViewSanPham.SelectedCells[0].OwningRow.Cells[2].Value;
                string unit = dataGridViewSanPham.SelectedCells[0].OwningRow.Cells[3].Value.ToString();
                int price = (int)dataGridViewSanPham.SelectedCells[0].OwningRow.Cells[4].Value;
                //Image image = (Image)dataGridViewSanPham.SelectedCells[0].OwningRow.Cells[5].Value;
                //MessageBox.Show(name + idcategory +unit+price+"");*/
                //int id = (int)dataGridViewSanPham.SelectedCells[0].OwningRow.Cells[0].Value;
                string id = dataGridViewSanPham.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
                Food food = FoodBLL.Instance.GetFoodbyIDFood(id);
                FCapNhatSanPham f = new FCapNhatSanPham(food, this);
                f.ShowDialog();
                // f.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void iconButtonXoaSP_Click(object sender, EventArgs e)
        {
            if (dataGridViewSanPham.SelectedCells.Count > 0)
            {
                string id = dataGridViewSanPham.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
                Food food = FoodBLL.Instance.GetFoodbyIDFood(id);
                if (MessageBox.Show("Bạn chắc chắn muốn xoá sản phẩm " + food.Name + "?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    FoodBLL.Instance.XoaSanPham(food);
                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK ,MessageBoxIcon.Information);
                    loadDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void iconButtonTimkiem_Click(object sender, EventArgs e)
        {
            string namefood = textBoxFoodName.Text.Trim();
            string namecategory = comboBoxDanhMuc.Text.Trim();
            if (namefood.Equals("Nhập ID hoặc tên sản phẩm")) namefood = "";
            if (namecategory.Equals("Tất cả")) namecategory = "";
            dataGridViewSanPham.Rows.Clear();
            DataTable table = FoodBLL.Instance.TimKiemSanPham(namefood, namecategory);
            foreach(DataRow row in table.Rows)
            {
                dataGridViewSanPham.Rows.Add(row["id"], row["name"], FoodCategoryBLL.Instance.GetNameCategorybyIDcate(row["idcategory"].ToString()), row["unit"], row["price"], row["image"]);
            }
        }

        private void textBoxFoodName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFoodName.Text != "Nhập ID hoặc tên sản phẩm")
            {
                if (textBoxFoodName.Text.Contains("Nhập ID hoặc tên sản phẩm"))
                {
                    textBoxFoodName.Text = textBoxFoodName.Text.Replace("Nhập ID hoặc tên sản phẩm", "");
                    textBoxFoodName.SelectionStart = 1;
                }
            }
            if (textBoxFoodName.Text == "")
            {
                textBoxFoodName.Text = "Nhập ID hoặc tên sản phẩm";
                textBoxFoodName.ForeColor = Color.Gray;
                return;
            }
            textBoxFoodName.ForeColor = Color.Black;
        }

        private void textBoxFoodName_Click(object sender, EventArgs e)
        {
            if(textBoxFoodName.Text == "Nhập ID hoặc tên sản phẩm")
                textBoxFoodName.SelectionStart = 0;
        }

        private void comboBoxDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
