using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace capstone_client
{
    public partial class clientMainForm : MetroFramework.Forms.MetroForm
    {
        public static clientMainForm ClientMainForm;

        ConnTcpServer conn = new ConnTcpServer();                                        // TCP Client 접속 객체
        List<string> nameList = new List<string>();                                      // 리스트 객체 생성    -->    나중에 Dictionary를 이용해서 Key, Value 형식으로 전환

        // 공백이 제거된 문자열 리스트를 name, category로 재분배후 리스트화
        List<string> name = new List<string>();
        List<string> cate = new List<string>();

        string data = null;
        string[] dataList = null;                                                        // 수신 받은 데이터들을 리스트에 저장하기 전에 임시로 보관하는 data 배열변수

        public clientMainForm()
        {
            InitializeComponent();

            dataList = conn.getNameValue().Split('\n');                                 // Name 값을 split을 통해 분리해서 배열에 저장
            
            nameList.AddRange(dataList);                                                // 리스트에 배열 데이터 입력
            nameList.RemoveAt(0);                                                       // 첫번째 속성 요소 제거

            List<string> lstStr = new List<string>();                                   // 데이터 공백 처리용 리스트 객체


            // 문자열 사이의 공백 제거
            string[] removeEntry = { "   " };
            foreach(string s in nameList) {
                string str = null;
                str = s.TrimEnd();
                string[] lst;
                lst = str.Split(removeEntry, StringSplitOptions.RemoveEmptyEntries);
                lstStr.AddRange(lst);
                
            }

            for(int i=0; i<lstStr.Count; i++)
            {
                string str = lstStr[i];
                str = str.Trim();
                if(i%2 == 1)
                {
                    name.Add(str);
                }
                else
                {
                    cate.Add(str);
                }

            }

            for(int i=0; i<name.Count; i++)
            {
                switch (cate[i])
                {
                    case "지도자":
                        prsList.Nodes[0].Nodes.Add(name[i]);
                        break;
                    case "종교인":
                        prsList.Nodes[1].Nodes.Add(name[i]);
                        break;
                    case "혁명가":
                        prsList.Nodes[2].Nodes.Add(name[i]);
                        break;
                    case "탐험가":
                        prsList.Nodes[3].Nodes.Add(name[i]);
                        break;
                    case "사업가":
                        prsList.Nodes[4].Nodes.Add(name[i]);
                        break;
                    case "운동선수":
                        prsList.Nodes[5].Nodes.Add(name[i]);
                        break;
                    case "예술가":
                        prsList.Nodes[6].Nodes.Add(name[i]);
                        break;
                    case "극작가":
                        prsList.Nodes[7].Nodes.Add(name[i]);
                        break;
                    case "음악가":
                        prsList.Nodes[8].Nodes.Add(name[i]);
                        break;
                    case "건축가":
                        prsList.Nodes[9].Nodes.Add(name[i]);
                        break;
                    case "철학자":
                        prsList.Nodes[10].Nodes.Add(name[i]);
                        break;
                    case "물리학자":
                        prsList.Nodes[11].Nodes.Add(name[i]);
                        break;
                    case "생물학자":
                        prsList.Nodes[12].Nodes.Add(name[i]);
                        break;
                    case "화학자":
                        prsList.Nodes[13].Nodes.Add(name[i]);
                        break;
                    case "사회봉사자":
                        prsList.Nodes[14].Nodes.Add(name[i]);
                        break;
                    case "교육학자":
                        prsList.Nodes[15].Nodes.Add(name[i]);
                        break;
                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void clientMainForm_Load(object sender, EventArgs e)
        {

        }

        private void crtButton_Click(object sender, EventArgs e)
        {

        }

        private void edtButton_Click(object sender, EventArgs e)
        {

        }

        private void cnfButton_Click(object sender, EventArgs e)
        {

        }

        private void prsList_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            
            foreach (string s in name)
            {
                if (e.Node.Text == s)
                {
                    data = conn.contValueSetting(s);
                    data = data.Replace("name\r\n", "");
                    contLabel.Text = data;
                }
            }
            
        }

        private void prsList_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            
        }

        private void clientMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.clientShutdown();
        }
    }
}
