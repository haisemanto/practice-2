using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for循环嵌套练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数字");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    if (i + j == number)
                    {
                        Console.WriteLine("{0}+{1}={2}", i, j, i + j);
                    }

                }
            }
            Console.ReadKey(true);

        }
    }
}
