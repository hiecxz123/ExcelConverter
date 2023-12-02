using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelConvertTools
{
    public class SystemConfig
    {
        /// <summary>
        /// 多个excel文件所在文件夹
        /// </summary>
        public string excelsForderPath = "";
        /// <summary>
        /// 单个excel文件所在路径
        /// </summary>
        public string excelPath = "";
        /// <summary>
        /// 是否使用Excel文件夹
        /// </summary>
        public bool useExcelForder = true;
        /// <summary>
        /// Json文件导出路径
        /// </summary>
        public string exportJsonPath = "";
        /// <summary>
        /// CSharp文件导出路径
        /// </summary>
        public string exportCSharpPath = "";
        /// <summary>
        /// 编码
        /// </summary>
        public string encoding = "";
        /// <summary>
        /// excel文件所在文件夹
        /// </summary>
        public string excelsForderName = "Excel";
        /// <summary>
        /// C#文件所在文件夹
        /// </summary>
        public string cSharpForderName = "CSharp";
        /// <summary>
        /// Json文件所在文件夹
        /// </summary>
        public string jsonForderName = "Json";
        /// <summary>
        /// 设置
        /// </summary>
        public Options options;
    }

    class DataManager
    {
        const string excelForderName = "Excel";
        const string cSharpForderName = "CSharp";
        const string jsonForderName = "Json";

        const string dataFormate = "";
        public static SystemConfig m_systemConfig;

        Encoding m_encoding;

        JsonExporter m_jsonExporter;
        CSharpGenerater m_cSharpGenerater;

        Dictionary<string, Encoding> encodingDic = new Dictionary<string, Encoding>();
        public Dictionary<string, Encoding> EncodingDic
        {
            get
            {
                return encodingDic;
            }
        }

        public SystemConfig systemConfig
        {
            get
            {
                return m_systemConfig;
            }
        }

        public string systemConfigPath
        {
            get
            {
                return Path.Combine(Directory.GetCurrentDirectory(), "settings.txt");
            }
        }

        public void InitData()
        {
            Encoding encoding = new UTF8Encoding(false);
            encodingDic.Clear();
            encodingDic.Add("utf8-nobom", encoding);
            int index = 1;
            foreach (EncodingInfo ei in Encoding.GetEncodings())
            {
                Encoding e = ei.GetEncoding();
                if (encodingDic.ContainsKey(e.HeaderName))
                {
                    encodingDic.Add(
                        e.HeaderName + "(" + index.ToString() + ")", e);
                    index++;
                }
                else
                {
                    encodingDic.Add(e.HeaderName, e);
                    index = 1;
                }
            }
            //settings file not exists, create new one
            if (!File.Exists(systemConfigPath))
            {
                CreateNewSettingFile();
            }
            else
            {
                string systemConfigjson = File.ReadAllText(systemConfigPath);
                m_systemConfig = JsonManager.ConvertToObj<SystemConfig>(systemConfigjson);
                if (!IsSettingDataRight())
                {
                    CreateNewSettingFile();
                    systemConfigjson = File.ReadAllText(systemConfigPath);
                    m_systemConfig = JsonManager.ConvertToObj<SystemConfig>(systemConfigjson);
                }
            }
            CheckEncodingData();
        }

        public int GetEncodingIndex(string encodingName)
        {
            int i = 0;
            foreach (var ed in encodingDic)
            {
                if (ed.Key == encodingName)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }

        void CheckEncodingData()
        {
            if (encodingDic.ContainsKey(m_systemConfig.encoding))
            {
                m_encoding = encodingDic[m_systemConfig.encoding];
            }
            else
            {
                m_encoding = new UTF8Encoding();
            }
        }

        bool IsSettingDataRight()
        {
            if (m_systemConfig.excelsForderPath == string.Empty ||
                m_systemConfig.exportCSharpPath == string.Empty ||
                m_systemConfig.exportJsonPath == string.Empty)
            {
                return false;
            }
            return true;
        }

        void CreateNewSettingFile()
        {
            m_systemConfig = new SystemConfig();
            m_systemConfig.excelsForderName = excelForderName;
            m_systemConfig.cSharpForderName = cSharpForderName;
            m_systemConfig.jsonForderName = jsonForderName;

            m_systemConfig.excelsForderPath =
                Path.Combine(Directory.GetCurrentDirectory(), systemConfig.excelsForderName);
            m_systemConfig.excelPath = "";
            m_systemConfig.exportJsonPath =
                Path.Combine(Directory.GetCurrentDirectory(), systemConfig.jsonForderName);
            m_systemConfig.exportCSharpPath =
                Path.Combine(Directory.GetCurrentDirectory(), systemConfig.cSharpForderName);

            m_systemConfig.encoding = "utf8-nobom";
            m_systemConfig.options = new Options();

            string json = JsonManager.ConertToJson(m_systemConfig);
            File.WriteAllText(systemConfigPath, json);
        }

        public void UpdateSystemConfig(SystemConfig systemConfig)
        {
            m_systemConfig = systemConfig;
        }

        public void SaveSystemConfig()
        {
            string json = JsonManager.ConertToJson(systemConfig);

            //使用文件流来代替File.WriteAllText，防止文件被占用报错
            using (FileStream file = new FileStream(systemConfigPath, FileMode.Create, FileAccess.Write))
            {
                using (TextWriter writer = new StreamWriter(file, m_encoding))
                    writer.Write(json);
            }
        }

        public void LoadExcel(string excelPath, Options options)
        {
            if (File.Exists(excelPath))
            {
                string excelName = Path.GetFileNameWithoutExtension(excelPath);
                ExcelLoader excel = new ExcelLoader(excelPath);
                m_jsonExporter = new JsonExporter(excel, options);
                m_cSharpGenerater = new CSharpGenerater(excelName, excel, options.ignoreStartStr);
            }
            else
            {
                MessageBox.Show("File Not Exists!!!");
            }
        }

        public void SaveJsonFile(string exportForderPath, string fileName)
        {
            string filePath = Path.Combine(exportForderPath, fileName + ".json");
            if (!Directory.Exists(exportForderPath))
            {
                Directory.CreateDirectory(exportForderPath);
            }
            m_jsonExporter.SaveContextToFile(filePath, m_encoding);
        }

        public void SaveCSharpFile(string exportForderPath, string fileName)
        {
            string filePath = Path.Combine(exportForderPath, fileName + ".cs");
            if (!Directory.Exists(exportForderPath))
            {
                Directory.CreateDirectory(exportForderPath);
            }
            m_cSharpGenerater.SaveToFile(filePath, m_encoding);
        }
    }
}
