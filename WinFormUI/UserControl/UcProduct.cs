using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class UcProduct : UserControl
    {
        public UcProduct()
        {
            InitializeComponent();
        }

        #region Properties
        private int _id;
        private string _pName;
        private string _description;
        private decimal _price;

        #region EventHandler
        public EventHandler _addClick;
        #endregion

        [Category("Custom Props")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Category("Custom Props")]
        public string PName
        {
            get { return _pName; }
            set { _pName = value; lbl_name.Text = value; }
        }

        [Category("Custom Props")]
        public string Description
        {
            get { return _description; }
            set { _description = value; lbl_description.Text = value; }
        }

        [Category("Custom Props")]
        public decimal Price
        {
            get { return _price; }
            set { _price = value; lbl_price.Text = value.ToString("N"); }
        }
        #endregion

        #region Event   
        private void UcProduct_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(233, 236, 239);
        }

        private void UcProduct_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(248, 249, 250);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (this._addClick != null)
                this._addClick(this, e);
        }
        #endregion

    }
}
