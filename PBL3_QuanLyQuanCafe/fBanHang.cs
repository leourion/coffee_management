using FontAwesome.Sharp;
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
    public partial class fBanHang : Form
    {
        private Account account;
        public fBanHang(Account account)
        {
            this.account = account;
            InitializeComponent();
            HienThiBanLenPanel();
            HienThiDanhMuc();
        }

        public void HienThiHoaDon(string idtable)
        {
            List<HoaDon> listhd = HoaDonBLL.Instance.GetlistHoaDon(idtable);
            listViewHoadon.Items.Clear();
            int tongtien = 0;
            foreach (HoaDon item in listhd)
            {
                ListViewItem lvi = new ListViewItem(item.Tenmon);
                lvi.SubItems.Add(item.Soluong.ToString());
                lvi.SubItems.Add(item.Dongia.ToString());
                lvi.SubItems.Add(item.Thanhtien.ToString());
                lvi.Tag = item.Idmon;
                listViewHoadon.Items.Add(lvi);
                tongtien += item.Thanhtien;
            }
            //CultureInfo culture = new CultureInfo("vi-VN");
            //txtTongTien.Text = tongtien.ToString("c", culture);
            txtTongTien.Text = tongtien.ToString();
        }

        private void HienThiDanhMuc()
        {
            comboBoxDanhmuc.DataSource = FoodCategoryBLL.Instance.GetListFoodCategory();
            comboBoxDanhmuc.DisplayMember = "name";
        }

        public void HienThiBanLenPanel()
        {
            flowpanelTable.Controls.Clear();
            List<Table> list = TableBLL.Instance.Getlisttable();
            foreach (Table item in list)
            {
                IconButton button = new IconButton();
                button.Size = new Size(90,90);
                button.BackColor = Color.WhiteSmoke;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                
                
                //button.IconChar = IconChar.MugHot;
                //button.IconChar = IconChar.Coffee;
                button.TextImageRelation = TextImageRelation.ImageAboveText;
                button.Text = item.Name + Environment.NewLine + item.Status;

                button.Click += Button_Click;
                button.Tag = item;

                if (item.Status == "Trống")
                {
                    button.IconChar = IconChar.Coffee;
                    button.ForeColor = Color.Black;
                }
                else
                {
                    button.IconChar = IconChar.MugHot;
                    button.ForeColor = Color.OrangeRed;
                    button.IconColor = Color.OrangeRed;
                }
                flowpanelTable.Controls.Add(button);
            }
        }
        IconButton tmp = null;
        private void Button_Click(object sender, EventArgs e)
        {
            if(tmp != null)
                tmp.FlatAppearance.BorderSize = 0;
            (sender as Button).FlatAppearance.BorderColor = Color.OrangeRed;
            (sender as Button).FlatAppearance.BorderSize = 1;
            tmp = sender as IconButton;


            string idTable = ((sender as Button).Tag as Table).Id;
            listViewHoadon.Tag = (sender as Button).Tag;
            HienThiHoaDon(idTable);
            labelTieude.Text = "Hoá đơn của: " + ((sender as Button).Tag as Table).Name;
        }

        private void comboBoxDanhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDanhmuc.SelectedIndex == -1)
                return;
            flowpanelMenu.Controls.Clear();
            FoodCategory foodCategory = comboBoxDanhmuc.SelectedItem as FoodCategory;
            string iddm = foodCategory.Id;
            List<Food> listfood = FoodBLL.Instance.GetlistFoodexist1byIdCategory(iddm);
            foreach (Food food in listfood)
            {
                Button buton = new Button();
                buton.Size = new Size(120, 120);

                if (food.Image != null)
                {
                    using (var ms = new MemoryStream(food.Image))
                    {
                        Image image = Image.FromStream(ms);
                        buton.BackgroundImageLayout = ImageLayout.Stretch;
                        buton.BackgroundImage = image;
                    }
                }
                buton.Click += Buton_Click;
                buton.Tag = food;


                Panel pan = new Panel();
                pan.Size = new Size(120, 160);
                //pan.BackColor = Color.Violet;

                Label label = new Label();
                label.Size = new Size(120, 40);
                label.Text = food.Name;
                label.Font = new Font(pan.Font.FontFamily, 9);
                label.TextAlign = ContentAlignment.TopCenter;
                label.BackColor = Color.Violet;

                pan.Controls.Add(buton);
                buton.Dock = DockStyle.Top;
                pan.Controls.Add(label);
                label.Dock = DockStyle.Bottom;

                flowpanelMenu.Controls.Add(pan);
            }
        }

        private void Buton_Click(object sender, EventArgs e)
        {
            txtTongTien.Tag = (sender as Button).Tag as Food;
        }

        private void iconButtonThemmon_Click(object sender, EventArgs e)
        {
            if (listViewHoadon.Tag == null) return;
            if(txtTongTien.Tag == null) return;
            Table table = listViewHoadon.Tag as Table;
            string idTable = table.Id;
            string idfood = (txtTongTien.Tag as Food).Id;
            int count = (int)numericUpDown.Value;

            BillBLL.Instance.ThemMontheo_IdTable(idTable, idfood, count);

            BillBLL.Instance.CapNhatstatusTable(idTable);
            HienThiBanLenPanel();

            HienThiHoaDon(table.Id);

            numericUpDown.Value = 1;

            txtTongTien.Tag = null;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (listViewHoadon.Tag == null)
                return;
            Table table = listViewHoadon.Tag as Table;
            string idbill = BillBLL.Instance.LayIDBillChuaThanhToanTheoIDTable(table.Id);
            if (idbill == "-1")
                return;
            //Table table = listViewHoadon.Tag as Table;
            //string idbill = BillBLL.Instance.LayIDBillChuaThanhToanTheoIDTable(table.Id);
            //if (idbill != "-1")
            //{
            //    if (MessageBox.Show("Bạn muốn thanh toán cho " + table.Name + " ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            //    {
            //        //double totalprice = Convert.ToDouble(txtTongTien.Text.Split(',')[0]);
            //        //MessageBox.Show(txtTongTien.Text);
            //        BillBLL.Instance.ThanhToan(table.Id, Convert.ToInt32(txtTongTien.Text), account.Username);
            //        BillBLL.Instance.CapNhatstatusTable(table.Id);
            //        HienThiBanLenPanel();
            //        HienThiHoaDon(table.Id);
            //        MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            int discount = (int)nmDiscount.Value;
            double totalPrice = double.Parse(txtTongTien.Text);
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;
            settlePayment module = new settlePayment(this, account);
            module.txtSale.Text = finalTotalPrice.ToString();
            module.ShowDialog();
        }

        private void iconButtonXoamon_Click(object sender, EventArgs e)
        {
            /* - nếu bàn chưa tồn tại bill chưa thanh toán => return
                   - nếu bàn đã tồn tại bill chưa thanh toán - LayIDBillChuaThanhToanTheoIDTable(idtable) != -1
                            + nếu có chọn trên listview: if(lv.selecteditem != null)
                                => - kiểm tra nếu số lượng món này trong bảng billinfor = 1 (món này chỉ có trong billinfo hiện tại) : T = 1
                                   - xoá billinfor(món) đó đi, hiển thị lại listview
                                   - Nếu T = 1
                                        + kiểm tra món này trong bảng food nếu có exist = 0 thì xoá món này trong bảng food
                                        (tại vì chức năg xoá món trong bảng food ta chưa biết được nếu món này có trong billinfo thì 
                                        bill chứa món này có sẽ được thanh toán hay không)
                                => - nếu xoá tất cả các món trong bill => xoá bill (Huỷ đặt bàn) -> xử lý trong hàm XoaBillInfor_XoaMon()
                */
            if (listViewHoadon.SelectedItems.Count == 0) return;
            Table table = listViewHoadon.Tag as Table;
            string idtable = table.Id;

            if (BillBLL.Instance.LayIDBillChuaThanhToanTheoIDTable(idtable) != null)
            {
                if (listViewHoadon.SelectedItems != null)
                {
                    string idbill = BillBLL.Instance.LayIDBillChuaThanhToanTheoIDTable(idtable);
                    ListViewItem lvi = listViewHoadon.SelectedItems[0];
                    string idfood = lvi.Tag.ToString();
    
                    //int idfood = BillBLL.Instance.GetIdFoodbyNameFood(lvi.SubItems[0].Text);
                    BillBLL.Instance.XoaBillInfor_XoaMon(idbill, idfood);

                    HienThiHoaDon(idtable);
                }
            }

            BillBLL.Instance.CapNhatstatusTable(idtable);
            HienThiBanLenPanel();
        }

        private void iconButtonHuyHoaDon_Click(object sender, EventArgs e)
        {
            if(listViewHoadon.Tag == null) 
                return;
            Table table = listViewHoadon.Tag as Table;         
            if (BillBLL.Instance.LayIDBillChuaThanhToanTheoIDTable(table.Id) != "-1")
            {
                if (MessageBox.Show("Bạn muốn huỷ hoá đơn của " + table.Name + "?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    BillBLL.Instance.HuyHoaDon(table.Id);
                    // cập nhật trạng thái bàn
                    BillBLL.Instance.CapNhatstatusTable(table.Id);
                    HienThiHoaDon(table.Id);
                    HienThiBanLenPanel();
                    MessageBox.Show("Huỷ hoá đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
