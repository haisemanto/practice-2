using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 异常捕获
{
    class Program
    {
        static void Main(string[] args)
        {//语法上没有错误，由于某些原因出现了错误，不能再正常的运行。
            bool b = true;
            decimal number = 0;//将number在外面定义，使他的作用域扩展到整个main函数
            try//在try中输入可能会出现异常的代码
            {
                Console.WriteLine("请输入一个数字，并打印输出他的两倍");
                number = Convert.ToDecimal(Console.ReadLine());
            }
            //try和catch之间必须紧密相连，不能有其他的代码
            catch//如果出现异常，则跳过try所执行的代码，转而执行catch里面的代码
            {
                Console.WriteLine("输入数据不能转换为数字，按任意键退出");
                b = false;//当程序出异常时，将bool型b赋值为false，不会执行number*2的操作
                Console.ReadKey(true);
                //Console.Clear();
            }//我们如果要执行下面这行代码，需要满足某些条件。uyr
            //让代码满足某些条件去执行的话，我们可以使用bool类型
            if (b)//b为true表示没有出异常，则执行下面这行代码。如果出了异常，b变为false就不会执行一下代码
            {
                Console.WriteLine(number * 2);
            }
            Console.ReadKey(true);
        }
    }
}
