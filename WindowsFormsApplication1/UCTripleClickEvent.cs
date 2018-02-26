using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    //3.创建一个委托类型
    public delegate void MyTripleClick();

    public partial class UCTripleClickEvent : UserControl
    {
        public UCTripleClickEvent()
        {
            InitializeComponent();
        }
        //1. 创建一个变量用于统计连击多少次
        int count = 0;

        //4. 有了委托类型就可以定义事件了
        public event MyTripleClick TripleClick;

        private void button1_Click(object sender, EventArgs e)
        {
            count++;   //2. 点击一次增加1
            if(count >=3)
            {
                if(TripleClick!=null)//判断这个事件为空，如果不为空，进去执行它
                {
                    TripleClick();
                }
                count = 0; //3. 清零
            }
        }
    }
}
