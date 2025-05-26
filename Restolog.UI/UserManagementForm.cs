using Restolog.DataAccess.Concrete;
using Restolog.DataAccess;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restolog.Entities.Concrete;
using Restolog.Core; 

namespace Restolog.UI
{
    public partial class UserManagementForm : Form
    {
        public UserManagementForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
        }

        private void LoadUsers()
        {
            var repo = new EfUserRepository(new RestologContext());
            var users = repo.GetAll();

            if (users == null || !users.Any())
            {
                dgvUsers.DataSource = null;
                MessageBox.Show("Kullanıcılar bulunamadı", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (chkActive.Checked && !chkPassive.Checked)
            {
                users = users.Where(u => u.IsActive).ToList();
            }
            else if (!chkActive.Checked && chkPassive.Checked)
            {
                users = users.Where(u => !u.IsActive).ToList();
            }

            // Arama
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                string search = txtSearch.Text.ToLower();
                users = users.Where(u => u.Name.ToLower().Contains(search)).ToList();
            }

            dgvUsers.DataSource = users.Select(u => new
            {
                u.Id,
                u.Name,
                Role = u.UserRole != null ? u.UserRole.Name : "Bulunamadı",
                Status = u.IsActive ? "Active" : "Passive"
            }).ToList();

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

        private void btnApply_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }
        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            if (CurrentUser.User != null)
            {
                lblUsername.Text = CurrentUser.User.Name;
                lblRole.Text = CurrentUser.User.UserRole?.Name ?? "Rol Yok";
            }

            LoadUsers();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new UserEditForm(); 
            if (form.ShowDialog() == DialogResult.OK)
                LoadUsers();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                var id = (Guid)dgvUsers.CurrentRow.Cells["Id"].Value;
                var repo = new EfUserRepository(new RestologContext());
                var user = repo.GetById(id);
                var form = new UserEditForm(user);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Logger.Info($"Kullanıcı düzenlendi: {user.Name} (ID: {user.Id}), Kullanıcı:  {CurrentUser.User?.Name ?? "Bilinmiyor"}");
                    LoadUsers();
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                var id = (Guid)dgvUsers.CurrentRow.Cells["Id"].Value;
                var repo = new EfUserRepository(new RestologContext());
                var user = repo.GetById(id); 
                var result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    repo.Delete(id);
                    Logger.Info($"Kullanıcı silindi: {user?.Name ?? "Bilinmiyor"} (ID: {id}), Kullanıcı:  {CurrentUser.User?.Name ?? "Bilinmiyor"}");
                    LoadUsers();
                }
            }
        }

        private void InitializeDataGridView()
        {
            DataGridViewStyle.ApplyStyle(dgvUsers, DataGridViewStyle.GridStyle.SleekBlue);

            foreach (DataGridViewColumn column in dgvUsers.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            foreach (DataGridViewRow row in dgvUsers.Rows)
            {
                if (row.Cells["Status"].Value != null)
                {
                    string status = row.Cells["Status"].Value.ToString();
                    var statusCell = row.Cells["Status"];

                    if (status == "Active")
                    {
                        statusCell.Style.BackColor = Color.FromArgb(34, 197, 94); 
                        statusCell.Style.ForeColor = Color.White;
                    }
                    else if (status == "Passive")
                    {
                        statusCell.Style.BackColor = Color.FromArgb(239, 68, 68); 
                        statusCell.Style.ForeColor = Color.White;
                    }
                }
            }
        }
    }
}
