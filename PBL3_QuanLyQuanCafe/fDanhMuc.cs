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
    public partial class fDanhMuc : Form
    {
        public fDanhMuc()
        {
            InitializeComponent();
            loadDataGrid();
        }
        public void loadDataGrid()
        {
            dataGridViewDanhMuc.Rows.Clear();
            List<FoodCategory> listcate = FoodCategoryBLL.Instance.GetListFoodCategory();
            foreach (FoodCategory item in listcate)
            {
                dataGridViewDanhMuc.Rows.Add(item.Id, item.Name, FoodBLL.Instance.GetFoodcountbyIDCategory(item.Id));
            }
        }

        private void iconButtonThemDM_Click(object sender, EventArgs e)
        {
            fThemDanhMuc f = new fThemDanhMuc(this);
            f.ShowDialog();
        }

        private void iconButtonCapnhatDM_Click(object sender, EventArgs e)
        {
            if(dataGridViewDanhMuc.SelectedCells.Count > 0)
            {
                string id = dataGridViewDanhMuc.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
                FoodCategory cate = FoodCategoryBLL.Instance.GetFoodCategorybyIDCate(id);
                fCapNhatDanhMuc f = new fCapNhatDanhMuc(cate, this);
                f.ShowDialog();
            }
        }

        private void iconButtonXoaDM_Click(object sender, EventArgs e)
        {
            if (dataGridViewDanhMuc.SelectedCells.Count > 0)
            {

                int soluongmon = (int)dataGridViewDanhMuc.SelectedCells[0].OwningRow.Cells[2].Value;
                if (soluongmon != 0)
                {
                    MessageBox.Show("Bạn không thể xoá danh mục đang có sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string id = dataGridViewDanhMuc.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
                string name = FoodCategoryBLL.Instance.GetNameCategorybyIDcate(id);
                if (MessageBox.Show("Bạn chắc chắn muốn xoá danh mục " + name + "?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    FoodCategoryBLL.Instance.XoaDanhMuc(id);
                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataGrid();
                }
            }

        }

        private void textBoxCateName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCateName.Text != "Nhập ID hoặc tên danh mục")
            {
                if (textBoxCateName.Text.Contains("Nhập ID hoặc tên danh mục"))
                {
                    textBoxCateName.Text = textBoxCateName.Text.Replace("Nhập ID hoặc tên danh mục", "");
                    textBoxCateName.SelectionStart = 1;
                }
            }
            if (textBoxCateName.Text == "")
            {
                textBoxCateName.Text = "Nhập ID hoặc tên danh mục";
                textBoxCateName.ForeColor = Color.Gray;
                return;
            }
            textBoxCateName.ForeColor = Color.Black;
        }


        private void textBoxCateName_Click(object sender, EventArgs e)
        {
            if (textBoxCateName.Text == "Nhập ID hoặc tên danh mục")
                textBoxCateName.SelectionStart = 0;
        }

        private void iconButtonTimkiem_Click(object sender, EventArgs e)
        {
            string namecate = textBoxCateName.Text.Trim();
            if (namecate.Equals("Nhập ID hoặc tên danh mục")) namecate = "";
            DataTable table = FoodCategoryBLL.Instance.TimKiemDanhMuc(namecate);
            dataGridViewDanhMuc.Rows.Clear();
            foreach (DataRow row in table.Rows)
            {
                dataGridViewDanhMuc.Rows.Add(row["id"], row["name"]);
            }
        }
    }
}
