using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class TicketDetails : Form
    {
        public TicketDetails(int ticketId)
        {
            InitializeComponent();

            _ticketId = ticketId;
        }

        OrderManager orderManager = new OrderManager(new EfOrderDal());
        ProductManager productManager = new ProductManager(new EfProductDal());
        int _ticketId;

        private void TicketDetails_Load(object sender, EventArgs e)
        {
            GetTicketOrders();
        }

        public void GetTicketOrders()
        {
            dgv_orders.Rows.Clear();

            foreach (var order in orderManager.GetAll(x => x.TicketId == _ticketId))
            {
                var product = productManager.GetById(order.ProductId);

                dgv_orders.Rows.Add(order.Id, order.ProductId, order.TicketId, product.Name, order.TotalPrice, order.Quantity);
            }

            dgv_orders.ClearSelection();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
