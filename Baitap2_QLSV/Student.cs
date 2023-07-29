using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Baitap2_QLSV
{
    internal class Student
    {
    private string rollno;
    private string name;
    private float mark;

    // Phương thức hiển thị thông tin sinh viên
    public void Display()
    {
        Console.WriteLine($"Mã SV: {rollno}, Họ tên: {name}, Điểm: {mark}");
    }

    // Phương thức nhập thông tin sinh viên
    public void Input()
    {
        Console.Write("Nhập mã sinh viên: ");
        rollno = Console.ReadLine();

        Console.Write("Nhập họ tên sinh viên: ");
        name = Console.ReadLine();

        Console.Write("Nhập điểm sinh viên: ");
        mark = float.Parse(Console.ReadLine());
    }
}
}
