using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtEditorInterFace;
using NotePadTextStyle;

namespace NotepadTextStyle
{
    public class SetTextStyle:IEditor
    {
        public string PluginName
        {
            get
            {
                return "字体";
            }

        }
        public void StartProgram(System.Windows.Forms.TextBox txtBox)
        {
            //这个插件里面还要添加一个窗体，作为选择
            frmSetTxtStyle frm = new frmSetTxtStyle(txtBox);
            frm.Show();
        }
    }
}
