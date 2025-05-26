using Microsoft.EntityFrameworkCore;
using Restolog.DataAccess;
using Restolog.DataAccess.Concrete;
using Restolog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Restolog.Core; 

namespace Restolog.UI
{
    public partial class TableManagementForm : Form
    {
        public TableManagementForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
        }


        private void InitializetTableStatusComboBox()
        {
            cmbTableStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTableStatus.Items.Add("Tümü");
            cmbTableStatus.Items.Add("Boş");
            cmbTableStatus.Items.Add("Dolu");
            cmbTableStatus.Items.Add("Rezerve");
            cmbTableStatus.SelectedIndex = 0;

            cmbTableStatus.SelectedIndexChanged += CmbTableStatus_SelectedIndexChanged;
        }

        private void CmbTableStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTables();
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

            // Durum filtresi
            string selectedStatus = cmbTableStatus.SelectedItem.ToString();
            if (selectedStatus != "Tümü")
            {
                tables = tables.Where(t => t.Status == selectedStatus).ToList();
            }

            dgvTables.DataSource = tables.Select(t => new
            {
                t.Id,
                t.Name,
                CreatedAt = t.CreatedAt.ToString("g"),
                Durum = t.Status
            }).ToList();

            InitializeDataGridView(); 
        }


        private void TableManagementForm_Load(object sender, EventArgs e)
        {
            if (CurrentUser.User != null)
            {
                lblUsername.Text = CurrentUser.User.Name;
                lblRole.Text = CurrentUser.User.UserRole?.Name ?? "Rol Yok";
            }

            InitializetTableStatusComboBox();
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
                {
                    Logger.Info($"Masa düzenlendi: {table.Name} (ID: {table.Id}), Kullanıcı: {CurrentUser.User?.Name ?? "Bilinmiyor"}");
                    LoadTables();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTables.CurrentRow != null)
            {
                var id = (Guid)dgvTables.CurrentRow.Cells["Id"].Value;
                var repo = new EfTableEntityRepository(new RestologContext());
                var table = repo.GetById(id); 
                var result = MessageBox.Show("Masa silinsin mi?", "Sil", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    repo.Delete(id);
                    Logger.Info($"Masa silindi: {table?.Name ?? "Bilinmiyor"} (ID: {id}), Kullanıcı: {CurrentUser.User?.Name ?? "Bilinmiyor"}"); LoadTables();
                }
            }
        }

        private void InitializeDataGridView()
        {
            DataGridViewStyle.ApplyStyle(dgvTables, DataGridViewStyle.GridStyle.SleekBlue);

            foreach (DataGridViewColumn column in dgvTables.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvTables.CellFormatting += (sender, e) =>
            {
                if (e.ColumnIndex == dgvTables.Columns["Durum"].Index && e.Value != null)
                {
                    var status = e.Value.ToString();
                    switch (status)
                    {
                        case "Dolu":
                            e.CellStyle.BackColor = Color.FromArgb(239, 68, 68); 
                            e.CellStyle.ForeColor = Color.White;

                            break;
                        case "Boş":
                            e.CellStyle.BackColor = Color.FromArgb(34, 197, 94);
                            e.CellStyle.ForeColor = Color.White;

                            break;
                        case "Rezerve":
                            e.CellStyle.BackColor = System.Drawing.Color.Orange;
                            break;
                    }
                }
            };

            dgvTables.RowTemplate.Height = 40;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            LoadTables();

            InitializeDataGridView();
        }
    }
}
