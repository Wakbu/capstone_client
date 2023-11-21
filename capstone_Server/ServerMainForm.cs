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

            userListForm.userInfo = serverCreate.UserInfoSend();

            foreach(int i in userListForm.userInfo.Keys)
            {
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(userListForm.userInfo[i]);

                userListForm.userListView.Items.Add(item);
            }

            userListForm.ShowDialog();
        }
    }
}
