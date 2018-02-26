using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _180226_04自定义验证控件事件2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userValidateControl1.UserLoginValidating += UserValidateControl1_UserLoginValidating;
        }

        private void UserValidateControl1_UserLoginValidating(object sender, MyEventargs e)
        {
         if(e.LoginId=="admin" && e.LoginPwd=="888888")
            {
                e.IsSuccess = true;
            }
        }
    }
}
