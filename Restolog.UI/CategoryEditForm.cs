using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restolog.DataAccess;
using Restolog.DataAccess.Concrete;
using Restolog.Entities.Concrete;

namespace Restolog.UI
{
    public partial class CategoryEditForm : Form
    {
        private readonly EfCategoryRepository _categoryRepo;

        public CategoryEditForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            _categoryRepo = new EfCategoryRepository(new RestologContext());
            btnSave.Click += btnSave_Click;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Kategori adı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newCategory = new Category
            {
                Name = name
            };

            _categoryRepo.Add(newCategory);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
