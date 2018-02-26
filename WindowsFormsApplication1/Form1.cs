using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //5.窗体加载创建一个事件,要加上方法，在下面第6步写
            ucTripleClickEvent1.TripleClick += Click1;
            ucTripleClickEvent1.TripleClick += Click2;
        }
        private void Click1()
        {
           MessageBox.Show("通过事件实现的三连击");
        }
        private void Click2()
        {
            MessageBox.Show("通过事件实现的三连击222");
        }



        private void ucTripleClickEvent1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
