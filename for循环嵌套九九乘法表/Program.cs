using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for循环嵌套九九乘法表
{
    class Program
    {
        static void Main(string[] args)
        {
            //for循环嵌套九九乘法表
            for (int i = 1; i <= 9; i++)//第一个乘数
            {
                if (i != 1)
                {
                    Console.WriteLine("\t");
                }

                for (int j = 1; j <= i; j++)//j<=i,可以输出梯形的九九乘法表
                //for (int j = 1; j <= 9; j++)//第二个乘数，矩形的九九乘法表
                {
                    Console.Write("{0}x{1}={2}\t", j, i, i * j);//Write和WriteLing的区别就是 一个只能输出一行 一个不用换行
                }
            }
            Console.ReadKey();

        }
    }
}
