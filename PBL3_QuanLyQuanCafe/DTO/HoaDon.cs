using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyQuanCafe.DTO
{
    public class HoaDon
    {
        private string idmon;
        private string tenmon;
        private int soluong;
        private int dongia;
        private int thanhtien;

        public string Tenmon { get => tenmon; set => tenmon = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Dongia { get => dongia; set => dongia = value; }
        public int Thanhtien { get => thanhtien; set => thanhtien = value; }
        public string Idmon { get => idmon; set => idmon = value; }

        public HoaDon(string idmon, string tenmon, int soluong, int dongia, int thanhtien)
        {
            this.idmon = idmon;
            this.tenmon = tenmon;
            this.soluong = soluong;
            this.dongia = dongia;
            this.thanhtien = thanhtien;
        }
    }
}
