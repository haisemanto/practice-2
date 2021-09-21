using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while循环计算1__100所有整数的和
{
    class Program
    {
        static void Main(string[] args)
        {
            //1--100所有整数的和
            //int i = 1;
            //int sum = 0;
            //while (i <= 100)
            //{
            //    sum += i;//sum总和＝i+1
            //    i++;//每次执行一次循环体，i自加1
            //    /*i += 1;*/
            //}
            //Console.WriteLine(sum);
            //Console.WriteLine(i);//最终i的值为101，但不参加最后一次累加计算
            //Console.ReadKey(true);


            //1--100所有偶数的和
            int i = 0;
            int sum = 0;
            while (i <= 100)
            {
                if (i % 2 == 0)//计算奇数总和的话，只需要把==改成!=
                {
                    sum += i;
                 i+=1;//因为是总结所有的偶数，所以i自加1或者自加2都可以
                }//if判断的括号结尾
                //如果i不是偶数，则自加1再做判断          
                    i++;
            }
            Console.WriteLine(sum);
            Console.WriteLine(i);//i最后的值是101 但是不参与最后一次运算
            Console.ReadKey(true);
        }
    }
}
