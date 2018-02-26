using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProFactory;
using ProOperation;

namespace ProCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //1.加载首先读取配置文件 
          string[] lines=  File.ReadAllLines("Config.txt");
            //2.坐标  139.154.75.23
            int x = 139;
            int y = 154;
            foreach (string item in lines)
            {
                //有几条数据，我就创建几个按钮
                Button btn = new Button();
                btn.Location = new Point(x, y);
                btn.Size = new Size(75, 23);
                x += 80;
                btn.Text = item;
                btn.Click += btn_Click;
                this.Controls.Add(btn);

            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //添加Factory和Operation的引用
  
            //sender就是触发当前对象的事件
            Button btn = sender as Button;//谁触发事件的就把谁的按钮给我
            int n1 = Convert.ToInt32(textBox1.Text.Trim());
            int n2 = Convert.ToInt32(textBox2.Text.Trim());
            //          //获得简单工厂的父类对象
            Operation oper = Factory.GetOper(btn.Text, n1, n2);
            //显示结果
            if(oper !=null)
            {
                label1.Text = oper.GetResult().ToString();
            }
            else
            {
                MessageBox.Show("并没有这个运算符");
            }
            
                 
        }
    }
}
