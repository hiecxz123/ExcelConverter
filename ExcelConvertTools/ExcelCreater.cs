using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelConvertTools
{
    public enum ExcelFile_Type
    {
        //65536行，256列
        XLS,
        //1048576行，16384列
        XLSX,
    }
    class ExcelCreater
    {

        public static void CreateExampleExcel(string path, string fileName, ExcelFile_Type excelPathType)
        {
            IWorkbook objects;
            if (excelPathType == ExcelFile_Type.XLS)
            {
                objects = new HSSFWorkbook();
            }
            else
            {
                objects = new XSSFWorkbook();
            }
            BuildExcelFile(objects);
            switch (excelPathType)
            {
                case ExcelFile_Type.XLS:
                    CreateXLS(path, fileName, objects);
                    break;
                case ExcelFile_Type.XLSX:
                    CreateXLSX(path, fileName, objects);
                    break;
            }
        }

        static void CreateXLS(string path, string fileName, IWorkbook objects)
        {
            string filePath = Path.Combine(path, fileName+".xls");
            if(File.Exists(filePath))
            {
                MessageBox.Show("Has Same Name File!!!,FileName:" + fileName + ".xls", "Status",MessageBoxButtons.OK);
            }
            objects.Write(new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write));
        }

        static void CreateXLSX(string path, string fileName, IWorkbook objects)
        {
            string filePath = Path.Combine(path, fileName+".xlsx");
            if (File.Exists(filePath))
            {
                MessageBox.Show("Has Same Name File!!!,FileName:"+ fileName + ".xlsx", "Status", MessageBoxButtons.OK);
            }
            objects.Write(new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write));
        }

        private static IWorkbook BuildExcelFile(IWorkbook objects)
        {
            ISheet objectss = objects.CreateSheet("ExampleSheet1");//创建表单
            IRow row1 = objectss.CreateRow(0);//创建第一行
            IRow row2 = objectss.CreateRow(1);//创建第二行
            IRow row3 = objectss.CreateRow(2);//创建第三行
            IRow row4 = objectss.CreateRow(3);//创建第四行
            IRow row5 = objectss.CreateRow(4);//创建第五行
            IRow row6 = objectss.CreateRow(5);//创建第六行
            IRow row7 = objectss.CreateRow(6);//创建第七行

            ICell cell_11 = row1.CreateCell(0);//创建第一行第一列
            ICell cell_12 = row1.CreateCell(1);//创建第一行第二列
            ICell cell_13 = row1.CreateCell(2);//创建第一行第三列
            ICell cell_14 = row1.CreateCell(3);//创建第一行第四列
            ICell cell_15 = row1.CreateCell(4);//创建第一行第五列
            ICell cell_16 = row1.CreateCell(5);//创建第一行第六列

            ICell cell_21 = row2.CreateCell(0);//创建第二行第一列
            ICell cell_22 = row2.CreateCell(1);//创建第二行第二列
            ICell cell_23 = row2.CreateCell(2);//创建第二行第三列
            ICell cell_24 = row2.CreateCell(3);//创建第二行第四列
            ICell cell_25 = row2.CreateCell(4);//创建第二行第五列
            ICell cell_26 = row2.CreateCell(5);//创建第二行第六列

            ICell cell_31 = row3.CreateCell(0);//创建第三行第一列
            ICell cell_32 = row3.CreateCell(1);//创建第三行第二列
            ICell cell_33 = row3.CreateCell(2);//创建第三行第三列
            ICell cell_34 = row3.CreateCell(3);//创建第三行第四列
            ICell cell_35 = row3.CreateCell(4);//创建第三行第五列
            ICell cell_36 = row3.CreateCell(5);//创建第三行第六列

            ICell cell_41 = row4.CreateCell(0);//创建第四行第一列
            ICell cell_42 = row4.CreateCell(1);//创建第四行第二列
            ICell cell_43 = row4.CreateCell(2);//创建第四行第三列
            ICell cell_44 = row4.CreateCell(3);//创建第四行第四列
            ICell cell_45 = row4.CreateCell(4);//创建第四行第五列
            ICell cell_46 = row4.CreateCell(5);//创建第四行第六列

            ICell cell_51 = row5.CreateCell(0);//创建第五行第一列
            ICell cell_52 = row5.CreateCell(1);//创建第五行第二列
            ICell cell_53 = row5.CreateCell(2);//创建第五行第三列
            ICell cell_54 = row5.CreateCell(3);//创建第五行第四列
            ICell cell_55 = row5.CreateCell(4);//创建第五行第五列
            ICell cell_56 = row5.CreateCell(5);//创建第五行第六列

            ICell cell_61 = row6.CreateCell(0);//创建第六行第一列
            ICell cell_62 = row6.CreateCell(1);//创建第六行第二列
            ICell cell_63 = row6.CreateCell(2);//创建第六行第三列
            ICell cell_64 = row6.CreateCell(3);//创建第六行第四列
            ICell cell_65 = row6.CreateCell(4);//创建第六行第五列
            ICell cell_66 = row6.CreateCell(5);//创建第六行第六列

            ICell cell_71 = row7.CreateCell(0);//创建第七行第一列
            ICell cell_72 = row7.CreateCell(1);//创建第七行第二列
            ICell cell_73 = row7.CreateCell(2);//创建第七行第三列
            ICell cell_74 = row7.CreateCell(3);//创建第七行第四列
            ICell cell_75 = row7.CreateCell(4);//创建第七行第五列
            ICell cell_76 = row7.CreateCell(5);//创建第七行第六列

            //第一列
            cell_11.SetCellValue("ID");
            cell_21.SetCellValue("Int");
            cell_31.SetCellValue("唯一索引");
            cell_41.SetCellValue(DataManager.m_systemConfig.options.ignoreStartStr+"忽略该行");
            cell_51.SetCellValue(1001);
            cell_61.SetCellValue(DataManager.m_systemConfig.options.ignoreStartStr + "1002");
            cell_71.SetCellValue(1003);
            //第二列
            cell_12.SetCellValue("Name");
            cell_22.SetCellValue("string");
            cell_32.SetCellValue("名称");
            cell_42.SetCellValue("测试字段");
            cell_52.SetCellValue("玩家1");
            cell_62.SetCellValue("玩家2");
            cell_72.SetCellValue("玩家3");
            //第三列
            cell_13.SetCellValue("MP");
            cell_23.SetCellValue("float");
            cell_33.SetCellValue("魔力");
            cell_43.SetCellValue("测试字段");
            cell_53.SetCellValue(100);
            cell_63.SetCellValue(50);
            cell_73.SetCellValue(150);
            //第四列
            cell_14.SetCellValue("MoveSpeed");
            cell_24.SetCellValue("float");
            cell_34.SetCellValue("移动速度");
            cell_44.SetCellValue("");
            cell_54.SetCellValue(100);
            cell_64.SetCellValue(120);
            cell_74.SetCellValue(130);
            //第五列
            cell_15.SetCellValue(DataManager.m_systemConfig.options.ignoreStartStr+"HP");
            cell_25.SetCellValue("float");
            cell_35.SetCellValue("移动速度");
            cell_45.SetCellValue("");
            cell_55.SetCellValue(1111);
            cell_65.SetCellValue(1111);
            cell_75.SetCellValue(1111);
            //第六列
            cell_16.SetCellValue("JumpHeight");
            cell_26.SetCellValue("float");
            cell_36.SetCellValue("跳跃高度");
            cell_46.SetCellValue("");
            cell_56.SetCellValue(2);
            cell_66.SetCellValue(2);
            cell_76.SetCellValue(2);


            objects.CreateSheet("ExampleSheet2");//创建第二个表单
            return objects;
        }
    }
}
