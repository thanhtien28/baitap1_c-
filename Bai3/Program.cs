Console.WriteLine("PHAM THANH TIEN\nMa sinh vien: 2415053122341\n");

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
var bai3 = numbers.OrderBy(x => x).ToList();

Console.Write("Danh sach tang dan: ");
bai3.ForEach(x => Console.Write(x + " "));

