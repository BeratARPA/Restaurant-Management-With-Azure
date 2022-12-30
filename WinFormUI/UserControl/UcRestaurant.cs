using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class UcRestaurant : UserControl
    {
        public UcRestaurant()
        {
            InitializeComponent();
        }

        #region Properties
        private int _id;
        private string _restaurantName;
        private string _address;
        private bool _status;
        private decimal _minimumAmount;

        #region EventHandler
        public EventHandler _restaurantNameClick;
        public EventHandler _imageClick;
        public EventHandler _minimumAmountClick;
        public EventHandler _statusClick;
        #endregion

        [Category("Custom Props")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Category("Custom Props")]
        public string RestaurantName
        {
            get { return _restaurantName; }
            set { _restaurantName = value; lbl_name.Text = value; }
        }

        [Category("Custom Props")]
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        [Category("Custom Props")]
        public bool Status
        {
            get { return _status; }
            set
            {
                _status = value;
                if (!_status)
                {
                    lbl_status.Visible = true;
                }
                else
                {
                    lbl_status.Visible = false;
                }
            }
        }

        [Category("Custom Props")]
        public decimal MinimumAmount
        {
            get { return _minimumAmount; }
            set { _minimumAmount = value; lbl_minimumAmount.Text = "Min. " + value.ToString("N"); }
        }
        #endregion

        #region Event   
        private void UcRestaurant_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(233, 236, 239);
        }

        private void UcRestaurant_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(248, 249, 250);

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {
            if (this._restaurantNameClick != null)
                this._restaurantNameClick(this, e);
        }
        private void pb_image_Click(object sender, EventArgs e)
        {
            if (this._imageClick != null)
                this._imageClick(this, e);
        }

        private void lbl_minimumAmount_Click(object sender, EventArgs e)
        {
            if (this._minimumAmountClick != null)
                this._minimumAmountClick(this, e);
        }

        private void lbl_status_Click(object sender, EventArgs e)
        {
            if (this._statusClick != null)
                this._statusClick(this, e);
        }
        #endregion       
    }
}
