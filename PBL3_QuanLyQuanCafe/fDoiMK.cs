
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
    public partial class fDoiMK : Form
    {
        fNhanVien nv = new fNhanVien();
        private Account loginAccount;
        public Account LoginAccount
        {

            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        public fDoiMK(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }
        void ChangeAccount(Account acc)
        {
            txtName.Text = loginAccount.Displayname;
            txtPhone.Text = loginAccount.Phonenumber;
            txtAccount.Text = loginAccount.Username;

        }
        void UpdateAccount()
        {
            string sdt = txtPhone.Text;
            string taikhoan = txtAccount.Text;
            string matkhau = txtPassword.Text;
            string newmatkhau = txtNewPass.Text;
            string laplaimatkhau = txtReenterPass.Text;

            if (MessageBox.Show("Bạm có chắc muốn chỉnh sửa thông tin không?", "Sửa thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (!newmatkhau.Equals(laplaimatkhau))
                {
                    MessageBox.Show("Mật khẩu nhập lại khác với mật khẩu mới!");
                }
                else
                {
                    if (AccountDAL.Instance.UpdateAccount(taikhoan, sdt, matkhau, newmatkhau))
                    {
                        MessageBox.Show("Cập nhật thành công.");
                        nv.LoadDatagrid();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu sai!");
                    }
                }
            }
        }


        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void Clear()
        {
            txtPassword.Clear();
            txtNewPass.Clear();
            txtReenterPass.Clear();
        }

        private void iconButtonUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }

        private void iconButtonCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
