using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //向控制台打印输出10遍，hello world
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("hello world");
            //    i++;
            //} 
            //Console.ReadKey(true);
            for (int i = 0; i < 10; i++)//for（表达式1；表达式2；表达式3）
                                        //表达式1一般为定义循环变量，记录循环次数。
                                        //表达式2一般为循环条件。
                                        //表达式3为改变循环条件的代码，使循环条件总能不满足
                                        //通过调试发现，只有当循环体执行完一次之后，才会执行i++,之后对于循环条件的判断
            {
                Console.WriteLine("hello world");
            }
            Console.ReadKey(true);




        }
    }
}
