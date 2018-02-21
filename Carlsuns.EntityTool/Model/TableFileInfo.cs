using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carlsuns.EntityTool.Model
{
    /**
    *
    * Ver 变更日期 负责人 变更内容
    * ───────────────────────────────────
    * V0.01 2018/1/30 16:50:43 房志伟 初版
    *
    *┌──────────────────────────────────┐
    *│　此程式版权归作者所有，在未经作者同意使用时，一切后果由使用者承担。│　　　　　　　　　　　　　│
    *└──────────────────────────────────┘
*/
    public class TableFileInfo
    {
        public bool CheckValue;
        public string TableName;
        public string FilePath;
        public string FileStatus;

        /// <summary>
        /// 用于记录作业列表中对应的列
        /// </summary>
        public DataGridViewRow DataRow
        {
            get;
            set;
        }
    }
}
