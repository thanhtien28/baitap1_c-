using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuan5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("\nPHAM THANH TIEN \n MSV 2416053122341");
            List<sinhvien> danhsach = new List<sinhvien>();
            danhsach.Add(new sinhvien("An", 18, 1, 8.5f, "cns"));
            danhsach.Add(new sinhvien("Binh", 19, 2, 7.2f, "ddt"));
            danhsach.Add(new sinhvien("Cuong", 20, 3, 9.0f, "hhc"));
            danhsach.Add(new sinhvien("Dung", 21, 4, 6.8f, "cns"));
            danhsach.Add(new sinhvien("Giang", 18, 1, 5.5f, "ddt"));
            danhsach.Add(new sinhvien("Hoa", 19, 2, 8.0f, "hhc"));
            danhsach.Add(new sinhvien("Khoa", 20, 3, 7.9f, "cns"));
            danhsach.Add(new sinhvien("Linh", 21, 4, 9.5f, "ddt"));
            danhsach.Add(new sinhvien("Minh", 22, 4, 4.5f, "hhc"));
            danhsach.Add(new sinhvien("Nam", 19, 1, 6.2f, "cns"));
            int max = danhsach.Max(s => s.tuoi);
            int min = danhsach.Min(s => s.tuoi);
            Console.WriteLine("Câu 1:");
            Console.WriteLine("Tuổi lớn nhất: " + max);
            Console.WriteLine("Tuổi nhỏ nhất: " + min);
            var svcns = danhsach.Where(s => s.khoa == "cns").ToList();
            Console.WriteLine("Câu 2:");
            Console.WriteLine("Danh sách sinh viên khoa CNS:");
            foreach (var sv in svcns)
            {
                Console.WriteLine(sv.ten + " - " + sv.tuoi + " tuổi - " + sv.namhoc + " năm học - " + sv.dtb + " điểm trung bình");
            }
            var top10 = danhsach.OrderByDescending(s => s.dtb).Take(10).ToList();
            Console.WriteLine("Câu 3:");
            Console.WriteLine("10 sinh viên có điểm trung bình cao nhất:");
            foreach (var sv in top10)
            {
                Console.WriteLine(sv.ten + " - " + sv.tuoi + " tuổi - " + sv.namhoc + " năm học - " + sv.dtb + " điểm trung bình");
            }
            var nocuoi = danhsach.Where(s => s.namhoc != 4).ToList();
            Console.WriteLine("Câu 4:");
            Console.WriteLine("Danh sách sinh viên chưa có năm học cuối:");
            foreach (var sv in nocuoi)
            {
                Console.WriteLine(sv.ten + " - " + sv.tuoi + " tuổi - " + sv.namhoc + " năm học - " + sv.dtb + " điểm trung bình");
            }

        }
    }
}

