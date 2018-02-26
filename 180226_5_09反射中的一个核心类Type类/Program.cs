using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _180226_5_09反射中的一个核心类Type类
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            //1.获取 Person类型的Type
            Type type = p.GetType(); //对象名方式获取
            //2. 通过typeof关键字
            Type type1 = typeof(Person);   //通过类名方式获取
            //3.通过程序集对象的GetType()方法
            Assembly asm = Assembly.LoadFile(@"D:\微云同步盘\2506330143\work\IT\C#练习\180226\180226事件练习\180226-4反射\bin\Debug\TestLib.dll");
            //asm.GetType("命名空间.类型名")方式
            Type typs = asm.GetType("TestLib.Class1");

            //4.1 获取Chinese 类型的Type
            Type typChiness = asm.GetType("TestLib.Chiness");

            //4.2 获取Person类型的Type
            Type typPerson = asm.GetType("TestLib.Person");

            //4.3 获取接口类型的Type
            Type typIXiuFu = asm.GetType("TestLib.IZiWoXiuFu");

            //4.4 获取抽象类MyAbsClass的Type
            Type typMyAbsClass = asm.GetType("TestLib.MyAbsClass");

            //4.5 获取静态类MyStaticClass的Type
            Type typMyStaticClass = asm.GetType("TestLib.MyStaticClass");

            //5. 验证一下Person类型是不是Chinese类型的父类
            bool b = typPerson.IsAssignableFrom(typChiness);

            Console.WriteLine(b);

            //6. 验证接口是否可以从typChinese继承,是否可以将typChiness的对象赋值给typIXiuFu类型
            bool b1 = typIXiuFu.IsAssignableFrom(typChiness);
            Console.WriteLine(b1);

            //7.创建一个typchiness类型的对象 obj
            object obj = Activator.CreateInstance(typChiness);

            //8.验证obj是不是Typchiness类型的对象
            bool b2 = typChiness.IsInstanceOfType(obj);
            Console.WriteLine(b2);

            //9. 验证typeChiness是否为typPerson的子类
            bool b3 = typChiness.IsSubclassOf(typPerson);
            Console.WriteLine(b3);

            //10. 判断 typChiness是否是typIXiuFu的子类
            //IsSubClassOf不考虑接口，只考虑父子类关系 
            bool b4 = typChiness.IsSubclassOf(typIXiuFu);
            Console.WriteLine(b4);  //false

            //11. IsAbstract 判断某个类型是否是一个抽象类
            //接口，抽象类、静态类都不能被实例化，所以这里都认为是“抽象的”
            Console.WriteLine(typChiness.IsAbstract);       //false
            Console.WriteLine(typPerson.IsAbstract);        //false
            Console.WriteLine(typIXiuFu.IsAbstract);        //true
            Console.WriteLine(typMyAbsClass.IsAbstract);    //true
            Console.WriteLine(typMyStaticClass.IsAbstract); //true


            Console.ReadLine();
        }
    }
    public class Person
    {
        public string Name
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
    }
}
