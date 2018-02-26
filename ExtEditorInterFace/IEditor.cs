using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtEditorInterFace
{   //接口
    public interface IEditor
    {
        string PluginName
        { get; }

        //启动插件程序
        void StartProgram(TextBox txtBox);
    }
}
