Console.WriteLine("PHAM THANH TIEN\nMa sinh vien: 2415053122341\n");

List<int> numbers = new List<int> { 1, 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5};
var bai19 = numbers.GroupBy(x => x).OrderByDescending(x => x.Count()).First();
Console.WriteLine($"Phan tu xuat hien nhieu nhat la: {bai19.Key}\nSo lan xuat hien: {bai19.Count()}");
