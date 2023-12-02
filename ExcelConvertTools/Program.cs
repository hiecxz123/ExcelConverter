using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelConvertTools
{

    public class Options
    {
        public int headerRows = 3;
        //Excel导出格式，Array或者Dictionary
        public string exportType = "Array";
        public string encoding = "utf8-nobom";
        public string ignoreStartStr = "#";
        public Excel_PathType pathType = Excel_PathType.UseExcelForder;
        
        public bool lowcase = false;
        public bool exportArray = false;
        public bool forceSheetName = false;
        public string dataFormat = "yyyy/MM/dd";
        
    }

    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        /// <param name="args">命令行参数</param>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length <= 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            else
            {
                //TODO:命令行执行逻辑
            }

        }
    }
}
