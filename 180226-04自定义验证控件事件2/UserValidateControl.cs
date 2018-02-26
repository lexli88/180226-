using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _180226_04自定义验证控件事件2
{
    public delegate void UserValidatingDelegate(object sender, MyEventargs e);

    public partial class UserValidateControl : UserControl
    {
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
            MyEventargs eventArgs = new MyEventargs();
            eventArgs.LoginId = UserId.Text.Trim();
            eventArgs.LoginPwd = UserPwd.Text;
            eventArgs.IsSuccess = false;

            UserLoginValidating(this, eventArgs);
            if (eventArgs.IsSuccess)
            {
                UserId.BackColor = Color.Green;
                UserPwd.BackColor = Color.Green;
            }
            else
            {
                UserId.BackColor = Color.Red;
                UserPwd.BackColor = Color.Red;
            }
        }
    }
}
