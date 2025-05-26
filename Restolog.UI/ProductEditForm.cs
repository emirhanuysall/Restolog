using Restolog.DataAccess;
using Restolog.DataAccess.Concrete;
using Restolog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Restolog.UI
{
    public partial class ProductEditForm : Form
    {
        private readonly EfProductRepository _productRepo;
        private readonly EfCategoryRepository _categoryRepo;
        private Product _product;

        public ProductEditForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
            _productRepo = new EfProductRepository(new RestologContext());
            _categoryRepo = new EfCategoryRepository(new RestologContext());
            _product = new Product();
        }

        public ProductEditForm(Product product) : this()
        {
            _product = product;
        }

        private void ProductEditForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;


            LoadCategories();

            if (_product.Id != 0) 
            {
                txtName.Text = _product.Name;
                txtDescription.Text = _product.Description;
                nudPrice.Value = _product.Price;
                cmbCategory.SelectedValue = _product.CategoryId;
            }
        }

        private void LoadCategories()
        {
            var categories = _categoryRepo.GetAll();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Ürün adı ve kategori alanları boş olamaz.");
                return;
            }

            string productName = txtName.Text.Trim();
            int currentProductId = _product?.Id ?? 0;

            // Aynı isimde ürün kontrolü
            var existingProduct = _productRepo.GetAll()
                .FirstOrDefault(p => p.Name.ToLower() == productName.ToLower() && p.Id != currentProductId);
            if (existingProduct != null)
            {
                MessageBox.Show("Bu isimde bir ürün zaten mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _product.Name = productName;
            _product.Description = txtDescription.Text.Trim();
            _product.Price = nudPrice.Value;
            _product.CategoryId = cmbCategory.SelectedValue != null ? (int)cmbCategory.SelectedValue : 0;

            if (_product.Id == 0)
                _productRepo.Add(_product);
            else
                _productRepo.Update(_product);

            var parentForm = this.Owner as MenuManagementForm;
            parentForm?.LoadProducts();

            DialogResult = DialogResult.OK;
        }

    }
}
