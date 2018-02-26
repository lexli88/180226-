using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _180226_2三连击事件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uc11.TripleClick += Click1;
            uc11.TripleClick += Click2;
        }
        private void Click1()
        {
            MessageBox.Show("第1个事件！。。");
        }
        private void Click2()
        {
            MessageBox.Show("第2个事件！。。。");
        }
    }
}
