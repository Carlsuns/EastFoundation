using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Collections;
using Carlsuns.EntityTool.Model;
using System.Threading;

namespace Carlsuns.EntityTool
{
    public partial class FM_Main : Form
    {

        private static Assembly asm = Assembly.GetExecutingAssembly();//如果是当前程序集
        AssemblyCopyrightAttribute asmcpr = (AssemblyCopyrightAttribute)Attribute.GetCustomAttribute(asm, typeof(AssemblyCopyrightAttribute));
        private string version = "V" + Application.ProductVersion;
        private string productName = Application.ProductName;
        private string companyName = Application.CompanyName;
        string copyRight = "";

        #region 定义全局变量
        private string _strCon = "";
        private DBHelper _dbHelper = new DBHelper();
        #endregion
        public FM_Main()
        {
            InitializeComponent();

            copyRight = asmcpr.Copyright;
            this.TSSL_ProductNameVersion.Text = Application.ProductName + " " + version + " "+ copyRight+" "+companyName;
        }


        private void FM_Main_Load(object sender, EventArgs e)
        {

            DataGridViewTextBoxColumn TableName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn FilePath = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn FileStatus = new DataGridViewTextBoxColumn();
            DataGridViewCheckBoxColumn SelectBox = new DataGridViewCheckBoxColumn();

            TableName.HeaderText = "表名";
            TableName.Name = "TableName";
            TableName.Width = 200;
            TableName.ReadOnly = true;
            TableName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            FilePath.HeaderText = "生成路径";
            FilePath.Name = "FilePath";
            FilePath.Width = 500;
            FilePath.ReadOnly = true;

            FileStatus.HeaderText = "生成状态";
            FileStatus.Name = "FileStatus";
            FileStatus.Width = 100;
            FileStatus.ReadOnly = true;

            SelectBox.DataPropertyName = "SelectBox";
            SelectBox.Width = 40;
            SelectBox.ReadOnly = false;
            SelectBox.HeaderText = "";
            datagridviewCheckboxHeaderCell ch = new datagridviewCheckboxHeaderCell();
            ch.OnCheckBoxClicked += new datagridviewCheckboxHeaderCell.HeaderEventHander(ch_OnCheckBoxClicked);
            SelectBox.HeaderCell = ch;


            try
            {
                dv_tableList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { SelectBox,TableName, FilePath, FileStatus });
                dv_tableList.AllowUserToAddRows = false;
                dv_tableList.AllowUserToDeleteRows = false;
                dv_tableList.BackgroundColor = System.Drawing.Color.LightSteelBlue;
                dv_tableList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dv_tableList.GridColor = System.Drawing.Color.LightSteelBlue;
                dv_tableList.RowHeadersWidth = 20;
                dv_tableList.RowTemplate.Height = 23;
                dv_tableList.TabIndex = 15;

                //delDataGridView = new DelegateDataGridView(this.UpdateDVTableFile);
                EventListener.UpdateDataGridViewEvent += UpdateDVTableFile;
            }
            catch (Exception ex)
            { }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            _strCon = "Server=" + this.tb_server.Text.Trim() + ";Database=master;Uid=" + this.tb_user.Text.Trim() + ";Pwd=" + this.tb_password.Text.Trim();
            
            string sql = "select name from sysdatabases order by name asc";
            string msg = null;
            ArrayList list = this._dbHelper.GetDataByConAndSql(_strCon, sql, out msg);
            if (msg != null)
            {
                if ("登录成功" == msg)
                {
                    this.cbo_dbList.DataSource = list;
                    this.cbo_dbList.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show(msg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cbo_dbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool checkValue = ((datagridviewCheckboxHeaderCell)this.dv_tableList.Columns[0].HeaderCell).Checked;

            if (string.IsNullOrEmpty(cbo_dbList.Text))
            {
                MessageBox.Show("请选择数据库！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql = "select table_name from " + this.cbo_dbList.Text.Trim() + ".information_schema.tables order by table_name asc";
                string msg = null;
                ArrayList list = this._dbHelper.GetDataByConAndSql(_strCon, sql, out msg);
                if ("登录成功" == msg)
                {
                    this.dv_tableList.Rows.Clear();
                    foreach (string s in list)
                    {
                        TableFileInfo model = new TableFileInfo();
                        model.CheckValue = checkValue;
                        model.TableName = s;
                        model.FilePath = this.tb_dirPath.Text + "\\" + s + ".cs";
                        model.FileStatus = "未生成";
                        EventListener.OnUpdateFMainDataGridView(AddUpdateDelete.Add, model);
                    }
                }
            }
        }
        
        //定义触发单击事件的委托         
        public delegate void datagridviewcheckboxHeaderEventHander(object sender, datagridviewCheckboxHeaderEventArgs e);
        void ch_OnCheckBoxClicked(object sender, datagridviewCheckboxHeaderEventArgs e)
        {
            foreach (DataGridViewRow dgvRow in dv_tableList.Rows)
            {
                if (e.CheckedState)
                {
                    dgvRow.Cells[0].Value = true;
                }
                else
                {
                    dgvRow.Cells[0].Value = false;
                }
            }
            btn_createFile.Focus();
        }

        private void dv_tableList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 0)
            {
                dv_tableList.EndEdit();
            }
        }

        private void btn_dirPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.tb_dirPath.Text = dialog.SelectedPath;
            }

            foreach (DataGridViewRow dgvRow in dv_tableList.Rows)
            {
                dgvRow.Cells[2].Value = this.tb_dirPath.Text + "\\" + dgvRow.Cells[1].Value + ".cs";
            }
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            string strNameSpace = this.tb_nameSpace.Text;
            string strTableName = "";
            //string strFilePath = "";
            if (string.IsNullOrEmpty(strNameSpace))
            {
                this.tb_nameSpace.Focus();
                MessageBox.Show("命名空间不可为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            foreach (DataGridViewRow dgvRow in dv_tableList.Rows)
            {
                if ((bool)dgvRow.Cells[0].Value)
                {
                    if (string.IsNullOrEmpty(strTableName))
                    {
                        strTableName = (string)dgvRow.Cells[1].Value;
                        //strFilePath= (string)dgvRow.Cells[2].Value;
                        dgvRow.Cells[3].Value = "已生成";
                    }
                    else
                    {
                        MessageBox.Show("请选择一条记录进行预览！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }
            }
            if (string.IsNullOrEmpty(strTableName))
            {
                MessageBox.Show("请选择一条记录进行预览！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }


            //FileHelper.SaveCSharpFile(_strCon, this.cbo_dbList.Text, strTableName, strNameSpace, strFilePath);

            FM_Preview fm_Preview = new FM_Preview(FileHelper.ConvertTableColumnToEntity(_strCon, this.cbo_dbList.Text, strTableName, strNameSpace));
            fm_Preview.ShowDialog();

        }

        private void btn_createFile_Click(object sender, EventArgs e)
        {
            List<string> listTable = new List<string>();
            string strNameSpace = this.tb_nameSpace.Text;
            if (string.IsNullOrEmpty(strNameSpace))
            {
                this.tb_nameSpace.Focus();
                MessageBox.Show("命名空间不可为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (string.IsNullOrEmpty(this.tb_dirPath.Text))
            {
                this.btn_dirPath.Focus();
                MessageBox.Show("生成目录不可以为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            foreach (DataGridViewRow dgvRow in dv_tableList.Rows)
            {
                if ((bool)dgvRow.Cells[0].Value)
                {
                    listTable.Add((string)dgvRow.Cells[1].Value);
                }
            }
            if (listTable.Count<1)
            {
                MessageBox.Show("请至少选择一条记录进行生成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            FM_CreateFile fm_CreateFile = new FM_CreateFile(listTable,this.tb_dirPath.Text,this._strCon, cbo_dbList.Text,strNameSpace);
            fm_CreateFile.ShowDialog();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            this.cbo_dbList_SelectedIndexChanged(sender, e);
        }


        //定义允许工作线程访问更新作业列表的delegate
        public delegate void DelegateDataGridView(AddUpdateDelete aud, Model.TableFileInfo tableFileInfo, bool isErr = false, bool clearRows = false);
        public DelegateDataGridView delDataGridView;
        private void UpdateDVTableFile(AddUpdateDelete aud, Model.TableFileInfo tableFileInfo, bool isErr = false, bool clearRows = false)
        {
            try
            {
                if (this.dv_tableList.InvokeRequired)
                {
                    object[] wrk = { aud, tableFileInfo, isErr, clearRows };
                    delDataGridView=new DelegateDataGridView(UpdateDVTableFile);
                    this.dv_tableList.Invoke(this.delDataGridView, wrk);
                }
                else
                {
                    if (clearRows)
                        this.dv_tableList.Rows.Clear();
                    else
                        switch (aud)
                        {
                            case AddUpdateDelete.Add:
                                if (tableFileInfo.TableName!= string.Empty)
                                {
                                    this.dv_tableList.Rows.Add();
                                    DataGridViewRow r = this.dv_tableList.Rows[this.dv_tableList.Rows.Count - 1];
                                    r.SetValues(tableFileInfo.CheckValue,tableFileInfo.TableName,tableFileInfo.FilePath,tableFileInfo.FileStatus);
                                    tableFileInfo.DataRow = r;
                                }
                                break;
                            case AddUpdateDelete.Update:
                                if (tableFileInfo.TableName != string.Empty )//&& tableFileInfo.DataRow != null)
                                {
                                    foreach (DataGridViewRow dgvRow in dv_tableList.Rows)
                                    {
                                        if (tableFileInfo.TableName == (string)dgvRow.Cells[1].Value)
                                        {
                                            dgvRow.Cells[3].Value = tableFileInfo.FileStatus;
                                            continue;
                                        }
                                    }

                                    //DataGridViewRow r = tableFileInfo.DataRow;
                                    ////r.SetValues(tableFileInfo.CheckValue, tableFileInfo.TableName, tableFileInfo.FilePath, tableFileInfo.FileStatus);
                                    //r.SetValues(r.Cells[0].Value,
                                    //    r.Cells[1].Value,
                                    //    r.Cells[2].Value,
                                    //    tableFileInfo.FileStatus);
                                    //if (isErr)
                                    //    this.dv_tableList.Rows[this.dv_tableList.Rows.IndexOf(r)].Cells[3].Style.ForeColor = Color.Red;
                                }
                                break;
                            case AddUpdateDelete.Delete:
                                if (tableFileInfo.TableName != string.Empty)
                                {
                                    this.dv_tableList.Rows.Remove(tableFileInfo.DataRow);
                                }
                                break;
                            default: break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }
    }
}
