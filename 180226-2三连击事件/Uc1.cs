using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _180226_2三连击事件
{
    public partial class Uc1 : UserControl
    {
        public delegate void MyTripleClick();

        public Uc1()
        {
            InitializeComponent();
        }
        int count = 0;
        public event MyTripleClick TripleClick;
        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            if(count >=3)
            {
                if(TripleClick!=null)
                {
                    TripleClick();
                }
                count = 0;
            }
        }
    }
}
