using FontAwesome.Sharp;
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
    public partial class fMain : Form
    {
        private DateTime dateLogin = new DateTime();
        private DateTime dateLogout = new DateTime();
        private Account accountLogin;

        public Account AccountLogin
        {
            get => accountLogin;
            set
            {
                accountLogin = value;
                //LockTabAdmin_PhanQuyen(accountLogin.Type);
            }
        }
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public fMain(Account acc)
        {
            this.AccountLogin = acc;
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 65);
            panelMenu.Controls.Add(leftBorderBtn);
            LockTabAdmin_PhanQuyen(accountLogin.Type);
            labelHello.Text = "Xin chào " + accountLogin.Displayname;
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblDay.Text = DateTime.Now.ToString("hh:mm:ss tt");
            dateLogin = DateTime.Now;
        }
        void LockTabAdmin_PhanQuyen(string type)
        {
            if (AccountLogin.Type != "Quản Lý") // nếu là nhân viên thì không thể thao tác các chức năng của quản lý có thể thao tác được
            {
                iconButtonNhanvien.Hide();
                iconButtonDanhMuc.Hide();
                iconButtonSanpham.Hide();
                iconButtonBan.Hide();
                iconButtonThongKe.Hide();
                iconButtonLuong.Hide();
                iconButtonHoaDon.Hide();


            }
            //tàiKhoảnToolStripMenuItem.Text += " (" + accountLogin.Displayname + ")";
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                // icon form con hien tai
                iconFormConHienTai.IconChar = currentBtn.IconChar;
                iconFormConHienTai.ForeColor = color;
                // lable tieu de
                labelTieuDe_FormCon.Text = currentBtn.Text;
                labelTieuDe_FormCon.ForeColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form ChildForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;    
            panelDesktop.Controls.Add(ChildForm);
            panelDesktop.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show(); 

        }
        private void iconButtonBanhang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new fBanHang(accountLogin));
        }

        private void iconButtonNhanvien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new fNhanVien());
        }

        private void iconButtonDanhMuc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new fDanhMuc());
        }

        private void iconButtonSanpham_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new fSanPham());
        }

        private void iconButtonBan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new fBan());
        }
        private void iconButtonThongKe_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new ChartForm());

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                Reset();
            }
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconFormConHienTai.IconChar = IconChar.Home;
            iconFormConHienTai.ForeColor = Color.MediumPurple;
            labelTieuDe_FormCon.Text = "Home";
            labelTieuDe_FormCon.ForeColor = Color.MediumPurple;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                dateLogout = DateTime.Now;
                string salary = accountLogin.Salary.ToString();
                TimeKeepingBLL.Instance.InsertTimeKeeping(accountLogin.Username, salary, dateLogin, dateLogout);
                this.Close();
            }
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            fDoiMK MK = new fDoiMK(accountLogin);
            MK.ShowDialog();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new SalaryForm());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new BillForm());
        }
    }
}
