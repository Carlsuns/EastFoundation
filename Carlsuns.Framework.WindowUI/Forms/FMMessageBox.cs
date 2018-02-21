using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Carlsuns.Framework.WindowUI.Forms
{
    /**
    *
    * Ver 变更日期 负责人 变更内容
    * ───────────────────────────────────
    * V0.01 2017/4/13 10:53:45 房志伟 初版
    *
    *┌──────────────────────────────────┐
    *│　此程式版权归作者所有，在未经作者同意使用时，一切后果由使用者承担。│　　　　　　　　　　　　　│
    *└──────────────────────────────────┘
*/


    /// <summary>
    /// MessageBox的扩展类
    /// </summary>
    public class FMMessageBox
    {
        public static DialogResult Info(string captionText, string message)
        {
            return ShowMessageBox(captionText, message, EnumMessageBox.Info);
        }


        private static DialogResult ShowMessageBox(string captionText, string message, EnumMessageBox infoType)
        {
            FM_MessageBox frm = new FM_MessageBox(captionText, message, infoType);
            DialogResult result = frm.ShowDialog();
            frm.Dispose();
            return result;
        }
    }
}
