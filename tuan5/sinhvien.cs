using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuan5
{
    public class sinhvien
    {
        public string ten { get; set; }
        public int tuoi { get; set; }
        public int namhoc { get; set; }
        
        public float  dtb { get; set; }
        public string khoa { get; set; }
        public sinhvien(string ten, int tuoi, int namhoc, float dtb, string khoa)
        {
            this.ten = ten;
            this.tuoi = tuoi;
            this.namhoc = namhoc;
            this.dtb = dtb;
            this.khoa = khoa;
        }
    }
}
