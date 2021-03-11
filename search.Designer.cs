
namespace Client_Project
{
    partial class search
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(search));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTime_Start = new System.Windows.Forms.DateTimePicker();
            this.dateTime_End = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Chk_All = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Chk_Class1 = new System.Windows.Forms.CheckBox();
            this.Chk_Class2 = new System.Windows.Forms.CheckBox();
            this.Chk_Class3 = new System.Windows.Forms.CheckBox();
            this.Chk_Class4 = new System.Windows.Forms.CheckBox();
            this.Chk_Class5 = new System.Windows.Forms.CheckBox();
            this.Chk_Class6 = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DataGrid_Config = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pm25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pm10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Save_Config = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Config)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTime_Start
            // 
            this.dateTime_Start.CalendarForeColor = System.Drawing.Color.SlateGray;
            this.dateTime_Start.CalendarMonthBackground = System.Drawing.Color.SlateGray;
            this.dateTime_Start.CalendarTitleBackColor = System.Drawing.Color.SlateGray;
            this.dateTime_Start.CalendarTitleForeColor = System.Drawing.Color.SlateGray;
            this.dateTime_Start.CalendarTrailingForeColor = System.Drawing.Color.SlateGray;
            this.dateTime_Start.CustomFormat = "";
            this.dateTime_Start.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTime_Start.Location = new System.Drawing.Point(240, 125);
            this.dateTime_Start.Name = "dateTime_Start";
            this.dateTime_Start.Size = new System.Drawing.Size(112, 21);
            this.dateTime_Start.TabIndex = 0;
            this.dateTime_Start.Value = new System.DateTime(2020, 12, 16, 0, 0, 0, 0);
            // 
            // dateTime_End
            // 
            this.dateTime_End.CustomFormat = "";
            this.dateTime_End.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTime_End.Location = new System.Drawing.Point(426, 126);
            this.dateTime_End.Name = "dateTime_End";
            this.dateTime_End.Size = new System.Drawing.Size(115, 21);
            this.dateTime_End.TabIndex = 1;
            this.dateTime_End.Value = new System.DateTime(2020, 12, 17, 0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1038, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 28);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "시작시간:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "종료시간:";
            // 
            // Chk_All
            // 
            this.Chk_All.AutoSize = true;
            this.Chk_All.Location = new System.Drawing.Point(594, 128);
            this.Chk_All.Name = "Chk_All";
            this.Chk_All.Size = new System.Drawing.Size(48, 16);
            this.Chk_All.TabIndex = 5;
            this.Chk_All.Text = "모두";
            this.Chk_All.UseVisualStyleBackColor = true;
            this.Chk_All.CheckedChanged += new System.EventHandler(this.Chk_All_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(555, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "교실:";
            // 
            // Chk_Class1
            // 
            this.Chk_Class1.AutoSize = true;
            this.Chk_Class1.Location = new System.Drawing.Point(648, 128);
            this.Chk_Class1.Name = "Chk_Class1";
            this.Chk_Class1.Size = new System.Drawing.Size(70, 16);
            this.Chk_Class1.TabIndex = 7;
            this.Chk_Class1.Text = "CLASS1";
            this.Chk_Class1.UseVisualStyleBackColor = true;
            this.Chk_Class1.CheckedChanged += new System.EventHandler(this.Chk_Class1_CheckedChanged);
            // 
            // Chk_Class2
            // 
            this.Chk_Class2.AutoSize = true;
            this.Chk_Class2.Location = new System.Drawing.Point(724, 128);
            this.Chk_Class2.Name = "Chk_Class2";
            this.Chk_Class2.Size = new System.Drawing.Size(70, 16);
            this.Chk_Class2.TabIndex = 8;
            this.Chk_Class2.Text = "CLASS2";
            this.Chk_Class2.UseVisualStyleBackColor = true;
            this.Chk_Class2.CheckedChanged += new System.EventHandler(this.Chk_Class2_CheckedChanged);
            // 
            // Chk_Class3
            // 
            this.Chk_Class3.AutoSize = true;
            this.Chk_Class3.Location = new System.Drawing.Point(800, 128);
            this.Chk_Class3.Name = "Chk_Class3";
            this.Chk_Class3.Size = new System.Drawing.Size(70, 16);
            this.Chk_Class3.TabIndex = 9;
            this.Chk_Class3.Text = "CLASS3";
            this.Chk_Class3.UseVisualStyleBackColor = true;
            this.Chk_Class3.CheckedChanged += new System.EventHandler(this.Chk_Class3_CheckedChanged);
            // 
            // Chk_Class4
            // 
            this.Chk_Class4.AutoSize = true;
            this.Chk_Class4.Location = new System.Drawing.Point(876, 128);
            this.Chk_Class4.Name = "Chk_Class4";
            this.Chk_Class4.Size = new System.Drawing.Size(70, 16);
            this.Chk_Class4.TabIndex = 10;
            this.Chk_Class4.Text = "CLASS4";
            this.Chk_Class4.UseVisualStyleBackColor = true;
            this.Chk_Class4.CheckedChanged += new System.EventHandler(this.Chk_Class4_CheckedChanged);
            // 
            // Chk_Class5
            // 
            this.Chk_Class5.AutoSize = true;
            this.Chk_Class5.Location = new System.Drawing.Point(952, 128);
            this.Chk_Class5.Name = "Chk_Class5";
            this.Chk_Class5.Size = new System.Drawing.Size(70, 16);
            this.Chk_Class5.TabIndex = 11;
            this.Chk_Class5.Text = "CLASS5";
            this.Chk_Class5.UseVisualStyleBackColor = true;
            this.Chk_Class5.CheckedChanged += new System.EventHandler(this.Chk_Class5_CheckedChanged);
            // 
            // Chk_Class6
            // 
            this.Chk_Class6.AutoSize = true;
            this.Chk_Class6.Location = new System.Drawing.Point(1028, 128);
            this.Chk_Class6.Name = "Chk_Class6";
            this.Chk_Class6.Size = new System.Drawing.Size(70, 16);
            this.Chk_Class6.TabIndex = 12;
            this.Chk_Class6.Text = "CLASS6";
            this.Chk_Class6.UseVisualStyleBackColor = true;
            this.Chk_Class6.CheckedChanged += new System.EventHandler(this.Chk_Class6_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Empty;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.SlateGray;
            this.dataGridView1.Location = new System.Drawing.Point(176, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(511, 390);
            this.dataGridView1.TabIndex = 13;
            // 
            // DataGrid_Config
            // 
            this.DataGrid_Config.AllowUserToAddRows = false;
            this.DataGrid_Config.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Empty;
            this.DataGrid_Config.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGrid_Config.BackgroundColor = System.Drawing.Color.SlateGray;
            this.DataGrid_Config.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Config.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGrid_Config.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Config.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.pm25,
            this.pm10});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_Config.DefaultCellStyle = dataGridViewCellStyle7;
            this.DataGrid_Config.GridColor = System.Drawing.Color.SlateGray;
            this.DataGrid_Config.Location = new System.Drawing.Point(693, 184);
            this.DataGrid_Config.Name = "DataGrid_Config";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Config.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGrid_Config.RowTemplate.Height = 23;
            this.DataGrid_Config.Size = new System.Drawing.Size(444, 171);
            this.DataGrid_Config.TabIndex = 14;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "교실";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 70;
            // 
            // pm25
            // 
            this.pm25.HeaderText = "초미세먼지 설정값";
            this.pm25.Name = "pm25";
            this.pm25.Width = 150;
            // 
            // pm10
            // 
            this.pm10.HeaderText = "미세먼지 설정값";
            this.pm10.Name = "pm10";
            this.pm10.Width = 150;
            // 
            // btn_Save_Config
            // 
            this.btn_Save_Config.BackColor = System.Drawing.Color.SlateGray;
            this.btn_Save_Config.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Save_Config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save_Config.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Save_Config.FlatAppearance.BorderSize = 0;
            this.btn_Save_Config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save_Config.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save_Config.Image")));
            this.btn_Save_Config.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Save_Config.Location = new System.Drawing.Point(1017, 361);
            this.btn_Save_Config.Name = "btn_Save_Config";
            this.btn_Save_Config.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Save_Config.Size = new System.Drawing.Size(99, 48);
            this.btn_Save_Config.TabIndex = 15;
            this.btn_Save_Config.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Save_Config.UseVisualStyleBackColor = false;
            this.btn_Save_Config.Click += new System.EventHandler(this.btn_Save_Config_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "시간";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "교실";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "초미세먼지";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "미세먼지";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // search
            // 
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1143, 586);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Save_Config);
            this.Controls.Add(this.DataGrid_Config);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Chk_Class6);
            this.Controls.Add(this.Chk_Class5);
            this.Controls.Add(this.Chk_Class4);
            this.Controls.Add(this.Chk_Class3);
            this.Controls.Add(this.Chk_Class2);
            this.Controls.Add(this.Chk_Class1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Chk_All);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTime_End);
            this.Controls.Add(this.dateTime_Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "search";
            this.Load += new System.EventHandler(this.search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Config)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTime_Start;
        private System.Windows.Forms.DateTimePicker dateTime_End;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Chk_All;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Chk_Class1;
        private System.Windows.Forms.CheckBox Chk_Class2;
        private System.Windows.Forms.CheckBox Chk_Class3;
        private System.Windows.Forms.CheckBox Chk_Class4;
        private System.Windows.Forms.CheckBox Chk_Class5;
        private System.Windows.Forms.CheckBox Chk_Class6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView DataGrid_Config;
        private System.Windows.Forms.Button btn_Save_Config;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn pm25;
        private System.Windows.Forms.DataGridViewTextBoxColumn pm10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
