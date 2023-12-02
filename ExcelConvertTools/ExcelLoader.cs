using System;
using System.IO;
using System.Data;
using ExcelDataReader;

namespace ExcelConvertTools
{
    public class ExcelDataOptions
    {
        public string excelPath;
        public string jsonPath;
        public string cSharpPath;
        public string fileName;

        public int headerRows;
        public string encoding;
        public bool lowcase;
        public bool exportArray;
        public bool forceSheetName;
        public ExcelDataOptions()
        {
            this.excelPath = "";
            this.jsonPath = "";
            this.cSharpPath = "";
            this.fileName = "";

            this.headerRows = 3;
            this.encoding = "utf8-nobom";
            this.lowcase = false;
            this.exportArray = false;
            this.forceSheetName = false;
        }
    }

    class ExcelLoader
    {
        DataSet m_dataSet;

        public DataTableCollection m_sheets
        {
            get
            {
                return this.m_dataSet.Tables;
            }
        }

        public ExcelLoader(string path)
        {
            using (var stream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet(CreateDataSetReadConfig());
                    this.m_dataSet = result;
                }
            }
        }

        private ExcelDataSetConfiguration CreateDataSetReadConfig()
        {
            var tableConfig = new ExcelDataTableConfiguration()
            {
                UseHeaderRow = true
            };

            return new ExcelDataSetConfiguration()
            {
                UseColumnDataType = true,
                ConfigureDataTable = (tableReader) => { return tableConfig; }
            };
        }

        
    }
}
