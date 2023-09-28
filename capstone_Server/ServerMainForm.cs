using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
