using System;
using System.Drawing.Text;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Analysis;

namespace capstone_client
{
    internal class serverConnect
    {
    }

    class ConnTcpServer
    {   
        // Tcp Client 객체변수
        public TcpClient client = new TcpClient();

        // TCP통신 데이터 수신 값 저장 변수
        byte[] outBuff;

        // 서버로 부터 받아온 데이터를 저장하는 변수들
        private string nameRec = "";        // name
        private string contRec = "";        // content

        public ConnTcpServer()
        {
            try
            {

                // DNS (Domain Name System) -> www.xxxxx.com -> IP
                //string dns = "capproject.kro.kr";
                //IPAddress ipAddr = Dns.GetHostAddresses(dns)[0];

                // 첫번째 매개변수는 접속할 IP
                // 서버가 내 PC에서 돌아가므로 127.0.0.1(자기자신을 나타내는 루프백IP)
                // 두번째 매개변수는 서버에서 설정한 포트번호 를 입력해줍니다.
                if (client.Connected)
                {
                    
                }
                else
                {
                    client.Connect("localhost", 7000);
                }

                // 기본 데이터 세팅 값 설정하는 메소드
                defaultSetting();

                //client.Close();
            }
            catch (SocketException ex)
            {
                MessageBox.Show("서버 접속 실패: " + ex.Message);
                ReconnectToServer();
            }
        }

        // 서버와의 접속 실패시 재접속 시도
        private void ReconnectToServer()
        {
            try
            {
                MessageBox.Show("재접속을 시도합니다...");
                client.Connect("localhost", 7000);

                defaultSetting();
            }
            catch (SocketException ex)
            {
                MessageBox.Show("재연결 오류: " + ex.Message);
                Application.ExitThread();
                Environment.Exit(0);
            }

        }

        // 서버로부터 받아온 name 데이터값을 리턴해주는 Get Method
        public string getNameValue()
        {
            return nameRec;
        }

        // 기본 데이터 세팅 값 설정하는 메소드
        private void defaultSetting()
        {
            //--------------------------Job, Name 받아오기-----------------------------||
            // 인물 이름 받아오는 쿼리문
            string basicDataSqlMsg = "select name, category from people_id";

            // "Client Connecting" stream으로 보내기 위해 byte[]형으로 바꿔줍니다.
            byte[] buf = Encoding.UTF8.GetBytes(basicDataSqlMsg);
            outBuff = new byte[100000];
            // 서버에서 Read하는 방식과 비슷한 형식으로 Write 시켜줍니다.
            client.GetStream().Write(buf, 0, buf.Length);

            // 서버에서 송신한 데이터를 바이트형식으로 수신받음
            int bytes = client.GetStream().Read(outBuff, 0, outBuff.Length);
            nameRec = Encoding.UTF8.GetString(outBuff, 0, bytes);
            //--------------------------Job, Name 받아오기-----------------------------||

        }

        public string contValueSetting(string name)
        {
            //--------------------------Story 받아오기-----------------------------||
            // 인물 이름 받아오는 쿼리문
            string basicDataSqlMsg = "select story from people_table where name_fk='" + name + "'";
            // "Client Connecting" stream으로 보내기 위해 byte[]형으로 바꿔줍니다.
            byte[] buf = Encoding.UTF8.GetBytes(basicDataSqlMsg);
            outBuff = new byte[100000];
            // 서버에서 Read하는 방식과 비슷한 형식으로 Write 시켜줍니다.
            client.GetStream().Write(buf, 0, buf.Length);
            // 서버에서 송신한 데이터를 바이트형식으로 수신받음
            int bytes = client.GetStream().Read(outBuff, 0, outBuff.Length);
            contRec = Encoding.UTF8.GetString(outBuff, 0, bytes);
            //--------------------------Story 받아오기-----------------------------||
            return contRec;
        }

        public void clientShutdown()
        {
            //--------------------------클라이언트 종료 명령어 받아오기-----------------------------||
            // 인물 이름 받아오는 쿼리문
            string basicDataSqlMsg = "EXIT";
            // "Client Connecting" stream으로 보내기 위해 byte[]형으로 바꿔줍니다.
            byte[] buf = Encoding.UTF8.GetBytes(basicDataSqlMsg);
            outBuff = new byte[100000];
            // 서버에서 Read하는 방식과 비슷한 형식으로 Write 시켜줍니다.
            client.GetStream().Write(buf, 0, buf.Length);
            //--------------------------클라이언트 종료 명령어 받아오기-----------------------------||
        }
    }
}
