using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePadTextStyle
{
    public partial class frmSetTxtStyle : Form
    {
        public frmSetTxtStyle()
        {
            InitializeComponent();
        }

        public frmSetTxtStyle(TextBox txtBox):this() //构造函数
        {
            _txtBox = txtBox;
        }

        private TextBox _txtBox;//定义一个文本对象

        private void btnOk_Click(object sender, EventArgs e)
        {
            float size = float.Parse(cboFontSize.Text);
            _txtBox.Font = new Font(cboFontFamily.Text, size);
            this.Close();//关闭
        }
    }
}
