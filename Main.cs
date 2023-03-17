using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;

namespace KeyAuthChatStyle
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        string chatchannel = ""; // chat channel name

        private void Main_Load(object sender, EventArgs e)
        {
            Login.KeyAuthApp.check();
            key.Text = "Username: " + Login.KeyAuthApp.user_data.username;
            subscription.Text = "Role: " + Login.KeyAuthApp.user_data.subscriptions[0].subscription;
            createDate.Text = "Creation date: " + UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.createdate));
            lastLogin.Text = "Last login: " + UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.lastlogin));
            numOnlineUsers.Text = "Number of online users: " + Login.KeyAuthApp.app_data.numOnlineUsers;

            var onlineUsers = Login.KeyAuthApp.fetchOnline();
            onlineUsersBox.Items.Clear();
            foreach (var user in onlineUsers)
            {
                onlineUsersBox.Items.Add(user.credential);
            }
            onlineUsersBox.SelectedIndex = 0;
        }

        public static bool SubExist(string name, int len)
        {
            for (var i = 0; i < len; i++)
            {
                if (Login.KeyAuthApp.user_data.subscriptions[i].subscription == name)
                {
                    return true;
                }
            }
            return false;
        }

        public DateTime UnixTimeToDateTime(long unixtime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            try
            {
                dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            }
            catch
            {
                dtDateTime = DateTime.MaxValue;
            }
            return dtDateTime;
        }

        private void sendmsg_Click(object sender, EventArgs e)
        {
            if (Login.KeyAuthApp.chatsend(chatmsg.Text, chatchannel))
            {
                dataGridView1.Rows.Insert(0, Login.KeyAuthApp.user_data.username, chatmsg.Text, UnixTimeToDateTime(DateTimeOffset.Now.ToUnixTimeSeconds()));
            }
            else
                chatmsg.Text = "Status: " + Login.KeyAuthApp.response.message;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            timer1.Interval = 1000; // get chat messages every 15 seconds
            if (!String.IsNullOrEmpty(chatchannel))
            {
                var messages = Login.KeyAuthApp.chatget(chatchannel);
                if (messages == null)
                {
                    dataGridView1.Rows.Insert(0, "KeyAuth", "No Chat Messages", UnixTimeToDateTime(DateTimeOffset.Now.ToUnixTimeSeconds()));
                }
                else
                {
                    foreach (var message in messages)
                    {
                        dataGridView1.Rows.Insert(0, message.author, message.message, UnixTimeToDateTime(long.Parse(message.timestamp)));
                    }
                }
            }
            else
            {
                dataGridView1.Rows.Insert(0, "KeyAuth", "No Chat Messages", UnixTimeToDateTime(DateTimeOffset.Now.ToUnixTimeSeconds()));
            }
        }

        private void subscription_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chatmsg_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            guna2Button1.Checked = false;
            guna2Button4.Checked = true;
            siticonePanel1.Show();
            guna2Panel1.Hide();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Button1.Checked = true;
            guna2Button4.Checked = false;
            siticonePanel1.Hide();
            guna2Panel1.Show();
        }
    }
}
