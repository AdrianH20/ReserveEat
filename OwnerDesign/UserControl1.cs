using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OwnerDesign
{
    public partial class UserControl1 : UserControl
    {
        UserControl2 uc2;
        public UserControl1(UserControl2 uc)
        {
            InitializeComponent();
            uc2 = uc;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            timer1.Start();   
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Left = this.Left - 15;
            if (uc2.Location.X > 0) uc2.Left = uc2.Left - 15;
            Console.WriteLine(uc2.Location);
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
