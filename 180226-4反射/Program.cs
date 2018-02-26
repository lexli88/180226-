using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _180226_4反射
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 加载指定的程序集，并且截取程序集中的所有的类型
            ////1.  Assembly.LoadFilel加载程序集
            //Assembly asm = Assembly.LoadFile(@"D:\微云同步盘\2506330143\work\IT\C#练习\180226\180226事件练习\180226-4反射\bin\Debug\180226-04类库TestLib.dll");
            ////2.  获取asm这个程序集中的所有类型 types是一个数组
            //Type[] types = asm.GetTypes();

            //Console.WriteLine("下面是所有类，包含接口，不能实例化的抽象类，接口，委托等");
            //Console.WriteLine("********************************************************");
            ////3. 循环遍历把每个类型都输出
            //int i = 0;
            //foreach(Type typeitem in types)
            //{
            //    i++;
            //    Console.WriteLine(i+"  " +typeitem.Name);
            //}
            //Console.WriteLine("********************************************************");
            ////4.获取程序集中的所有的public的类型
            //Type[] exportedtypes = asm.GetExportedTypes();
            //Console.WriteLine("下面是所有public类");
            //Console.WriteLine("********************************************************");
            //int j= 0;
            //foreach(Type exitem in exportedtypes)
            //{
            //    j++;
            //    Console.WriteLine(j+"  " + exitem.Name);
            //}
            //Console.WriteLine("********************************************************");
            //Console.ReadLine();
            #endregion

            #region 加载指定的程序集，并且获取所有的方法
            //1. 加载程序集
            Assembly asm = Assembly.LoadFile(@"D:\微云同步盘\2506330143\work\IT\C#练习\180226\180226事件练习\180226-4反射\bin\Debug\TestLib.dll");
            ////2. 使用GetType获取Class1这个类型
            Type typeClass1 = asm.GetType("TestLib.Class1");

            ////3. 获取class1中的所有方法
            MethodInfo[] minfos = typeClass1.GetMethods();

            ////4. 遍历每个方法，把每个方法的名称打印出来。
            //foreach (MethodInfo methodItem in minfos)
            //{
            //    Console.WriteLine(methodItem.Name);
            //}

            //获取SayHi方法
            MethodInfo method = typeClass1.GetMethod("SayHi");
            //输出该方法名
            Console.WriteLine(method.Name);
            //创建一个Class1类型的对象
            object obj = Activator.CreateInstance(typeClass1);
            //调用该方法
            method.Invoke(obj,null); //由于SayHi方法没有参数，所以第二个参数传递一个null

            Console.ReadLine();
            #endregion
        }
    }
}
