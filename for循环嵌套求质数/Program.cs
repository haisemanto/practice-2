using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for循环嵌套求质数
{
    class Program
    {
        static void Main(string[] args)
        {
            //怎么判断该数是不是质数，i从2开始除 一直除到i-1 如果余数都不为0 则这个数是质数。
            //bool b = true;//当代码要求满足某个条件执行的时候，用到bool类型
            for (int i = 2; i < 100; i++)
            {
                bool b = true;
                if (b)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)//这个数不是质数的时候，执行以下循环
                        {
                            b = false;
                            break;//跳出这个数的除数查找循环，将b的bool值转为false，防止继续对当前这个非质数是否为质数的判断
                        }
                    }
                    if (b)//这个数不是质数的时候，立即从当前i+1的数值重新开始这个循环
                    {
                        Console.WriteLine(i);
                        //continue;
                    }                    
                }
            }
            Console.ReadKey(true);
        }
    }
}
