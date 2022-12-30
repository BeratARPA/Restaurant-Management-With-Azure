using EntityLayer.Concrete;
using System;
using System.Windows.Forms;
using WinFormUI.Class;

namespace WinFormUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetLoginViewModel();
        }

        public void Profile()
        {
            profile.Id = UserHelper.User.Id;
            profile.NameSurname = UserHelper.User.NameSurname;
            profile.PhoneNumber = UserHelper.User.PhoneNumber;
        }

        public void EditLayout()
        {
            if (UserHelper.User.Restaurants.Count == 0)
            {
                splitContainer1.Panel1Collapsed = true;
                yeniRestoranKayıtıToolStripMenuItem.Visible = false;
                kategorilerToolStripMenuItem.Visible = false;
                ürünlerToolStripMenuItem.Visible = false;
            }
            else
            {
                splitContainer1.Panel1Collapsed = false;
                yeniRestoranKayıtıToolStripMenuItem.Visible = true;
                kategorilerToolStripMenuItem.Visible = true;
                ürünlerToolStripMenuItem.Visible = true;
            }
        }

        public void GetLoginViewModel()
        {
            if (UserHelper.User == null)
            {
                Login login = new Login();
                login.TopLevel = false;
                panel.Controls.Add(login);
                login.Show();
                login.Dock = DockStyle.Fill;
                login.BringToFront();
            }
        }

        public void GetMyRestaurantsViewModel()
        {
            MyRestaurants myRestaurants = new MyRestaurants();
            myRestaurants.TopLevel = false;
            p_top.Controls.Add(myRestaurants);
            myRestaurants.Show();
            myRestaurants.Dock = DockStyle.Fill;
            myRestaurants.BringToFront();
        }

        public void GetRestaurantsViewModel()
        {
            Restaurants restaurants = new Restaurants();
            restaurants.TopLevel = false;
            p_middle.Controls.Add(restaurants);
            restaurants.Show();
            restaurants.Dock = DockStyle.Fill;
            restaurants.BringToFront();
        }

        private void profile_Click(object sender, EventArgs e)
        {
            cms_profile.Show(profile, 1, profile.Height);
        }

        #region MenuStrip
        private void cıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserHelper.User = null;
            GetLoginViewModel();
        }

        private void yeniRestoranKayıtıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UcRestaurantRegistration ucRestaurantRegistration = new UcRestaurantRegistration();
            p_main.Controls.Add(ucRestaurantRegistration);
            ucRestaurantRegistration.Show();
            ucRestaurantRegistration.Dock = DockStyle.Fill;
            ucRestaurantRegistration.BringToFront();
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UcSettings ucSettings = new UcSettings();
            p_main.Controls.Add(ucSettings);
            ucSettings.Show();
            ucSettings.Dock = DockStyle.Fill;
            ucSettings.BringToFront();
        }

        private void kategorilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UcCategoryList ucCategoryList = new UcCategoryList();
            p_main.Controls.Add(ucCategoryList);
            ucCategoryList.Show();
            ucCategoryList.Dock = DockStyle.Fill;
            ucCategoryList.BringToFront();
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UcProductList ucProductList = new UcProductList();
            p_main.Controls.Add(ucProductList);
            ucProductList.Show();
            ucProductList.Dock = DockStyle.Fill;
            ucProductList.BringToFront();
        }
        #endregion       
    }
}
