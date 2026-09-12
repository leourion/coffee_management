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
    public partial class fThemBan : Form
    {
        private fBan fban;
        public fThemBan(fBan fban)
        {
            this.fban = fban;
            InitializeComponent();
        }

        private void iconButtonThemDm_Click(object sender, EventArgs e)
        {
            int soluong = (int)numericUpDown1.Value;
            if (MessageBox.Show("Bạn muốn thêm " +soluong+ " bàn?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                TableBLL.Instance.ThemBan(soluong);
                fban.LoadDataGrid();
                this.Close();
                MessageBox.Show("Thêm " + soluong + " bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fThemBan_Load(object sender, EventArgs e)
        {
            labelSoLuongBanHienTai.Text = "*Số lượng bàn hiện tại: " + TableBLL.Instance.SoLuongBanHienTai().ToString();
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //chỉ cho phép nhập số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}
