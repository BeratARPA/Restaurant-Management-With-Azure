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
    public partial class UcProductList : UserControl
    {
        public UcProductList()
        {
            InitializeComponent();
        }

        RestaurantManager restaurantManager = new RestaurantManager(new EfRestaurantDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        ProductManager productManager = new ProductManager(new EfProductDal());

        private void UcProductList_Load(object sender, EventArgs e)
        {
            GetMyRestaurants();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #region Get
        public void GetMyRestaurants()
        {
            cb_restaurants.DisplayMember = "Name";
            cb_restaurants.ValueMember = "Id";
            cb_restaurants.DataSource = restaurantManager.GetByCustomerId(UserHelper.User.Id);
        }

        public void GetRestaurantCategories()
        {
            int restaurantId = Convert.ToInt32(cb_restaurants.SelectedValue);

            cb_categories.DisplayMember = "Name";
            cb_categories.ValueMember = "Id";
            cb_categories.DataSource = categoryManager.GetAll(x => x.RestaurantId == restaurantId);
        }

        public void GetRestaurantProducts()
        {
            dgv_products.Rows.Clear();

            int restaurantId = Convert.ToInt32(cb_restaurants.SelectedValue);
            foreach (var product in productManager.GetAll(x => x.RestaurantId == restaurantId))
            {
                var category = categoryManager.GetById(product.CategoryId);

                dgv_products.Rows.Add(product.Id, product.CategoryId, category.Name, product.Name, product.Description, product.Price);
            }

            dgv_products.ClearSelection();
        }
        #endregion

        #region AddProduct
        public bool AddProduct(Product product)
        {
            ProductValidation validationRules = new ProductValidation();
            ValidationResult validationResult = validationRules.Validate(product);

            if (validationResult.IsValid)
            {                
                productManager.Add(product);
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (cb_categories.SelectedValue != null)
            {
                Product product = new Product()
                {
                    CategoryId = Convert.ToInt32(cb_categories.SelectedValue),
                    RestaurantId = Convert.ToInt32(cb_restaurants.SelectedValue),
                    Name = txt_name.Text,
                    Description = txt_description.Text,
                    Price = Convert.ToDecimal(txt_price.Text)
                };

                if (AddProduct(product))
                {
                    Clear();
                    GetRestaurantProducts();
                }
            }
        }
        #endregion

        #region UpdateProduct
        public bool UpdateProduct(Product product)
        {
            ProductValidation validationRules = new ProductValidation();
            ValidationResult validationResult = validationRules.Validate(product);

            if (validationResult.IsValid)
            {
                productManager.Update(product);
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dgv_products.Rows.Count != 0)
            {
                Product product = new Product()
                {
                    Id = Convert.ToInt32(dgv_products.CurrentRow.Cells[0].Value),
                    CategoryId = Convert.ToInt32(cb_categories.SelectedValue),
                    RestaurantId = Convert.ToInt32(cb_restaurants.SelectedValue),
                    Name = txt_name.Text,
                    Description = txt_description.Text,
                    Price = Convert.ToDecimal(txt_price.Text)
                };

                if (UpdateProduct(product))
                {
                    Clear();
                    GetRestaurantProducts();
                }
            }
        }
        #endregion

        #region DeleteProduct
        public bool DeleteProduct(int id)
        {
            Product product = productManager.GetById(id);

            ProductValidation validationRules = new ProductValidation();
            ValidationResult validationResult = validationRules.Validate(product);

            if (validationResult.IsValid)
            {
                productManager.Delete(product);
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_products.Rows.Count != 0)
            {
                if (DeleteProduct(Convert.ToInt32(dgv_products.CurrentRow.Cells[0].Value)))
                {
                    Clear();
                    GetRestaurantProducts();
                }
            }
        }
        #endregion

        private void dgv_products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_categories.Text = dgv_products.CurrentRow.Cells[2].Value.ToString();
            txt_name.Text = dgv_products.CurrentRow.Cells[3].Value.ToString();
            txt_description.Text = dgv_products.CurrentRow.Cells[4].Value.ToString();
            txt_price.Text = dgv_products.CurrentRow.Cells[5].Value.ToString();
        }

        public void Clear()
        {
            cb_categories.SelectedIndex = -1;

            txt_name.Clear();
            txt_description.Clear();
            txt_price.Clear();
        }

        private void cb_restaurants_TextChanged(object sender, EventArgs e)
        {
            if (cb_restaurants.SelectedValue != null)
            {
                GetRestaurantCategories();
                GetRestaurantProducts();
            }
        }
    }
}
