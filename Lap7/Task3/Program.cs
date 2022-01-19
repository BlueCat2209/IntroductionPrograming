using System;
using System.Collections;

namespace Task3
{
    class Program
    {        
        static void ShowMenu()
        {
            Console.WriteLine("1-Nhap danh sach mon hoc");
            Console.WriteLine("2-Hien thi danh sach mon hoc");
            Console.WriteLine("3-Diem TB cao nhat");
            Console.WriteLine("4-Thoat");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so luong mon hoc: ");
            int n = int.Parse(Console.ReadLine());
            Console.Clear();

            ArrayList SubjectsMark = new ArrayList(n);
            bool check = false;

            while (true)
            {
                ShowMenu();
                int option = int.Parse(Console.ReadLine());             
                switch (option)
                {
                    case 1:
                        check = true;
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"Mon hoc thu {i + 1}");
                            Console.WriteLine("--------------");
                            Console.Write("Ten mon hoc: ");
                            string subjectName = Console.ReadLine();
                            Console.Write("Diem LT: ");
                            int learningMark = int.Parse(Console.ReadLine());
                            Console.Write("Diem TH: ");
                            int praticingMark = int.Parse(Console.ReadLine());
                            Console.WriteLine("=====================");
                            SubjectsMark.Add(new Mark(subjectName, learningMark, praticingMark, (learningMark + praticingMark) / 2));
                        }
                        Console.WriteLine("Nhap Thanh Cong!");
                        Console.ReadKey();                        
                        break;
                    case 2:
                        if (!check)
                        {
                            Console.WriteLine("Chua nhap thong tin!");
                            Console.ReadKey();
                            break;
                        }
                        Mark tmp = null;
                        for (int i = 0; i < n; i++)
                        {
                            tmp = (Mark)SubjectsMark[i];
                            tmp.PrintSubjectMark();
                        }
                        Console.ReadKey();          
                        break;
                    case 3:
                        Console.WriteLine("Cac mon hoc co diem cao nhat la:");
                        float max = 0;
                        for (int i = 0; i < n; i++)
                        {
                            tmp = (Mark)SubjectsMark[i];
                            if (max < tmp.AverageMark)
                            {
                                max = tmp.AverageMark;
                            }
                        }
                        for (int i = 0; i < n; i++)
                        {
                            tmp = (Mark)SubjectsMark[i];
                            if (max == tmp.AverageMark)
                            {
                                Console.WriteLine(tmp.SubjectName);
                            }
                        }
                        Console.WriteLine($"Co muc diem {max}");
                        Console.ReadKey();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
                Console.Clear();
            }
        }
    }
}
