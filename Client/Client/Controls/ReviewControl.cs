using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class Reviews : UserControl
    {
        public Reviews()
        {
            InitializeComponent();
        }

        private void Reviews_Load(object sender, EventArgs e)
        {

        }

        public void  setInfo(string content, string author)
        {
            this.ContentLabel.Text = content;
            this.Author.Text = author;

        }

        private void Author_Click(object sender, EventArgs e)
        {

        }
    }
}
