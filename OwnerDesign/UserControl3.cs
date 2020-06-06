using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OwnerDesign
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private void upload_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader(textBox1.Text);
                String line = sr.ReadLine();

                while (line != null)
                {
                    listBox1.Items.Add(line);
                    line = sr.ReadLine();
                }

                //close the file
                sr.Close();
            }

            catch (System.ArgumentException exp) { MessageBox.Show("Please gice a non-empty path"); }

        }

        private void submit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for choosing us! Your menu has been saved into our database!");

        }
    }
}
