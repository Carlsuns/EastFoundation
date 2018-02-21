using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Carlsuns.EntityTool
{
    public partial class FM_CreateFile : Form
    {
        IList<string>  _listTableName;
        string _dirPath;
        string _dbConnection;
        string _dataBase;
        string _nameSpace;
        private delegate void SetPos(int ipos, int iTotal,string strMessage);//代理
        private delegate void DelCloseForm();//关闭方法的委托
        public FM_CreateFile(IList<string> listTableName,string dirPath,string dbConnection,string dataBase,string nameSpace)
        {
            _listTableName = listTableName;
            _dirPath = dirPath;
            _dbConnection = dbConnection;
            _dataBase = dataBase;
            _nameSpace = nameSpace;
            InitializeComponent();

        }

        private void CreateFiles()
        {
            int i = 0;
            try
            {
                int fileCount = _listTableName == null ? 0 : _listTableName.Count;
                while (i < fileCount)
                {
                    FileHelper.SaveCSharpFile(_dbConnection, _dataBase, _listTableName[i], _nameSpace, _dirPath + "\\" + _listTableName[i] + ".cs");
                    SetTextMesssage(i, fileCount, "");
                    Model.TableFileInfo model = new Model.TableFileInfo();
                    model.TableName = _listTableName[i];
                    model.FileStatus = "文件已生成，目录为：" + _dirPath + "\\" + _listTableName[i] + ".cs";
                    EventListener.OnUpdateFMainDataGridView(Model.AddUpdateDelete.Update, model);
                    i++;
                }
                SetTextMesssage(fileCount, fileCount, "");
                //System.Threading.Thread.CurrentThread.Abort();
            }
            catch (Exception ex)
            {
                MessageBox.Show(System.Threading.Thread.CurrentThread.ThreadState.ToString());
                Model.TableFileInfo model = new Model.TableFileInfo();
                model.TableName = _listTableName[i - 1 < 0 ? 0 : i - 1];
                model.FileStatus = "生成文件报错，错误原因为" + ex.Message;
                EventListener.OnUpdateFMainDataGridView(Model.AddUpdateDelete.Update, model);

                MessageBox.Show("生成文件报错，错误原因为" + ex.Message, "报错", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.CloseForm();
            }

        }

        private void SetTextMesssage(int ipos, int iTotal, string strMessage)
        {
            if (this.InvokeRequired)
            {
                SetPos setpos = new SetPos(SetTextMesssage);
                this.Invoke(setpos, new object[] { ipos, iTotal, strMessage });
            }
            else
            {
                this.lb_status.Text = "已完成" + ipos + "/" + iTotal + "  "+ strMessage;
                this.pb_createFile.Value = Convert.ToInt32(ipos * 100/ iTotal);
            }
        }

        //关闭当前窗口
        private void CloseForm()
        {
            if (this.InvokeRequired)
            {
                DelCloseForm delCloseForm=new DelCloseForm(CloseForm);
                this.Invoke(delCloseForm, new object[] { });
            }
            else
            {
                this.Dispose();
                this.Close();
            }
        }

        private void FM_CreateFile_Shown(object sender, EventArgs e)
        {
            this.Show();
            Thread thread = new Thread(CreateFiles);
            thread.Start();
        }
    }
}
