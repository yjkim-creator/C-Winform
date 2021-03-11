
namespace Client_Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btn_monitoring = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_alarm = new System.Windows.Forms.Button();
            this.btn_chart = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.모니터링ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.데이터관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.알람이력ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.실시간차트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mySqlCommandBuilder1 = new MySqlConnector.MySqlCommandBuilder();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(1336, 4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(48, 21);
            this.txtPort.TabIndex = 6;
            this.txtPort.Text = "8910";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1299, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(1197, 4);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(92, 21);
            this.txtHost.TabIndex = 7;
            this.txtHost.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1157, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Host:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(1390, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(63, 20);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(1197, 31);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(256, 40);
            this.txtMessage.TabIndex = 8;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(1390, 77);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(63, 20);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(1159, 103);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(294, 383);
            this.txtStatus.TabIndex = 10;
            // 
            // btn_monitoring
            // 
            this.btn_monitoring.BackColor = System.Drawing.Color.Black;
            this.btn_monitoring.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_monitoring.BackgroundImage")));
            this.btn_monitoring.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_monitoring.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_monitoring.FlatAppearance.BorderSize = 0;
            this.btn_monitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_monitoring.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_monitoring.ForeColor = System.Drawing.Color.Snow;
            this.btn_monitoring.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_monitoring.ImageKey = "(없음)";
            this.btn_monitoring.Location = new System.Drawing.Point(0, 122);
            this.btn_monitoring.Name = "btn_monitoring";
            this.btn_monitoring.Size = new System.Drawing.Size(143, 90);
            this.btn_monitoring.TabIndex = 11;
            this.btn_monitoring.Text = "모니터링";
            this.btn_monitoring.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_monitoring.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_monitoring.UseVisualStyleBackColor = false;
            this.btn_monitoring.Click += new System.EventHandler(this.btn_monitoring_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_search.ForeColor = System.Drawing.Color.Snow;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_search.ImageKey = "(없음)";
            this.btn_search.Location = new System.Drawing.Point(0, 215);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(143, 90);
            this.btn_search.TabIndex = 13;
            this.btn_search.Text = "데이터 관리";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_alarm
            // 
            this.btn_alarm.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_alarm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_alarm.BackgroundImage")));
            this.btn_alarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_alarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_alarm.FlatAppearance.BorderSize = 0;
            this.btn_alarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alarm.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_alarm.ForeColor = System.Drawing.Color.Snow;
            this.btn_alarm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_alarm.ImageKey = "(없음)";
            this.btn_alarm.Location = new System.Drawing.Point(0, 308);
            this.btn_alarm.Name = "btn_alarm";
            this.btn_alarm.Size = new System.Drawing.Size(143, 90);
            this.btn_alarm.TabIndex = 14;
            this.btn_alarm.Text = "알람 조회";
            this.btn_alarm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_alarm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_alarm.UseVisualStyleBackColor = false;
            this.btn_alarm.Click += new System.EventHandler(this.btn_alarm_Click);
            // 
            // btn_chart
            // 
            this.btn_chart.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_chart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_chart.BackgroundImage")));
            this.btn_chart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_chart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_chart.FlatAppearance.BorderSize = 0;
            this.btn_chart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chart.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_chart.ForeColor = System.Drawing.Color.Snow;
            this.btn_chart.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_chart.ImageKey = "(없음)";
            this.btn_chart.Location = new System.Drawing.Point(0, 401);
            this.btn_chart.Name = "btn_chart";
            this.btn_chart.Size = new System.Drawing.Size(143, 90);
            this.btn_chart.TabIndex = 15;
            this.btn_chart.Text = "실시간 차트";
            this.btn_chart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_chart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_chart.UseVisualStyleBackColor = false;
            this.btn_chart.Click += new System.EventHandler(this.btn_chart_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.모니터링ToolStripMenuItem,
            this.데이터관리ToolStripMenuItem,
            this.알람이력ToolStripMenuItem,
            this.실시간차트ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(123, 586);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // 모니터링ToolStripMenuItem
            // 
            this.모니터링ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.모니터링ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("모니터링ToolStripMenuItem.Image")));
            this.모니터링ToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.모니터링ToolStripMenuItem.Name = "모니터링ToolStripMenuItem";
            this.모니터링ToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.모니터링ToolStripMenuItem.Text = "모니터링";
            this.모니터링ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // 데이터관리ToolStripMenuItem
            // 
            this.데이터관리ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("데이터관리ToolStripMenuItem.Image")));
            this.데이터관리ToolStripMenuItem.Name = "데이터관리ToolStripMenuItem";
            this.데이터관리ToolStripMenuItem.Size = new System.Drawing.Size(92, 39);
            this.데이터관리ToolStripMenuItem.Text = "데이터 관리";
            this.데이터관리ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // 알람이력ToolStripMenuItem
            // 
            this.알람이력ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("알람이력ToolStripMenuItem.Image")));
            this.알람이력ToolStripMenuItem.Name = "알람이력ToolStripMenuItem";
            this.알람이력ToolStripMenuItem.Size = new System.Drawing.Size(92, 39);
            this.알람이력ToolStripMenuItem.Text = "알람이력";
            this.알람이력ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // 실시간차트ToolStripMenuItem
            // 
            this.실시간차트ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("실시간차트ToolStripMenuItem.Image")));
            this.실시간차트ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.실시간차트ToolStripMenuItem.Name = "실시간차트ToolStripMenuItem";
            this.실시간차트ToolStripMenuItem.Size = new System.Drawing.Size(92, 55);
            this.실시간차트ToolStripMenuItem.Text = "실시간차트";
            this.실시간차트ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mySqlCommandBuilder1
            // 
            this.mySqlCommandBuilder1.DataAdapter = null;
            this.mySqlCommandBuilder1.QuotePrefix = "`";
            this.mySqlCommandBuilder1.QuoteSuffix = "`";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.btn_monitoring);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btn_chart);
            this.panel1.Controls.Add(this.btn_alarm);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 589);
            this.panel1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageKey = "(없음)";
            this.button1.Location = new System.Drawing.Point(0, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 90);
            this.button1.TabIndex = 17;
            this.button1.Text = "종료";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1136, 586);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "미세먼지 모니터링 시스템";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btn_monitoring;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_alarm;
        private System.Windows.Forms.Button btn_chart;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 모니터링ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 데이터관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 알람이력ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 실시간차트ToolStripMenuItem;
        private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

