using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 三元表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            //计算两个用户输入数字的大小，求出最大的
            #region if_else的做法
            //Console.WriteLine("请输入第一个数字");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个数字");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //if (n1 > n2)
            //{
            //    Console.WriteLine(n1);
            //}
            //else
            //{
            //    Console.WriteLine(n2);
            //}
            //Console.ReadKey(true); 
            #endregion
            //Console.WriteLine("请输入第一个数字");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个数字");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //int max = n1 > n2 ? n1 : n2;
            //Console.WriteLine(max);
            //Console.ReadKey(true);



            //提示用户输入一个姓名，只要输入的不是黑涩，就全是流氓
            Console.WriteLine("请输入一个姓名");
            string name = Console.ReadLine();
            string result = name == "黑涩" ? "淫才啊!!!" : "流氓啊!!!";//从if_else的角度来看，if（name=="黑涩"）为真时，匹配后面的
            //匹配后面的第一个string类型，当发生其他情况 else时，匹配后面的第二个string类型
            Console.WriteLine(result);
            Console.ReadKey(true);
        }
    }
}
