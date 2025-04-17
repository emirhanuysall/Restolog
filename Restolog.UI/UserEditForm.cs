using Restolog.DataAccess.Concrete;
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
        private User _currentUser;

        public UserEditForm(User user = null)
        {
            InitializeComponent();
            _userRepository = new EfUserRepository(new RestologContext());
            _currentUser = user;
        }

        private void UserEditForm_Load(object sender, EventArgs e)
        {
            // Roller combobox'ı yükle
            cmbRole.Items.Add("Yönetici");
            cmbRole.Items.Add("Personel");
            cmbRole.SelectedIndex = 0; // Varsayılan "Yönetici"

            if (_currentUser != null)
            {
                txtName.Text = _currentUser.Name;
                cmbRole.SelectedItem = _currentUser.UserRole?.Name;
                chkIsActive.Checked = _currentUser.IsActive;
                txtPassword.Text = ""; // Şifreyi boş bırak
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Kullanıcı bilgilerini al
            var name = txtName.Text;
            var role = cmbRole.SelectedItem.ToString();
            var isActive = chkIsActive.Checked;
            var password = txtPassword.Text;

            // Yeni kullanıcı veya mevcut kullanıcıyı güncelle
            if (_currentUser == null)
            {
                var newUser = new User
                {
                    Name = name,
                    UserRole = new UserRole { Name = role },
                    IsActive = isActive,
                    Password = password // Şifreyi buradan alabiliriz
                };

                _userRepository.Add(newUser);
            }
            else
            {
                // Mevcut kullanıcıyı güncelle
                _currentUser.Name = name;
                _currentUser.UserRole = new UserRole { Name = role };
                _currentUser.IsActive = isActive;
                _currentUser.Password = password;

                _userRepository.Update(_currentUser);
            }

            // Değişiklikleri kaydet ve formu kapat
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
