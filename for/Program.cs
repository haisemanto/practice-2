using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for循环的三个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 录入年龄并计算平均年龄
            //循环录入五个人的年龄，并计算平均年龄，如果出现负数或大于100的数，立刻停止输入并且报错
            //如果录入的数据出现负数或大于100的数，立刻停止输入并报错
            //知道循环次数的循环，采用for循环嵌套
            //循环体：输入并且接收数据转化为int型年龄。
            //循环条件：输入人数<=5 当输入结束时，计算平均年龄，要求使用for循环计算
            //int age;
            //double sum = 0;

            //for (int i = 1; i <= 5; i++)
            //{
            //    {
            //        Console.WriteLine("请输入第{0}个人的年龄", i);
            //        try
            //        {
            //            age = Convert.ToInt32(Console.ReadLine());
            //            if (age > 0 && age < 100)
            //            {
            //                sum += age;
            //            }
            //            else
            //            {
            //                Console.WriteLine("输入了错误的数据类型，请重新输入");
            //                i--;//当输入的数据出现问题时，停止这个用户的输入。i-1让他重新开始输入
            //                continue;//通过调试发现，continue并不是从这个for循环的int i = 1开始，而是从i++开始继续这个循环
            //            }
            //        }
            //        catch
            //        {
            //            Console.WriteLine("输入了错误的数据类型，请重新输入");
            //            i--;
            //            continue;//通过调试发现，continue并不是从这个for循环的int i = 1开始，而是从i++开始继续这个循环

            //        }
            //    }

            //}
            //Console.WriteLine("所有五个人的总年龄为{0}，平均年龄为{1:0.0}", sum, sum / 5);
            //Console.ReadKey(true); 
            #endregion
            #region 提示输入用户名密码
            //在while中使用break实现要求用户一直输入用户名和密码
            //只要用户名不是admin以及密码不是888888就一直提示要求重新输入，如果正确，则提示输入成功
            //循环体：提示用户输入用户名和密码
            //循环条件：用户名和密码不正确
            //string userName;
            //string pwd;
            //bool b = true;
            //while (b)
            //{
            //    Console.WriteLine("请输入用户名");
            //    userName = Console.ReadLine();
            //    Console.WriteLine("请输入密码");
            //    pwd = Console.ReadLine();
            //    if (userName == "admin" && pwd == "888888")
            //    {
            //        b = false;
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("输入错误，重新输入");
            //        //break;
            //    }

            //}
            //if (!b)
            //{
            //    Console.WriteLine("输入正确，程序退出");
            //}

            //Console.ReadKey(true); 
            #endregion
            //1--100之间的整数相加，得到累加值大于20的当前数
            int sum = 0;

            for (int i = 1; i < 100; i++)
            {
                sum += i;
                if (sum > 20)
                {
                    Console.WriteLine("加到{0}的时候，总和大于20了",i);
                    break;
                }
            }

            Console.ReadKey(true);
        }
    }
}
