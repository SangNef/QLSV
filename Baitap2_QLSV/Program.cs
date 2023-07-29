using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap2_QLSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            StudentList studentList = new StudentList();

            while (true)
            {
                Console.WriteLine("====== QUẢN LÝ SINH VIÊN ======");
                Console.WriteLine("1. Nhập danh sách sinh viên");
                Console.WriteLine("2. Hiển thị danh sách sinh viên");
                Console.WriteLine("3. Sắp xếp theo điểm giảm dần");
                Console.WriteLine("4. Tìm sinh viên theo họ tên");
                Console.WriteLine("5. Thoát");
                Console.Write("Nhập lựa chọn của bạn (1-5): ");
                int luaChon = int.Parse(Console.ReadLine());

                switch (luaChon)
                {
                    case 1:
                        Console.WriteLine("=== Nhập danh sách sinh viên ===");
                        studentList.Input();
                        break;
                    case 2:
                        Console.WriteLine("=== Hiển thị danh sách sinh viên ===");
                        studentList.Display();
                        break;
                    case 3:
                        Console.WriteLine("=== Sắp xếp theo điểm giảm dần ===");
                        studentList.SortByMark();
                        studentList.Display();
                        break;
                    case 4:
                        Console.WriteLine("=== Tìm sinh viên theo họ tên ===");
                        Console.Write("Nhập họ tên sinh viên cần tìm: ");
                        string hoTenTimKiem = Console.ReadLine();
                        int index = studentList.Search(hoTenTimKiem);
                        if (index != -1)
                        {
                            Console.WriteLine("Tìm thấy sinh viên:");
                            studentList.list[index].Display();
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy sinh viên có họ tên như trên.");
                        }
                        break;
                    case 5:
                        Console.WriteLine("=== Thoát chương trình ===");
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
