using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class UcProductOnCard : UserControl
    {
        public UcProductOnCard()
        {
            InitializeComponent();
        }

        #region Properties
        private int _id;
        private string _pName;
        private int _quantity;
        private decimal _price;
        private decimal _unitPrice;

        #region EventHandler
        public EventHandler _deleteClick;
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
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; lbl_quantity.Text = value.ToString(); }
        }

        [Category("Custom Props")]
        public decimal Price
        {
            get { return _price; }
            set { _price = value; lbl_price.Text = value.ToString("N"); }
        }

        [Category("Custom Props")]
        public decimal UnitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value;}
        }
        #endregion

        #region Event   
        private void UcProductOnCard_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(233, 236, 239);
        }

        private void UcProductOnCard_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(248, 249, 250);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (this._deleteClick != null)
                this._deleteClick(this, e);
        }
        #endregion

    }
}
