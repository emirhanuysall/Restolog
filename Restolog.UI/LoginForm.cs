using Restolog.DataAccess.Concrete;
using System;
using System.Windows.Forms;
using Restolog.Entities.Concrete;
using Restolog.DataAccess;

namespace Restolog.UI
{
    public partial class LoginForm : Form
    {
        private readonly EfUserRepository _userRepository;

        public LoginForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;


            InitializeComponent();
            _userRepository = new EfUserRepository(new RestologContext());

            txtPassword.PasswordChar = '*';
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz.");
                return;
            }

            User? user = _userRepository.Login(username, password);

            if (user != null)
            {
                CurrentUser.User = user;

               

                this.Hide();
                new RedirectForm(user).ShowDialog();
                this.Close(); // RedirectForm kapatıldığında LoginForm'u da kapat
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            }
        }
    }
}
