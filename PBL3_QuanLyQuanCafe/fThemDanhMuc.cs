using PBL3_QuanLyQuanCafe.BLL;
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
    public partial class fThemDanhMuc : Form
    {
        private fDanhMuc fdm;
        public fThemDanhMuc(fDanhMuc fdm)
        {
            this.fdm = fdm;
            InitializeComponent();
        }

        private void iconButtonThemDm_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên danh mục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string name = textBoxName.Text.Trim();
            if(FoodCategoryBLL.Instance.checkCategoryExist(name))
            {
                MessageBox.Show("Tên danh mục đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FoodCategoryBLL.Instance.ThemDanhMuc(name);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fdm.loadDataGrid();
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
