using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TROCHOIDOMIN.Sources 
{
   
    public class LAN 
    {
        Socket client;
        public bool ConnectServer()
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(IP), Port);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try {
                client.Connect(iep);
                return true;
            } 
            catch 
            {
                return false;
            }
        }
        Socket server;
        public void CreateServer()
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(IP), Port);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(iep);
            server.Listen(10);
            Thread acceptClient = new Thread(() =>
            {
                client = server.Accept();
            });
            acceptClient.IsBackground = true;
            acceptClient.Start();
        }
        public string IP = "127.0.0.1";
        public bool isServer = true;
        public int Port = 2306;
        public const int Buffer = 2048; 
        public bool Sent(object data)
        {
            byte[] sentdata = SerializeData(data);
                return sentData(client, sentdata);
        }
        public object receive()
        {
            byte[] receivedata = new byte[Buffer];
            bool isOK = receiveData(client, receivedata);
            return DeserializeData(receivedata);
        }
        private bool sentData(Socket target, byte[] data)
        {
            return target.Send(data) == 1 ? true : false;
        }
        public bool receiveData(Socket target, byte[] data)
        {
            return target.Receive(data) == 1 ? true : false;
        }
        /// <summary>
        /// Nén đối tượng thành mảng byte[]
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public byte[] SerializeData(Object o)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, o);
            return ms.ToArray();
        }
        /// <summary>
        /// Giải nén mảng byte[] thành đối tượng object
        /// </summary>
        /// <param name="theByteArray"></param>
        /// <returns></returns>
        public object DeserializeData(byte[] theByteArray)
        {
            MemoryStream ms = new MemoryStream(theByteArray);
            BinaryFormatter bf1 = new BinaryFormatter();
            ms.Position = 0;
            return bf1.Deserialize(ms);
        }
        /// <summary>
        /// Lấy IP v4 của card mạng đang dùng
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public string GetLocalIPv4(NetworkInterfaceType type)
        {
            string output = "";
            foreach(NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if(item.NetworkInterfaceType == type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if(ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            output = ip.Address.ToString();
                        }
                    }
                }
            }
            return output;
        }
    }
}
