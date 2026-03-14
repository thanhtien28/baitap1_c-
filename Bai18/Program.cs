using SinhVien;

Console.WriteLine("PHAM THANH TIEN\nMa sinh vien: 2415053122341\n");

List<Student> students = new List<Student>() {  new Student { Id = 1, Name = "An", Score = 8 }, 
                                                new Student { Id = 2, Name = "Binh", Score = 6 }, 
                                                new Student { Id = 3, Name = "Chi", Score = 9 }, 
                                                new Student { Id = 4, Name = "Dung", Score = 7 } };

var hsg = students.Where(x => x.Score >= 8).ToList();
var hsk = students.Where(x=>x.Score>=6 && x.Score<8).ToList();
var hstb = students.Where(x => x.Score < 6 ).ToList();

Console.WriteLine("Danh sach hoc sinh gioi gom: ");
if (hsg.Count() == 0)
   Console.WriteLine("Rong");
else
   hsg.ForEach(x => Console.WriteLine($"Ten: {x.Name}; Diem: {x.Score}"));

Console.WriteLine("\nDanh sach hoc sinh kha gom: ");
if (hsk.Count() == 0)
    Console.WriteLine("Rong");
else
    hsk.ForEach(x => Console.WriteLine($"Ten: {x.Name}; Diem: {x.Score}"));

Console.WriteLine("\nDanh sach hoc sinh trung binh gom: ");
if (hstb.Count() == 0)
    Console.WriteLine("Rong");
else
    hstb.ForEach(x => Console.WriteLine($"Ten: {x.Name}; Diem: {x.Score}"));
