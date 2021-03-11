using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Client_Project
{
    public partial class search : Form
    {

        MySQL mysql = new MySQL("localhost", "manage", "root", "1111");
        public string sSelectText = "";

        
        public search()
        {
            InitializeComponent();
            Chk_All.Checked = true;

            DateTime YesterDay = DateTime.Today.AddDays(-1);
            DateTime StartdateTime = new DateTime(YesterDay.Year, YesterDay.Month, YesterDay.Day, 00, 00, 00);
            dateTime_Start.Value = StartdateTime;
            dateTime_Start.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            DateTime EnddateTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 23, 59, 59);
            dateTime_End.Value = EnddateTime;
            dateTime_End.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            
        }

        private void search_Load(object sender, EventArgs e)
        {
            Config_View();
        }
        public void Config_View()
        {
            DataGrid_Config.Rows.Clear();
            sSelectText = "SELECT * FROM OPERATION_LIST ";
            
            mysql.Select_sql(sSelectText);

            while (mysql.rdr.Read())
            {
                string sClass = Convert.ToString(mysql.rdr["class"]);
                
                string sPm25 = Convert.ToString(mysql.rdr["after_pm2.5"]);
                string sPm10 = Convert.ToString(mysql.rdr["after_pm10"]);

                DataGrid_Config.Rows.Add(sClass, sPm25, sPm10);
            }
        }
        private void Chk_Class5_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Class5.Checked)
            {
                Chk_All.Checked = false;
            }

            if (Chk_Class1.Checked && Chk_Class2.Checked && Chk_Class3.Checked
                && Chk_Class4.Checked && Chk_Class5.Checked && Chk_Class6.Checked)
            {
                Chk_All.Checked = true;

                Chk_Class1.Checked = false;
                Chk_Class2.Checked = false;
                Chk_Class3.Checked = false;
                Chk_Class4.Checked = false;
                Chk_Class5.Checked = false;
                Chk_Class6.Checked = false;
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {

            if (!Chk_All.Checked && !Chk_Class1.Checked && !Chk_Class2.Checked && !Chk_Class3.Checked
               && !Chk_Class4.Checked && !Chk_Class5.Checked && !Chk_Class6.Checked)
            {
                MessageBox.Show("선택된 교실이 없습니다.");

                return;
            }
            sSelectText = "";
            DateTime nextDt0 = new DateTime();
            int n_DiffYear = Convert.ToInt32(dateTime_End.Value.ToString("yy")) - Convert.ToInt32(dateTime_Start.Value.ToString("yy"));
            int n_DiffMonth = 0;
            if (n_DiffYear == 1)
            {
                n_DiffMonth = Convert.ToInt32(dateTime_End.Value.ToString("MM"))+12 - Convert.ToInt32(dateTime_Start.Value.ToString("MM"));
            }
            else n_DiffMonth = Convert.ToInt32(dateTime_End.Value.ToString("MM")) - Convert.ToInt32(dateTime_Start.Value.ToString("MM"));

            if(n_DiffMonth < 0)
            {
                MessageBox.Show("시작 시간이 종료시간 보다 뒤에 있습니다.");
                return;
            }

            nextDt0 = dateTime_Start.Value;
            for (int i = 0; i < n_DiffMonth+1; i ++)
            {
                sSelectText += "SELECT * FROM SENSOR_DATA_" + nextDt0.ToString("yy_MM") + " UNION ALL ";

                nextDt0 = dateTime_Start.Value.AddMonths(i+1);
            }
            
            sSelectText = sSelectText.Remove(sSelectText.LastIndexOf("UNION ALL"),9);
            
            dataGridView1.Rows.Clear();
            sSelectText += " WHERE REGDATE >= '" + dateTime_Start.Value.ToString("yyyy-MM-dd HH-mm-ss") 
                + "' AND REGDATE <= '" + dateTime_End.Value.ToString("yyyy-MM-dd HH-mm-ss") + "'";
            if (!Chk_All.Checked)
            {
                sSelectText += " AND (";
                if (Chk_Class1.Checked) sSelectText += "class = 1 OR ";
                if (Chk_Class2.Checked) sSelectText += "class = 2 OR ";
                if (Chk_Class3.Checked) sSelectText += "class = 3 OR ";
                if (Chk_Class4.Checked) sSelectText += "class = 4 OR ";
                if (Chk_Class5.Checked) sSelectText += "class = 5 OR ";
                if (Chk_Class6.Checked) sSelectText += "class = 6 OR";
                
                sSelectText += ")";
            }
            else sSelectText += "OR";
            sSelectText = sSelectText.Remove(sSelectText.LastIndexOf("OR"),2);

            sSelectText += " order by REGDATE DESC ";
            sSelectText += "limit 1000 ";
            
            mysql.Select_sql(sSelectText);

            while (mysql.rdr.Read())
            {
                string sTime = Convert.ToString(mysql.rdr["regdate"]);
                string sClass = Convert.ToString(mysql.rdr["class"]);
                string sPm25 = Convert.ToString(mysql.rdr["pm2.5"]);
                string sPm10 = Convert.ToString(mysql.rdr["pm10"]);

                dataGridView1.Rows.Add( sTime, sClass, sPm25, sPm10);
            }
            
        }

        private void Chk_All_CheckedChanged(object sender, EventArgs e)
        {
            if(Chk_All.Checked)
            {
                Chk_Class1.Checked = false;
                Chk_Class2.Checked = false;
                Chk_Class3.Checked = false;
                Chk_Class4.Checked = false;
                Chk_Class5.Checked = false;
                Chk_Class6.Checked = false;
            }
        }

        private void Chk_Class1_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Class1.Checked)
            {
                Chk_All.Checked = false;
            }

            if (Chk_Class1.Checked && Chk_Class2.Checked && Chk_Class3.Checked
                && Chk_Class4.Checked && Chk_Class5.Checked && Chk_Class6.Checked)
            {
                Chk_All.Checked = true;

                Chk_Class1.Checked = false;
                Chk_Class2.Checked = false;
                Chk_Class3.Checked = false;
                Chk_Class4.Checked = false;
                Chk_Class5.Checked = false;
                Chk_Class6.Checked = false;
            }

        }

        private void Chk_Class2_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Class2.Checked)
            {
                Chk_All.Checked = false;
            }

            if (Chk_Class1.Checked && Chk_Class2.Checked && Chk_Class3.Checked
                && Chk_Class4.Checked && Chk_Class5.Checked && Chk_Class6.Checked)
            {
                Chk_All.Checked = true;

                Chk_Class1.Checked = false;
                Chk_Class2.Checked = false;
                Chk_Class3.Checked = false;
                Chk_Class4.Checked = false;
                Chk_Class5.Checked = false;
                Chk_Class6.Checked = false;
            }
        }

        private void Chk_Class3_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Class3.Checked)
            {
                Chk_All.Checked = false;
            }

            if (Chk_Class1.Checked && Chk_Class2.Checked && Chk_Class3.Checked
                && Chk_Class4.Checked && Chk_Class5.Checked && Chk_Class6.Checked)
            {
                Chk_All.Checked = true;

                Chk_Class1.Checked = false;
                Chk_Class2.Checked = false;
                Chk_Class3.Checked = false;
                Chk_Class4.Checked = false;
                Chk_Class5.Checked = false;
                Chk_Class6.Checked = false;
            }
        }

        private void Chk_Class4_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Class4.Checked)
            {
                Chk_All.Checked = false;
            }

            if (Chk_Class1.Checked && Chk_Class2.Checked && Chk_Class3.Checked
                && Chk_Class4.Checked && Chk_Class5.Checked && Chk_Class6.Checked)
            {
                Chk_All.Checked = true;

                Chk_Class1.Checked = false;
                Chk_Class2.Checked = false;
                Chk_Class3.Checked = false;
                Chk_Class4.Checked = false;
                Chk_Class5.Checked = false;
                Chk_Class6.Checked = false;
            }
        }

        private void Chk_Class6_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Class6.Checked)
            {
                Chk_All.Checked = false;
            }

            if (Chk_Class1.Checked && Chk_Class2.Checked && Chk_Class3.Checked
                && Chk_Class4.Checked && Chk_Class5.Checked && Chk_Class6.Checked)
            {
                Chk_All.Checked = true;

                Chk_Class1.Checked = false;
                Chk_Class2.Checked = false;
                Chk_Class3.Checked = false;
                Chk_Class4.Checked = false;
                Chk_Class5.Checked = false;
                Chk_Class6.Checked = false;
            }
        }

        private void btn_Save_Config_Click(object sender, EventArgs e)
        {
            
            for(int i=0; i < DataGrid_Config.Rows.Count; i++)
            {
                string sUpdate_Query = "update operation_list set `regdate` = '#regdate', `after_pm2.5` = '#after_pm2.5' , `after_pm10` = '#after_pm10'" +
                    " where class = '#class'";

                sUpdate_Query = sUpdate_Query.Replace("#regdate", DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss"));
                sUpdate_Query = sUpdate_Query.Replace("#after_pm2.5", DataGrid_Config.Rows[i].Cells[1].Value.ToString());
                sUpdate_Query = sUpdate_Query.Replace("#after_pm10", DataGrid_Config.Rows[i].Cells[2].Value.ToString());
                sUpdate_Query = sUpdate_Query.Replace("#class", DataGrid_Config.Rows[i].Cells[0].Value.ToString());

                monitoring.n_Config_Value[i] = Convert.ToInt32(DataGrid_Config.Rows[i].Cells[1].Value.ToString());
                monitoring.n_Config_Value2[i] = Convert.ToInt32(DataGrid_Config.Rows[i].Cells[2].Value.ToString());

                mysql.sql(sUpdate_Query);
            }
        }
    }
}
