using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    private string studentID;
    private string fullName;
    private float averageScore;
    private string faculty;

    public string StudentID { get => studentID; set => studentID = value; }
    public string FullName { get => fullName; set => fullName = value; }
    public float AverageScore { get => averageScore; set => averageScore = value; }
    public string Faculty { get => faculty; set => faculty = value; }

    public Student() { }

    public Student(string studentID, string fullName, float averageScore, string faculty)
    {
        this.studentID = studentID;
        this.fullName = fullName;
        this.averageScore = averageScore;
        this.faculty = faculty;
    }

    public void Input()
    {
        Console.Write("Nhap MSSV: ");
        StudentID = Console.ReadLine();
        Console.Write("Nhap Ho Ten Sinh vien: ");
        FullName = Console.ReadLine();
        Console.Write("Nhap Diem TB: ");
        if (float.TryParse(Console.ReadLine(), out float score))
        {
            AverageScore = score;
        }
        else
        {
            Console.WriteLine("Loi: Diem trung binh khong hop le. Dat mac dinh la 0.");
            AverageScore = 0f;
        }
        Console.Write("Nhap Khoa: ");
        Faculty = Console.ReadLine();
    }

    public void Show()
    {
        Console.WriteLine($"MSSV:{StudentID} | Ho Ten:{FullName} | Khoa:{Faculty} | Diem TB:{AverageScore:0.0}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Student> studentList = new List<Student>();
        bool exit = false;

        // Them du lieu mau de kiem tra cac chuc nang LINQ
        studentList.Add(new Student("SV001", "Nguyen Van A", 7.5f, "CNTT"));
        studentList.Add(new Student("SV002", "Le Thi B", 8.8f, "Kinh Te"));
        studentList.Add(new Student("SV003", "Tran Van C", 5.2f, "CNTT"));
        studentList.Add(new Student("SV004", "Pham Thi D", 9.1f, "CNTT"));
        studentList.Add(new Student("SV005", "Hoang Van E", 6.9f, "Ky Thuat"));
        studentList.Add(new Student("SV006", "Vo Thi F", 9.5f, "CNTT"));
        studentList.Add(new Student("SV007", "Duong Gia G", 9.5f, "CNTT"));

        while (!exit)
        {
            Console.WriteLine("\n==== MENU QUAN LY SINH VIEN ====");
            Console.WriteLine("1. Them sinh vien");
            Console.WriteLine("2. Hien thi danh sach sinh vien");
            Console.WriteLine("3. Xuat ra thong tin cua cac SV thuoc khoa 'CNTT'");
            Console.WriteLine("4. Xuat ra thong tin SV co diem TB >= 5");
            Console.WriteLine("5. Xuat ra danh sach SV duoc sap xep theo diem TB tang dan");
            Console.WriteLine("6. Xuat ra danh sach SV co diem TB >= 5 va thuoc khoa 'CNTT'");
            Console.WriteLine("7. Xuat ra danh sach SV co diem TB cao nhat va thuoc khoa 'CNTT'");
            Console.WriteLine("8. Hien thi so luong cua tung xep loai");
            Console.WriteLine("0. Thoat");
            Console.Write("Chon chuc nang (0-8): ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    AddStudent(studentList);
                    break;
                case "2":
                    DisplayStudentList(studentList);
                    break;
                case "3":
                    DisplayStudentsByFaculty(studentList, "CNTT");
                    break;
                case "4":
                    DisplayStudentsWithHighAverageScore(studentList, 5f);
                    break;
                case "5":
                    SortStudentsByAverageScore(studentList);
                    break;
                case "6":
                    DisplayStudentsByFacultyAndScore(studentList, "CNTT", 5f);
                    break;
                case "7":
                    DisplayStudentsWithHighestAverageScoreByFaculty(studentList, "CNTT");
                    break;
                case "8":
                    CountStudentsByGrade(studentList);
                    break;
                case "0":
                    exit = true;
                    Console.WriteLine("Ket thuc chuong trinh.");
                    break;
                default:
                    Console.WriteLine("Tuy chon khong hop le. Vui long chon lai.");
                    break;
            }
        }
    }

    private static void DisplayStudentList(IEnumerable<Student> list)
    {
        if (list == null || !list.Any())
        {
            Console.WriteLine("Danh sach trong.");
            return;
        }
        foreach (Student student in list)
        {
            student.Show();
        }
    }

    static void AddStudent(List<Student> studentList)
    {
        Console.WriteLine("=== Nhap thong tin sinh vien ===");
        Student student = new Student();
        student.Input();
        studentList.Add(student);
        Console.WriteLine("Them sinh vien thanh cong!");
    }

    static void DisplayStudentList(List<Student> studentList)
    {
        Console.WriteLine("=== Danh sach chi tiet thong tin sinh vien ===");
        DisplayStudentList(studentList.AsEnumerable());
    }

    static void DisplayStudentsByFaculty(List<Student> studentList, string faculty)
    {
        Console.WriteLine($"=== Danh sach sinh vien thuoc khoa {faculty} ===");
        var students = studentList.Where(s => s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase));
        DisplayStudentList(students);
    }

    static void DisplayStudentsWithHighAverageScore(List<Student> studentList, float minDTB)
    {
        Console.WriteLine($"=== Danh sach sinh vien co diem TB >= {minDTB} ===");
        var students = studentList.Where(s => s.AverageScore >= minDTB);
        DisplayStudentList(students);
    }

    static void SortStudentsByAverageScore(List<Student> studentList)
    {
        Console.WriteLine("=== Danh sach sinh vien duoc sap xep theo diem trung binh tang dan ===");
        var sortedStudents = studentList.OrderBy(s => s.AverageScore).ToList();
        DisplayStudentList(sortedStudents);
    }

    static void DisplayStudentsByFacultyAndScore(List<Student> studentList, string faculty, float minDTB)
    {
        Console.WriteLine($"=== Danh sach sinh vien co diem TB >= {minDTB} va thuoc khoa {faculty} ===");
        var students = studentList.Where(s => s.AverageScore >= minDTB
                                            && s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase)).ToList();
        DisplayStudentList(students);
    }

    static void DisplayStudentsWithHighestAverageScoreByFaculty(List<Student> studentList, string faculty)
    {
        Console.WriteLine($"=== Danh sach SV Khoa {faculty} co diem TB cao nhat ===");

        var cnttStudents = studentList
            .Where(s => s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase));

        if (!cnttStudents.Any())
        {
            Console.WriteLine("Khong tim thay sinh vien thuoc khoa nay.");
            return;
        }

        float maxScore = cnttStudents.Max(s => s.AverageScore);

        var highestScoreStudents = cnttStudents
            .Where(s => s.AverageScore == maxScore)
            .ToList();

        DisplayStudentList(highestScoreStudents);
    }

    static void CountStudentsByGrade(List<Student> studentList)
    {
        Console.WriteLine("=== Thong ke so luong theo xep loai ===");

        string GetGrade(float score)
        {
            if (score >= 9.0f && score <= 10.0f) return "Xuat sac";
            if (score >= 8.0f && score < 9.0f) return "Gioi";
            if (score >= 7.0f && score < 8.0f) return "Kha";
            if (score >= 5.0f && score < 7.0f) return "Trung binh";
            if (score >= 4.0f && score < 5.0f) return "Yeu";
            return "Kem";
        }

        var gradeCounts = studentList
            .GroupBy(s => GetGrade(s.AverageScore))
            .Select(g => new { Grade = g.Key, Count = g.Count() })
            .OrderByDescending(x => x.Count);

        foreach (var item in gradeCounts)
        {
            Console.WriteLine($"- Xep loai {item.Grade}: {item.Count} sinh vien");
        }
    }
}