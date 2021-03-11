using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;
using System.Threading;
using MySql.Data.MySqlClient;

namespace Client_Project
{
    public partial class Form1 : Form
    {
        SimpleTcpClient client;

        MySQL mysql = new MySQL("localhost", "manage", "root", "1111");

        //2020.12.16 MDI 추가
        private monitoring mchildForm_Monitoring = null; //모니터링
        private search mchildForm_Search = null; //데이터관리
        private alarm mchildForm_Alarm = null; //알람
        private chart mchildForm_Chart = null; //차트

        public static int[] holdingRegister = Enumerable.Repeat(0, 100).ToArray();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
 
        }

        public static void SetTextBox(TextBox tb, string str)
        {
            if (tb.InvokeRequired)
            {
                tb.Invoke(new MethodInvoker(delegate
                {
                    tb.Text = str;
                }));
            }
            else
            {
                tb.Text = str;
            }
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
            btn_monitoring.BackColor = Color.Red;
            //시작메뉴 모니터링 화면
            if (ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild != mchildForm_Monitoring)
                {
                    //ActiveMdiChild.Close();
                    ActiveMdiChild.Hide();

                }
                mchildForm_Monitoring = ShowActiveForm(mchildForm_Monitoring, typeof(monitoring)) as monitoring;
            }
            else
            {
                mchildForm_Monitoring = ShowActiveForm(mchildForm_Monitoring, typeof(monitoring)) as monitoring;
            }


        }

        private void Client_DataReceived(Object sender, SimpleTCP.Message e)
        {
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
               txtStatus.Text += "\r\n";
               txtStatus.Text += e.MessageString;

            });
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            client.WriteLineAndGetReply(txtMessage.Text, TimeSpan.FromSeconds(3));

        }
        private void Connectbtn_enable(Button btn, bool b_bool)
        {

            if (btn.InvokeRequired)
            {
                btn.Invoke(new MethodInvoker(delegate
                {
                    btn.Enabled = b_bool;
                }));
            }
            else
            {
                btn.Enabled = b_bool;
            }
        }
        private void btn_DBConnect_Click(object sender, EventArgs e)
        {

            
        }

        private Form ShowActiveForm(Form form, Type t)
        {
            if (form == null)
            {
                form = (Form)Activator.CreateInstance(t);
                form.MdiParent = this;
                form.WindowState = FormWindowState.Maximized;
                form.ControlBox = false;
                form.Show();
            }
            else
            {
                if (form.IsDisposed)
                {
                    form = (Form)Activator.CreateInstance(t);
                    form.MdiParent = this;
                    form.WindowState = FormWindowState.Maximized;
                    form.ControlBox = false;

                    form.Show();

                }
                else
                {
                    form.Activate();
                }
            }
            return form;
        }
        private void btn_monitoring_Click(object sender, EventArgs e)
        {
            ButtonReset();
            if (ActiveMdiChild != null)
            {
                if(this.ActiveMdiChild != mchildForm_Monitoring)
                {
                    //ActiveMdiChild.Close();
                    ActiveMdiChild.Hide();

                }
                mchildForm_Monitoring = ShowActiveForm(mchildForm_Monitoring, typeof(monitoring)) as monitoring;
                mchildForm_Monitoring.Show();
            }
            else
            {
                mchildForm_Monitoring = ShowActiveForm(mchildForm_Monitoring, typeof(monitoring)) as monitoring;
                mchildForm_Monitoring.Show();

            }
            btn_monitoring.BackColor = Color.Red;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            ButtonReset();
            if (ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild != mchildForm_Search)
                {
                    //ActiveMdiChild.Close();
                    ActiveMdiChild.Hide();

                }
                mchildForm_Search = ShowActiveForm(mchildForm_Search, typeof(search)) as search;
                mchildForm_Search.Show();
            }
            else
            {
                mchildForm_Search = ShowActiveForm(mchildForm_Search, typeof(search)) as search;
                mchildForm_Search.Show();
            }
            btn_search.BackColor = Color.Red;
        }

        private void btn_alarm_Click(object sender, EventArgs e)
        {
            ButtonReset();
            if (ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild != mchildForm_Alarm)
                {
                    //ActiveMdiChild.Close();
                    ActiveMdiChild.Hide();

                }
                mchildForm_Alarm = ShowActiveForm(mchildForm_Alarm, typeof(alarm)) as alarm;
                mchildForm_Alarm.Show();
            }
            else
            {
                mchildForm_Alarm = ShowActiveForm(mchildForm_Alarm, typeof(alarm)) as alarm;
                mchildForm_Alarm.Show();
            }
            btn_alarm.BackColor = Color.Red;
        }

        private void btn_chart_Click(object sender, EventArgs e)
        {
            ButtonReset();
            if (ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild != mchildForm_Chart)
                {
                    //ActiveMdiChild.Close();
                    ActiveMdiChild.Hide();
                   

                }
                mchildForm_Chart = ShowActiveForm(mchildForm_Chart, typeof(chart)) as chart;
                mchildForm_Chart.Show();
            }
            else
            {
                mchildForm_Chart = ShowActiveForm(mchildForm_Chart, typeof(chart)) as chart;
                mchildForm_Chart.Show();
            }
            btn_chart.BackColor = Color.Red;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(0);
        }

        public void ButtonReset()
        {
            btn_monitoring.BackColor = Color.Black;
            btn_search.BackColor = Color.Black;
            btn_alarm.BackColor = Color.Black;
            btn_chart.BackColor = Color.Black;
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            var ConfirmResult = MessageBox.Show("종료 하시겠습니까? ", "", MessageBoxButtons.YesNo);

            if(ConfirmResult == DialogResult.Yes)
            {
                Application.ExitThread();
                Environment.Exit(0);
            }
            
        }
    }
}
