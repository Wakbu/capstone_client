using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class serverConnect
    {
    }

    class ConnSocket
    {
        public ConnSocket() {

            try
            {
                //DNS (Domain Name System) -> www.xxxxx.com -> IP
                string dns = "capproject.kro.kr";
                IPAddress ipAddr = Dns.GetHostAddresses(dns)[0];

                TcpClient client = new TcpClient();

                // 첫번째 매개변수는 접속할 IP
                // 서버가 내 PC에서 돌아가므로 127.0.0.1(자기자신을 나타내는 루프백IP)
                // 두번째 매개변수는 서버에서 설정한 포트번호 를 입력해줍니다.
                client.Connect(ipAddr, 7000);

                // "Client Connecting" stream으로 보내기 위해 byte[]형으로 바꿔줍니다.
                byte[] buf = Encoding.Default.GetBytes("Client Connecting");

                // 서버에서 Read하는 방식과 비슷한 형식으로 Write 시켜줍니다.
                client.GetStream().Write(buf, 0, buf.Length);

                client.Close();
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
