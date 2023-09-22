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
                // 소켓 객체 생성(TCP 프로토콜 사용)
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // 서버에 연결
                var ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 7000);
                socket.Connect(ep);
            }catch (SocketException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
