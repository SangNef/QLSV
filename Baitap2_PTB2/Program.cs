using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap2_PTB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double a, b, c;
            double x1 = 0, x2 = 0;
            int soNghiem;

            Nhapso(out a, "Nhập hệ số A: ");
            Nhapso(out b, "Nhập hệ số B: ");
            Nhapso(out c, "Nhập hệ số C: ");

            soNghiem = GiaiPTB2(a, b, c, ref x1, ref x2);

            if (soNghiem == 0)
            {
                Console.WriteLine("Phương trình vô nghiệm.");
            }
            else if (soNghiem == 1)
            {
                Console.WriteLine($"Phương trình có nghiệm kép: x = {x1}");
            }
            else
            {
                Console.WriteLine($"Phương trình có 2 nghiệm phân biệt: x1 = {x1}, x2 = {x2}");
            }
            Console.ReadKey();
        }

        // Hàm nhập số thực sử dụng tham chiếu (ref)
        static void Nhapso(out double num, string message)
        {
            Console.Write(message);
            num = double.Parse(Console.ReadLine());
        }

        // Hàm giải phương trình bậc 2 sử dụng tham chiếu (ref)
        static int GiaiPTB2(double A, double B, double C, ref double X1, ref double X2)
        {
            double delta = B * B - 4 * A * C;

            if (delta < 0)
            {
                return 0; // Vô nghiệm
            }
            else if (delta == 0)
            {
                X1 = X2 = -B / (2 * A);
                return 1; // Nghiệm kép
            }
            else
            {
                X1 = (-B + Math.Sqrt(delta)) / (2 * A);
                X2 = (-B - Math.Sqrt(delta)) / (2 * A);
                return 2; // 2 nghiệm phân biệt
            }
        }
    }
}
