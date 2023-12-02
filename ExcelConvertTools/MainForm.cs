using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ExcelConvertTools
{
    public enum Excel_PathType
    {
        UseSingleExcel,
        UseExcelForder
    }
    public partial class MainForm : Form
    {
        DataManager m_dataManager;
        public MainForm()
        {
            InitializeComponent();

            m_dataManager = new DataManager();
            m_dataManager.InitData();

            InitMainForm();

        }
        //初始化表格
        public void InitMainForm()
        {
            //设置所有路径修改事件
            ExcelForderPathTextbox.AllowDrop = true;

            ExcelForderPathTextbox.Text = m_dataManager.systemConfig.excelsForderPath;
            ExcelForderPathTextbox.TextChanged += OnSettingChanged;

            ExcelSinglePathTextbox.Text = m_dataManager.systemConfig.excelPath;
            ExcelSinglePathTextbox.TextChanged += OnSettingChanged;

            ExcelForderNameTextbox.Text = m_dataManager.systemConfig.excelsForderName;
            ExcelForderNameTextbox.TextChanged += OnSettingChanged;

            CSharpForderNameTextbox.Text = m_dataManager.systemConfig.cSharpForderName;
            CSharpForderNameTextbox.TextChanged += OnSettingChanged;

            JsonForderNameTextbox.Text = m_dataManager.systemConfig.jsonForderName;
            JsonForderNameTextbox.TextChanged += OnSettingChanged;

            ExportCSharpPathTextbox.Text = m_dataManager.systemConfig.exportCSharpPath;
            ExportCSharpPathTextbox.TextChanged += OnSettingChanged;

            ExportJsonPathTextbox.Text = m_dataManager.systemConfig.exportJsonPath;
            ExportJsonPathTextbox.TextChanged += OnSettingChanged;

            //一些utf8-bom的文本格式在web端会出错，设置utf8-nobom
            ExportTypeComboBox.Items.Clear();
            foreach (var ei in m_dataManager.EncodingDic)
            {
                ExportTypeComboBox.Items.Add(ei.Key);
            }
            ExportTypeComboBox.SelectedIndexChanged += ExportTypeComboBox_SelectedIndexChanged;
            //初始化Encoding的选择
            this.ExportTypeComboBox.SelectedIndex =
                m_dataManager.GetEncodingIndex(m_dataManager.systemConfig.encoding);

            //设置Excel文件路径类型，是Excel文件夹还是单个Excel文件
            switch (m_dataManager.systemConfig.options.pathType)
            {
                case Excel_PathType.UseSingleExcel:
                    UseSingleExcel.Checked = true;
                    break;
                case Excel_PathType.UseExcelForder:
                    UseExcelForder.Checked = true;
                    break;
            }
            UseExcelForder.CheckedChanged += OnSettingChanged;
            UseSingleExcel.CheckedChanged += OnSettingChanged;
        }

        void OnSettingChanged(object sender, System.EventArgs e)
        {
            //初始化文件路径
            SystemConfig systemConfig = new SystemConfig();
            systemConfig.cSharpForderName = CSharpForderNameTextbox.Text;
            systemConfig.excelsForderName = ExcelForderNameTextbox.Text;
            systemConfig.jsonForderName = JsonForderNameTextbox.Text;
            systemConfig.excelsForderPath = ExcelForderPathTextbox.Text;
            systemConfig.excelPath = ExcelSinglePathTextbox.Text;
            systemConfig.exportJsonPath = ExportJsonPathTextbox.Text;
            systemConfig.exportCSharpPath = ExportCSharpPathTextbox.Text;

            //初始化设置数据
            systemConfig.options = new Options();
            systemConfig.options.ignoreStartStr = IgnoreStrTextBox.Text;
            //systemConfig.options.dataFormat = DateFormateCombox.SelectedItem.ToString();
            systemConfig.options.lowcase = LowCaseCheckBox.Checked;
            systemConfig.options.pathType = GetUseExcelPathType();

            m_dataManager.UpdateSystemConfig(systemConfig);
            m_dataManager.SaveSystemConfig();
            m_dataManager.InitData();
        }

        string GetDragForderPath(DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            return path;
        }

        void ExplorePath(string path)
        {
            if (Directory.Exists(path))
            {
                System.Diagnostics.Process.Start("explorer.exe", path);
                return;
            }
            MessageBox.Show("Path Not Exist!", "Status", MessageBoxButtons.OK);
        }
        //拖拽文件进入Textbox以获取路径
        void DragFileToTextbox_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void ForderPathTxtbox_DragDrop(object sender, DragEventArgs e)
        {
            ExcelForderPathTextbox.Text = GetDragForderPath(e);
        }

        private void ForderPathTxtbox_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void ExportJsonPathTextbox_DragDrop(object sender, DragEventArgs e)
        {
            ExportJsonPathTextbox.Text =
                Path.Combine(GetDragForderPath(e), m_dataManager.systemConfig.jsonForderName);
        }

        private void ExportCSharpPathTextbox_DragDrop(object sender, DragEventArgs e)
        {
            ExportCSharpPathTextbox.Text =
                Path.Combine(GetDragForderPath(e), m_dataManager.systemConfig.cSharpForderName);
        }
        //创建CSharp文件
        private void GenerateCSharpFile_Click(object sender, System.EventArgs e)
        {
            string exportCSharpPath = m_dataManager.systemConfig.exportCSharpPath;
            //是否需要清理文件夹
            if (ClearForderCheckBox.Checked)
            {
                FileManager.ClearForder(exportCSharpPath);
            }
            //生成复数的CSharp文件
            if (DataManager.m_systemConfig.options.pathType == Excel_PathType.UseExcelForder)
            {
                List<string> filePaths = FileManager.GetAllExcelPaths(m_dataManager.systemConfig.excelsForderPath);
                for (int i = 0; i < filePaths.Count; i++)
                {
                    m_dataManager.LoadExcel(filePaths[i], m_dataManager.systemConfig.options);
                    string fileName = System.IO.Path.GetFileNameWithoutExtension(filePaths[i]);
                    m_dataManager.SaveCSharpFile(exportCSharpPath, fileName);
                }
                MessageBox.Show("Generate " + filePaths.Count + " CSharp File Success!", "Status", MessageBoxButtons.OK);
            }
            else
            {
                m_dataManager.LoadExcel(m_dataManager.systemConfig.excelPath, m_dataManager.systemConfig.options);
                string fileName = Path.GetFileNameWithoutExtension(m_dataManager.systemConfig.excelPath);
                m_dataManager.SaveCSharpFile(m_dataManager.systemConfig.exportCSharpPath, fileName);
                MessageBox.Show("Generate CSharp File Success!", "Status", MessageBoxButtons.OK);
            }

        }
        //创建Josn文件
        private void GenerateJsonFile_Click(object sender, System.EventArgs e)
        {
            string exportJsonPath = m_dataManager.systemConfig.exportJsonPath;
            if (ClearForderCheckBox.Checked)
            {
                FileManager.ClearForder(exportJsonPath);
            }
            //生成复数的Json文件
            if (DataManager.m_systemConfig.options.pathType == Excel_PathType.UseExcelForder)
            {
                List<string> filePaths = FileManager.GetAllExcelPaths(m_dataManager.systemConfig.excelsForderPath);
                if (filePaths.Count <= 0)
                {
                    MessageBox.Show("There Is 0 Files In ExcelForder");
                    return;
                }
                for (int i = 0; i < filePaths.Count; i++)
                {
                    m_dataManager.LoadExcel(filePaths[i], m_dataManager.systemConfig.options);
                    string fileName = System.IO.Path.GetFileNameWithoutExtension(filePaths[i]);
                    m_dataManager.SaveJsonFile(exportJsonPath, fileName);
                }
                MessageBox.Show("Generate " + filePaths.Count + " Json File Success!", "Status", MessageBoxButtons.OK);
            }
            else
            {
                m_dataManager.LoadExcel(m_dataManager.systemConfig.excelPath, m_dataManager.systemConfig.options);
                string fileName = System.IO.Path.GetFileNameWithoutExtension(m_dataManager.systemConfig.excelPath);
                m_dataManager.SaveJsonFile(m_dataManager.systemConfig.exportJsonPath, fileName);
                MessageBox.Show("Generate Json File Success!", "Status", MessageBoxButtons.OK);
            }


        }
        private void ExcelPathTextbox_DragDrop(object sender, DragEventArgs e)
        {
            ExcelSinglePathTextbox.Text = GetDragForderPath(e);
        }


        private void JsonPathLabel_DoubleClick(object sender, System.EventArgs e)
        {
            ExplorePath(ExportJsonPathTextbox.Text);
        }

        private void CSharpPathLabal_DoubleClick(object sender, System.EventArgs e)
        {
            ExplorePath(ExportCSharpPathTextbox.Text);
        }

        private void ExportTypeComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            m_dataManager.systemConfig.encoding = ExportTypeComboBox.SelectedItem.ToString();
            m_dataManager.SaveSystemConfig();
        }

        private void CreateExampleExcel_Click(object sender, System.EventArgs e)
        {
            if (FileManager.IsForderExists(ExcelForderPathTextbox.Text))
            {
                ExcelCreater.CreateExampleExcel(ExcelForderPathTextbox.Text, "ExcelExample", ExcelFile_Type.XLSX);
                MessageBox.Show("Create Example Success!!!", "Status", MessageBoxButtons.OK);
            }
        }
        private Excel_PathType GetUseExcelPathType()
        {
            if (UseExcelForder.Checked)
            {
                return Excel_PathType.UseExcelForder;
            }
            else if (UseSingleExcel.Checked)
            {
                return Excel_PathType.UseSingleExcel;
            }
            return Excel_PathType.UseExcelForder;
        }

    }

}
