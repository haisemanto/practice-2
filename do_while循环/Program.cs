using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while循环
{
    class Program
    {
        static void Main(string[] args)
        {
            #region do_while
            //明天小兰就要登台演出了，老师说再把演出的歌曲唱一遍
            //如果满意，小兰就可以回家了，否则就需要再联系一遍，直到老师满意位置。（y/n)
            //string ans;
            //Console.WriteLine("老师，我唱的你满意了吗(y/n)");
            //ans = Console.ReadLine();
            //do
            //{
            //    Console.WriteLine("老师，我再唱一遍你满意了吗（y/n）");
            //    ans = Console.ReadLine();
            //}
            //while (ans == "n");//判断条件成立，则继续执行循环体
            //Console.ReadKey(true);




            //遇见这种首先执行一遍循环体，拿着执行后的循环体再去判断是否执行循环的循环。
            //我们推荐使用do-while循环 
            #endregion
            string name;
            string pwd;
            do
            {
                Console.WriteLine("请输入用户名");
                name = Console.ReadLine();
                Console.WriteLine("请输入密码");
                pwd = Console.ReadLine();
                if (name != "admin" && pwd != "888888")
                {
                    Console.WriteLine("用户名或密码错误，请重新输入");
                }

            } while (name != "admin" && pwd != "888888");
            Console.WriteLine("输入正确，程序关闭");
            Console.ReadKey(true);


        }
    }
}
