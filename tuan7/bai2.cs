using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuan7
{
    internal class bai2
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Product> list = new List<Product>() 
                {
                    new Product(1, "Cà phê Đen", 20000, "Cà phê"),
                    new Product(2, "Cà phê Sữa", 25000, "Cà phê"),
                    new Product(3, "Trà Đào Cam Sả", 35000, "Trà"),
                    new Product(4, "Trà Sữa Trân Châu", 40000, "Trà sữa"),
                    new Product(5, "Bánh Mì Muối Ớt", 30000, "Thức ăn"),
                    new Product(6, "Bánh Tiramisu", 45000, "Thức ăn")
                };
            Console.WriteLine("cau 2");
            foreach (Product item in list)
            {
                Console.WriteLine(item.Id + " "+item.Name+" "+item.Price+" "+item.Category);
            }
            Console.WriteLine("\ncau 3");
            Console.WriteLine("\ncau 3.1");
            List<Product> ba1 = list.Where(n=> n.Price>500).ToList();
            foreach (Product item in ba1)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Price + " " + item.Category);
            }
            Console.WriteLine("\ncau 3.2");
            List<Product> ba2 = list.OrderBy(n=> n.Price).ToList();
            foreach (Product item in ba2)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Price + " " + item.Category);
            }
            Console.WriteLine("\ncau 3.3");
            List<Product> ba3 = list.Take(3).ToList();
            foreach (Product item in ba2)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Price + " " + item.Category);
            }
            Console.WriteLine("\ncau 3.4");
            Console.WriteLine("nhap ten san pha muon tim");
            String ten=Console.ReadLine();
            var searchResult = list.Where(p => p.Name.ToLower().Contains(ten.ToLower())).ToList();

            Console.WriteLine($"\n Kết quả tìm kiếm cho từ khóa: '{ten}'");

            if (searchResult.Count > 0)
            {
                foreach (var item in searchResult)
                {
                    Console.WriteLine($"ID: {item.Id} | Tên: {item.Name} | Giá: {item.Price}");
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy sản phẩm nào phù hợp!");
            }
            double tongGiaTri = list.Sum(p => p.Price);
            double giaTrungBinh = list.Average(p => p.Price);
            Console.WriteLine($"Tổng giá trị : {tongGiaTri} ");
            Console.WriteLine($"Giá trung bình sản phẩm: {giaTrungBinh} ");
        }
    }
}
