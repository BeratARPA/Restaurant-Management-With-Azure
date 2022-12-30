using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using System;
using System.Windows.Forms;
using WinFormUI.Class;

namespace WinFormUI
{
    public partial class UcLogin : UserControl
    {
        public UcLogin()
        {
            InitializeComponent();
        }

        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        RestaurantManager restaurantManager = new RestaurantManager(new EfRestaurantDal());

        private void btn_goOn_Click(object sender, EventArgs e)
        {        
            var customer = customerManager.GetByPhoneAndPassword(txt_phoneNumber.Text, txt_password.Text);
            var restaurants = restaurantManager.GetByCustomerId(customer.Id);

            if (customer != null)
            {
                Login login = (Login)Application.OpenForms["Login"];
                if (login != null)
                {
                    MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
                    if (mainForm != null)
                    {
                        UserHelper.User = customer;
                        UserHelper.User.Restaurants = restaurants;

                        mainForm.Profile();
                        mainForm.GetRestaurantsViewModel();
                        mainForm.GetMyRestaurantsViewModel();
                        mainForm.EditLayout();
                    }

                    login.Close();
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
