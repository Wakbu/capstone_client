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

namespace capstone_Server
{
    internal class serverCreate
    {

    }

    class createSocket
    {
        private Socket mainsock;
        List<Socket> connectedClients = new List<Socket>();

        private int size = 1024;
        private byte[] data = new byte[1024];

        public createSocket()
        {
            try
            {
                //소켓을 생성한다
                mainsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //목적지를 정해준다
                IPEndPoint serverEP = new IPEndPoint(IPAddress.Any, 7000);
                //목적지와 묶어준다
                mainsock.Bind(serverEP);
                //받아들이기 시작한다 (최대 10개의 Client까지)
                mainsock.Listen(10);
                //연결시도가 감지되면 AcceptCallBack으로 이동하게 설정
                mainsock.BeginAccept(AcceptCallBack, null);
            }
            catch (Exception e)
            {
            }

            void AcceptCallBack(IAsyncResult ar)
            {
                Socket client = mainsock.EndAccept(ar);

            }
        }


    }
}
