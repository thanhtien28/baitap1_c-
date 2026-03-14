Console.WriteLine("PHAM THANH TIEN\nMa sinh vien: 2415053122341\n");

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
var bai5 = numbers.Select(x => x * x).ToList();

Console.Write("Danh sach binh phuong: ");
bai5.ForEach(x=> Console.Write(x +" "));