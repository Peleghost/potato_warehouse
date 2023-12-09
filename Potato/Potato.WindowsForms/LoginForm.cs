using Potato.Domain.Entities;
using Potato.Domain.Repositories;

namespace Potato.WindowsForms
{
    public partial class LoginForm : Form
    {

        private readonly IUserRepository _userRepository;



        public LoginForm(IUserRepository userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var temp = new User();
            var user = _userRepository.GetUserById(101).ToList();
            foreach (var item in user)
            {
                temp.UserName = item.UserName;
                temp.Password = item.Password;
            }


            if (usernameTextBox.Text == $"{temp.UserName}" && passwordTextBox.Text == $"{temp.Password}")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("      *****   Inválido   *****\n\n         " +
                    "Usuário ou Senha\n\n         " +
                    "Tente novamente");

                usernameTextBox.Clear();
                passwordTextBox.Clear();
            }
        }

    }
}
