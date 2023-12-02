using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelConvertTools
{
    class JsonExporter
    {
        string m_context = "";
        public JsonExporter(ExcelLoader excel, Options options)
        {
            //获取所有表单
            List<DataTable> valitSheets = new List<DataTable>();
            for (int i = 0; i < excel.m_sheets.Count; i++)
            {
                DataTable sheet = excel.m_sheets[i];
                if (sheet.Columns.Count > 0 && sheet.Rows.Count > 0)
                {
                    valitSheets.Add(sheet);
                }
            }
            //设置导出格式
            var jsonSettings = new JsonSerializerSettings
            {
                DateFormatString = options.dataFormat,
                Formatting = Formatting.Indented
            };
            if (valitSheets.Count == 1)
            {
                object sheetValue = null;
                //设置Json格式
                if (options.exportType=="Array")
                {
                    sheetValue = ConvertSheetToArray(valitSheets[0], options);
                }
                else
                {
                    sheetValue = ConvertSheetToDict(valitSheets[0], options);
                }
                m_context = JsonConvert.SerializeObject(sheetValue, jsonSettings);
            }
            else
            {

            }
        }

        /// <summary>
        /// 将表格转换为数组
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        private object ConvertSheetToArray(DataTable sheet, Options options)
        {
            List<object> values = new List<object>();
            int firstDataRow = options.headerRows - 1;
            for (int i = firstDataRow; i < sheet.Rows.Count; i++)
            {
                //检测当前行第一格是否有忽略标记字符，如果存在则忽略该行
                if(IsRowIgnored(sheet.Rows[i]))
                {
                    continue;
                }
                DataRow row = sheet.Rows[i];
                values.Add(ConvertRowToDict(sheet, row, options));
            }
            return values;
        }
        /// <summary>
        /// 将表格转换为字典
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        private object ConvertSheetToDict(DataTable sheet, Options options)
        {
            Dictionary<string, object> importData = new Dictionary<string, object>();
            for (int i = 0; i < sheet.Rows.Count; i++)
            {
              
                DataRow row = sheet.Rows[i];

                string ID = row[sheet.Columns[0]].ToString();
                if (ID.Length <= 0)
                {
                    ID = string.Format("row_{0}", i);
                }

                importData[ID] = ConvertRowToDict(sheet, row, options);
            }
            return new object();
        }

        /// <summary>
        /// 将每一行转换为 "object",将每一列转换为属性 "Property"
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="row"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        private Dictionary<string, object> ConvertRowToDict(DataTable sheet, DataRow row, Options options)
        {
            var rowData = new Dictionary<string, object>();
            int col = 0;
            foreach (DataColumn column in sheet.Columns)
            {
                string columnName = column.ToString();
                //忽略掉进行标记的列
                if (options.ignoreStartStr.Length > 0 && columnName.StartsWith(options.ignoreStartStr))
                {
                    continue;
                }
                object value = row[column];
                //处理空值（DBNull 类表示一个不存在的值）
                if (value.GetType() == typeof(System.DBNull))
                {
                    value = GetColumnDefault(sheet, column, options.headerRows - 1);
                }
                string fieldName = column.ToString();

                if (options.lowcase)
                {
                    fieldName = fieldName.ToLower();
                }

                if (string.IsNullOrEmpty(fieldName))
                {
                    fieldName = string.Format("col_{0}", col);
                }

                rowData[fieldName] = value;
                col++;
            }

            return rowData;
        }

        /// <summary>
        /// 处理空值，如果表格中值为空，找到一列中的非空值，构造一个同类型默认值,
        /// 如果整列都为空，默认为string
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="column"></param>
        /// <param name="firstDataRow"></param>
        /// <returns></returns>
        object GetColumnDefault(DataTable sheet, DataColumn column, int firstDataRow)
        {
            for (int i = firstDataRow; i < sheet.Rows.Count; i++)
            {
                object value = sheet.Rows[i][column];
                Type valueType = value.GetType();
                if (valueType != typeof(System.DBNull))
                {
                    if (valueType.IsValueType)
                        return Activator.CreateInstance(valueType);
                    break;
                }
            }
            return "";
        }

        public void SaveContextToFile(string filePath, Encoding encoding)
        {
            //使用文件流来代替File.WriteAllText，防止文件被占用报错
            using (FileStream file = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            { 
                using (TextWriter writer = new StreamWriter(file, encoding))
                    writer.Write(m_context);
            }
        }

        public bool IsRowIgnored(DataRow row)
        {
            return row[0].ToString().StartsWith(DataManager.m_systemConfig.options.ignoreStartStr);
        }

    }
}
