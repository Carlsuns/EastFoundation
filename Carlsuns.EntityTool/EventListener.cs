using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Carlsuns.EntityTool.Model;

namespace Carlsuns.EntityTool
{
    /**
    *
    * Ver 变更日期 负责人 变更内容
    * ───────────────────────────────────
    * V0.01 2018/1/29 17:25:41 房志伟 初版
    *
    *┌──────────────────────────────────┐
    *│　此程式版权归作者所有，在未经作者同意使用时，一切后果由使用者承担。│　　　　　　　　　　　　　│
    *└──────────────────────────────────┘
*/
    public class EventListener
    {
        public delegate void UpdateDataGridViewHandler(AddUpdateDelete aud, TableFileInfo tableFileInfo, bool isErr = false, bool clearRows = false);
        public static event UpdateDataGridViewHandler UpdateDataGridViewEvent;
        public static void OnUpdateFMainDataGridView(AddUpdateDelete aud, TableFileInfo tableFileInfo, bool isErr = false, bool clearRows = false)
        {
            if (UpdateDataGridViewEvent != null)
                UpdateDataGridViewEvent(aud, tableFileInfo, isErr, clearRows);
        }
    }
}
