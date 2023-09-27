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
        public serverMainForm()
        {
            InitializeComponent();
            serverMain = this;
        }

        private void serverMainForm_Load(object sender, EventArgs e)
        {
            createSocket serverCreate = new createSocket();
        }

        private void logTBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
