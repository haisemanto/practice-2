using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 产生随机数
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 生成1-10以内的随机数
            ////产生随机数
            ////1.创建能够产生随机数的对象
            //Random r = new Random();//创建对象不能放在循环里面，不然每循环一次就会创建一个空间
            ////让产生随机数的对象，调用方法来产生方法来产生随机数
            ////要调用Next方法来产生随机数的话，还要提供相应的参数
            //while (true)
            //{
            //    int rNumber = r.Next(1, 11);//限定产生随机数的范围是1-10，左闭右开区间
            //    Console.WriteLine(rNumber);
            //    Console.ReadKey(true);

            //} 
            #endregion
            //输入名字随机显示这个人上辈子是什么样的人
            //思路：
            //1.首先创建一个产生随机数的对象
            //2.产生随机数（1,7）最大能产生6
            Random r = new Random();
            while (true)
            {
                int rNumber = r.Next(1, 7);
                Console.WriteLine("请输入一个姓名,查询他是怎么死的");
                string name = Console.ReadLine();
                switch (rNumber)
                {
                    case 1:
                        Console.WriteLine("{0}这辈子，打手冲冲死了", name);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("{0}这辈子，因为在图书馆打手冲被曝光，社死了", name);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("{0}这辈子因为强奸未成年，被抓进监狱判了死刑", name);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("{0}不想努力了，被富婆玩死了", name);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("{0}平平无奇，过着淡然的日子善终了", name);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine("{0}上厕所太爽，爽死了", name);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
