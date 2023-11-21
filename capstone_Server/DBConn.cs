using System.Data.SqlClient;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Microsoft.Data.Analysis;
using Apache.Arrow;
using System.Collections;
using System.Collections.Generic;
using System.Security;
using System.Windows.Forms;

namespace capstone_Server
{
    internal class DBConn
    {
    }

    class DBConnection
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;Database=capstone;Uid=root;Pwd=1234");
        MySqlCommand oc = null;
        MySqlDataReader data = null;

        List<string> name = new List<string>();          // 이름
        List<string> category = new List<string>();
        List<string> nation = new List<string>();        // 국가
        List<string> time = new List<string>();          // 생몰년도
        List<string> achievement = new List<string>();   // 업적
        List<string> story = new List<string>();         // 뒷배경
        List<string> tell = new List<string>();          // 기타사항
        DataFrame sqlValue = null;

        public DBConnection(string sql)
        {
            try
            {
                conn.Open();
                oc = new MySqlCommand(sql, conn);
                data = oc.ExecuteReader();
            }
            catch (SqlException e)
            {
                serverMainForm.serverMain.logTBox.AppendText(e.Message + "\r\n");
            }
        }

        public DataFrame defaultNameReceive()
        {

            try
            {
                while(data.Read())
                {
                    name.Add(data["name"].ToString());
                    category.Add(data["category"].ToString());
                }
                DataFrameColumn[] sqlColumns = {
                    new StringDataFrameColumn("category", category),
                    new StringDataFrameColumn("name", name)
                };
                sqlValue = new DataFrame(sqlColumns);
            }
            catch (SqlException e)
            {
                serverMainForm.serverMain.logTBox.AppendText(e.ToString() + "\r\n");
            }
            return sqlValue;
        }

        public string defaultStoryReceive()
        {
            string story = null;
            try
            {
                while (data.Read())
                {
                    story = data["story"].ToString();
                }
            }
            catch (SqlException e)
            {
                serverMainForm.serverMain.logTBox.AppendText(e.ToString() + "\r\n");
            }
            return story;
        }

        public void closeAction()
        {
            conn.Close();
            data.Close();
        }
    }
}
