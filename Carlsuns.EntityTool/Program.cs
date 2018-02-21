using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Carlsuns.Framework.WindowUI;

namespace Carlsuns.EntityTool
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            #region 设置皮肤
            SoftConfig.SkinFile = @"Skins\Office2007\Office2007.ssk";
            Sunisoft.IrisSkin.SkinEngine se = new Sunisoft.IrisSkin.SkinEngine();
            se.@__DrawButtonFocusRectangle = true;
            se.DisabledButtonTextColor = System.Drawing.Color.Gray;
            se.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            se.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            se.SerialNumber = "";
            se.SkinFile = System.AppDomain.CurrentDomain.BaseDirectory + SoftConfig.SkinFile; //皮肤文件.ssk
            #endregion


            //获取欲启动进程名
            string strProcessName = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
            //检查进程是否已经启动，已经启动则显示报错信息退出程序。 
            if (System.Diagnostics.Process.GetProcessesByName(strProcessName).Length > 1)
            {
                MessageBox.Show("程序已开启，不能重复启动！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FM_Main());
        }
    }
}
