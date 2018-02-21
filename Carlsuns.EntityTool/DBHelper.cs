using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using System.Data.SqlClient;

namespace Carlsuns.EntityTool
{
    /**
    *
    * Ver 变更日期 负责人 变更内容
    * ───────────────────────────────────
    * V0.01 2018/1/24 14:57:46 房志伟 初版
    *
    *┌──────────────────────────────────┐
    *│　此程式版权归作者所有，在未经作者同意使用时，一切后果由使用者承担。│　　　　　　　　　　　　　│
    *└──────────────────────────────────┘
*/
    public class DBHelper
    {
        public DBHelper()
        { }
        public ArrayList GetDataByConAndSql(string strCon, string sql, out string msg)
        {
            ArrayList list = new ArrayList();
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = null;
                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(reader[0].ToString());
                    }
                    msg = "登录成功";
                }
                catch (SqlException exception)
                {
                    msg = exception.Message;
                }
                catch (Exception exception2)
                {
                    msg = exception2.Message;
                }
                finally
                {
                    if (reader != null)
                    {
                        reader.Close();
                    }
                    connection.Close();
                }
                return list;
            }
        }

        public ArrayList GetFieldAndNullByConAndSql(string strCon, string sql)
        {
            ArrayList list = new ArrayList();
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = null;
                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string str = reader[0].ToString().Substring(0, 1).ToLower() + reader[0].ToString().Substring(1);
                        string str2 = reader[1].ToString().ToUpper();
                        if ("NO" == str2)
                        {
                            str2 = "not null";
                        }
                        else
                        {
                            str2 = "null";
                        }
                        //AboutField field = new AboutField();
                        //field.col_name = str;
                        //field.col_nullable = str2;
                        //list.Add(field);
                    }
                }
                catch (SqlException exception)
                {
                    throw exception;
                }
                catch (Exception exception2)
                {
                    throw exception2;
                }
                finally
                {
                    if (reader != null)
                    {
                        reader.Close();
                    }
                    connection.Close();
                }
                return list;
            }
        }

        public ArrayList GetFieldByConAndSql(string strCon, string sql,out string msg)
        {
            ArrayList list = new ArrayList();
            msg = "";
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = null;
                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add((reader[0].ToString().Substring(0, 1).ToLower() + reader[0].ToString().Substring(1)) + "|" + this.DBTpyeConvertCSType(reader[1].ToString()));
                    }
                }
                catch (SqlException exception)
                {
                    msg = exception.Message;
                    throw exception;
                }
                catch (Exception exception2)
                {
                    msg = exception2.Message;
                    throw exception2;
                }
                finally
                {
                    if (reader != null)
                    {
                        reader.Close();
                    }
                    connection.Close();
                }
                return list;
            }
        }

        #region string DBTpyeConvertCSType将SQLServer的数据类型转换为C#类型
        /// <summary>
        /// 将SQLServer的数据类型转换为C#类型
        /// </summary>
        /// <param name="dbtype"></param>
        /// <returns></returns>
        private string DBTpyeConvertCSType(string dbtype)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("SQL", "C#");
            hashtable.Add("bigint", "long");
            hashtable.Add("binary", "object");
            hashtable.Add("bit", "bool");
            hashtable.Add("char", "string");
            hashtable.Add("datetime", "DateTime");
            hashtable.Add("decimal", "decimal");
            hashtable.Add("float", "double");
            hashtable.Add("image", "byte[]");
            hashtable.Add("int", "int");
            hashtable.Add("money", "decimal");
            hashtable.Add("nchar", "string");
            hashtable.Add("ntext", "string");
            hashtable.Add("numeric", "decimal");
            hashtable.Add("nvarchar", "string");
            hashtable.Add("real", "float");
            hashtable.Add("smalldatetime", "DateTime");
            hashtable.Add("smallint", "short");
            hashtable.Add("smallmoney", "decimal");
            hashtable.Add("text", "string");
            hashtable.Add("timestamp", "byte[]");
            hashtable.Add("tinyint", "byte");
            hashtable.Add("uniqueidentifier", "Guid");
            hashtable.Add("varbinary", "byte[]");
            hashtable.Add("varchar", "string");
            hashtable.Add("xml", "string");
            hashtable.Add("sql_variant", "object");
            string str = "未知类型";
            if (!string.IsNullOrEmpty(dbtype))
            {
                try
                {
                    str = hashtable[dbtype].ToString();
                    if (string.IsNullOrEmpty(str))
                    {
                        str = "未知类型";
                    }
                }
                catch
                {
                    str = "未知类型";
                }
            }
            return str;
        }

        #endregion
    }
}
