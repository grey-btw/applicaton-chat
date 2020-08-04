using Jil;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Application_Chat {
    public class Client {
        private TcpClient _tcpClient;
        private SslStream _encryptedStream; 
        private Thread _threadReceive;
        private Thread _threadSend;
        public ManualResetEvent _exitEvent; 
        private Timer keepalive; 

        private Dictionary<string, ModelObject> _commandResults = new Dictionary<string, ModelObject>();   
        private Dictionary<string, List<ModelObject>> _receivedMessages = new Dictionary<string, List<ModelObject>>(); 
        private static Mutex rcvMutex = new Mutex();

        private ConcurrentQueue<string> _sendQueue = new ConcurrentQueue<string>();

        public class ModelObject {
            public struct Command {
                public string code;
                public string id;
                public string status;
            }
            public struct User {
                public string name;
                public string alias;
                public string pass;
                public string ava;
                public string email;
            }
            public struct Room {
                public string id;
                public string name;
                public string type;
                public User[] members;
            }
            public struct Message {
                public string data;
                public string type;
                public string author;
                public string date;
                public Room[] existroom;
            }
            public Command command;
            public User user;
            public Room room;
            public Message message;

        }

        private struct _flag {
            public const int
                Login = 1,      
                Register = 2,   
                CreateRoom = 3, 
                JoinRoom = 4,    
                SendMessage = 5,
                               
                GetAllUsers = 7,
                                
                Logout = 9,    
                LeaveRoom = 10;  
        }
        
        public Client() {
            _tcpClient = new TcpClient();
            _tcpClient.Connect("52.163.205.117", 8080);
            Console.WriteLine("[+] TCP connected");
            _encryptedStream = new SslStream(
                _tcpClient.GetStream(),
                false,
                (sender, cert, chain, err) => true 
            );
            _encryptedStream.AuthenticateAsClient("fukkkkkkkkkkkkkkkkkkk");
            Console.WriteLine("[+] TLS negotiated.");

            _exitEvent = new ManualResetEvent(false);

            _threadReceive = new Thread(ReceiveLoop) { IsBackground = true };
            _threadSend = new Thread(SendLoop) { IsBackground = true };
            _threadReceive.Start();
            _threadSend.Start();
            keepalive = new Timer(
                (Object state) => {
                    _sendQueue.Enqueue("{}");
                    Console.WriteLine("[+] Keep-alive sent.");
                },
                null,
                10000,
                10000
            );
        }

        public void closeProgram() {
            keepalive.Dispose();
            _exitEvent.Set();
        }

        public List<string> getAllUser(ModelObject.User[] Members) {
            List<string> result = new List<string>();
            if (Members == null) {
                return result;
            }
            for (int i = 0; i < Members.Length; i++)
                result.Add(Members[i].name);
            return result;
        }

        public void _taskSend(ModelObject sendObj) {
            string jsonStr = JSON.Serialize(sendObj); 
            Console.WriteLine(jsonStr);
            _sendQueue.Enqueue(jsonStr);
        }

        public void Send(ModelObject aFuckingBigAssObject) {
            Task.Run(() => _taskSend(aFuckingBigAssObject));
        }

        private void SendLoop() {
            string str;
            byte[] raw_data;
            while (!_exitEvent.WaitOne(0)) {
                if (!_sendQueue.IsEmpty) {
                    if (_sendQueue.TryDequeue(out str)) {
                        str += "<EOF>";
                        raw_data = Encoding.UTF8.GetBytes(str);
                        Console.WriteLine(raw_data);
                        _encryptedStream.Write(raw_data, 0, raw_data.Length);
                    }
                }
                else {
                   
                }
            }
            Console.WriteLine("[Client.cs] Send thread shutdown.");
        }

        public List<ModelObject> GetMessage(string roomID) {
            rcvMutex.WaitOne();
            List<ModelObject> msg = new List<ModelObject>();

            if (_receivedMessages.ContainsKey(roomID) == true && _receivedMessages[roomID].Count > 0) {
                msg = _receivedMessages[roomID].ToList();
                _receivedMessages[roomID].Clear();
            }
            rcvMutex.ReleaseMutex();
            return msg;
        }

        public ModelObject GetCommandResult(string CommandID) {
            rcvMutex.WaitOne();
            ModelObject res = new ModelObject();
            if (_commandResults.ContainsKey(CommandID) == true) {
                res = _commandResults[CommandID];
                _commandResults.Remove(CommandID);
            }
            else {
                rcvMutex.ReleaseMutex();
                return null;
            }

            rcvMutex.ReleaseMutex();
            return res;
        }

        private void ReceiveLoop() {
            byte[] buffer = new byte[2048];
            StringBuilder messageData = new StringBuilder();
            Decoder decoder = Encoding.UTF8.GetDecoder();
            int bytes;
            while (!_exitEvent.WaitOne(0)) {
                do {                    
                    bytes = _encryptedStream.Read(buffer, 0, buffer.Length);
                    char[] chars = new char[decoder.GetCharCount(buffer, 0, bytes)];
                    decoder.GetChars(buffer, 0, bytes, chars, 0);
                    messageData.Append(chars);
                    if (messageData.ToString().IndexOf("<EOF>") != -1) {
                        break;
                    }
                } while (bytes != 0);
                string response = messageData.ToString();  
                messageData.Clear();

                if(response != "")
                {

                    response = response.Remove(response.Length - 5);
                    Console.WriteLine(response);
                    ModelObject recvObj = JSON.Deserialize<ModelObject>(response);
                    {
                        rcvMutex.WaitOne();

                        if (recvObj.command.code == "6")
                        {  
                            string roomID = recvObj.room.id;
                            if (!_receivedMessages.ContainsKey(roomID))
                            {
                                _receivedMessages[roomID] = new List<ModelObject>();
                            }
                            _receivedMessages[roomID].Add(recvObj);
                        }
                        else
                        {
                            
                            Console.WriteLine("This is cmdID return:" + recvObj.command.id);
                            _commandResults[recvObj.command.id] = recvObj;
                        }
                        rcvMutex.ReleaseMutex();
                    }
                }
            }
            Console.WriteLine("[Client.cs] Receive thread shutdown.");
        }
    }
}
