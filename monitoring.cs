using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EasyModbus;
using System.Threading;
using MySql.Data.MySqlClient;
using System.Linq;
using System.IO;

namespace Client_Project
{
    public partial class monitoring : Form
    {
        MySQL mysql = new MySQL("localhost", "manage", "root", "1111");

        int[] n_SensorState = Enumerable.Repeat(3, 20).ToArray();
        public static int[] n_Config_Value = Enumerable.Repeat(0, 6).ToArray();
        public static int[] n_Config_Value2 = Enumerable.Repeat(0, 6).ToArray();
        public static int[] n_Value_pm25 = Enumerable.Repeat(0, 20).ToArray();
        public static int[] n_Value_pm10 = Enumerable.Repeat(0, 20).ToArray();
        Boolean[] b_Alarm  = new Boolean[6];
        Boolean[] b_Alarm2 = new Boolean[6];
        public Thread t1;
        public ModbusClient modbusClient;
        bool b_Modbus_Connect = false;
        private StreamWriter sw;
        

        public monitoring()
        {
            InitializeComponent();
        }

        private void monitoring_Load(object sender, EventArgs e)
        {
            Config_DataRead();

            t1 = new Thread(new ThreadStart(Read_Data));
            t1.Start();
            

            timer1.Interval = 1000;
            timer1.Start();

        }
        private void ThreadExecute()
        {
            Read_Data();

        }
        private void Read_Data()
        {           
            modbusClient = new ModbusClient("127.0.0.1", 502);    //Ip-Address and Port of Modbus-TCP-Server
           // modbusClient.Disconnect();
           

            try
            {
                modbusClient.Connect();
                b_Modbus_Connect = true;
            }
            catch (Exception)
            {
                b_Modbus_Connect = false;
                SaveLogFile("Modbus 연결 실패");
                return;
            }

            while (true)
            {

                try
                {
                    n_Value_pm25 = modbusClient.ReadInputRegisters(0, 20);
                    System.Threading.Thread.Sleep(1000);
                    n_Value_pm10 = modbusClient.ReadInputRegisters(100, 20);
                    System.Threading.Thread.Sleep(1000);
                    n_SensorState = modbusClient.ReadInputRegisters(200, 20);
                   

                 }
                catch (Exception)
                {
                    modbusClient.Disconnect();
                    b_Modbus_Connect = false;
                    SaveLogFile("Modbus data Read Fail");
                    n_SensorState = Enumerable.Repeat(3, 20).ToArray();
                    return;
                }

                for (int i = 0; i < 6; i ++)
                {
                    DateTime dataTime = DateTime.Now;

                    string time = DateTime.Now.ToString("yy_MM");
                    string time1 = DateTime.Now.ToString("yy-MM-dd-HH-mm-ss");

                    string sInsert_Text = "INSERT INTO sensor_data_";
                   
                    sInsert_Text += time + " VALUES (null," + Convert.ToString(i+1) + ",'" + time1+ "',";
                    
                    sInsert_Text += Convert.ToString(n_Value_pm25[i*2]) + "," + Convert.ToString(n_Value_pm10[i*2]) + ")";

                    if(mysql.sql(sInsert_Text) == false)
                    {
                        SaveLogFile("insert Fail" + sInsert_Text);
                        string s_Create_Query = "CREATE TABLE `manage`.`sensor_data_#Date` " +
                            "(`index_id` BIGINT(20) NOT NULL AUTO_INCREMENT,`class` INT(11) NOT NULL,	" 
                            + "`regdate` TIMESTAMP NULL DEFAULT NULL,	`pm2.5` INT(11) NULL DEFAULT '0',	" 
                            + "`pm10` INT(11) NULL DEFAULT '0', INDEX `index_id` (`index_id`) USING BTREE)";

                        s_Create_Query = s_Create_Query.Replace("#Date", time);

                        mysql.sql(s_Create_Query); //년월 테이블 생성
                        mysql.sql(sInsert_Text); //실패한 데이터 다시 insert 
                    }

                    if(n_Config_Value[i] <= n_Value_pm25[i*2] && b_Alarm[i] == false)
                    {
                        b_Alarm[i] = true;
                        string sInsert_AlarmText = "INSERT INTO alarm_list VALUES (null," + Convert.ToString(i + 1) + ",'" + time1 + "',";
                        sInsert_AlarmText += Convert.ToString(n_Config_Value[i]) + "," + Convert.ToString(n_Config_Value2[i]) +
                            "," + Convert.ToString(n_Value_pm25[i * 2]) + "," + Convert.ToString(n_Value_pm10[i * 2]) + ")";
                        mysql.sql(sInsert_AlarmText);

                    }
                    else if(n_Config_Value[i] >= n_Value_pm25[i * 2] && b_Alarm[i] == true)
                    {
                        b_Alarm[i] = false;         
                    }

                    if (n_Config_Value2[i] <= n_Value_pm10[i * 2] && b_Alarm2[i] == false)
                    {
                        b_Alarm2[i] = true;
                        string sInsert_AlarmText = "INSERT INTO alarm_list VALUES (null," + Convert.ToString(i + 1) + ",'" + time1 + "',";
                        sInsert_AlarmText += Convert.ToString(n_Config_Value[i]) + "," + Convert.ToString(n_Config_Value2[i]) +
                            "," + Convert.ToString(n_Value_pm25[i * 2]) + "," + Convert.ToString(n_Value_pm10[i * 2]) + ")";
                        mysql.sql(sInsert_AlarmText);
                    }
                    else if (n_Config_Value2[i] >= n_Value_pm10[i * 2] && b_Alarm2[i] == true)
                    {
                        b_Alarm2[i] = false;
                    }
 
                }
 
                
                SetLabel(label_Class1PM25, n_Value_pm25[0].ToString());
                SetLabel(label_Class2PM25, n_Value_pm25[2].ToString());
                SetLabel(label_Class3PM25, n_Value_pm25[4].ToString());
                SetLabel(label_Class4PM25, n_Value_pm25[6].ToString());
                SetLabel(label_Class5PM25, n_Value_pm25[8].ToString());
                SetLabel(label_Class6PM25, n_Value_pm25[10].ToString());

                SetLabel(label_Class1PM10, n_Value_pm10[0].ToString());
                SetLabel(label_Class2PM10, n_Value_pm10[2].ToString());
                SetLabel(label_Class3PM10, n_Value_pm10[4].ToString());
                SetLabel(label_Class4PM10, n_Value_pm10[6].ToString());
                SetLabel(label_Class5PM10, n_Value_pm10[8].ToString());
                SetLabel(label_Class6PM10, n_Value_pm10[10].ToString());

                System.Threading.Thread.Sleep(1000);
           
            }
            b_Modbus_Connect = false;
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
        public static void SetLabel(Label lb, string str)
        {
            if (lb.InvokeRequired)
            {
                lb.Invoke(new MethodInvoker(delegate
                {
                    lb.Text = str;
                }));
            }
            else
            {
                lb.Text = str;
            }
        }
        private void SensorStatus()
        {
            if (n_SensorState == null) return;

            if (n_SensorState[0] == 0)//1
            {
                Pb_class1Off.Visible = false;
                Pb_class1On.Visible = true;
            }
            else
            {
                Pb_class1Off.Visible = true;
                Pb_class1On.Visible = false;
            }

            if (n_SensorState[2] == 0)//2
            {
                Pb_class2Off.Visible = false;
                Pb_class2On.Visible = true;
            }
            else
            {
                Pb_class2Off.Visible = true;
                Pb_class2On.Visible = false;
            }

            if (n_SensorState[4] == 0)//3
            {
                Pb_class3Off.Visible = false;
                Pb_class3On.Visible = true;
            }
            else
            {
                Pb_class3Off.Visible = true;
                Pb_class3On.Visible = false;
            }

            if (n_SensorState[6] == 0)//4
            {
                Pb_class4Off.Visible = false;
                Pb_class4On.Visible = true;
            }
            else
            {
                Pb_class4Off.Visible = true;
                Pb_class4On.Visible = false;
            }

            if (n_SensorState[8] == 0)//5
            {
                Pb_class5Off.Visible = false;
                Pb_class5On.Visible = true;
            }
            else
            {
                Pb_class5Off.Visible = true;
                Pb_class5On.Visible = false;
            }

            if (n_SensorState[10] == 0)//6
            {
                Pb_class6Off.Visible = false;
                Pb_class6On.Visible = true;
            }
            else
            {
                Pb_class6Off.Visible = true;
                Pb_class6On.Visible = false;
            }

        }
        private void AlarmStatus(int nClass, bool b_Set)
        {
            if(nClass == 1)
            {
                Pb_Class1_Alarm.Visible = b_Set;
            }
            else if (nClass == 2)
            {
                Pb_Class2_Alarm.Visible = b_Set;
            }
            else if (nClass == 3)
            {
                Pb_Class3_Alarm.Visible = b_Set;
            }
            else if (nClass == 4)
            {
                Pb_Class4_Alarm.Visible = b_Set;
            }
            else if (nClass == 5)
            {
                Pb_Class5_Alarm.Visible = b_Set;
            }
            else if (nClass == 6)
            {
                Pb_Class6_Alarm.Visible = b_Set;
            }
        }
        private void AlarmStatus2(int nClass, bool b_Set)
        {
            if (nClass == 1)
            {
                Pb_Class1_Alarm2.Visible = b_Set;
            }
            else if (nClass == 2)
            {
                Pb_Class2_Alarm2.Visible = b_Set;
            }
            else if (nClass == 3)
            {
                Pb_Class3_Alarm2.Visible = b_Set;
            }
            else if (nClass == 4)
            {
                Pb_Class4_Alarm2.Visible = b_Set;
            }
            else if (nClass == 5)
            {
                Pb_Class5_Alarm2.Visible = b_Set;
            }
            else if (nClass == 6)
            {
                Pb_Class6_Alarm2.Visible = b_Set;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            SensorStatus();

            for (int i = 0; i < 6; i++)
            {
                AlarmStatus(i + 1, b_Alarm[i]);
                AlarmStatus2(i + 1, b_Alarm2[i]);
            }
            if(b_Modbus_Connect ==  false)
            {
                   b_Modbus_Connect = true;

                  t1 = new Thread(new ThreadStart(Read_Data));
                  t1.Start();

            }
        }
        public void monitoring_FormClosing(object sender, FormClosingEventArgs e)
        {
            t1.Abort(); //Thread 종료
            modbusClient.Disconnect();
        }
        private void Config_DataRead()
        {
            string sSelect_OperList = "";

            for(int i =0; i < 6; i++)
            {
                sSelect_OperList = "SELECT `after_pm2.5`, `after_pm10` from operation_list where class = " + Convert.ToString(i+1);
                                
                mysql.Select_sql(sSelect_OperList);

                try
                {
                    mysql.rdr.Read();
                }
                catch(Exception)
                {
                    return;
                }

                n_Config_Value[i] = Convert.ToInt32(mysql.rdr["after_pm2.5"]);
                n_Config_Value2[i] = Convert.ToInt32(mysql.rdr["after_pm10"]);
            }
        }
        private void cb_class1_use_CheckedChanged(object sender, EventArgs e)
        {
            if (!cb_class1_use.Checked)
            {
                try
                {
                    modbusClient.WriteSingleRegister(4, 2);//2= Discard //1 = Load // 0 = Ready
                }
                catch { }
            }
            else
            {
                try
                {
                    modbusClient.WriteSingleRegister(4, 1);
                }
                catch { }
                
            }
        }

        private void cb_class2_use_CheckedChanged(object sender, EventArgs e)
        {
            if (!cb_class2_use.Checked)
            {
                try
                {
                    modbusClient.WriteSingleRegister(14, 2);//2= Discard //1 = Load // 0 = Ready
                }
                catch { }
            }
            else
            {
                try
                {
                    modbusClient.WriteSingleRegister(14, 1);
                }
                catch { }

            }
        }

        private void cb_class3_use_CheckedChanged(object sender, EventArgs e)
        {
            if (!cb_class3_use.Checked)
            {
                try
                {
                    modbusClient.WriteSingleRegister(24, 2);//2= Discard //1 = Load // 0 = Ready
                }
                catch { }
            }
            else
            {
                try
                {
                    modbusClient.WriteSingleRegister(24, 1);
                }
                catch { }

            }
        }
        private void cb_class4_use_CheckedChanged(object sender, EventArgs e)
        {
            if (!cb_class4_use.Checked)
            {
                try
                {
                    modbusClient.WriteSingleRegister(34, 2);//2= Discard //1 = Load // 0 = Ready
                }
                catch { }
            }
            else
            {
                try
                {
                    modbusClient.WriteSingleRegister(34, 1);
                }
                catch { }

            }
        }
        private void cb_class5_use_CheckedChanged(object sender, EventArgs e)
        {
            if (!cb_class5_use.Checked)
            {
                try
                {
                    modbusClient.WriteSingleRegister(44, 2);//2= Discard //1 = Load // 0 = Ready
                }
                catch { }
            }
            else
            {
                try
                {
                    modbusClient.WriteSingleRegister(44, 1);
                }
                catch { }

            }
        }
        private void cb_class6_use_CheckedChanged(object sender, EventArgs e)
        {
            if (!cb_class6_use.Checked)
            {
                try
                {
                    modbusClient.WriteSingleRegister(54, 2);//2= Discard //1 = Load // 0 = Ready
                }
                catch { }
            }
            else
            {
                try
                {
                    modbusClient.WriteSingleRegister(54, 1);
                }
                catch { }

            }
        }
        public void SaveLogFile(string s_LogMessage)
        { 
            string s_FilePath = Application.StartupPath + @"\Log\Log_" + DateTime.Today.ToString("yyyyMMdd") + ".log";
            string s_DirPath = Application.StartupPath + @"\Log";
            string temp;

            DirectoryInfo di = new DirectoryInfo(s_DirPath);
            FileInfo fi = new FileInfo(s_FilePath);
           
            try
            {
                if (di.Exists != true) Directory.CreateDirectory(s_DirPath);

                if (fi.Exists != true)
                {
                    using (sw = new StreamWriter(s_FilePath))
                    {
                        temp = string.Format("[{0}] : {1}", GetDateTime(), s_LogMessage);
                        sw.WriteLine(temp);
                        sw.Close();
                    }
                }
                else
                {
                    using (sw = File.AppendText(s_FilePath))
                    {
                        temp = string.Format("[{0}] : {1}", GetDateTime(), s_LogMessage);
                        sw.WriteLine(temp);
                        sw.Close();

                    }
                }

            }
            catch(Exception e)
            {
                sw.Close();
            }

           
        }
        private string GetDateTime()
        {
            DateTime NowDate = DateTime.Now;
            return NowDate.ToString("yyyy-MM-dd HH:mm:ss") + ":" + NowDate.Millisecond.ToString("000");
        }
    }
}
