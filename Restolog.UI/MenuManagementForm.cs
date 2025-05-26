using Restolog.DataAccess;
using Restolog.DataAccess.Concrete;
using Restolog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Restolog.Core;

namespace Restolog.UI
{
    public partial class MenuManagementForm : Form
    {
        private readonly EfProductRepository _productRepo;
        private readonly EfCategoryRepository _categoryRepo;

        public MenuManagementForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
            _productRepo = new EfProductRepository(new RestologContext());
            _categoryRepo = new EfCategoryRepository(new RestologContext());
        }

        private void MenuManagementForm_Load(object sender, EventArgs e)
        {


            if (CurrentUser.User != null)
            {
                lblUsername.Text = CurrentUser.User.Name;
                lblRole.Text = CurrentUser.User.UserRole?.Name ?? "Rol Yok";
            }

            LoadCategories();
            InitializeDataGridView();
            LoadProducts();

            cmbCategories.SelectedIndexChanged += (s, ev) => LoadProducts();
        }



        private void LoadCategories()
        {
            var categories = _categoryRepo.GetAll();

            var allOption = new Category
            {
                Id = 0,
                Name = "Tümü"
            };

            categories.Insert(0, allOption); 

            cmbCategories.DataSource = categories;
            cmbCategories.DisplayMember = "Name";
            cmbCategories.ValueMember = "Id";
        }



        public void LoadProducts()
        {
            var products = _productRepo.GetAll();

            // Kategori filtresi
            if (cmbCategories.SelectedItem is Category selectedCategory && selectedCategory.Id != 0)
            {
                products = products.Where(p => p.CategoryId == selectedCategory.Id).ToList();
            }

            // Arama filtresi
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                string search = txtSearch.Text.ToLower();
                products = products.Where(p => p.Name.ToLower().Contains(search)).ToList();
            }

            dgvProducts.DataSource = products.Select(p => new
            {
                p.Id,
                p.Name,
                p.Description,
                Price = $"{p.Price:C}",
                Category = p.Category?.Name ?? "Tanımsız"
            }).ToList();
        }


        private void InitializeDataGridView()
        {
            DataGridViewStyle.ApplyStyle(dgvProducts, DataGridViewStyle.GridStyle.SleekBlue);

            foreach (DataGridViewColumn column in dgvProducts.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {  
            Application.Exit();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new ProductEditForm();
            if (form.ShowDialog() == DialogResult.OK)
                LoadProducts();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
            {
                int id = (int)dgvProducts.CurrentRow.Cells["Id"].Value;
                var product = _productRepo.GetById(id);
                var form = new ProductEditForm(product);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Logger.Info($"Ürün düzenlendi: {product.Name} (ID: {product.Id}), Kullanıcı: {CurrentUser.User?.Name ?? "Bilinmiyor"}");
                    LoadProducts();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
            {
                int id = (int)dgvProducts.CurrentRow.Cells["Id"].Value;
                var product = _productRepo.GetById(id); 
                var result = MessageBox.Show("Bu ürünü silmek istediğinize emin misiniz?", "Sil", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _productRepo.Delete(id);
                    Logger.Info($"Ürün silindi: {product?.Name ?? "Bilinmiyor"} (ID: {id}), Kullanıcı: {CurrentUser.User?.Name ?? "Bilinmiyor"}"); LoadProducts();
                }
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            var form = new CategoryEditForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadCategories();
            }
        }
    }
}
