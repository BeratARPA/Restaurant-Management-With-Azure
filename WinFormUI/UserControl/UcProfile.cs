using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class UcProfile : UserControl
    {
        public UcProfile()
        {
            InitializeComponent();
        }      

        #region Properties
        private int _id;
        private string _nameSurname;
        private string _phoneNumber;
     
        [Category("Custom Props")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Category("Custom Props")]
        public string NameSurname
        {
            get { return _nameSurname; }
            set { _nameSurname = value; lbl_nameSurname.Text = value; }
        }

        [Category("Custom Props")]
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; lbl_phoneNumber.Text = value; }
        }
        #endregion

        #region Event    
        private void pb_image_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void lbl_nameSurname_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void lbl_phoneNumber_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
        #endregion
    }
}
