using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Mark
    {
        static string tenMonHoc;
        static float diemLT; static float diemTH;
        static float diemTB;
        public static void NhapMonHoc()
        {
            Console.Write("Nhap Mon Hoc: ");
            tenMonHoc = Console.ReadLine();

            Console.Write("Nhap diem ly thuyet: ");
            diemLT = float.Parse(Console.ReadLine());

            Console.Write("Nhap diem thuc hanh: ");
            diemTH = float.Parse(Console.ReadLine());

            diemTB = (diemLT + diemTH) / 2;
        }
        public static void XuatMonHoc()
        {
            Console.WriteLine("Thong Tin Mon Hoc");
            Console.WriteLine("=================");
            Console.WriteLine($"Diem ly thuyet la: {diemLT}");
            Console.WriteLine($"Diem thuc hanh la: {diemTH}");
            Console.WriteLine($"Diem trung binh la: {diemTB}");

        }
    }
}
