using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CardView = Client.Models.CardView;
using CardViewControl = Client.Controls.CardViewControl;


namespace Client
{
    public partial class RestaurantsControl : UserControl
    {
        List<CardViewControl> cardViewControls = new List<CardViewControl>();
        List<CardView> cardViews = new List<CardView>();

        public int client_id;
        public RestaurantsControl()
        {
            InitializeComponent();

           
        }

        public void setRestaurants()
        {
            cardViews = API.SQLDatabase.GetCardViews();
            int posX = 45;
            int posY = 30;
            int count = 0;
            foreach(CardView cardView in cardViews)
            {

                count++;
                CardViewControl cardViewControl = new CardViewControl();
                cardViewControl.SetCardViewControler(cardView, client_id);
                cardViewControl.Location = new Point(posX,posY);

                posX += 200;
                if (count % 3 == 0) { posX = 45;posY += 160; }
                cardViewControls.Add(cardViewControl);

                Controls.Add(cardViewControl);
            }

        }

        private void RestaurantsControl_Load(object sender, EventArgs e)
        {

        }
    }
}
