using Restolog.DataAccess;
using Restolog.DataAccess.Concrete;
using Restolog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Restolog.UI
{
    public partial class TableManagementForm : Form
    {
        public TableManagementForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
        }

        private void LoadTables()
        {
            var repo = new EfTableEntityRepository(new RestologContext());
            var tables = repo.GetAll();

            if (tables == null || !tables.Any())
            {
                dgvTables.DataSource = null;
                MessageBox.Show("Masa bulunamadı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Arama
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                string search = txtSearch.Text.ToLower();
                tables = tables.Where(t => t.Name.ToLower().Contains(search)).ToList();
            }

            dgvTables.DataSource = tables.Select(t => new
            {
                t.Id,
                t.Name,
                CreatedAt = t.CreatedAt.ToString("g"),
                Durum = t.IsFull ? (t.IsReserved ? "Dolu - Rezerve" : "Dolu") : "Boş"
            }).ToList();

            InitializeDataGridView(); // Load işlemi sonrası stil uygula
        }


        private void TableManagementForm_Load(object sender, EventArgs e)
        {


            if (CurrentUser.User != null)
            {
                lblUsername.Text = CurrentUser.User.Name;
                lblRole.Text = CurrentUser.User.UserRole?.Name ?? "Rol Yok";
            }

            LoadTables();
            InitializeDataGridView();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new TableEditForm();
            if (form.ShowDialog() == DialogResult.OK)
                LoadTables();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTables.CurrentRow != null)
            {
                var id = (Guid)dgvTables.CurrentRow.Cells["Id"].Value;
                var repo = new EfTableEntityRepository(new RestologContext());
                var table = repo.GetById(id);
                var form = new TableEditForm(table);
                if (form.ShowDialog() == DialogResult.OK)
                    LoadTables();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTables.CurrentRow != null)
            {
                var id = (Guid)dgvTables.CurrentRow.Cells["Id"].Value;
                var result = MessageBox.Show("Masa silinsin mi?", "Sil", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var repo = new EfTableEntityRepository(new RestologContext());
                    repo.Delete(id);
                    LoadTables();
                }
            }
        }

        private void InitializeDataGridView()
        {
            // DataGridView stilini güncelle
            dgvTables.EnableHeadersVisualStyles = false;
            dgvTables.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(34, 36, 49);
            dgvTables.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvTables.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dgvTables.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Satır stilini güncelle
            dgvTables.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(40, 42, 54);
            dgvTables.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvTables.RowsDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgvTables.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(75, 75, 75);
            dgvTables.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

            // Alternatif satır renkleri
            dgvTables.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(50, 52, 63);

            // Kenarlıkları daha ince yap
            dgvTables.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvTables.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(50, 60, 70);
            dgvTables.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

            // Sütunlar için stil
            foreach (DataGridViewColumn column in dgvTables.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Genişlik ayarları
            dgvTables.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTables.RowTemplate.Height = 40;

            // Tablonun genel arka plan rengini değiştirme
            dgvTables.BackgroundColor = System.Drawing.Color.FromArgb(48, 50, 61);
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            LoadTables();

            InitializeDataGridView();
        }
    }
}
