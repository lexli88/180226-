using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _180226_3自定义验证控件事件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //12. 给控件添加事件要执行的方法
            userValidateControl1.UserLoginValidating += UserValidateControl1_UserLoginValidating;
        }
        //13.可以由上面直接生成此方法
        private void UserValidateControl1_UserLoginValidating(object sender, MyEventArgs e)
        {
            //添加一个判断，用户名和密码，完全一样就将IsSuccess的标志设置为true
            if(e.LoginId=="admin" && e.LoginPwd=="888888")
            {
                e.IsSuccess = true;
            }
           //throw new NotImplementedException();
        }
    }
}
