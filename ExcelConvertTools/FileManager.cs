using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ExcelConvertTools
{
    class FileManager
    {

        public static bool IsForderExists(string forderPath)
        {
            if (Directory.Exists(forderPath))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Forder Not Exists!!!", "Status", MessageBoxButtons.OK);
                return false;
            }

        }
        public static bool IsFileExists(string filePath)
        {
            if (File.Exists(filePath))
            {
                return true;
            }
            else
            {
                MessageBox.Show("File Not Exists!!!", "Status", MessageBoxButtons.OK);
                return false;
            }
        }

        public static List<string> GetAllExcelPaths(string forderPath)
        {
            List<string> pathLists = new List<string>();
            if (IsForderExists(forderPath))
            {
                string[] files = Directory.GetFiles(forderPath, "*.xls");
                for (int i = 0; i < files.Length; i++)
                {
                    pathLists.Add(files[i]);
                }
            }
            return pathLists;
        }


    }
}
