Console.WriteLine("PHAM THANH TIEN\nMa sinh vien: 2415053122341\n");

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
var bai6 = numbers.Count(x => x%2==0);

Console.WriteLine("Co {0} so chan trong danh sach",bai6);