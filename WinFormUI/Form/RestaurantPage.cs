using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormUI.Class;

namespace WinFormUI
{
    public partial class RestaurantPage : Form
    {
        public RestaurantPage(int restaurantId)
        {
            InitializeComponent();

            _restaurantId = restaurantId;
        }

        OrderManager orderManager = new OrderManager(new EfOrderDal());
        TicketManager ticketManager = new TicketManager(new EfTicketDal());
        ProductManager productManager = new ProductManager(new EfProductDal());
        RestaurantManager restaurantManager = new RestaurantManager(new EfRestaurantDal());
        int _restaurantId;

        private void RestaurantPage_Load(object sender, EventArgs e)
        {
            GetRestaurantInformation();
            GetRestaurantProducts();
        }

        public void GetRestaurantInformation()
        {          
            var restaurant = restaurantManager.GetById(_restaurantId);

            ucRestaurant.Id = restaurant.Id;
            ucRestaurant.RestaurantName = restaurant.Name;
            ucRestaurant.Status = restaurant.Status;
            ucRestaurant.Address = restaurant.Address;
            ucRestaurant.MinimumAmount = restaurant.MinimumAmount;

            if (!restaurant.Status)
            {
                btn_toOrder.Visible = false;
            }
        }

        public void GetRestaurantProducts()
        {
            flp_products.Controls.Clear();        

            foreach (var product in productManager.GetAll(x => x.RestaurantId == _restaurantId))
            {
                UcProduct ucProduct = new UcProduct();

                ucProduct.Id = product.Id;
                ucProduct.PName = product.Name;
                ucProduct.Description = product.Description;
                ucProduct.Price = product.Price;

                #region EventHandler
                ucProduct._addClick += new EventHandler(AddProductToOrder_Click);
                #endregion

                flp_products.Controls.Add(ucProduct);
            }
        }

        public decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (UcProductOnCard productOnCard in flp_orders.Controls)
            {
                totalPrice += productOnCard.Price;
            }

            lbl_totalPrice.Text = totalPrice.ToString();
            lbl_totalPrice.Visible = true;
            btn_toOrder.Visible = true;

            if (totalPrice == 0)
            {
                lbl_totalPrice.Visible = false;
                btn_toOrder.Visible = false;
            }

            return totalPrice;
        }

        private void AddProductToOrder_Click(object sender, EventArgs e)
        {
            if (ucRestaurant.Status)
            {
                UcProduct product = (UcProduct)sender;
                bool forState = false;
                int forQuantity = 1;

                if (flp_orders.Controls.Count == 0)
                {
                    UcProductOnCard ucProductOnCard = new UcProductOnCard();

                    ucProductOnCard.Id = product.Id;
                    ucProductOnCard.PName = product.PName;
                    ucProductOnCard.Quantity = 1;
                    ucProductOnCard.Price = product.Price;
                    ucProductOnCard.UnitPrice = product.Price;

                    #region EventHandler
                    ucProductOnCard._deleteClick += new EventHandler(DeleteProductToOrder_Click);
                    #endregion

                    flp_orders.Controls.Add(ucProductOnCard);
                }
                else
                {
                    foreach (UcProductOnCard productOnCard in flp_orders.Controls)
                    {
                        if (productOnCard.Id == product.Id)
                        {
                            forState = true;

                            forQuantity = Convert.ToInt32(productOnCard.Quantity);
                            forQuantity++;
                            decimal totalPrice = (decimal)(forQuantity * product.Price);
                            productOnCard.Quantity = forQuantity;
                            productOnCard.Price = totalPrice;

                            break;
                        }
                    }

                    if (!forState)
                    {
                        UcProductOnCard ucProductOnCard = new UcProductOnCard();

                        ucProductOnCard.Id = product.Id;
                        ucProductOnCard.PName = product.PName;
                        ucProductOnCard.Quantity = 1;
                        ucProductOnCard.Price = product.Price;
                        ucProductOnCard.UnitPrice = product.Price;

                        #region EventHandler
                        ucProductOnCard._deleteClick += new EventHandler(DeleteProductToOrder_Click);
                        #endregion

                        flp_orders.Controls.Add(ucProductOnCard);
                    }
                }

                CalculateTotalPrice();
            }
        }

        private void DeleteProductToOrder_Click(object sender, EventArgs e)
        {
            UcProductOnCard ucProductOnCard = (UcProductOnCard)sender;

            if (ucProductOnCard.Quantity == 1)
            {
                flp_orders.Controls.RemoveAt(flp_orders.Controls.GetChildIndex(ucProductOnCard));
            }
            else if (ucProductOnCard.Quantity >= 1)
            {
                int quantity = ucProductOnCard.Quantity;
                quantity--;
                decimal totalPrice = (decimal)(quantity * ucProductOnCard.UnitPrice);
                ucProductOnCard.Quantity = quantity;
                ucProductOnCard.Price = totalPrice;
            }

            CalculateTotalPrice();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_toOrder_Click(object sender, EventArgs e)
        {         
            int ticketCount = ticketManager.GetAll().Count;
            ticketCount++;

            Ticket newTicket = new Ticket()
            {
                TotalPrice = CalculateTotalPrice(),
                TicketNumber = ticketCount,
                Status = true,
                Date = DateTime.Now,
                PaymentMethodText = "Nakit",
                CustomerNote = "Müşteri Notu",
                RestaurantId = _restaurantId,
                CustomerId = UserHelper.User.Id
            };

            ticketManager.Add(newTicket);

            var ticket = ticketManager.Get(x => x.CustomerId == UserHelper.User.Id && x.Status == true && x.TicketNumber == ticketCount);
            foreach (UcProductOnCard productOnCard in flp_orders.Controls)
            {
                Order order = new Order()
                {
                    ProductId = productOnCard.Id,
                    TotalPrice = productOnCard.Price,
                    Quantity = productOnCard.Quantity,
                    TicketId = ticket.Id
                };
                
                orderManager.Add(order);
            }

            flp_orders.Controls.Clear();
            lbl_totalPrice.Visible = false;

            btn_toOrder.Visible = false;

            MessageBox.Show("Siparişiniz başarıyla verildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
