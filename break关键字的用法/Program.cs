using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break关键字的用法
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = 1;
            while (i <= 10)
            {
                while (j <= 10)
                {
                    Console.WriteLine("我是里面的while循环");
                    j++;
                    //break;//打印里面的while循环之后，跳出当前循环后 i++的循环中又打印了里面的while循环   
                }
                Console.WriteLine("我是外面的while循环");
               i++; 
                //break;//可以起到跳出当前while循环的作用
            }
            Console.ReadKey(true);

        }
    }
}
