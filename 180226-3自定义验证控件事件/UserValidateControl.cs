using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _180226_3自定义验证控件事件
{ //1.创建委托类型，要传出参数，就要定义一个object对象和一个事件MyEventArgs在最后定义一个类及属性
    public delegate void UserValidatingDelegate(object sender, MyEventArgs e);

    public partial class UserValidateControl : UserControl
    {
        //3.有了委托类型，就可以定义一个委托变量加event就是事件
        public event UserValidatingDelegate UserLoginValidating;
        public UserValidateControl()
        {
            InitializeComponent();
        }

        private void UserValidateControl_Load(object sender, EventArgs e)
        {
       
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //4.有了MyEventArgs类，就可以new 一个对象出来操作
            MyEventArgs eventArgs = new MyEventArgs();
            //5.loginid用于接收用户名文本框的用户名
            eventArgs.LoginId = txtUserId.Text.Trim();
            //6. LoginPwd用于接收密码框的内容
            eventArgs.LoginPwd = txtUserPwd.Text;

            //7. 使用是否成功，默认为false
            eventArgs.IsSuccess = false;
            //8. 传送这个控件及事件
            UserLoginValidating(this, eventArgs);
            //9. 判断是否成功用户名和密码是否匹配，颜色变化
            if(eventArgs.IsSuccess)
            {
                txtUserId.BackColor = Color.Green;
                txtUserPwd.BackColor = Color.Green;
            }
            else
            {
                txtUserId.BackColor = Color.Red;
                txtUserPwd.BackColor = Color.Red;
            }
        }
    }
    //2. 创建一个事件的类用于new对象，属性三个用户名和密码，成功标志
    public class MyEventArgs
    {
        public string LoginId
        {
            get;
            set;
        }
        public string LoginPwd
        {
            get;
            set;
        }
        public bool IsSuccess
        {
            get;
            set;
        }
    }
}
