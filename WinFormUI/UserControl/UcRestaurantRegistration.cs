using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormUI.Class;

namespace WinFormUI
{
    public partial class UcRestaurantRegistration : UserControl
    {
        public UcRestaurantRegistration()
        {
            InitializeComponent();
        }

        RestaurantManager restaurantManager = new RestaurantManager(new EfRestaurantDal());

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public bool AddRestaurant(Restaurant restaurant)
        {
            RestaurantValidation validationRules = new RestaurantValidation();
            ValidationResult validationResult = validationRules.Validate(restaurant);

            if (validationResult.IsValid)
            {    
                restaurantManager.Add(restaurant);
                return true;
            }
            else
            {
                string rules = "";

                foreach (var item in validationResult.Errors)
                {
                    rules += item.ErrorMessage + "\n";
                }

                if (rules != "")
                {
                    MessageBox.Show(rules, "Doğrulama Kuralları", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return false;
        }

        private void btn_goOn_Click(object sender, EventArgs e)
        {
            Restaurant restaurant = new Restaurant()
            {
                Name = txt_restaurantName.Text,
                Address = txt_restaurantAddress.Text,
                Status = false,
                MinimumAmount = 10,
                CustomerId = UserHelper.User.Id
            };

            if (AddRestaurant(restaurant))
            {
                MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
                if (mainForm != null)
                {
                    mainForm.GetMyRestaurantsViewModel();
                    this.Dispose();
                }
            }
        }
    }
}
