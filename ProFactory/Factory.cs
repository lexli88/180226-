using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProOperation;
using System.Reflection;
using System.IO;

namespace ProFactory
{
    public class Factory
    {
        //工厂返回父类，其实父类中装的是子类对象
        //创建一个静态方法
        public static Operation GetOper(string type, int n1, int n2)
        {
            Operation oper = null;

            //plug中添加了add.dll后，要动态的加载
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "plug");
            //获得path路径下所有程序集文件 的全路径
            string[] files = Directory.GetFiles(path, "*.dll");
            //遍历
            foreach (string item in files)
            {
                Assembly ass = Assembly.LoadFile(item);
                //获得程序集文件中所有公开的数据类型
                Type[] types = ass.GetExportedTypes();
                foreach (Type tt in types)
                {
                    //还要判断是否是我要的数据类型，是子类，而且不是抽象类
                    if (tt.IsSubclassOf(typeof(Operation)) && !tt.IsAbstract)
                    {
                        //创建子类对象，赋值给oper
                        //object o=  改成oper 对象  后面的还要强转换
                        oper = (Operation)Activator.CreateInstance(tt, n1, n2);
                        if (type == oper.Type)
                        {
                            return oper;
                        }
                        else
                        {
                            oper = null; //将这个对象清空
                        }
                    }
                }
            }
            return oper;
        }
    }
}
