using eventManagementSystem.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventManagementSystem.admin
{
    public partial class TicketView : UserControl
    {
        private int eventId;
        public int ticketPrice;
        private int total;
        public TicketView(int EventId)
        {
            InitializeComponent();
            this.eventId = EventId;
        }

        private void TicketView_Load(object sender, EventArgs e)
        {
            EventHelper helper = new EventHelper();
            Event ev = helper.returnEvent(eventId.ToString());
            eventNameLabel.Text = ev.displayName;
            addressLabel.Text = ev.eventType;
            eventtypeLabel.Text = ev.eventDate.ToString("dd/MM/yyyy");
            
            using(MemoryStream ms = new MemoryStream(ev.imageData))
            {
                pb1.Image = Image.FromStream(ms);
            }

            ticketPrice = ev.ticketValue;
            ticketPriceLabel.Text = $"LKR {ticketPrice.ToString()} .00";


        }

        private void ticketCountBox_ValueChanged(object sender, EventArgs e)
        {
            total = Convert.ToInt32(ticketCountBox.Value * ticketPrice);
            subTotalLabel.Text = totalLabel.Text = $"LKR {total.ToString()} .00";
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            PaymentGateway gateway = new PaymentGateway(total,Convert.ToInt32(ticketCountBox.Value), eventId);
            gateway.StartPosition = FormStartPosition.CenterScreen;
            gateway.ShowDialog();
        }
    }
}
