using System;
using System.Collections.Generic;

namespace capstone_Server
{
    public partial class UserListForm : MetroFramework.Forms.MetroForm
    {
        public Dictionary<int, string> userInfo = new Dictionary<int, string>();

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
