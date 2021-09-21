using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case判断每个月的天数
{
    class Program
    {
        static void Main(string[] args)
        {
        L1: Console.Clear();   //请用户输入年份，再输入月份，判断这个月有多少天。
            int month = 0;
            int year = 0;
            bool b = true;
            Console.WriteLine("请输入查询的年份");
            try
            {
                year = Convert.ToInt32(Console.ReadLine());
                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)//能被4整除并且不能被100整除或者能被400整除
                {
                    Console.WriteLine("请输入查询月份");
                    month = Convert.ToInt32(Console.ReadLine());
                    switch (month)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            Console.WriteLine("{0}年的{1}月是31天", year, month);
                            Console.ReadKey(true);
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            Console.WriteLine("{0}年的{1}月是30天", year, month);
                            Console.ReadKey(true);
                            break;
                        case 2:
                            Console.WriteLine("{0}年的2月是29天", year);
                            Console.ReadKey(true);
                            break;
                        default:
                            Console.WriteLine("输入月份有误，按任意键重新输入");
                            Console.ReadKey(true);
                            goto L1;
                    }
                }
                else
                {
                    Console.WriteLine("请输入查询月份");
                    month = Convert.ToInt32(Console.ReadLine());
                    switch (month)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            Console.WriteLine("{0}年的{1}月是31天", year, month);
                            Console.ReadKey(true);
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            Console.WriteLine("{0}年的{1}月是30天", year, month);
                            Console.ReadKey(true);
                            break;
                        case 2:
                            Console.WriteLine("{0}年的2月是28天", year);
                            Console.ReadKey(true);
                            break;
                        default:
                            Console.WriteLine("输入月份有误，按任意键重新输入");
                            Console.ReadKey(true);
                            goto L1;
                            break;
                    }//switch括号的结尾
                }//else括号的结尾
            }//判断的结尾
            catch
            {
                Console.WriteLine("输入年份有误，按任意键重新输入");
                Console.ReadKey(true);
                goto L1;
            }//catch括号的结尾
        }
    }
}
