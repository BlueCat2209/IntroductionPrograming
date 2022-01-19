using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            string output = " ";
            int k = 0;
            // Trạng thái xác định từ (true: kí tự là từ; false: kí tự là khoảng trắng)
            bool curr = false; bool pass = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {                 
                    int j = (int)input[i];
                    // Là chữ cái
                    if (((j >= 65) & (j <= 90)) || ((j >= 97) & (j <= 122)))
                    {
                        string toBeAdded = "";
                        // Xác định kí tự đầu tiên trong một từ để viết hoa
                        if ((curr == true) & (pass == false))
                        {
                            toBeAdded = input[i].ToString().ToUpper();
                        }
                        // Thêm kí tự cần thêm vào ouput
                        output.Insert(k++, toBeAdded);
                        // Cập nhật trạng thái xác định từ
                        curr = true;
                    }
                    else // Là kí tự đặc biệt
                    {
                        // Loại bỏ khỏi chuỗi
                    }
                }
                else 
                {
                    // Kí tự trước đó là chữ cái
                    if (pass)
                    {
                        string toBeAdded = " ";
                        output.Insert(k++, toBeAdded);
                    }
                    else // Kí tự trước đó là khoảng trắng
                    {
                        // Loại bỏ khỏi chuỗi
                    } 
                        
                    // Cập nhật trạng thái xác định từ 
                    curr = false;
                }             
                // Cập nhật trạng thái xác định từ
                pass = curr;                
            }
            Console.WriteLine($"After formating: {output}");
        }
    }
}
