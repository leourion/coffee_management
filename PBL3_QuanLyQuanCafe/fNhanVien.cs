using PBL3_QuanLyQuanCafe.BLL;
using PBL3_QuanLyQuanCafe.DAL;
using PBL3_QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_QuanLyQuanCafe
{
    public partial class fNhanVien : Form
    {
        string title = "Hệ thống quản lý quán cafe";
        public fNhanVien()
        {
            InitializeComponent();
            LoadDatagrid();
            comboBoxDanhMuc.SelectedIndex = 0;
        }

        public void LoadDatagrid()
        {
            dgvEmployer.Rows.Clear();
            DataTable table = AccountBLL.Instance.GetListAccount();
            int i = 0;
            foreach (DataRow row in table.Rows)
            {
                i++;
                string name = row["displayname"].ToString();
                string phone = row["phonenumber"].ToString();
                string addr = row["address"].ToString();
                string sex = row["sex"].ToString();
                DateTime? birth = (DateTime?)row["dateofbirth"];
                string vaitro = row["type"].ToString();
                int luong = (int)row["salary"];
                string username = row["username"].ToString();
                string password = row["password"].ToString();
                dgvEmployer.Rows.Add(i, name, phone, addr, sex, birth, vaitro, luong, username, password);
            }
        }


        private void iconButtonThemSP_Click(object sender, EventArgs e)
        {
            fThemNhanVien modun = new fThemNhanVien(this);
            modun.iconButtonUpdate.Enabled = false;
            modun.ShowDialog();

        }

        private void iconButtonTimkiem_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string vaitro = comboBoxDanhMuc.Text.Trim();
            if (name.Equals("Nhập tên nhân viên")) name = "";
            if (vaitro.Equals("Tất cả")) vaitro = "";
            dgvEmployer.Rows.Clear();
            DataTable table = AccountBLL.Instance.Timkiemnhanvien(name, vaitro);
            int i = 0;
            foreach (DataRow row in table.Rows)
            {
                i++;
                string displayname = row["displayname"].ToString();
                string phone = row["phonenumber"].ToString();
                string addr = row["address"].ToString();
                string sex = row["sex"].ToString();
                DateTime? birth = (DateTime?)row["dateofbirth"];
                string type = row["type"].ToString();
                int luong = (int)row["salary"];
                string username = row["username"].ToString();
                string password = row["password"].ToString();
                dgvEmployer.Rows.Add(i, displayname, phone, addr, sex, birth, type, luong, username, password);
            }
        }

        #region method
        //Truy vấn dữ liệu

        #endregion
        private void dgvEmployer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvEmployer.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                //Truyền dữ liệu về đăng kí tài khoản
                fThemNhanVien module = new fThemNhanVien(this);
                module.lblEid.Text = dgvEmployer.Rows[e.RowIndex].Cells[0].Value.ToString();
                module.txtName.Text = dgvEmployer.Rows[e.RowIndex].Cells[1].Value.ToString();
                module.txtSdt.Text = dgvEmployer.Rows[e.RowIndex].Cells[2].Value.ToString();
                module.txtAddress.Text = dgvEmployer.Rows[e.RowIndex].Cells[3].Value.ToString();
                module.rdMale.Checked = dgvEmployer.Rows[e.RowIndex].Cells[4].Value.ToString() == "Nam" ? true : false;
                module.dtpDob.Text = dgvEmployer.Rows[e.RowIndex].Cells[5].Value.ToString();
                module.cbRole.Text = dgvEmployer.Rows[e.RowIndex].Cells[6].Value.ToString();
                module.txtLuong.Text = dgvEmployer.Rows[e.RowIndex].Cells[7].Value.ToString();
                module.txtAccount.Text = dgvEmployer.Rows[e.RowIndex].Cells[8].Value.ToString();
                module.txtPassWord.Text = dgvEmployer.Rows[e.RowIndex].Cells[9].Value.ToString();
                module.iconButtonCapnhatSP.Enabled = false;
                module.ShowDialog();

            }
            else if (colName == "Delete")//muốn xóa kích vào biểu tượng xóa
            {
                try
                {
                    if (MessageBox.Show("Bạm có chắc muốn xóa bản ghi không?", "Xóa bản ghi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int check = AccountDAL.Instance.CheckBill(dgvEmployer.Rows[e.RowIndex].Cells[8].Value.ToString());
                        if (check > 0)
                        {
                            if (AccountDAL.Instance.DeleteAccount1(dgvEmployer.Rows[e.RowIndex].Cells[8].Value.ToString()) == true)
                            {
                                MessageBox.Show("Dữ liệu đã được xóa thành công!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadDatagrid();
                            }
                        }
                        else
                        {
                            if (AccountDAL.Instance.DeleteAccount(dgvEmployer.Rows[e.RowIndex].Cells[8].Value.ToString()) == true)
                            {
                                MessageBox.Show("Dữ liệu đã được xóa thành công!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadDatagrid();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, title);
                }
            }
        }


        private void textBoxName_TextChanged_1(object sender, EventArgs e)
        {
            if (textBoxName.Text != "Nhập tên nhân viên")
            {
                if (textBoxName.Text.Contains("Nhập tên nhân viên"))
                {
                    textBoxName.Text = textBoxName.Text.Replace("Nhập tên nhân viên", "");
                    textBoxName.SelectionStart = 1;
                }
            }
            if (textBoxName.Text == "")
            {
                textBoxName.Text = "Nhập tên nhân viên";
                textBoxName.ForeColor = Color.Gray;
                return;
            }
            textBoxName.ForeColor = Color.Black;
        }

        private void textBoxName_Click_1(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Nhập tên nhân viên")
                textBoxName.SelectionStart = 0;
        }
    }
}
