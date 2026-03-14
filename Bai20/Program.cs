using SinhVien;
Console.WriteLine("PHAM THANH TIEN\nMa sinh vien: 2415053122341\n");

List<Student> students = new List<Student>() {  new Student { Id = 1, Name = "An", Score = 8 }, 
                                                new Student { Id = 2, Name = "Binh", Score = 6 }, 
                                                new Student { Id = 3, Name = "Chi", Score = 9 },
                                                new Student { Id = 4, Name = "Dung", Score = 7 } };
var bai20 = students.OrderByDescending(x => x.Score).Take(3).ToList();
Console.WriteLine("Top 3 sinh vien diem cao nhat la: ");
bai20.ForEach(x => Console.WriteLine($"Ten: {x.Name}; Diem: {x.Score}"));