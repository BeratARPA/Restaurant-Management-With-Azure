using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using System;
using System.Linq;
using System.Windows.Forms;
using WinFormUI.Class;

namespace WinFormUI
{
    public partial class MyRestaurants : Form
    {
        public MyRestaurants()
        {
            InitializeComponent();
        }

        RestaurantManager restaurantManager = new RestaurantManager(new EfRestaurantDal());

        private void MyRestaurants_Load(object sender, EventArgs e)
        {
            GetAllRestaurants();
        }

        public void GetAllRestaurants()
        {
            if (UserHelper.User != null)
            {
                flp_myRestaurants.Controls.Clear();               

                foreach (var restaurant in restaurantManager.GetByCustomerId(UserHelper.User.Id).OrderBy(x => x.Name))
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

                    flp_myRestaurants.Controls.Add(ucRestaurant);
                }
            }
        }

        private void Restaurant_Click(object sender, EventArgs e)
        {
            UcRestaurant ucRestaurant = (UcRestaurant)sender;

            MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
            if (mainForm != null)
            {
                RestaurantDashboard restaurantDashboard = new RestaurantDashboard(ucRestaurant.Id);
                restaurantDashboard.TopLevel = false;
                mainForm.p_main.Controls.Add(restaurantDashboard);
                restaurantDashboard.Show();
                restaurantDashboard.Dock = DockStyle.Fill;
                restaurantDashboard.BringToFront();
            }
        }
       
    }
}
