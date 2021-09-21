using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace if语句
{
    class Program
    {
        static void Main(string[] args)
        {

        L1: Console.WriteLine("请输入要判断的年份");
            int year = Convert.ToInt32(Console.ReadLine());
            //bool a=year % 400 == 0;
            bool a = year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
            //逻辑与的优先级要高于逻辑或
            //能被400整除或者 能被4整除而不被100整除
            if (!a)
            {
                Console.WriteLine("这一年不是闰年，按任意键继续");
                Console.ReadKey(true);
                Console.Clear();
                goto L1;
            }
            Console.WriteLine("这一年是闰年，按任意键继续");
            Console.ReadKey(true);
            Console.Clear();
            goto L1;
        }
    }
}
