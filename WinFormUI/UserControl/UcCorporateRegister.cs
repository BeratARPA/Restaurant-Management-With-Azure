using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class UcCorporateRegister : UserControl
    {
        public UcCorporateRegister()
        {
            InitializeComponent();
        }

        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public bool AddCorporateCustomer(Customer customer)
        {
            CustomerValidation validationRules = new CustomerValidation();
            ValidationResult validationResult = validationRules.Validate(customer);

            if (validationResult.IsValid)
            {           
                customerManager.Add(customer);
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
            List<Restaurant> restaurants = new List<Restaurant>();

            Restaurant restaurant = new Restaurant()
            {
                Name = txt_restaurantName.Text,
                Address = txt_restaurantAddress.Text,
                Status = false,
                MinimumAmount = 10
            };

            restaurants.Add(restaurant);

            Customer customer = new Customer()
            {
                NameSurname = txt_nameSurname.Text,
                Email = txt_eMail.Text,
                PhoneNumber = txt_phoneNumber.Text,
                Password = txt_password.Text,
                Restaurants = restaurants
            };

            if (AddCorporateCustomer(customer))
            {
                this.Dispose();
            }
        }
    }
}
