using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 四个练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            //比较三个数字的大小 不考虑相等

            //分别提示用户输入三个数字 我们接收并且转换为int类型
            Console.WriteLine("请输入第一个数字");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个数字");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第三个数字");
            int n3 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2)//如果第一个数字大于第二个数字
            {
                if (n2 > n3)
                {
                    Console.WriteLine("{0}这个数字最大", n1);

                }
                else if (n1 > n3)
                {
                    Console.WriteLine("{0}这个数字最大", n1);
                }
                else
                {
                    Console.WriteLine("{0}这个数字最大", n3);
                }
            }
            else if (n2 < n3)
            {
                Console.WriteLine("{0}这个数字最大", n3);
}
            else
            {
                Console.WriteLine("{0}这个数字最大", n2);
            }





                //if (n1 > n2 && n1 > n3)//如果第一个数字大于第二个数字并且大于第三个数字
                //{
                //    Console.WriteLine("{0}这个数字最大",n1);
                //}
                //else if (n2 > n1 && n2 > n3)//如果第二个数字大于第一个数字并且大于第三个数字
                //{
                //    Console.WriteLine("{0}这个数字最大",n2);
                //}
                //else//如果第三个数字大于第一个数字并且大于第二个数字
                //{
                //    Console.WriteLine("{0}这个数字最大",n3);
                //}
                Console.ReadKey(true);
            





        }
    }
}
