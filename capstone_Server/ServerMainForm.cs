using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace capstone_Server
{
    public partial class serverMainForm : Form
    {
        public static serverMainForm serverMain;
        createServer serverCreate;

        public serverMainForm()
        {
            InitializeComponent();
            serverMain = this;
        }

        private void serverMainForm_Load(object sender, EventArgs e)
        {

        }

        private void logTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void serverStartBtn_Click(object sender, EventArgs e)
        {
            serverCreate = new createServer();
        }

        private void serverStopBtn_Click(object sender, EventArgs e)
        {
            serverCreate.serverStop();
        }

        private void UserListButton_Click(object sender, EventArgs e)
        {
            UserListForm userListForm = new UserListForm();

            userListForm.UserID = serverCreate.UserIdSend();
            userListForm.UserIP = serverCreate.UserIPSend();
            userListForm.UserStat = serverCreate.UserStatSend();

            for(int i=0; i<userListForm.UserID.Count; i++)
            {
                ListViewItem item = new ListViewItem(userListForm.UserID[i]);
                item.SubItems.Add(userListForm.UserIP[i]);

                userListForm.userListView.Items.Add(item);
            }

            userListForm.ShowDialog();
        }
    }
}
