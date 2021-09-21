using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace continue_s_循环
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 练习1
            //用while-continue实现计算从1到100的能被7整除的所有数的和
            //循环体：判断i能否被7整除,如果能，则计算i的总和
            //循环条件：i<=100
            //int i = 1;
            //int sum = 0;
            //while (i <= 100)
            //{
            //    if (i % 7 != 0)
            //    {
            //        i++;
            //        continue;

            //    }
            //    else
            //    {
            //        sum += i;
            //        i++;
            //    }
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey(true);
            //Console.ReadKey(); 
            #endregion
            //找出1-100以内所有的质数
            //素数/质数：只能被1和它本身整除的数字 2 3 5 7 11 13 17 19......
            //循环体：判断这个数是不是质数，如果不是则continue，是的话则打印输出一次
            //循环条件：i<=100
            int i = 2;
            while (i <= 100)
            {
                if (i == 2)
                {
                    Console.WriteLine(i);
                    i++;
                }
                else if (i <= 10&&i%2!=0&&i%9!=0)
                {
                    Console.WriteLine(i);
                    i++;
                }
                else if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0)
                {
                    Console.WriteLine(i);
                    i++;
                }
                else
                {
                    i++;
                    continue;
                }
            }//while循环的括号
            Console.ReadKey(true);
        }
    }
}
