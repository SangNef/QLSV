using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap2_QLSV
{
    internal class StudentList
    {
        public Student[] list = new Student[10];
        public int n;

        // Phương thức nhập danh sách sinh viên
        public void Input()
        {
            Console.Write("Nhập số lượng sinh viên: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập thông tin sinh viên thứ {i + 1}:");
                list[i] = new Student();
                list[i].Input();
            }
        }

        // Phương thức hiển thị danh sách sinh viên
        public void Display()
        {
            if (n == 0)
            {
                Console.WriteLine("Danh sách sinh viên trống.");
                return;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Thông tin sinh viên thứ {i + 1}:");
                list[i].Display();
            }
        }

        // Phương thức sắp xếp danh sách sinh viên theo điểm giảm dần
        public void SortByMark()
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (list[i].mark < list[j].mark)
                    {
                        Student temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
        }

        // Phương thức tìm kiếm sinh viên theo tên
        public int Search(string key)
        {
            for (int i = 0; i < n; i++)
            {
                if (list[i].name.ToLower().Contains(key.ToLower()))
                {
                    return i;
                }
            }
            return -1; // Không tìm thấy sinh viên có tên như vậy
        }
    }
}
