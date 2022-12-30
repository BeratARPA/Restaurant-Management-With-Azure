using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class UcRegisterIndividually : UserControl
    {
        public UcRegisterIndividually()
        {
            InitializeComponent();
        }

        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public bool AddIndividualCustomer(Customer customer)
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
            Customer customer = new Customer()
            {
                NameSurname = txt_nameSurname.Text,
                Email = txt_eMail.Text,
                Address = txt_address.Text,
                PhoneNumber = txt_phoneNumber.Text,
                Password = txt_password.Text,
            };

            if (AddIndividualCustomer(customer))
            {
                this.Dispose();
            }
        }
    }
}
