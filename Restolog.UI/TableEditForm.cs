using Restolog.DataAccess;
using Restolog.DataAccess.Concrete;
using Restolog.Entities.Concrete;
using System;
using System.Windows.Forms;

namespace Restolog.UI
{
    public partial class TableEditForm : Form
    {
        private TableEntity _table;

        public TableEditForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;


            InitializeComponent();
        }

        public TableEditForm(TableEntity table) : this()
        {
            _table = table;
            txtName.Text = _table.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = txtName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Masa adı boş olamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var repo = new EfTableEntityRepository(new RestologContext());

            if (_table == null)
            {
                _table = new TableEntity
                {
                    Id = Guid.NewGuid(),
                    Name = name,
                    CreatedAt = DateTime.Now
                };
                repo.Add(_table);
            }
            else
            {
                _table.Name = name;
                repo.Update(_table);
            }

            DialogResult = DialogResult.OK;
        }
    }
}
