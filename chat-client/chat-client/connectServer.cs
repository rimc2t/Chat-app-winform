using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace chat_client
{
	class ConnectServer
	{
		//Tạo socket
		public Socket clientSocket = null;
		//Tạo endpoint
		public IPEndPoint ep = null;

		public ConnectServer()
		{
			//End point sẽ có IP 127.0.0.1 và PORT 1302
			ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1302);
			clientSocket = new Socket(
				AddressFamily.InterNetwork,
				SocketType.Stream,
				ProtocolType.Tcp);
			try
			{
				clientSocket.Connect(ep);
			}
			catch
			{
				MessageBox.Show("Cannot connect to server");
			}
		}
	}
}
