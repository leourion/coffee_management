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
    public partial class fCapNhatDanhMuc : Form
    {
        private fDanhMuc fdm;
        private FoodCategory category;
        public fCapNhatDanhMuc(FoodCategory category, fDanhMuc fdm)
        {
            this.category = category;
            this.fdm = fdm;
            InitializeComponent();
        }

        private void iconButtonCapnhatDm_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên danh mục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string name = textBoxName.Text.Trim();
            if(FoodCategoryBLL.Instance.checkCategoryExist(name))
            {
                MessageBox.Show("Danh mục đã tồn tại", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FoodCategoryBLL.Instance.CapNhatDanhMuc(name, category.Id);
            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fdm.loadDataGrid();
            this.Close();
        }

        private void fCapNhatDanhMuc_Load(object sender, EventArgs e)
        {
            textBoxName.Text = category.Name;
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
