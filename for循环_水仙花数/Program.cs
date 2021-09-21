using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for循环_水仙花数
{
    class Program
    {
        static void Main(string[] args)
        {            
            #region 判断100以内的奇数偶数和
            //循环体：判断为奇数/偶数则相加，并且i+1
            //循环条件：i<100
            //int sum = 0;
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        sum += i;

            //    }
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey(true); 
            #endregion
            #region 100-999水仙花数
            //个位数的立方+十位数的立方+百位数的立方==当前这个数字
            //计算1-999的水仙花数
            int a;
            int b;
            int c;
            for (int i = 100; i < 999; i++)
            {
                a = i % 10;//个位数等于i%10
                b = i % 100 / 10;//十位数等于（i%100/10）
                c = i / 100;//百位数等于i/100
                if (a * a * a + b * b * b + c * c * c == i)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("所有水仙花数如上所示");
            Console.ReadKey(true);
            #endregion



        }
    }
}
