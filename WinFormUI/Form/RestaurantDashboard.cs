using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using System;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class RestaurantDashboard : Form
    {
        public RestaurantDashboard(int restaurantId)
        {
            InitializeComponent();

            _restaurantId = restaurantId;
        }

        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        RestaurantManager restaurantManager = new RestaurantManager(new EfRestaurantDal());
        TicketManager ticketManager = new TicketManager(new EfTicketDal());
        int _restaurantId;

        private void RestaurantDashboard_Load(object sender, EventArgs e)
        {
            GetMyRestaurantStatus();
            GetActiveTickets();
            GetPassiveTickets();
        }

        public void GetActiveTickets()
        {
            dgv_activeTickets.Rows.Clear();

            foreach (var ticket in ticketManager.GetAll(x => x.RestaurantId == _restaurantId && x.Status == true))
            {
                var customer = customerManager.GetById(ticket.CustomerId);

                dgv_activeTickets.Rows.Add(ticket.Id, ticket.TicketNumber, ticket.Date, customer.NameSurname, ticket.CustomerNote, ticket.PaymentMethodText, ticket.TotalPrice, ticket.Status, ticket.RestaurantId, ticket.CustomerId);
            }

            dgv_activeTickets.ClearSelection();
        }

        public void GetPassiveTickets()
        {
            dgv_passiveTickets.Rows.Clear();


            foreach (var ticket in ticketManager.GetAll(x => x.RestaurantId == _restaurantId && x.Status == false))
            {
                var customer = customerManager.GetById(ticket.CustomerId);

                dgv_passiveTickets.Rows.Add(ticket.Id, ticket.TicketNumber, ticket.Date, customer.NameSurname, ticket.CustomerNote, ticket.PaymentMethodText, ticket.TotalPrice, ticket.Status, ticket.RestaurantId, ticket.CustomerId);
            }

            dgv_passiveTickets.ClearSelection();
        }

        public void GetMyRestaurantStatus()
        {
            var restaurant = restaurantManager.GetById(_restaurantId);
            if (restaurant.Status)
            {
                btn_changeStatus.Text = "Açık";
            }
            else
            {
                btn_changeStatus.Text = "Kapalı";
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_activeTickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_activeTickets.Columns[e.ColumnIndex].HeaderText == "Kabul Et")
            {
                var ticket = ticketManager.GetById(Convert.ToInt32(dgv_activeTickets.CurrentRow.Cells[0].Value));

                ticket.Status = false;

                ticketManager.Update(ticket);

                GetActiveTickets();
                GetPassiveTickets();
            }
            else if (dgv_activeTickets.Columns[e.ColumnIndex].HeaderText == "İptal Et")
            {
                var ticket = ticketManager.GetById(Convert.ToInt32(dgv_activeTickets.CurrentRow.Cells[0].Value));

                ticket.Status = false;

                ticketManager.Update(ticket);

                GetActiveTickets();
                GetPassiveTickets();
            }
        }

        private void btn_changeStatus_Click(object sender, EventArgs e)
        {
            var restaurant = restaurantManager.GetById(_restaurantId);
            if (restaurant.Status)
            {
                restaurant.Status = false;
            }
            else
            {
                restaurant.Status = true;
            }

            restaurantManager.Update(restaurant);

            GetMyRestaurantStatus();
        }

        private void timer_checkTickets_Tick(object sender, EventArgs e)
        {
            GetActiveTickets();
        }

        private void dgv_activeTickets_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TicketDetails ticketDetails = new TicketDetails(Convert.ToInt32(dgv_activeTickets.CurrentRow.Cells[0].Value));
            ticketDetails.ShowDialog();
        }

        private void dgv_passiveTickets_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TicketDetails ticketDetails = new TicketDetails(Convert.ToInt32(dgv_passiveTickets.CurrentRow.Cells[0].Value));
            ticketDetails.ShowDialog();
        }
    }
}
