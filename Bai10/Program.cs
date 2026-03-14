using SinhVien;

Console.WriteLine("PHAM THANH TIEN\nMa sinh vien: 2415053122341\n");

List<Student> students = new List<Student>() {  new Student { Id = 1, Name = "An", Score = 8 },
                                                new Student { Id = 2, Name = "Binh", Score = 6 },
                                                new Student { Id = 3, Name = "Chi", Score = 9 },
                                                new Student { Id = 4, Name = "Dung", Score = 7 } };
var bai10 = students.OrderByDescending(student => student.Score).ToList();

Console.WriteLine("Danh sach giam dan theo diem: ");
bai10.ForEach(x => Console.WriteLine($"Ten: {x.Name} ; Diem: {x.Score}"));