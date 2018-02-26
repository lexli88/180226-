using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExtEditorInterFace;

namespace 记事本
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //主程序的窗体加载事件

        private void Form1_Load(object sender, EventArgs e)
        {
            //1.检查plugins目录下是否有dll文件 
            //1.1获取当前执行的exe文件 的绝对路径
            string exePath = Assembly.GetExecutingAssembly().Location;
            //获取插件的目录路径
            string pluginsPath = Path.Combine(Path.GetDirectoryName(exePath), "plugins");
            //2.如果有dll文件，则循环遍历，将每个dll文件都通过Assembly.LoadFile();加载进来，然后获取dll程序集中的类型

            //2.1 搜索pluginsPath目录下是否有对应的dll文件 
            //返回值是一个string[]数值，里面存储着每个dll文件的完整路径
            string[] dlls = Directory.GetFiles(pluginsPath, "*.dll");

            //循环遍历把每个插件（dll）都加载
            foreach(string item in dlls)
            {
                //这里每个item,就是每个dll的完整路径
                Assembly asem = Assembly.LoadFile(item);

                //获取当前插件（当前的asem这个程序集中对应的类型，然后调用方法就可以了
                //遍历asem这个插件（程序集）中的每个类型，找到那些public的类型，并且是实现了IEditor接口的哪些类

                //获取所有的public类型
                Type[] typs = asem.GetExportedTypes();

                //获取所接口的Type
                Type typIEditor = typeof(IEditor);

                //遍历每个类型看看这个类型是否是实现了IEditor接口的类型
                foreach(Type typeClass in typs)
                {
                    //判断当前类型typeClass,是否实现了IEDitor这个接口
                    //2.并且这个类型是可以被实例化的，否则不能用。
                    if(typIEditor.IsAssignableFrom(typeClass)&& !typeClass.IsAbstract)
                    {
                        //创建一个typeClass类型的对象
                        IEditor editor = (IEditor)Activator.CreateInstance(typeClass);

                        //在菜单栏中，将该插件的名称增加进去
                        ToolStripItem tsiMenu = this.格式ToolStripMenuItem.DropDownItems.Add(editor.PluginName);
                        tsiMenu.Tag = editor;


                        //为tsiMenu注册一个单击事件
                        tsiMenu.Click += new EventHandler(tsiMenu_Click);
                    }
                }
            }
        } 
        //新增的插件的菜单项的单击事件
    void tsiMenu_Click(object sender, EventArgs e)
    {
        //sender就是当前单击的菜单项
        ToolStripItem tsi = (ToolStripItem)sender;
        IEditor editor = (IEditor)tsi.Tag;
        editor.StartProgram(textBox1);
    }
    }

}
 