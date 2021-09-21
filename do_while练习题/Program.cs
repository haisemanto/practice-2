using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 练习1
            //string name;
            //do
            //{
            //    Console.WriteLine("请输入姓名");
            //    name = Console.ReadLine();


            //} while (name != "q");//判断条件成立，则执行循环体 
            #endregion
            #region 第二个练习题
            string input;
            int max = 0;
            do
            {
                Console.WriteLine("请输入一个数字(正整数)，当输入end时显示所输入数字集合中的的最大值");
                input = Console.ReadLine();
                try
                {
                    if (input != "end")
                    {
                        if (max <= (Convert.ToInt32(input)))
                        {
                            max = (Convert.ToInt32(input));
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("输入的内容有误，请重新输入");
                }
            } while (input != "end");
            Console.WriteLine("您输入的最大的数字为{0:0.00}", max);
            Console.ReadKey(true);
            #endregion
            //循环体，提示用户输入数字，接收，转换并打印该数字的两倍
            //循环条件：输入的字符串不为q
            #region do while做法
            //string input;
            //do
            //{
            //    Console.WriteLine("请输入一个数字");
            //    input = Console.ReadLine();//不能直接转换为int类型，因为有可能输入q
            //    try
            //    {
            //        if (input != "q")
            //        {
            //            Console.WriteLine((Convert.ToInt32(input) * 2));
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("输入的内容有误，请重新输入");//异常捕获
            //    }

            //} while (input != "q");
            #endregion
            #region while做法
            //string n = "";
            //while (n != "q")
            //{
            //    Console.WriteLine("请输入一个数字");
            //    n = Console.ReadLine();
            //    if (n != "q")
            //    {
            //        int m = Convert.ToInt32(n);
            //        Console.WriteLine(m * 2);
            //    }

            //} 
            #endregion
        }
    }
}
