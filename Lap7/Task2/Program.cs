using System;
using System.Collections;

namespace Task2
{       
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Luu Thong Tin San Pham!");
            Console.WriteLine("-----------------------");

            Console.Write("Nhap so luong loai san pham: ");        
            int n = int.Parse(Console.ReadLine());

            ArrayList products = new ArrayList(n);
            string name; int number; int price;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine($"Thong tin san pham {i + 1}: ");                                

                Console.Write("Nhap ten san pham: ");
                name = Console.ReadLine();

                Console.Write($"Nhap so luong san pham {name}: ");              
                number = int.Parse(Console.ReadLine());

                Console.Write($"Nhap don gia san pham {name}: ");       
                price = int.Parse(Console.ReadLine());

                products.Add(new Product(i + 1, name, number, price));
            }

            Console.Clear();
            Console.WriteLine("DANH MUC SAN PHAM");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("|ID|   Product Name   | Number |  Price  |  Total  |");
            Console.WriteLine("----------------------------------------------------");

            const int idSpacing = 2;
            const int nameSpacing = -18;
            const int numberSpacing = 8;
            const int priceSpacing = 9;
            const int sumSpacing = 9;
            const int totalSpacing = 50;
            int total = 0;
            Product tmp = null;
            for (int i = 0; i < n; i++)
            {
                tmp = (Product) products[i];
                int sumPrice = tmp.SumPrice(tmp.Number, tmp.Price);
                Console.WriteLine($"|{tmp.Id, idSpacing}|{tmp.Name, nameSpacing}|{tmp.Number, numberSpacing}|{tmp.Price, priceSpacing}|{sumPrice, sumSpacing}|");
                total += sumPrice;
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"|{total, totalSpacing}|");
        }
    }
}
