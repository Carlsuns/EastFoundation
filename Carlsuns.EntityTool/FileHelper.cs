using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace Carlsuns.EntityTool
{
    /**
    *
    * Ver 变更日期 负责人 变更内容
    * ───────────────────────────────────
    * V0.01 2018/1/25 17:13:21 房志伟 初版
    *
    *┌──────────────────────────────────┐
    *│　此程式版权归作者所有，在未经作者同意使用时，一切后果由使用者承担。│　　　　　　　　　　　　　│
    *└──────────────────────────────────┘
*/
    public static class FileHelper
    {
        static DBHelper _dbHelper = new DBHelper();
        public static string ConvertTableColumnToEntity(string strCon,string strDataBase,string strTableName,string strNameSpace)
        {
            string sql = "select column_name,data_type from " + strDataBase + ".information_schema.columns where table_name='" + strTableName + "'";
            string msg="";
            ArrayList list =_dbHelper.GetFieldByConAndSql(strCon, sql,out msg);
            StringBuilder builder = new StringBuilder();
            builder.Append("using System;\r");
            //builder.AppendLine("\r");
            builder.Append("\nusing System.Collections.Generic;\r");
            builder.Append("\nusing System.Linq;\r");
            builder.Append("\nusing System.Text;\r");
            builder.Append("\nusing System.Threading.Tasks;\r");
            builder.Append("\n\nnamespace "+ strNameSpace+ "\r");
            builder.Append("\npublic class ");
            builder.AppendLine(strTableName);
            builder.AppendLine("{");
            foreach (string str in list)
            {
                builder.Append("\tprivate ");
                builder.Append(str.Substring(str.IndexOf('|') + 1));
                builder.Append(" ");
                builder.Append(str.Substring(0, str.IndexOf('|')));
                builder.AppendLine(";");
                builder.Append("\tpublic ");
                builder.Append(str.Substring(str.IndexOf('|') + 1));
                builder.Append(" ");
                builder.AppendLine(str.Substring(0, 1).ToUpper() + str.Substring(1, str.IndexOf('|') - 1));
                builder.AppendLine("\t{");
                builder.Append("\t\tget { return ");
                builder.Append(str.Substring(0, str.IndexOf('|')));
                builder.AppendLine("; }");
                builder.Append("\t\tset { ");
                builder.Append(str.Substring(0, str.IndexOf('|')));
                builder.AppendLine(" = value; }");
                builder.AppendLine("\t}");
                builder.AppendLine();
            }
            builder.Remove(builder.Length - 3, 2);
            builder.Append("}");


            return builder.ToString();
        }

        public static void SaveCSharpFile(string strCon, string strDataBase, string strTableName, string strNameSpace,string strFilePath)
        {
            string fileContent = ConvertTableColumnToEntity(strCon, strDataBase, strTableName, strNameSpace);
            if (File.Exists(strFilePath))
                File.Delete(strFilePath);
            System.IO.File.WriteAllText(strFilePath, fileContent, Encoding.UTF8);
        }
    }
}
