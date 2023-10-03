using System;
using System.Collections.Generic;

namespace capstone_Server
{
    public partial class UserListForm : MetroFramework.Forms.MetroForm
    {
        public List<string> UserID = new List<string>();
        public List<string> UserIP = new List<string>();
        public List<string> UserStat = new List<string>();

        public UserListForm()
        {
            InitializeComponent();
        }

        private void UserListForm_Load(object sender, EventArgs e)
        {

        }

        private void metroListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
