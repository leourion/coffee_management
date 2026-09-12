using PBL3_QuanLyQuanCafe.BLL;
using PBL3_QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_QuanLyQuanCafe
{
    public partial class FCapNhatSanPham : Form
    {
        private fSanPham fsp;
        private Food food;
        /*
        private string name;
        private int idcategory;
        private string unit;
        private int price;
        //private Image image;*/
        public FCapNhatSanPham(Food food, fSanPham fsp)
        {
            InitializeComponent();
            this.food = food;
            this.fsp = fsp;
            /* this.name = name;
             this.idcategory = idcategory;
             this.unit = unit;
             this.price = price;
             //this.image = image;*/
            LoadMaDanhMuc();
        }
        void LoadMaDanhMuc()
        {
            List<FoodCategory> listdm = FoodCategoryBLL.Instance.GetListFoodCategory();
            comboBoxidCategory.DataSource = listdm;
            comboBoxidCategory.DisplayMember = "Name";
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FCapNhatSanPham_Load(object sender, EventArgs e)
        {
            textBoxName.Text = food.Name;
            textBoxUnit.Text = food.Unit;
            comboBoxidCategory.Text = FoodCategoryBLL.Instance.GetNameCategorybyIDcate(food.IdCategory);
            textBoxPrice.Text = food.Price.ToString();
            //pictureBox1.Image = food.Image.ToString();
            if (food.Image != null)
            {
                using (var ms = new MemoryStream(food.Image))
                {
                    Image image = Image.FromStream(ms);
                    pictureBox1.Image = image;
                }
            }            
        }

        private void iconButtonChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void iconButtonCapnhatSP_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên món", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxUnit.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đơn vị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxPrice.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        


            string name = textBoxName.Text.ToString().Trim();
            FoodCategory dm = comboBoxidCategory.SelectedItem as FoodCategory;
            string idcate = dm.Id;
            string unit = textBoxUnit.Text.ToString().Trim();
            int price = int.Parse(textBoxPrice.Text);
            if (pictureBox1.Image != null)
            {
                //MessageBox.Show("co anh");
                Image image = pictureBox1.Image;
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(image, typeof(byte[]));
                FoodBLL.Instance.CapNhatSanPham(food, name, idcate, unit, price, arr);
            }
            else
            {
                //MessageBox.Show("k co anh");
                FoodBLL.Instance.CapNhatSanPham(food, name, idcate, unit, price);
            }
            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fsp.loadDataGrid();
            this.Close();
            /*
            textBoxName.Text = "";
            textBoxUnit.Text = "";
            textBoxPrice.Text = "";
            pictureBox1.Image = null;*/

        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Đơn giá là số ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void iconButtonBochonanh_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
