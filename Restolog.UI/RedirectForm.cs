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


            btnOrderManagement.Visible = true;
            btnMenuManagement.Visible = true;
            btnTableManagement.Visible = true;

            bool isAdmin = _currentUser.UserRoleId == 1;

            btnUserManagement.Visible = isAdmin;
            btnDashboard.Visible = isAdmin;
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
    }
}
