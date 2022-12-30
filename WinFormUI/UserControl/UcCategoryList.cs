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
    public partial class UcCategoryList : UserControl
    {
        public UcCategoryList()
        {
            InitializeComponent();
        }

        RestaurantManager restaurantManager = new RestaurantManager(new EfRestaurantDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        private void UcCategoryList_Load(object sender, EventArgs e)
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
            dgv_categories.Rows.Clear();
        
            int restaurantId = Convert.ToInt32(cb_restaurants.SelectedValue);
            foreach (var category in categoryManager.GetAll(x => x.RestaurantId == restaurantId))
            {
                dgv_categories.Rows.Add(category.Id, category.Name);
            }

            dgv_categories.ClearSelection();
        }
        #endregion

        #region AddCategory
        public bool AddCategory(Category category)
        {
            CategoryValidation validationRules = new CategoryValidation();
            ValidationResult validationResult = validationRules.Validate(category);

            if (validationResult.IsValid)
            {
                categoryManager.Add(category);
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
            if (cb_restaurants.SelectedValue != null)
            {
                Category category = new Category()
                {
                    RestaurantId = Convert.ToInt32(cb_restaurants.SelectedValue),
                    Name = txt_name.Text
                };

                if (AddCategory(category))
                {
                    Clear();
                    GetRestaurantCategories();
                }
            }
        }
        #endregion

        #region UpdateCategory
        public bool UpdateCategory(Category category)
        {
            CategoryValidation validationRules = new CategoryValidation();
            ValidationResult validationResult = validationRules.Validate(category);

            if (validationResult.IsValid)
            {
                categoryManager.Update(category);
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
            if (dgv_categories.Rows.Count != 0)
            {
                Category category = new Category()
                {
                    Id = Convert.ToInt32(dgv_categories.CurrentRow.Cells[0].Value),
                    RestaurantId = Convert.ToInt32(cb_restaurants.SelectedValue),
                    Name = txt_name.Text
                };

                if (UpdateCategory(category))
                {
                    Clear();
                    GetRestaurantCategories();
                }
            }
        }
        #endregion

        #region DeleteCategory
        public bool DeleteCategory(int id)
        {
            Category category = categoryManager.GetById(id);

            CategoryValidation validationRules = new CategoryValidation();
            ValidationResult validationResult = validationRules.Validate(category);

            if (validationResult.IsValid)
            {
                categoryManager.Delete(category);
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
            if (dgv_categories.Rows.Count != 0)
            {
                if (DeleteCategory(Convert.ToInt32(dgv_categories.CurrentRow.Cells[0].Value)))
                {
                    Clear();
                    GetRestaurantCategories();
                }
            }
        }
        #endregion

        private void dgv_categories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_name.Text = dgv_categories.CurrentRow.Cells[1].Value.ToString();
        }

        public void Clear()
        {
            txt_name.Clear();
        }

        private void cb_restaurants_TextChanged(object sender, EventArgs e)
        {
            if (cb_restaurants.SelectedValue != null)
            {
                GetRestaurantCategories();
            }
        }
    }
}
