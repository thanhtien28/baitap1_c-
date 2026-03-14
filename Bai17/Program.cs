using SinhVien;

Console.WriteLine("PHAM THANH TIEN\nMa sinh vien: 2415053122341\n");

List<Student> students = new List<Student>() {  new Student { Id = 1, Name = "An", Score = 8 }, 
                                                new Student { Id = 2, Name = "Binh", Score = 6 }, 
                                                new Student { Id = 3, Name = "Chi", Score = 9 }, 
                                                new Student { Id = 4, Name = "Dung", Score = 7 }};
var bai17 = students.Average(x => x.Score);
Console.WriteLine("Diem trung binh sinh vien la: " + bai17);