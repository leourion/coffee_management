using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyQuanCafe.DTO
{
    public class BillInfo
    {
        private int id;
        private string idbill;
        private string idfood;
        private int count;

        public int Id { get => id; set => id = value; } 
        public int Count { get => count; set => count = value; }
        public string Idbill { get => idbill; set => idbill = value; }
        public string Idfood { get => idfood; set => idfood = value; }

        public BillInfo(int id, string idbill, string idfood, int count)
        {
            this.id = id;
            this.idbill = idbill;
            this.idfood = idfood;
            this.count = count;
        }
    }
}
