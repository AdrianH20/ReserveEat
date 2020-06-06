using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client.Controls
{
    public partial class ReservedControl : UserControl
    {

        public int client_id = 0;
        public ReservedControl()
        {
            InitializeComponent();
        }

        private void ReservedControl_Load(object sender, EventArgs e)
        {
            label1.Text = "id client: "+client_id.ToString();
        }
    }
}
