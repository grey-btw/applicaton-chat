using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Win32.SafeHandles;
using Microsoft.VisualBasic.Devices;
using System.IO;
using System.IO.Compression;

namespace Application_Chat
{
    public partial class ChatForm : Form
    {

        public List<existRoom> listExistRoom = new List<existRoom>();
        public List<Client.ModelObject.Room> listRoomFromTop;

        public int round = 1;
        public ChatForm()
        {
            InitializeComponent();
            panelMain.Controls.Add(subpanel);
            Control.CheckForIllegalCrossThreadCalls = false;
            Thread rcvMessageCurrentRoom = new Thread(RcvMessage);
            rcvMessageCurrentRoom.Start();
        }
        
        existRoom currentRoom = null;

        public class existRoom
        {
            private string IDRoom;
            private string nameRoom;
            private bool status;
            public Panel myPanel;
            public Room myRoom;
            public Client.ModelObject.User[] Members;

            public existRoom(string idroom, string roomName, bool statusRoom, Panel box, Client.ModelObject.User[] listUser)
            {
                IDRoom = idroom;
                nameRoom = roomName;
                status = statusRoom;
                myPanel = box;
                Members = listUser;
            }

            public string IDROOM
            {
                get
                {
                    return IDRoom;
                }
                set
                {
                    IDRoom = value;
                }
            }
            public string NAMEROOM
            {
                get
                {
                    return nameRoom;
                }
                set
                {
                    nameRoom = value;
                }
            }
            public bool STATUS
            {
                get
                {
                    return status;
                }
                set
                {
                    status = value;
                }
            }
            public Client.ModelObject.User[] MEMBERS
            {
                get
                {
                    return Members;
                }
                set
                {
                    Members = value;
                }
            }
        }
        
        private const int  
               RecvCreate = 3,  
               RecvJoin = 4,    
               Leave = 10;

        private void RcvMessage()
        {
            List<Client.ModelObject> data = new List<Client.ModelObject>();
            
            while (!register.socket._exitEvent.WaitOne(0))
            {
                Thread.Sleep(50);
                if (currentRoom == null) continue;

                data = register.socket.GetMessage(currentRoom.IDROOM);
                for (int i = 0; i < data.Count; i += 1)
                {
                    ShowReceivedMessage(data[i].message.type, data[i].message.author, data[i].message.data);
                }
            }

            Console.WriteLine("Receiv in client shutdown");
        }

        public void RecvData(int flag, string commandId)
        {
            Client.ModelObject data = new Client.ModelObject();
            int p = 0;
            while (p < 5000)
            {
                data = register.socket.GetCommandResult(commandId);
                if ((data != null))
                {
                    switch (flag)
                    {
                        case RecvCreate:
                            if (data.command.status != "0")
                            {
                                MessageBox.Show("Failed to create!");
                                break;
                            }

                            listExistRoom.Add(new existRoom(data.room.id, data.room.name, false, null, data.room.members));
                            MessageBox.Show("Create successfully!");
                            JoinRoom();
                            break;
                        case RecvJoin:

                            if (data.command.status != "0")
                            {
                                MessageBox.Show("Failed to create!");
                                break;
                            }

                            listExistRoom.Add(new existRoom(data.room.id, data.room.name, false, null, data.room.members));
                            MessageBox.Show("Join successfully");
                            JoinRoom();

                            break;
                        case Leave:
                            if (data.command.status != "0")
                            {
                                MessageBox.Show("Failed to leave, please try again!");
                                break;
                            }
                            listExistRoom.RemoveAll(item => item.IDROOM.Equals(currentRoom.IDROOM));
                            
                            break;
                    }
                    return;
                }
                p += 50;
                Thread.Sleep(50);
            }
            MessageBox.Show("Timeout!");
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (subSetting.Visible)
            {
                subSetting.Hide();
            }
            else
            {
                subSetting.Show();
                subSetting.BringToFront();

            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (btnJoin.Text == "Join")
            {
                btnJoin.Text = "Create";
            }
            else
            {
                btnJoin.Text = "Join";
            }
        }

        private void btnCreateJoinRoom_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textJoin.Text) && !String.IsNullOrWhiteSpace(textJoin.Text))
            {

                if (btnJoin.Text == "Create")
                {
                    int id = Program.RandomNumber(0, 2 ^ 32);

                    Client.ModelObject Send = new Client.ModelObject();
                    Send.command.code = "3";
                    Send.command.id = $"{id}";
                    Send.room.name = textJoin.Text;
                   

                    register.socket.Send(Send);

                    if(subSetting.Visible == true)
                    {
                        subSetting.Visible = false;
                    }
                    textJoin.Text = "";
                    RecvData(3, Send.command.id);
                }
                else
                {
                    for (int i = 0; i < listExistRoom.Count; i++)
                    {
                        if (listExistRoom[i].IDROOM == textJoin.Text)
                        {
                            MessageBox.Show("Room has been joined!");
                            return;
                        }
                    }
                    int id = Program.RandomNumber(0, 2 ^ 32);

                    Client.ModelObject Send = new Client.ModelObject();

                    Send.command.code = "4";
                    Send.command.id = $"{id}";
                    Send.room.id = textJoin.Text;

                    register.socket.Send(Send);

                    if (subSetting.Visible == true)
                    {
                        subSetting.Visible = false;
                    }
                    textJoin.Text = "";

                    RecvData(4, Send.command.id);
                }
            }
        }

        private void sendMessage(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textboxMessage.Text))
            {
                MyBubble bubble = new MyBubble(1);
                bubble.Dock = DockStyle.Bottom;
                bubble.SendToBack();
                bubble.Body = textboxMessage.Text;
                currentRoom.myPanel.Controls.Add(bubble);
                int id = Program.RandomNumber(0, 2 ^ 32);

                Client.ModelObject Send = new Client.ModelObject();
                Send.command.code = "5";
                Send.command.id = $"{id}";
                Send.message.type = "1";
                Send.message.data = textboxMessage.Text;
                Send.room.id = currentRoom.IDROOM;
                

                register.socket.Send(Send);
                textboxMessage.Text = "";
            }
        }

        private void ShowReceivedMessage(string type, string username, string content)
        {
            int typeInt = Int32.Parse(type);
            YourBubble bubble = new YourBubble(typeInt);
            bubble.Dock = DockStyle.Bottom;
            bubble.SendToBack();

            if (typeInt == 0)
            {
                Image x = Base64ToImage(content);
                bubble.Body = username;
                bubble.ImageOfMessage = x;
            }
            else if (typeInt == 1)
            {
                bubble.Body = username + ": " + content;
            }
            else if(typeInt == 2)
            {
                int index = content.IndexOf("[;]");
                string message = content.Substring(0, index);
                string data = content.Substring(index + 3);
                
                bubble.Body = username + ": " + message;
                string fileName = message.Substring(7);
                string path = Path.GetDirectoryName(Application.ExecutablePath) + @"\data\" + fileName;
                Byte[] bytes = Convert.FromBase64String(data);
                File.WriteAllBytes(path, bytes);
            }


            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate()
                {
                    currentRoom.myPanel.Controls.Add(bubble);
                    currentRoom.myPanel.VerticalScroll.Value = subpanel.VerticalScroll.Maximum;
                });
            }
            else
            {
                currentRoom.myPanel.Controls.Add(bubble);
                currentRoom.myPanel.VerticalScroll.Value = subpanel.VerticalScroll.Maximum;
            }
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            
            int id = Program.RandomNumber(0, 2 ^ 32);

            Client.ModelObject Send = new Client.ModelObject();
            Send.command.code = "10";
            Send.command.id = id.ToString();
            Send.room.id = currentRoom.IDROOM;
            register.socket.Send(Send);

            btnSetting_Click(sender, e);

            foreach(Client.ModelObject.Room x in listRoomFromTop)
            {
                if (x.id == currentRoom.IDROOM)
                {
                    listRoomFromTop.Remove(x);
                    break;
                }
            }

            RecvData(10, Send.command.id);
            
            currentRoom.myPanel.Dispose();
            currentRoom.myRoom.Dispose();
            currentRoom = null; 
            if (listExistRoom.Count != 0) {
                currentRoom = listExistRoom[0];
                ShowChatPanel(currentRoom.myPanel, currentRoom.myRoom);
            }
            else
            {
                nameRoomHeader.Text = "Welcome";
                roomIdHeader.Text = "000000";
            }
        } 

        

        public void JoinRoom()
        {
            for (int i = 0; i < listExistRoom.Count; i++)
            {
                if (!listExistRoom[i].STATUS)
                {
                    Room croom = new Room();
                    panelSidebar.Controls.Add(croom);
                    croom.Dock = DockStyle.Top;
                    croom.lastestMessage = "";
                    croom.nameRoom = listExistRoom[i].NAMEROOM;
                    croom.IDROOM = listExistRoom[i].IDROOM;
                    listExistRoom[i].STATUS = true;
                    listExistRoom[i].myRoom = croom;

                    Panel newPanel = new Panel();
                    newPanel.BackColor = Color.White;
                    subpanel.Controls.Add(newPanel);

                    panelMain.AutoScroll = false;
                    panelMain.VerticalScroll.Enabled = true;
                    panelMain.VerticalScroll.Visible = true;
                    panelMain.AutoScroll = true;
                    newPanel.Dock = DockStyle.Fill;
                    newPanel.AutoScroll = true;
                    newPanel.AutoSize = true;


                    listExistRoom[i].myPanel = newPanel;
                    croom.OnClick += ShowBlockChat;
                    currentRoom = listExistRoom[i];
                    ShowChatPanel(listExistRoom[i].myPanel, listExistRoom[i].myRoom);
                    AddToCurrentRoom(listExistRoom[i].IDROOM, listExistRoom[i].NAMEROOM, listExistRoom[i].MEMBERS);
                }
            }
            
        }


        private void ShowChatPanel(Panel panel, Room room)
        {
            panel.BringToFront();
            panel.Show();
            pictureBoxHeader.FillColor = room.ColorAvatar;
            nameRoomHeader.Text = room.nameRoom;
            roomIdHeader.Text = room.IDROOM;
        }


        public void ShowBlockChat(object sender, EventArgs e)
        {
            var roomClicked = (Room)sender;
            if (currentRoom != null)
            {
                nameRoomHeader.Text = roomClicked.nameRoom;
                pictureBoxHeader.FillColor = roomClicked.ColorAvatar;
                roomIdHeader.Text = roomClicked.IDROOM;

                for (int i = 0; i < listExistRoom.Count; i++)
                {
                    if (roomClicked.IDROOM == listExistRoom[i].IDROOM)
                    {
                        listExistRoom[i].myPanel.Show();
                        currentRoom = listExistRoom[i];
                    }
                    else
                    {
                        listExistRoom[i].myPanel.Hide();
                    }
                }

            }
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.Filter = "Image Files(*.jpg, *png)|*jpg;*png|Txt files(*.txt)|*.txt|Pdf files(*.pdf)|*pdf|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 4;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(openFileDialog.FileName);
                    long fileSize = fi.Length;
                    if(fileSize > 10 * 1024 * 1024)
                    {
                        MessageBox.Show("The size is over limited size.");
                        return;
                    }
                    filePath = openFileDialog.FileName;
                    string[] partsFileName = filePath.Split('.');
                    
                    if (partsFileName[partsFileName.Length - 1] == "jpg" || partsFileName[partsFileName.Length - 1] == "png")
                    {
                        byte[] bytesFromImage = ImageToByteArray(Image.FromFile(filePath));
                        string base64OfImgae = Convert.ToBase64String(bytesFromImage);
                        Image x = Base64ToImage(base64OfImgae);
                        Upload ul = new Upload(x);
                        

                        Form form1 = new Form();
                        form1.BackColor = System.Drawing.Color.Black;
                        form1.Opacity = (double)0.5;
                        form1.FormBorderStyle = FormBorderStyle.None;
                        form1.Height = ActiveForm.Height;
                        form1.Width = ActiveForm.Width;
                        form1.FormBorderStyle = FormBorderStyle.None;
                        

                        form1.ShowIcon = false;
                        form1.ShowInTaskbar = false; 

                        form1.BringToFront();
                        form1.Show();

                        ul.BringToFront();
                        ul.ShowDialog();
                        form1.Dispose();
                        
                        if(ul.flag)
                        {
                            MyBubble bubble = new MyBubble(0);
                            bubble.Dock = DockStyle.Bottom;
                            bubble.SendToBack();
                            bubble.ImageOfMessage = x;
                            currentRoom.myPanel.Controls.Add(bubble);
                            int id = Program.RandomNumber(0, 2 ^ 32);

                            Client.ModelObject Send = new Client.ModelObject();
                            Send.command.code = "5";
                            Send.command.id = $"{id}";
                            Send.message.type = "0";
                            Send.room.id = currentRoom.IDROOM;
                            Send.message.data = base64OfImgae;
                            register.socket.Send(Send);


                        }
                    }
                    else
                    {
                        byte[] bytesFromFile = File.ReadAllBytes(filePath);
                        string base64OfFile = Convert.ToBase64String(bytesFromFile);

                        MyBubble bubble = new MyBubble(2);
                        bubble.Dock = DockStyle.Bottom;
                        bubble.SendToBack();

                        bubble.ChatTextCursor = Cursors.Hand;
                        bubble.Body = $"Đã gửi {filePath.Split('\\')[filePath.Split('\\').Length - 1]}";

                        currentRoom.myPanel.Controls.Add(bubble);

                        string body = $"{bubble.Body}[;]{base64OfFile}";
                        int id = Program.RandomNumber(0, 2 ^ 32);
                        Client.ModelObject Send = new Client.ModelObject();
                        Send.command.code = "5";
                        Send.command.id = $"{id}";
                        Send.message.type = "2";
                        Send.room.id = currentRoom.IDROOM;
                        Send.message.data = body;
                        register.socket.Send(Send);

                    }

                }
            }
        }

        Image Base64ToImage(string base64)
        {
            byte[] imageBytes = Convert.FromBase64String(base64);
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }

        private void textboxMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendMessage(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnAddFile_MouseHover(object sender, EventArgs e)
        {
            labelDescriptionAddFile.Visible = true;
        }

        private void btnAddFile_MouseLeave(object sender, EventArgs e)
        {
            labelDescriptionAddFile.Visible = false;
        }

        private void textJoin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCreateJoinRoom_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnSend_MouseHover(object sender, EventArgs e)
        {
            labelDescriptionSend.Visible = true;
        }

        private void btnSend_MouseLeave(object sender, EventArgs e)
        {
            labelDescriptionSend.Visible = false;
        }

        public void AddRoom(List<Client.ModelObject.Room> listRoom)
        {
            listRoomFromTop = listRoom;
            for (int i = 0; i < listRoom.Count; i += 1)
            {
                existRoom x = new existRoom(listRoomFromTop[i].id, listRoomFromTop[i].name, false, null, listRoomFromTop[i].members);
                if (!listExistRoom.Contains(x))
                    listExistRoom.Add(x);
                
            }
        }

        private void textJoin_Click(object sender, EventArgs e)
        {
            if (subSetting.Visible == true)
                subSetting.Visible = false;
        }

        private void AddToCurrentRoom(string id, string name, Client.ModelObject.User[] listUser)
        {
            Client.ModelObject.Room x = new Client.ModelObject.Room();
            x.id = id;
            x.name = name;
            x.members = listUser;

            if (listRoomFromTop.Contains(x))
                return;
            listRoomFromTop.Add(x);
        }

        private void ZipFileFromLocal(string startPath)
        {
            Thread thread = new Thread(t =>
            {
                
                FileInfo fi = new FileInfo(startPath);
                string zipPath = fi.Name.Split('.')[0] + ".zip";
                zipPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\data\" + $"{zipPath}";
                ZipFile.Open(startPath, System.IO.Compression.ZipArchiveMode.Create);
                    
            })
            { IsBackground = true };
            thread.Start();
        }
    }
}
