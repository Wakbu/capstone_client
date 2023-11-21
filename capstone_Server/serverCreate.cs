using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Analysis;
using Microsoft.ML.Data;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Ocsp;

namespace capstone_Server
{
    internal class serverCreate
    {

    }

    class createServer
    {
        const int size = 100000;
        TcpListener listener;
        TcpClient tc;
        NetworkStream stream;
        DBConnection conn;

        Dictionary<int, string> userInfo = new Dictionary<int, string>();
        int userCount = 0;
        int userFindIndex = 0;

        DataFrame defaultSqlValue_df = null;
        string defaultSqlValue_str = null;

        public createServer()
        {
            AsyncEchoServer();
        }

        async public Task AsyncEchoServer()
        {
            try
            {
                // 도메인 서버 접속용 아이피 할당 변수
                //string dns = "capproject.kro.kr";
                //IPAddress bnetServerIP = Dns.GetHostAddresses(dns)[0];

                //TCP Server를 생성한다
                listener = new TcpListener(IPAddress.Any, 7000);
                listener.Start();
                serverMainForm.serverMain.logTBox.AppendText("클라이언트 Accept Listener 실행중...\r\n");

                // 서버 시작 버튼 비활성화, 서버 종료 버튼 활성화
                serverMainForm.serverMain.serverStartBtn.Enabled = false;
                serverMainForm.serverMain.serverStopBtn.Enabled = true;
                serverMainForm.serverMain.UserListButton.Enabled = true;

                while (true)
                {

                    // 클라이언트 비동기 Accept(클라이언트 수신)
                    TcpClient clientSock = await listener.AcceptTcpClientAsync().ConfigureAwait(false);

                    // 새 쓰레드에서 처리
                    Task.Factory.StartNew(AsyncTcpProcess, clientSock);
                    serverMainForm.serverMain.logTBox.AppendText(clientSock.Client.LocalEndPoint.ToString() + " 유저가 접속했습니다.\r\n");
                }
            }
            catch (SocketException e)
            {
                serverMainForm.serverMain.logTBox.AppendText(e.ToString() + "\r\n");
            }
        }

        async public void AsyncTcpProcess(object o)
        {
            tc = (TcpClient)o;
            

            while (tc.Connected)
            {
                try
                {
                    // 유저정보 저장
                    int dupleUserCount = userInfo.Count;
                    if (dupleUserCount == 0)
                    {
                        userInfo.Add(userCount, tc.Client.LocalEndPoint.ToString());
                        userFindIndex = userCount;
                        userCount++;
                    }
                    else if (userInfo[dupleUserCount - 1] != tc.Client.LocalEndPoint.ToString())
                    {
                        userInfo.Add(userCount, tc.Client.LocalEndPoint.ToString());
                        userFindIndex = userCount;
                        userCount++;
                    }

                    // 통신을 통해 받아올 데이터를 불러오는 stream객체
                    stream = tc.GetStream();

                    var buff = new byte[size];
                    var nbytes = 0;

                    serverMainForm.serverMain.logTBox.AppendText(tc.Client.LocalEndPoint + "데이터 처리중..." + "\r\n");

                    if (nbytes == 0)
                    {
                        nbytes = await stream.ReadAsync(buff, 0, buff.Length).ConfigureAwait(false);

                        // 기본제공데이터 저장 string 변수
                        string sql = Encoding.UTF8.GetString(buff, 0, nbytes);
                        // 기본 DB 데이터 클라이언트에 제공하기위한 DB 컨넥션 객체
                        conn = new DBConnection(sql);

                        byte[] buffer = null;
                        if (sql.Contains("cate"))
                        {
                            defaultSqlValue_df = conn.defaultNameReceive();
                            buffer = Encoding.UTF8.GetBytes(defaultSqlValue_df.ToString());
                        }
                        else if (sql.Contains("story"))
                        {
                            defaultSqlValue_str = conn.defaultStoryReceive();
                            buffer = Encoding.UTF8.GetBytes(defaultSqlValue_str);
                        }

                        conn.closeAction();

                        string msg = Encoding.UTF8.GetString(buff, 0, nbytes);

                        // 비동기 송신
                        await stream.WriteAsync(buffer, 0, buffer.Length).ConfigureAwait(false);
                        serverMainForm.serverMain.logTBox.AppendText(tc.Client.LocalEndPoint + "의 " + msg + " 명령 데이터 처리완료" + "\r\n");

                        defaultSqlValue_df = null;
                        defaultSqlValue_str = null;

                        nbytes = 0;
                        if (sql.Contains("EXIT"))
                        {
                            Cleanup();
                        }
                        
                    }
                    
                    else if(nbytes == 0 && !tc.Connected)
                    {
                        Cleanup();
                    }
                    
                    
                }
                catch (Exception e)
                {                    
                    serverMainForm.serverMain.logTBox.AppendText(e.ToString() + "\r\n");
                }
            }
        }

        public void serverStop()
        {
            listener.Stop();
            
            serverMainForm.serverMain.logTBox.AppendText("통신 종료\r\n");

            // 서버 시작 버튼 재활성화, 서버 종료 버튼 비활성화
            serverMainForm.serverMain.serverStartBtn.Enabled = true;
            serverMainForm.serverMain.serverStopBtn.Enabled = false;
            serverMainForm.serverMain.UserListButton.Enabled = false;
        }

        public void Cleanup()
        {
            userInfo.Remove(userFindIndex);
            stream.Close();
            tc.Close();
        }

        public Dictionary<int, string> UserInfoSend()
        {
            return userInfo;
        }
    }

}
