using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;

namespace capstone_Server
{
    internal class serverCreate
    {

    }

    class createSocket
    {
        public createSocket()
        {
            try
            {
                // TcpListener 생성자에 붙는 매개변수는 
                // 첫번째는 IP를 두번째는 port 번호입니다.
                TcpListener server = new TcpListener(IPAddress.Any, 7000);

                // 서버를 시작합니다.
                server.Start();

                // 클라이언트 객체를 만들어 7000에 연결한 client를 받아옵니다
                // 클라이언트가 접속할때까지 서버는 해당구문에서 블락됩니다.
                TcpClient client = server.AcceptTcpClient();

                // NetworkStream 객체를 만들어 client에서 보낸 데이터를 받을 객체를 생성합니다.
                NetworkStream ns = client.GetStream();

                // Socket은 byte[] 형식으로 데이터를 주고받으므로 byte[]형 변수를 선언합니다.
                byte[] byteData = new byte[1024];

                // 클라이언트가 write한 데이터를 읽어옵니다.
                // 아래의 작업 이후에 byteData에는 읽어온 데이터가 들어갑니다.
                // 동기서버의 경우 해당코드에서 읽을데이터가 올때까지 대기합니다.
                ns.Read(byteData, 0, byteData.Length);


                // 출력을 위해 byteData를 string형으로 바꿔줍니다.
                string stringData = Encoding.Default.GetString(byteData);

                MessageBox.Show(stringData);

                server.Stop();
                ns.Close();


            } catch(SocketException ex) { 
                MessageBox.Show(ex.Message);
            }
        }
    }

}
