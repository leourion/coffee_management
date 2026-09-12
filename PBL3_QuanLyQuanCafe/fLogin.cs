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
    public partial class fLogin : Form
    {
        private static bool iconbuttonshow_Bringtofront = true;
        
        public fLogin()
        {
            InitializeComponent();
            iconButtonHide.Hide();
            iconButtonShow.Hide();
            txtUsername.SelectionStart = 0;
        /*    if(txtPassword.Text == "Enter Password")
            {
                txtPassword.PasswordChar = '\0';
                iconButtonHide.Hide();
                iconButtonShow.Hide();
            } */
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text != "Enter Username")
                {
                    if (txtUsername.Text.Contains("Enter Username"))
                    {
                        txtUsername.Text = txtUsername.Text.Replace("Enter Username", "");
                        txtUsername.SelectionStart = 1;
                    }
                }
                if (txtUsername.Text == "")
                {
                    txtUsername.Text = "Enter Username";
                    txtUsername.ForeColor = Color.Gray;
                    return;
                }
                txtUsername.ForeColor = Color.White;
                label3.Visible = false;
            }
            catch { }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text != "Enter Password")
                {
                    if(iconbuttonshow_Bringtofront)    //
                    {
                        txtPassword.PasswordChar = '*';//
                    }
                    else                                  //     
                    {
                        txtPassword.PasswordChar = '\0';   //
                    }                                      //
                    
                    iconButtonHide.Show();  //
                    iconButtonShow.Show();  //
                    if (txtPassword.Text.Contains("Enter Password"))
                    {
                        txtPassword.Text = txtPassword.Text.Replace("Enter Password", "");
                        txtPassword.SelectionStart = 1;
                    }
                }
                else
                {
                    txtPassword.PasswordChar = '\0';
                    iconButtonHide.Hide();  //
                    iconButtonShow.Hide();  //
                }
                if (txtPassword.Text == "")
                {     
                    txtPassword.Text = "Enter Password";
                    txtPassword.ForeColor = Color.Gray;
                    return;
                }
                txtPassword.ForeColor = Color.White;
                label4.Visible = false;
            }
            catch { }
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            //txtUsername.SelectAll();
            if (txtUsername.Text == "Enter Username")
            {
                txtUsername.SelectionStart = 0;
            }
        }


        private void txtPassword_Click(object sender, EventArgs e)
        {
            //txtPassword.SelectAll();
            if (txtPassword.Text == "Enter Password")
            {
                txtPassword.SelectionStart = 0;
            }
        }

        private void buttonLogin_MouseEnter(object sender, EventArgs e)
        {
            buttonLogin.ForeColor = Color.Black;
        }

        private void buttonLogin_MouseLeave(object sender, EventArgs e)
        {
            buttonLogin.ForeColor = Color.Lime;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (username == "Enter Username")
            {
                label3.Visible = true;
                txtUsername.Focus();
                return;
            }
            if (password == "Enter Password")
            {
                label4.Visible = true;
                txtPassword.Focus();
                return;
            }

            if(Login(username, password))
            {
                Account loginAccount = AccountBLL.Instance.GetAccountByUsername(username);
                fMain formMain = new fMain(loginAccount);
                this.Hide();
                formMain.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }           
        }

        private bool Login(string username, string password)
        {
            return AccountBLL.Instance.Login(username, password);
        }

        private void iconButtonShow_Click(object sender, EventArgs e)
        {         
           // if (txtPassword.PasswordChar == '*')
           // {
                iconButtonHide.BringToFront();
                txtPassword.PasswordChar = '\0';
            iconbuttonshow_Bringtofront = false;
           // }
        }

        private void iconButtonHide_Click(object sender, EventArgs e)
        {
           // if (txtPassword.PasswordChar == '\0')
           // {
                iconButtonShow.BringToFront();
                txtPassword.PasswordChar = '*';
            iconbuttonshow_Bringtofront = true;
            // }
        }

        private void buttonExit_MouseEnter(object sender, EventArgs e)
        {
            buttonExit.ForeColor = Color.Black;
        }

        private void buttonExit_MouseLeave(object sender, EventArgs e)
        {
            buttonExit.ForeColor = Color.Red;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
