using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case
{
    class Program
    {

        //李四的年终工作评定
        //如果定为A级则来年的工资涨500
        //如果定为B级，则涨200
        //如果定为C级，工资不变
        //如果定为D级，则降200
        //设李四的原工资为5000，请用户输入李四的评级，然后显示李四来年的工资
        static void Main(string[] args)
        {
            #region if else-if的做法
            //            bool b = true;
            //            double salary = 5000;
            //            Console.WriteLine("请输入对李四工资的年终评定");//可能输入的并不是ABCD
            //            string level = Console.ReadLine();
            //            if (level == "A")
            //            {
            //                salary += 500;
            //            }
            //            else if(level=="B")
            //                {
            //                salary += 200;
            //            }
            //            else if(level=="C")
            //                {  
            //            }
            //            else if (level == "D")
            //            {
            //                salary -= 200;
            //            }
            //            else
            //            {
            //                Console.WriteLine("输入有误程序，退出");
            //                b = !b;//在报错的同时，使程序不会输出原有的输出
            //                Console.ReadKey(true);
            //            }
            //            if (b)
            //            {
            //Console.WriteLine("李四来年的工资是{0}", salary);
            //            Console.ReadKey(true);
            //            }
            #endregion
            #region switch case的做法
            bool b = true;
            double salary = 5000;
            Console.WriteLine("请输入对李四工资的年终评定");//可能输入的并不是ABCD
            string level = Console.ReadLine();
            switch (level)//将输入的level值与下面的case进行匹配 匹配成功则进行该程序的输出
            {
                case "A":
                    salary += 500;
                    break;//一定要加break来跳出switch case结构
                case "B":
                    salary += 200;
                    break;
                case "C": break;
                case "D":
                    salary -= 200;
                    break;
                case "E":
                    salary -= 500;
                    break;
                default:
                    Console.WriteLine("输入有误，程序退出");
                    b = !b;
                    break;

            }
            if (b)
            {
                Console.WriteLine("李四明年的工资收入为{0}", salary);
            }
            Console.ReadKey(true);
            #endregion
        }
    }
}
