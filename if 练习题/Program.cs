using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你的年龄");
            int age = Convert.ToInt32(Console.ReadLine());//将输入的string年龄直接转换为int32位进行判断处理
                                                          //bool b = age >= 23;
            if (age >= 23)//if后面的括号跟的是一个bool型
            {
                Console.WriteLine("你可以结婚了");
                Console.ReadKey(true);
            }
            else if (age < 23 && age >= 10)
            {
                Console.WriteLine("你现在还不能结婚");
                Console.ReadKey(true);
            }
            else if (age > 0 && age < 10)
            {
                Console.WriteLine("你还太小了");
                Console.ReadKey(true);

            }


            //L1: Console.WriteLine("请输入您的用户名");
            //    string admin = Console.ReadLine();
            //    Console.WriteLine("请输入您的密码");
            //    string pwd = Console.ReadLine();
            //    bool a = admin == "admin" && pwd == "password";//判断是否相等 ==后面的判断条件要加引号
            //    if (a)
            //    {
            //        Console.WriteLine("账号密码输入正确，允许登录");
            //        Console.ReadKey(true);

            //    }
            //    else
            //    {
            //        Console.WriteLine("账号或密码错误，不能登录");
            //        Console.ReadKey(true);
            //        Console.Clear();
            //        goto L1;
            //    }
            #region if的做法
            //Console.WriteLine("请输入你的考试成绩");
            //int score = Convert.ToInt32(Console.ReadLine());
            //if (score >= 90 && score <= 100)
            //{
            //    Console.WriteLine("成绩为A");
            //    Console.ReadKey(true);

            //}
            //if (score >= 80 && score < 90)
            //{
            //    Console.WriteLine("成绩为B");
            //    Console.ReadKey(true);

            //}
            //if (score >= 70 && score < 80)
            //{
            //    Console.WriteLine("成绩为C");
            //    Console.ReadKey(true);

            //} 
            //if (score >= 60 && score < 70)
            //{
            //    Console.WriteLine("成绩为D");
            //    Console.ReadKey(true);

            //}
            //if (score < 60)
            //{
            //    Console.WriteLine("成绩为E");
            //    Console.ReadKey(true);

            //}
            ////else//else永远和离他最近的if配对
            ////{
            ////        Console.WriteLine("成绩为E");
            ////        Console.ReadKey(true);

            ////    }
            #endregion
            #region if else的做法 代码嵌套代码 看起来很难受
            //Console.WriteLine("请输入你的成绩");
            //int score = Convert.ToInt32(Console.ReadLine());
            //if (score >= 90)
            //{
            //    Console.WriteLine("A");
            //}
            //else //80
            //{
            //    if (score >= 80)
            //    {
            //        Console.WriteLine("B");
            //    }
            //    else
            //    {
            //        if (score >= 70)
            //        {
            //            Console.WriteLine("C");
            //        }
            //        else
            //        {
            //            if (score >= 60)
            //            {
            //                Console.WriteLine("D");
            //            }
            //            else
            //            {
            //                Console.WriteLine("E");
            //            }
            //        }
            //    }
            //}
            //Console.ReadKey(true);


            #endregion





            //代码最后一行后面永远留三个括号
        }
    }
}
