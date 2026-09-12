using PBL3_QuanLyQuanCafe.DAL;
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
    public partial class fThemNhanVien : Form
    {
        fNhanVien NV;
        string title = "Hệ thống quản lý quán cafe";
        bool check = false;
        public fThemNhanVien( fNhanVien nv)
        {
            InitializeComponent();
            NV = nv;
            cbRole.SelectedIndex = 2;//Mặc định là phục vụ
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void iconButtonCapnhatSP_Click(object sender, EventArgs e)
        {
            try
            {
                checkField();
                if (check)
                {
                    if (MessageBox.Show("Bạn có chắc đăng kí tài khoản không?", "Đăng khí tài khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        string name = txtName.Text;
                        string sdt = txtSdt.Text;
                        string dc = txtAddress.Text;
                        DateTime dt = dtpDob.Value;
                        string sex = rdMale.Checked ? "Nam" : "Nữ";
                        string vt = cbRole.Text;
                        int luong = int.Parse(txtLuong.Text);
                        string username = txtAccount.Text;
                        string pass = txtPassWord.Text;
                        if (AccountDAL.Instance.InsertAccount(name, sdt, dc, sex, vt, luong, username, pass, dt))
                        MessageBox.Show("Đăng kí thành công!", title);
                        Clear();//Xóa tất cả trường dữ liệu sau khi nhập vào csdl
                        check = false;
                        NV.LoadDatagrid();//lam mới danh sách khi chèn dữ liệu vào bảng
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }
        //Chức năng xóa các trường
        #region method
        public void Clear()
        {
            txtName.Clear();
            txtSdt.Clear();
            txtAccount.Clear();
            txtAddress.Clear();
            txtPassWord.Clear();
            txtLuong.Clear();
            dtpDob.Value = DateTime.Now;
            cbRole.SelectedIndex = 2;//Mặc định là phục vụ
            
        }
        //Check dữ liệu nhập vào và kiểm tra ngày sinh
        public void checkField()
        {
            if (txtName.Text == "" || txtSdt.Text == "" || txtLuong.Text == "" || txtAccount.Text == "" || txtPassWord.Text == "")
            {
                MessageBox.Show("Dữ liệu nhập bắt buộc!", "Warning");
                return;// trở lại trường dữ liệu và nhập lại
            }
            if (checkAge(dtpDob.Value) < 18)
            {
                MessageBox.Show("Nhân viên dưới 18 tuổi", "Warning");
                return;
            }
            if(AccountDAL.Instance.KtTK(txtAccount.Text) > 0)
            {
                MessageBox.Show("Tài khoản đã tồn tại!", "Warning");
                return;// trở lại trường dữ liệu và nhập lại
            }
            check = true;
        }
        public void checkField1()
        {
            if (txtName.Text == "" || txtSdt.Text == "" || txtLuong.Text == "" || txtAccount.Text == "" || txtPassWord.Text == "")
            {
                MessageBox.Show("Dữ liệu nhập bắt buộc!", "Warning");
                return;// trở lại trường dữ liệu và nhập lại
            }
            if (checkAge(dtpDob.Value) < 18)
            {
                MessageBox.Show("Nhân viên dưới 18 tuổi", "Warning");
                return;
            }
            //if (AccountDAL.Instance.KtTK(txtAccount.Text) > 0)
            //{
            //    MessageBox.Show("Tài khoản đã tồn tại!", "Warning");
            //    return;// trở lại trường dữ liệu và nhập lại
            //}
            check = true;
        }
        //Check tuổi có dưới 18t
        private static int checkAge(DateTime dateofBirth)
        {
            int age = DateTime.Now.Year - dateofBirth.Year;
            if (DateTime.Now.Year < dateofBirth.DayOfYear)
                age = age - 1;
            return age;
        }

        #endregion method

        private void iconButtonCancel_Click(object sender, EventArgs e)
        {
            Clear();
            iconButtonUpdate.Enabled = false;
            iconButtonCapnhatSP.Enabled = true;
        }

        private void iconButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                checkField1();
                if (check)
                {
                    if (MessageBox.Show("Bạn có chắc sửa thông tin tài khoản không?", "Chỉnh sửa tài khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string username1 = NV.dgvEmployer.Rows[int.Parse(lblEid.Text) - 1].Cells[8].Value.ToString();
                        string name = txtName.Text;
                        string sdt = txtSdt.Text;
                        string dc = txtAddress.Text;
                        DateTime? dt = dtpDob.Value;
                        string sex = rdMale.Checked ? "Nam" : "Nữ";
                        string vt = cbRole.Text;
                        int luong = int.Parse(txtLuong.Text);
                        string username = txtAccount.Text;
                        string pass = txtPassWord.Text;
                        
                        if (AccountDAL.Instance.UpdateAccount(name, sdt, dc, sex, vt, luong, username, pass, dt,username1))
                        MessageBox.Show("Đăng kí thành công!", title);
                        Clear();//Xóa tất cả trường dữ liệu sau khi nhập vào csdl
                        this.Dispose();
                        NV.LoadDatagrid();//lam mới danh sách khi chèn dữ liệu vào bảng
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //SDt chỉ cho phép nhập số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
