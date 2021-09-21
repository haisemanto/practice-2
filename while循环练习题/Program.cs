using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while循环练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region while循环判断用户是否输入正确的账号密码
            //要求用户名输入用户名和密码，只要用户名不是admin以及密码不是888888就得重新输入。
            //循环体:提示用户输入用户名 我们接收密码 判断是否可以登录 成功
            //循环条件：账号||密码错误
            //string userName = "";
            //string userPwd = "";
            //while (userName != "admin" || userPwd != "888888")
            //{Console.WriteLine("请输入账号");
            //    userName = Console.ReadLine();
            //    Console.WriteLine("请输入密码");
            //    userPwd = Console.ReadLine();
            //    if (userName == "admin" || userPwd == "888888")//当账号密码输入正确时，要求立刻跳出该循环并且显示账号密码输入正确
            //    {
            //        break;
            //    }
            //    Console.WriteLine("账号或密码错误请重新输入");
            //    Console.ReadKey(true);
            //    Console.Clear(); 
            //}
            //Console.WriteLine("账号密码正确，程序结束");
            //Console.ReadKey(true); 
            #endregion
            #region 计算给定班级人数的成绩并计算
            //int i = 1;//声明循环变量记录循环的次数
            //double sum = 0;
            //double count = 0;
            //bool b = false;
            //while (!b)
            //{
            //    Console.WriteLine("请输入班级人数");
            //    try
            //    {
            //        count = Convert.ToDouble(Console.ReadLine());//转为double型
            //        b = true;//只有当输入数据不产生报错时，才会将bool型b更改为true，此时就可以跳出这个while循环
            //    }
            //    catch
            //    {
            //        Console.WriteLine("输入有误，请重新输入");
            //        Console.ReadKey(true);
            //        Console.Clear();
            //    }
            //}
            //while (i <= count)
            //{
            //    try
            //    {
            //        Console.WriteLine("请输入第{0}个学员的成绩", i);
            //        double score = Convert.ToDouble(Console.ReadLine());//转为double型，此处一旦报错，后面的以及sum +=j以及i++都不会执行，直接跳转到catch段代码
            //        sum += score;
            //        i++;
            //    }
            //    catch
            //    {
            //        Console.WriteLine("输入成绩有误，请重新输入");//前面一旦出现异常报错，执行玩catch段后，便会跳回到while循环中
            //        //Console.ReadKey(true);
            //    }
            //}
            //Console.WriteLine("总成绩为{0},平均成绩为{1:0.0}", sum, sum / count);
            //Console.ReadKey(true);


            #endregion
            #region 老师问学生会做了没有直到他会才放学
            //int i = 1;
            //string answer = "n";
            //while (i <= 10 && answer == "n")
            //{
            //L1:
            //    Console.WriteLine("老师问道：这道题你会做了吗？");
            //    Console.WriteLine("请输入y/n");
            //    answer = Console.ReadLine();
            //    if (answer == "n")
            //    {
            //        Console.WriteLine("老师又讲了一遍题目,已经讲了{0}遍了", i);
            //        i++;
            //        if (i == 11)
            //        {
            //            Console.WriteLine("10遍太多了，无论如何也要放学了");
            //        }
            //    }
            //    else if (answer == "y")
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("你说啥呢？好好说");
            //        //Console.ReadKey(true);
            //        goto L1;
            //    }
            //}
            //Console.WriteLine("太好了，可以放学了");
            //Console.ReadKey(true);
            #endregion
            #region 2006年八万人 每年增加25% 多久到达20万
            //2006培养学员80000人，每年增长25 %,请问按此增长速度，什么时候学员人数将达到20万人
            //循环体：每年增长25%
            //循环条件：人数小于20万
            //int year = 2006;
            //double number = 80000;
            //while (number <= 200000)
            //{
            //    year++;
            //    number *= 1.25;
            //}
            //Console.WriteLine("将在{0}年的时候达到20万人，此时的人数是{1:0.00}万人", year, number / 10000);
            //Console.ReadKey(true);
            #endregion
            #region 提示用户A B输入用户名
            //提示用户A输入用户名，不能为空，一旦为空，就要求用户A继续输入
            //循环体：提示用户A输入用户名
            //循环条件：用户名输入为空
            //string userNameA = "";
            //while (userNameA == "")
            //{
            //    Console.WriteLine("请用户A输入用户名");
            //    userNameA = Console.ReadLine();
            //    if (userNameA == "")
            //    {
            //        Console.WriteLine("用户名A不能为空，请重新输入");
            //    }
            //}
            ////第二个循环提示用户B输入用户名，并且不能和用户A的相同以及为空
            ////循环体：提示用户B输入用户名
            ////循环条件：用户B的用户名为空或与A的相同。
            //string userNameB = "";
            //while (userNameB == userNameA || userNameB == "")
            //{
            //    Console.WriteLine("请用户B输入用户名");
            //    userNameB = Console.ReadLine();
            //    if (userNameB == "")
            //    {
            //        Console.WriteLine("用户名不能为空，请重新输入");
            //    }
            //    else if (userNameB == userNameA)
            //    {
            //        Console.WriteLine("用户名B不能与A相同，请重新输入");
            //    }
            //}
            //Console.ReadKey(true);
            //Console.WriteLine("用户A的用户名是{0},用户B的用户名数{1}", userNameA, userNameB);
            //Console.ReadKey(true);
            #endregion
        } 
       
    }
}

