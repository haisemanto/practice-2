using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 将区间变为定值_使switch_case完成else_if能做的
{
    class Program
    {
        static void Main(string[] args)
        {
            //成绩90-100 A级别
            //成绩80-90  B级别
            //成绩70-80  C级别
            //成绩60-70  D级别
            //成绩60以下 E级别
            bool b = true;
            Console.WriteLine("请输入一个考试成绩");
            int score = 0;
            try
            {
                score = Convert.ToInt32(Console.ReadLine());
                score /= 10;
                if (score > 10)
                {
                    Console.WriteLine("分数输入超出范围，程序退出");
                    Console.ReadKey(true);
                    b = !b;
                }
            }
            catch
            {
                Console.WriteLine("输入有误，程序退出");
                b = !b;
                Console.ReadKey(true);
            }
            if (b)
            {
                switch (score)
                {
                    case 10://case "10"不用加引号，因为他们是int型。加引号代表后面的判断类型是字符串 如果case后面是字母 则需要加引号
                        //Console.WriteLine("A");//当两行case代码一样时，可以删除前面一个的代码
                        //break;
                    case 9:
                        Console.WriteLine("A");
                        break;
                    case 8:
                        Console.WriteLine("B");
                        break;
                    case 7:
                        Console.WriteLine("C");
                        break;
                    case 6:
                        Console.WriteLine("D");
                        break;
                    default:
                        Console.WriteLine("E");
                        break;
                }
            }
            Console.ReadKey(true);


        }
    }
}
