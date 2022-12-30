using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class Restaurants : Form
    {
        public Restaurants()
        {
            InitializeComponent();
        }

        RestaurantManager restaurantManager = new RestaurantManager(new EfRestaurantDal());

        private void Restaurants_Load(object sender, EventArgs e)
        {
            GetAllRestaurants();
        }

        public void GetAllRestaurants()
        {
            flp_restaurants.Controls.Clear();
       
            var restaurants = restaurantManager.GetAll().OrderBy(x => x.Name);
            lbl_restaurantCount.Text = restaurants.Count() + " Restoran Listeleniyor";

            foreach (var restaurant in restaurants)
            {
                UcRestaurant ucRestaurant = new UcRestaurant();

                ucRestaurant.Id = restaurant.Id;
                ucRestaurant.RestaurantName = restaurant.Name;
                ucRestaurant.Address = restaurant.Address;
                ucRestaurant.Status = restaurant.Status;
                ucRestaurant.MinimumAmount = restaurant.MinimumAmount;

                #region EventHandler
                ucRestaurant.Click += new EventHandler(Restaurant_Click);
                ucRestaurant._restaurantNameClick += new EventHandler(Restaurant_Click);
                ucRestaurant._imageClick += new EventHandler(Restaurant_Click);
                ucRestaurant._minimumAmountClick += new EventHandler(Restaurant_Click);
                ucRestaurant._statusClick += new EventHandler(Restaurant_Click);
                #endregion  

                flp_restaurants.Controls.Add(ucRestaurant);
            }
        }

        private void Restaurant_Click(object sender, EventArgs e)
        {
            UcRestaurant ucRestaurant = (UcRestaurant)sender;

            MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
            if (mainForm != null)
            {
                RestaurantPage restaurantPage = new RestaurantPage(ucRestaurant.Id);
                restaurantPage.TopLevel = false;
                mainForm.p_main.Controls.Add(restaurantPage);
                restaurantPage.Show();
                restaurantPage.Dock = DockStyle.Fill;
                restaurantPage.BringToFront();
            }
        }
    }
}
