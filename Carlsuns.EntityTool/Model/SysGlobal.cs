using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Carlsuns.EntityTool.Model
{
    /**
    *
    * Ver 变更日期 负责人 变更内容
    * ───────────────────────────────────
    * V0.01 2018/1/31 14:30:11 房志伟 初版
    *
    *┌──────────────────────────────────┐
    *│　此程式版权归作者所有，在未经作者同意使用时，一切后果由使用者承担。│　　　　　　　　　　　　　│
    *└──────────────────────────────────┘
*/
    public class SysGlobal
    {
        //const int LOCK = 10000000; //申请读写时间
        //private static IList<TableFileInfo> _iListTableFile = new List<TableFileInfo>();
        //static ReaderWriterLock pushLock = new ReaderWriterLock();//输入锁
        //public static IList<TableFileInfo> IListTableFile
        //{
        //    get { return _iListTableFile; }
        //}
        //public static bool PushTableFile(TableFileInfo model)
        //{
        //    foreach (Model.TableFileInfo tableFileInfo in _iListTableFile)
        //    {
        //        if (tableFileInfo == null)
        //            continue;
        //        if (tableFileInfo.TableName == model.TableName)
        //        {
        //            tableFileInfo.CheckValue = model.CheckValue;
        //            tableFileInfo.FilePath = model.FilePath;
        //            tableFileInfo.FileStatus = model.FileStatus;

        //            //释放
        //            if (pushLock.IsWriterLockHeld)
        //                pushLock.ReleaseWriterLock();
        //            if (pushLock.IsReaderLockHeld || pushLock.IsWriterLockHeld)
        //                pushLock.ReleaseLock();
        //            return true;
        //        }
        //    }

        //    _iListTableFile.Add(model);
        //    EventListener.OnUpdateFMainDataGridView(AddUpdateDelete.Add, model);

        //    //释放
        //    if (pushLock.IsWriterLockHeld)
        //        pushLock.ReleaseWriterLock();
        //    if (pushLock.IsReaderLockHeld || pushLock.IsWriterLockHeld)
        //        pushLock.ReleaseLock();
        //    return true;
        //}


    }
}
