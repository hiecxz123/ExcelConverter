
namespace ExcelConvertTools
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ExcelForderPathTextbox = new System.Windows.Forms.TextBox();
            this.ForderPathLab = new System.Windows.Forms.Label();
            this.ExcelForderNameTextbox = new System.Windows.Forms.TextBox();
            this.ExcelForderLab = new System.Windows.Forms.Label();
            this.CSharpForderLab = new System.Windows.Forms.Label();
            this.CSharpForderNameTextbox = new System.Windows.Forms.TextBox();
            this.JsonForderLab = new System.Windows.Forms.Label();
            this.JsonForderNameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExcelSinglePathTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CSharpPathLabel = new System.Windows.Forms.Label();
            this.ExportCSharpPathTextbox = new System.Windows.Forms.TextBox();
            this.JsonPathLabel = new System.Windows.Forms.Label();
            this.ExportJsonPathTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.IgnoreStrTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.GenerateCSharpBtn = new System.Windows.Forms.Button();
            this.GenerateJsonBtn = new System.Windows.Forms.Button();
            this.ExportTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DateFormateCombox = new System.Windows.Forms.ComboBox();
            this.CreateExampleExcel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.UseExcelForder = new System.Windows.Forms.RadioButton();
            this.UseSingleExcel = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.LowCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.JsonConvertExcelBtn = new System.Windows.Forms.Button();
            this.CSharpConvertExcelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExcelForderPathTextbox
            // 
            this.ExcelForderPathTextbox.AllowDrop = true;
            this.ExcelForderPathTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExcelForderPathTextbox.Font = new System.Drawing.Font("宋体", 10F);
            this.ExcelForderPathTextbox.Location = new System.Drawing.Point(100, 40);
            this.ExcelForderPathTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.ExcelForderPathTextbox.Name = "ExcelForderPathTextbox";
            this.ExcelForderPathTextbox.Size = new System.Drawing.Size(552, 23);
            this.ExcelForderPathTextbox.TabIndex = 0;
            this.ExcelForderPathTextbox.Text = "All excels need convert";
            this.ExcelForderPathTextbox.DragDrop += new System.Windows.Forms.DragEventHandler(this.ForderPathTxtbox_DragDrop);
            this.ExcelForderPathTextbox.DragOver += new System.Windows.Forms.DragEventHandler(this.ForderPathTxtbox_DragOver);
            // 
            // ForderPathLab
            // 
            this.ForderPathLab.AutoSize = true;
            this.ForderPathLab.Font = new System.Drawing.Font("宋体", 10F);
            this.ForderPathLab.Location = new System.Drawing.Point(6, 40);
            this.ForderPathLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ForderPathLab.Name = "ForderPathLab";
            this.ForderPathLab.Size = new System.Drawing.Size(84, 14);
            this.ForderPathLab.TabIndex = 1;
            this.ForderPathLab.Text = "Forder Path";
            // 
            // ExcelForderNameTextbox
            // 
            this.ExcelForderNameTextbox.Font = new System.Drawing.Font("宋体", 10F);
            this.ExcelForderNameTextbox.Location = new System.Drawing.Point(100, 156);
            this.ExcelForderNameTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.ExcelForderNameTextbox.Name = "ExcelForderNameTextbox";
            this.ExcelForderNameTextbox.Size = new System.Drawing.Size(98, 23);
            this.ExcelForderNameTextbox.TabIndex = 2;
            this.ExcelForderNameTextbox.Text = "Forder Name";
            // 
            // ExcelForderLab
            // 
            this.ExcelForderLab.AutoSize = true;
            this.ExcelForderLab.Font = new System.Drawing.Font("宋体", 10F);
            this.ExcelForderLab.Location = new System.Drawing.Point(7, 158);
            this.ExcelForderLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ExcelForderLab.Name = "ExcelForderLab";
            this.ExcelForderLab.Size = new System.Drawing.Size(91, 14);
            this.ExcelForderLab.TabIndex = 4;
            this.ExcelForderLab.Text = "Excel Forder";
            // 
            // CSharpForderLab
            // 
            this.CSharpForderLab.AutoSize = true;
            this.CSharpForderLab.Font = new System.Drawing.Font("宋体", 10F);
            this.CSharpForderLab.Location = new System.Drawing.Point(205, 158);
            this.CSharpForderLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CSharpForderLab.Name = "CSharpForderLab";
            this.CSharpForderLab.Size = new System.Drawing.Size(98, 14);
            this.CSharpForderLab.TabIndex = 6;
            this.CSharpForderLab.Text = "CSharp Forder";
            // 
            // CSharpForderNameTextbox
            // 
            this.CSharpForderNameTextbox.Font = new System.Drawing.Font("宋体", 10F);
            this.CSharpForderNameTextbox.Location = new System.Drawing.Point(319, 156);
            this.CSharpForderNameTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.CSharpForderNameTextbox.Name = "CSharpForderNameTextbox";
            this.CSharpForderNameTextbox.Size = new System.Drawing.Size(98, 23);
            this.CSharpForderNameTextbox.TabIndex = 5;
            this.CSharpForderNameTextbox.Text = "Forder Name";
            // 
            // JsonForderLab
            // 
            this.JsonForderLab.AutoSize = true;
            this.JsonForderLab.Font = new System.Drawing.Font("宋体", 10F);
            this.JsonForderLab.Location = new System.Drawing.Point(440, 158);
            this.JsonForderLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.JsonForderLab.Name = "JsonForderLab";
            this.JsonForderLab.Size = new System.Drawing.Size(84, 14);
            this.JsonForderLab.TabIndex = 8;
            this.JsonForderLab.Text = "Json Forder";
            // 
            // JsonForderNameTextbox
            // 
            this.JsonForderNameTextbox.Font = new System.Drawing.Font("宋体", 10F);
            this.JsonForderNameTextbox.Location = new System.Drawing.Point(532, 154);
            this.JsonForderNameTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.JsonForderNameTextbox.Name = "JsonForderNameTextbox";
            this.JsonForderNameTextbox.Size = new System.Drawing.Size(98, 23);
            this.JsonForderNameTextbox.TabIndex = 7;
            this.JsonForderNameTextbox.Text = "Forder Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "Excel Path";
            // 
            // ExcelSinglePathTextbox
            // 
            this.ExcelSinglePathTextbox.AllowDrop = true;
            this.ExcelSinglePathTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExcelSinglePathTextbox.Font = new System.Drawing.Font("宋体", 10F);
            this.ExcelSinglePathTextbox.Location = new System.Drawing.Point(100, 69);
            this.ExcelSinglePathTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.ExcelSinglePathTextbox.Name = "ExcelSinglePathTextbox";
            this.ExcelSinglePathTextbox.Size = new System.Drawing.Size(552, 23);
            this.ExcelSinglePathTextbox.TabIndex = 10;
            this.ExcelSinglePathTextbox.Text = "Single excel need convert";
            this.ExcelSinglePathTextbox.DragDrop += new System.Windows.Forms.DragEventHandler(this.ExcelPathTextbox_DragDrop);
            this.ExcelSinglePathTextbox.DragOver += new System.Windows.Forms.DragEventHandler(this.DragFileToTextbox_DragOver);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "ForderName:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(4, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Source File Path:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(6, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Export File Path:";
            // 
            // CSharpPathLabel
            // 
            this.CSharpPathLabel.AutoSize = true;
            this.CSharpPathLabel.Font = new System.Drawing.Font("宋体", 10F);
            this.CSharpPathLabel.Location = new System.Drawing.Point(8, 247);
            this.CSharpPathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CSharpPathLabel.Name = "CSharpPathLabel";
            this.CSharpPathLabel.Size = new System.Drawing.Size(84, 14);
            this.CSharpPathLabel.TabIndex = 20;
            this.CSharpPathLabel.Text = "CSharp Path";
            this.CSharpPathLabel.DoubleClick += new System.EventHandler(this.CSharpPathLabal_DoubleClick);
            // 
            // ExportCSharpPathTextbox
            // 
            this.ExportCSharpPathTextbox.AllowDrop = true;
            this.ExportCSharpPathTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportCSharpPathTextbox.Font = new System.Drawing.Font("宋体", 10F);
            this.ExportCSharpPathTextbox.Location = new System.Drawing.Point(100, 245);
            this.ExportCSharpPathTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.ExportCSharpPathTextbox.Name = "ExportCSharpPathTextbox";
            this.ExportCSharpPathTextbox.Size = new System.Drawing.Size(552, 23);
            this.ExportCSharpPathTextbox.TabIndex = 19;
            this.ExportCSharpPathTextbox.Text = "Generate csharp files in this path (double click label open forder)";
            this.ExportCSharpPathTextbox.DragDrop += new System.Windows.Forms.DragEventHandler(this.ExportCSharpPathTextbox_DragDrop);
            this.ExportCSharpPathTextbox.DragOver += new System.Windows.Forms.DragEventHandler(this.DragFileToTextbox_DragOver);
            // 
            // JsonPathLabel
            // 
            this.JsonPathLabel.AutoSize = true;
            this.JsonPathLabel.Font = new System.Drawing.Font("宋体", 10F);
            this.JsonPathLabel.Location = new System.Drawing.Point(7, 218);
            this.JsonPathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.JsonPathLabel.Name = "JsonPathLabel";
            this.JsonPathLabel.Size = new System.Drawing.Size(70, 14);
            this.JsonPathLabel.TabIndex = 18;
            this.JsonPathLabel.Text = "Json Path";
            this.JsonPathLabel.DoubleClick += new System.EventHandler(this.JsonPathLabel_DoubleClick);
            // 
            // ExportJsonPathTextbox
            // 
            this.ExportJsonPathTextbox.AllowDrop = true;
            this.ExportJsonPathTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportJsonPathTextbox.Font = new System.Drawing.Font("宋体", 10F);
            this.ExportJsonPathTextbox.Location = new System.Drawing.Point(100, 216);
            this.ExportJsonPathTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.ExportJsonPathTextbox.Name = "ExportJsonPathTextbox";
            this.ExportJsonPathTextbox.Size = new System.Drawing.Size(552, 23);
            this.ExportJsonPathTextbox.TabIndex = 17;
            this.ExportJsonPathTextbox.Text = "Generate json files in this path (double click label open forder)";
            this.ExportJsonPathTextbox.DragDrop += new System.Windows.Forms.DragEventHandler(this.ExportJsonPathTextbox_DragDrop);
            this.ExportJsonPathTextbox.DragOver += new System.Windows.Forms.DragEventHandler(this.DragFileToTextbox_DragOver);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(169, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "(Drag forder to textbox to get path)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 192);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(353, 12);
            this.label8.TabIndex = 22;
            this.label8.Text = "(forder will be created in these path when generate files)";
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.SettingsLabel.Location = new System.Drawing.Point(6, 308);
            this.SettingsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(89, 16);
            this.SettingsLabel.TabIndex = 23;
            this.SettingsLabel.Text = "Settings:";
            // 
            // IgnoreStrTextBox
            // 
            this.IgnoreStrTextBox.AllowDrop = true;
            this.IgnoreStrTextBox.Font = new System.Drawing.Font("宋体", 10F);
            this.IgnoreStrTextBox.Location = new System.Drawing.Point(181, 337);
            this.IgnoreStrTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.IgnoreStrTextBox.Name = "IgnoreStrTextBox";
            this.IgnoreStrTextBox.Size = new System.Drawing.Size(52, 23);
            this.IgnoreStrTextBox.TabIndex = 24;
            this.IgnoreStrTextBox.Text = "#";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10F);
            this.label9.Location = new System.Drawing.Point(8, 338);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 14);
            this.label9.TabIndex = 25;
            this.label9.Text = "Ignore Mark(Row,Columns)";
            // 
            // GenerateCSharpBtn
            // 
            this.GenerateCSharpBtn.Location = new System.Drawing.Point(119, 275);
            this.GenerateCSharpBtn.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateCSharpBtn.Name = "GenerateCSharpBtn";
            this.GenerateCSharpBtn.Size = new System.Drawing.Size(106, 24);
            this.GenerateCSharpBtn.TabIndex = 12;
            this.GenerateCSharpBtn.Text = "Generate CSharp";
            this.GenerateCSharpBtn.UseVisualStyleBackColor = true;
            this.GenerateCSharpBtn.Click += new System.EventHandler(this.GenerateCSharpFile_Click);
            // 
            // GenerateJsonBtn
            // 
            this.GenerateJsonBtn.Location = new System.Drawing.Point(9, 274);
            this.GenerateJsonBtn.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateJsonBtn.Name = "GenerateJsonBtn";
            this.GenerateJsonBtn.Size = new System.Drawing.Size(106, 25);
            this.GenerateJsonBtn.TabIndex = 9;
            this.GenerateJsonBtn.Text = "Generate Json";
            this.GenerateJsonBtn.UseVisualStyleBackColor = true;
            this.GenerateJsonBtn.Click += new System.EventHandler(this.GenerateJsonFile_Click);
            // 
            // ExportTypeComboBox
            // 
            this.ExportTypeComboBox.Enabled = false;
            this.ExportTypeComboBox.FormattingEnabled = true;
            this.ExportTypeComboBox.Location = new System.Drawing.Point(326, 338);
            this.ExportTypeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.ExportTypeComboBox.Name = "ExportTypeComboBox";
            this.ExportTypeComboBox.Size = new System.Drawing.Size(109, 20);
            this.ExportTypeComboBox.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 10F);
            this.label10.Location = new System.Drawing.Point(240, 338);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 14);
            this.label10.TabIndex = 27;
            this.label10.Text = "Export Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10F);
            this.label5.Location = new System.Drawing.Point(440, 338);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 14);
            this.label5.TabIndex = 30;
            this.label5.Text = "Date Formate";
            // 
            // DateFormateCombox
            // 
            this.DateFormateCombox.Enabled = false;
            this.DateFormateCombox.FormattingEnabled = true;
            this.DateFormateCombox.Location = new System.Drawing.Point(532, 338);
            this.DateFormateCombox.Margin = new System.Windows.Forms.Padding(2);
            this.DateFormateCombox.Name = "DateFormateCombox";
            this.DateFormateCombox.Size = new System.Drawing.Size(109, 20);
            this.DateFormateCombox.TabIndex = 31;
            // 
            // CreateExampleExcel
            // 
            this.CreateExampleExcel.Location = new System.Drawing.Point(443, 306);
            this.CreateExampleExcel.Name = "CreateExampleExcel";
            this.CreateExampleExcel.Size = new System.Drawing.Size(197, 24);
            this.CreateExampleExcel.TabIndex = 32;
            this.CreateExampleExcel.Text = "Create Example Excel";
            this.CreateExampleExcel.UseVisualStyleBackColor = true;
            this.CreateExampleExcel.Click += new System.EventHandler(this.CreateExampleExcel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 12);
            this.label6.TabIndex = 33;
            this.label6.Text = "Create Example Excel In Excel Forder Path";
            // 
            // UseExcelForder
            // 
            this.UseExcelForder.AutoSize = true;
            this.UseExcelForder.Location = new System.Drawing.Point(12, 97);
            this.UseExcelForder.Name = "UseExcelForder";
            this.UseExcelForder.Size = new System.Drawing.Size(107, 16);
            this.UseExcelForder.TabIndex = 34;
            this.UseExcelForder.Text = "UseExcelForder";
            this.UseExcelForder.UseVisualStyleBackColor = true;
            // 
            // UseSingleExcel
            // 
            this.UseSingleExcel.AutoSize = true;
            this.UseSingleExcel.Checked = true;
            this.UseSingleExcel.Location = new System.Drawing.Point(138, 97);
            this.UseSingleExcel.Name = "UseSingleExcel";
            this.UseSingleExcel.Size = new System.Drawing.Size(107, 16);
            this.UseSingleExcel.TabIndex = 35;
            this.UseSingleExcel.TabStop = true;
            this.UseSingleExcel.Text = "UseSingleExcel";
            this.UseSingleExcel.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 364);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 21);
            this.textBox1.TabIndex = 36;
            this.textBox1.Text = "3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 10F);
            this.label11.Location = new System.Drawing.Point(8, 366);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 14);
            this.label11.TabIndex = 37;
            this.label11.Text = "Header Rows";
            // 
            // LowCaseCheckBox
            // 
            this.LowCaseCheckBox.AutoSize = true;
            this.LowCaseCheckBox.Enabled = false;
            this.LowCaseCheckBox.Font = new System.Drawing.Font("宋体", 10F);
            this.LowCaseCheckBox.Location = new System.Drawing.Point(181, 366);
            this.LowCaseCheckBox.Name = "LowCaseCheckBox";
            this.LowCaseCheckBox.Size = new System.Drawing.Size(75, 18);
            this.LowCaseCheckBox.TabIndex = 38;
            this.LowCaseCheckBox.Text = "LowCase";
            this.LowCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // JsonConvertExcelBtn
            // 
            this.JsonConvertExcelBtn.Enabled = false;
            this.JsonConvertExcelBtn.Location = new System.Drawing.Point(356, 274);
            this.JsonConvertExcelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.JsonConvertExcelBtn.Name = "JsonConvertExcelBtn";
            this.JsonConvertExcelBtn.Size = new System.Drawing.Size(139, 25);
            this.JsonConvertExcelBtn.TabIndex = 39;
            this.JsonConvertExcelBtn.Text = "Json Convert Excel";
            this.JsonConvertExcelBtn.UseVisualStyleBackColor = true;
            // 
            // CSharpConvertExcelBtn
            // 
            this.CSharpConvertExcelBtn.Enabled = false;
            this.CSharpConvertExcelBtn.Location = new System.Drawing.Point(499, 274);
            this.CSharpConvertExcelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CSharpConvertExcelBtn.Name = "CSharpConvertExcelBtn";
            this.CSharpConvertExcelBtn.Size = new System.Drawing.Size(143, 24);
            this.CSharpConvertExcelBtn.TabIndex = 40;
            this.CSharpConvertExcelBtn.Text = "CSharp Convert Excel";
            this.CSharpConvertExcelBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(662, 412);
            this.Controls.Add(this.CSharpConvertExcelBtn);
            this.Controls.Add(this.JsonConvertExcelBtn);
            this.Controls.Add(this.LowCaseCheckBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.UseSingleExcel);
            this.Controls.Add(this.UseExcelForder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CreateExampleExcel);
            this.Controls.Add(this.DateFormateCombox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ExportTypeComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.IgnoreStrTextBox);
            this.Controls.Add(this.SettingsLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CSharpPathLabel);
            this.Controls.Add(this.ExportCSharpPathTextbox);
            this.Controls.Add(this.JsonPathLabel);
            this.Controls.Add(this.ExportJsonPathTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GenerateCSharpBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExcelSinglePathTextbox);
            this.Controls.Add(this.GenerateJsonBtn);
            this.Controls.Add(this.JsonForderLab);
            this.Controls.Add(this.JsonForderNameTextbox);
            this.Controls.Add(this.CSharpForderLab);
            this.Controls.Add(this.CSharpForderNameTextbox);
            this.Controls.Add(this.ExcelForderLab);
            this.Controls.Add(this.ExcelForderNameTextbox);
            this.Controls.Add(this.ForderPathLab);
            this.Controls.Add(this.ExcelForderPathTextbox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(666, 427);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel Converter V1.0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ExcelForderPathTextbox;
        private System.Windows.Forms.Label ForderPathLab;
        private System.Windows.Forms.TextBox ExcelForderNameTextbox;
        private System.Windows.Forms.Label ExcelForderLab;
        private System.Windows.Forms.Label CSharpForderLab;
        private System.Windows.Forms.TextBox CSharpForderNameTextbox;
        private System.Windows.Forms.Label JsonForderLab;
        private System.Windows.Forms.TextBox JsonForderNameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ExcelSinglePathTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CSharpPathLabel;
        private System.Windows.Forms.TextBox ExportCSharpPathTextbox;
        private System.Windows.Forms.Label JsonPathLabel;
        private System.Windows.Forms.TextBox ExportJsonPathTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label SettingsLabel;
        private System.Windows.Forms.TextBox IgnoreStrTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button GenerateCSharpBtn;
        private System.Windows.Forms.Button GenerateJsonBtn;
        private System.Windows.Forms.ComboBox ExportTypeComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox DateFormateCombox;
        private System.Windows.Forms.Button CreateExampleExcel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton UseExcelForder;
        private System.Windows.Forms.RadioButton UseSingleExcel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox LowCaseCheckBox;
        private System.Windows.Forms.Button JsonConvertExcelBtn;
        private System.Windows.Forms.Button CSharpConvertExcelBtn;
    }
}

