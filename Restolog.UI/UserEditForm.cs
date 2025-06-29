﻿using Restolog.DataAccess.Concrete;
using Restolog.DataAccess;
using Restolog.Entities.Concrete;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Restolog.UI
{
    public partial class UserEditForm : Form
    {
        private readonly EfUserRepository _userRepository;
        private readonly EfUserRoleRepository _roleRepository;

        private User _currentUser;

        public UserEditForm(User user = null)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
            _userRepository = new EfUserRepository(new RestologContext());
            _roleRepository = new EfUserRoleRepository(new RestologContext());
            _currentUser = user;
        }

        private void UserEditForm_Load(object sender, EventArgs e)
        {
            var roles = _roleRepository.GetAll();
            cmbRole.DataSource = roles;
            cmbRole.DisplayMember = "Name";
            cmbRole.ValueMember = "Id";

            if (_currentUser != null)
            {
                txtName.Text = _currentUser.Name;
                cmbRole.SelectedValue = _currentUser.UserRoleId;
                chkIsActive.Checked = _currentUser.IsActive;
                txtPassword.Text = ""; 
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = txtName.Text.Trim();
            var roleSelected = cmbRole.SelectedItem != null;
            var password = txtPassword.Text;

            // Boş alan kontrolü
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Kullanıcı adı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!roleSelected)
            {
                MessageBox.Show("Bir rol seçmelisiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_currentUser == null && string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Şifre boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (password.Length > 0 && password.Length < 6)
            {
                MessageBox.Show("Şifre en az 6 karakter olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existingUser = _userRepository.GetAll().FirstOrDefault(u => u.Name.ToLower() == name.ToLower() && (_currentUser == null || u.Id != _currentUser.Id));
            if (existingUser != null)
            {
                MessageBox.Show("Bu isimde bir kullanıcı zaten mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var roleId = (int)cmbRole.SelectedValue;
            var isActive = chkIsActive.Checked;

            if (_currentUser == null)
            {
                var newUser = new User
                {
                    Id = Guid.NewGuid(),
                    Name = name,
                    UserRoleId = roleId,
                    IsActive = isActive,
                    Password = password
                };

                _userRepository.Add(newUser);
            }
            else
            {
                _currentUser.Name = name;
                _currentUser.UserRoleId = roleId;
                _currentUser.IsActive = isActive;

                if (!string.IsNullOrEmpty(password))
                {
                    _currentUser.Password = password;
                }

                _userRepository.Update(_currentUser);
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
