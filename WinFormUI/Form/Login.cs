using System;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_logIn_Click(object sender, EventArgs e)
        {
            UcLogin ucLogin = new UcLogin();
            p_main.Controls.Add(ucLogin);
            ucLogin.Show();
            ucLogin.Dock = DockStyle.Fill;
            ucLogin.BringToFront();
        }

        private void btn_registerIndividually_Click(object sender, EventArgs e)
        {
            UcRegisterIndividually ucRegisterIndividually = new UcRegisterIndividually();
            p_main.Controls.Add(ucRegisterIndividually);
            ucRegisterIndividually.Show();
            ucRegisterIndividually.Dock = DockStyle.Fill;
            ucRegisterIndividually.BringToFront();
        }

        private void btn_corporateRegister_Click(object sender, EventArgs e)
        {
            UcCorporateRegister ucCorporateRegister = new UcCorporateRegister();
            p_main.Controls.Add(ucCorporateRegister);
            ucCorporateRegister.Show();
            ucCorporateRegister.Dock = DockStyle.Fill;
            ucCorporateRegister.BringToFront();
        }
    }
}
