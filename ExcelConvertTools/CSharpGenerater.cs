using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
struct FieldDef
{
    public string name;
    public string type;
    public string comment;
}


namespace ExcelConvertTools
{
    class CSharpGenerater
    {
        string m_code="";
        public CSharpGenerater(string excelName, ExcelLoader excelLoader, string ignoreStartStr)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("//");
            sb.AppendLine("// Auto Generated Code");
            sb.AppendLine("// 1. 每个 Sheet 形成一个 Struct 定义, Sheet 的名称作为 Struct 的名称");
            sb.AppendLine("// 2. 表格约定：第一行是变量名称，第二行是变量类型");
            sb.AppendLine();
            sb.AppendFormat("// Generate From {0}.xlsx", excelName);
            sb.AppendLine();
            sb.AppendLine();

            for(int i=0;i<excelLoader.m_sheets.Count;i++)
            {
                DataTable sheet = excelLoader.m_sheets[i];
                sb.Append(ExportSheet(sheet, ignoreStartStr));
            }
            sb.AppendLine();
            sb.AppendLine("//End of Auto Generated Code");
            m_code = sb.ToString();
        }

        /// <summary>
        /// 处理每一张sheet
        /// </summary>
        /// <param name="sheet"></param>
        /// <returns></returns>
        private string ExportSheet(DataTable sheet, string excludePrefix)
        {
            if (sheet.Columns.Count < 0 || sheet.Rows.Count < 2)
                return "";
            string sheetName = sheet.TableName;
            if (excludePrefix.Length > 0 && sheetName.StartsWith(excludePrefix))
                return "";

            List<FieldDef> fieldList = new List<FieldDef>();
            DataRow typeRow = sheet.Rows[0];
            DataRow commentRow = sheet.Rows[1];

            foreach (DataColumn column in sheet.Columns)
            {
                string columnName = column.ToString();
                if (excludePrefix.Length > 0 && columnName.StartsWith(excludePrefix))
                    continue;

                FieldDef field;
                field.name = column.ToString();
                field.type = typeRow[column].ToString();
                field.comment = commentRow[column].ToString();

                fieldList.Add(field);
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("public class {0}\r\n{{", sheet.TableName);
            sb.AppendLine();

            foreach (FieldDef f in fieldList)
            {
                sb.AppendFormat("\tpublic {0} {1}; // {2}", f.type, f.name, f.comment);
                sb.AppendLine();
            }
            sb.Append('}');
            sb.AppendLine();
            sb.AppendLine();
            return sb.ToString();
        }

        public void SaveToFile(string filePath,Encoding encoding)
        {
            using (FileStream file = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                using (TextWriter writer = new StreamWriter(file, encoding))
                    writer.Write(m_code);
            }
        }
    }
}
