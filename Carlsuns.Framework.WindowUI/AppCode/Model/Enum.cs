using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carlsuns.Framework.WindowUI
{
    /**
    *
    * Ver 变更日期 负责人 变更内容
    * ───────────────────────────────────
    * V0.01 2017/4/13 11:09:52 房志伟 初版
    *
    *┌──────────────────────────────────┐
    *│　此程式版权归作者所有，在未经作者同意使用时，一切后果由使用者承担。│　　　　　　　　　　　　　│
    *└──────────────────────────────────┘
*/

    #region EnumMessageBox

    /// <summary>
    /// EnumMessageBox的信息类型
    /// </summary>
    internal enum EnumMessageBox
    {
        /// <summary>
        /// 信息
        /// </summary>
        Info,

        /// <summary>
        /// 错误
        /// </summary>
        Error,

        /// <summary>
        /// 询问
        /// </summary>
        Question,

        /// <summary>
        /// 警告
        /// </summary>
        Warning,
    }

    #endregion
}
