using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomepageFinal
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            vScrollBar1.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            
        }

        private void vScrollBar1_MouseHover(object sender, EventArgs e)
        {
            vScrollBar1.Visible = true;
        }

        private void vScrollBar1_MouseLeave(object sender, EventArgs e)
        {
            vScrollBar1.Visible = false;
        }
    }
}
