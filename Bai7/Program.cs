Console.WriteLine("PHAM THANH TIEN\nMa sinh vien: 2415053122341\n");

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8};
var bai7 = numbers.Any(x => x > 10);

Console.WriteLine(bai7 ? "Co so lon hon 10" : "Khong co so lon hon 10");