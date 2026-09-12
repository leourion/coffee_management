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
    public partial class fThemSanPham : Form
    {
        private fSanPham fsp;
        public fThemSanPham(fSanPham fsp)
        {
            this.fsp = fsp;
            InitializeComponent();
            LoadMaDanhMuc();
        }

        void LoadMaDanhMuc()
        {
            List<FoodCategory> listdm = FoodCategoryBLL.Instance.GetListFoodCategory();
            comboBoxidCategory.DataSource = listdm;
            comboBoxidCategory.DisplayMember = "Name";
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void iconButtonThemSp_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text.Trim() == "")
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
            if (FoodBLL.Instance.checknamefoodexist(name))
            {
                MessageBox.Show("Tên món đã tồn tại!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FoodCategory dm = comboBoxidCategory.SelectedItem as FoodCategory;
            string idcate = dm.Id;
            string unit = textBoxUnit.Text.ToString().Trim();
            int price = int.Parse(textBoxPrice.Text);
            if (pictureBox1.Image != null)
            {
                Image image = pictureBox1.Image;
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(image, typeof(byte[]));
                FoodBLL.Instance.ThemSanPham(name, idcate, unit, price, arr);
            }
            else
                FoodBLL.Instance.ThemSanPham(name, idcate, unit, price);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fsp.loadDataGrid();

            textBoxName.Text = "";
            textBoxUnit.Text = "";
            textBoxPrice.Text = "";
            pictureBox1.Image = null;

        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //chỉ cho phép nhập số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Đơn giá là số ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void iconButtonBochonanh_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

       
    }
}
