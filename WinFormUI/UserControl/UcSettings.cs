using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Windows.Forms;
using WinFormUI.Class;

namespace WinFormUI
{
    public partial class UcSettings : UserControl
    {
        public UcSettings()
        {
            InitializeComponent();
        }

        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

        private void UcSettings_Load(object sender, EventArgs e)
        {
            GetCustomerInformation();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void GetCustomerInformation()
        {     
            var customer = customerManager.GetById(UserHelper.User.Id);

            txt_nameSurname.Text = customer.NameSurname;
            txt_eMail.Text = customer.Email;
            txt_address.Text = customer.Address;
            txt_phoneNumber.Text = customer.PhoneNumber;
            txt_password.Text = customer.Password;
        }

        public bool UpdateIndividualCustomer(Customer customer)
        {
            CustomerValidation validationRules = new CustomerValidation();
            ValidationResult validationResult = validationRules.Validate(customer);

            if (validationResult.IsValid)
            {
                customerManager.Update(customer);
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
            Customer customer = new Customer()
            {
                Id = UserHelper.User.Id,
                NameSurname = txt_nameSurname.Text,
                Email = txt_eMail.Text,
                Address = txt_address.Text,
                PhoneNumber = txt_phoneNumber.Text,
                Password = txt_password.Text,
            };

            if (UpdateIndividualCustomer(customer))
            {
                MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
                if (mainForm != null)
                {
                    UserHelper.User = customer;
                    mainForm.Profile();

                    this.Dispose();
                }                
            }
        }

    }
}
