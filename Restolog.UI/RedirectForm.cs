using Restolog.Entities.Concrete;
using Restolog.UI;
using System;
using System.Windows.Forms;

namespace Restolog.UI
{
    public partial class RedirectForm : Form
    {
        private readonly User _currentUser;

        public RedirectForm(User user)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
            _currentUser = user;
        }

        private void RedirectForm_Load(object sender, EventArgs e)
        {
            bool isAdmin = _currentUser.UserRoleId == 1;

            btnOrderManagement.Visible = true;
            btnMenuManagement.Visible = isAdmin;
            btnTableManagement.Visible = isAdmin;
            btnUserManagement.Visible = isAdmin;
            btnDashboard.Visible = isAdmin;
            pcboxUser.Visible = isAdmin;
            pcboxDashboard.Visible = isAdmin;
            pcboxMenu.Visible = isAdmin;
            pcboxTable.Visible = isAdmin;

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOrderManagement_Click(object sender, EventArgs e)
        {
            var form = new OrderManagementForm();
            form.ShowDialog();
        }

        private void btnMenuManagement_Click(object sender, EventArgs e)
        {
            var form = new MenuManagementForm();
            form.ShowDialog();
        }

        private void btnTableManagement_Click(object sender, EventArgs e)
        {
            var form = new TableManagementForm();
            form.ShowDialog();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            var form = new UserManagementForm();
            form.ShowDialog();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            var form = new DashboardForm();
            form.ShowDialog();
        }
    }
}
