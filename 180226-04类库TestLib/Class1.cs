using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    public class Class1
    {
        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public void SayHi()
        {
            Console.WriteLine("大家好");
        }
    }
    public interface IFlyable
    {
        void Fly();
    }
    //创建一个委托类型
    public delegate void MyDelegate();
    //创建一个枚举类型
    public enum Good
    {
        高,
        富,
        帅
    }
    //创建一个内部类
    internal class MyClass
    {
        internal void BBB()
        { Console.WriteLine("能看到这个吗？");
        }
    }
    //创建一个接口
    public interface IZiWoXiuFu
    {
        void XiuFu();
    }
    //创建一个Person类
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
    public class Chiness:Person,IZiWoXiuFu
    {
       public string HuKouSuoZaiDi
        {
            get;
            set;
        }
        //reload
        public void XiuFu()
        {
            Console.WriteLine("以素攻素，配平了");
        }
    }
    //创建一个静态类,不能实例化
    public abstract class MyAbsClass
    {
        public abstract void SayHello();  //直接调用
    }
    //创建一个抽象类，不能实例化
    public static class MyStaticClass
    {

    }
}
