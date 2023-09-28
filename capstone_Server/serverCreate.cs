using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;
using System.IO;
using Oracle.ManagedDataAccess;

namespace capstone_Server
{
    internal class serverCreate
    {

    }

    class createServer
    {
        const int size = 1024;
        TcpListener listener;

        public createServer()
        {
            AsyncEchoServer();
        }

        async public Task AsyncEchoServer()
        {
            try
            {

                string dns = "capproject.kro.kr";
                IPAddress bnetServerIP = Dns.GetHostAddresses(dns)[0];

                //TCP Server를 생성한다
                listener = new TcpListener(bnetServerIP, 7000);
                listener.Start();
                serverMainForm.serverMain.logTBox.AppendText("클라이언트 Accept Listener 실행중...\r\n");

                // 서버 시작 버튼 비활성화, 서버 종료 버튼 활성화
                serverMainForm.serverMain.serverStartBtn.Enabled = false;
                serverMainForm.serverMain.serverStopBtn.Enabled = true;

                while (true) {

                    // 클라이언트 비동기 Accept(클라이언트 수신)
                    TcpClient clientSock = await listener.AcceptTcpClientAsync().ConfigureAwait(false);

                    // 새 쓰레드에서 처리
                    Task.Factory.StartNew(AsyncTcpProcess, clientSock);
                }
            }
            catch (SocketException e)
            {
                serverMainForm.serverMain.logTBox.AppendText(e.ToString() + "\r\n");
            }
        }

        TcpClient tc;
        NetworkStream stream;

        async public void AsyncTcpProcess(object o)
        {
            tc = (TcpClient)o;

            stream = tc.GetStream();

            // 비동기 수신
            var buff = new byte[size];
            var nbytes = await stream.ReadAsync(buff, 0, buff.Length).ConfigureAwait(false);

            if(nbytes > 0)
            {
                string msg = Encoding.ASCII.GetString(buff, 0, nbytes);
                serverMainForm.serverMain.logTBox.AppendText(msg+ "\r\n");

                // 비동기 송신
                await stream.WriteAsync(buff, 0, nbytes).ConfigureAwait(false);
            }
        }

        public void serverStop()
        {
            listener.Stop();
            serverMainForm.serverMain.logTBox.AppendText("통신 종료\r\n");

            // 서버 시작 버튼 재활성화, 서버 종료 버튼 비활성화
            serverMainForm.serverMain.serverStartBtn.Enabled = true;
            serverMainForm.serverMain.serverStopBtn.Enabled = false;
        }
    }

}
