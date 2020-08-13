using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace chat_client
{
	class HandleClient
	{
		public const int bytelen = 1024 * 5000;

		public HandleClient()
		{
		}

		
		public void sendData(string msg)
		{
			NetworkStream ns = new NetworkStream(Program.con.clientSocket);
			byte[] u = new byte[bytelen];
			u = Serialize(msg);
			ns.Write(u, 0, u.Length);
			ns.Flush();
			ns.Close();
		}

		public byte[] Serialize(object obj)
		{
			//khởi tạo stream để lưu các byte phân mảnh
			MemoryStream stream = new MemoryStream();
			//khởi tạo đối tượng BinaryFormatter để phân mảnh dữ liệu sang kiểu byte
			BinaryFormatter formatter = new BinaryFormatter();
			//phân mảnh rồi ghi vào stream
			formatter.Serialize(stream, obj);
			//từ stream chuyển các các byte thành dãy rồi cbi gửi đi
			return stream.ToArray();
		}

		//Hàm gom mảnh các byte nhận được rồi chuyển sang kiểu string
		public object Deseriliaze(byte[] data)
		{
			//khởi tạo stream đọc kết quả của quá trình phân mảnh 
			MemoryStream stream = new MemoryStream(data);
			//khởi tạo đối tượng chuyển đổi
			BinaryFormatter formatter = new BinaryFormatter();
			//chuyển đổi dữ liệu và lưu lại kết quả 
			return (string)formatter.Deserialize(stream);
		}
	}
}
