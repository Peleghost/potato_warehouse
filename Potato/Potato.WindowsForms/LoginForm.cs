﻿using Potato.Domain.Entities;
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

        private User CreateUserInstance()
        {
            var temp = new User();
            var user = _userRepository.GetUserById(101).ToList();
            foreach (var item in user)
            {
                temp.UserName = item.UserName;
                temp.Password = item.Password;
            }

            return temp;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var user = CreateUserInstance();

            if (usernameTextBox.Text == $"{user.UserName}" && passwordTextBox.Text == $"{user.Password}")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                string error = "      *****   Inválido   *****\n\n         " +
                    "Usuário ou Senha\n\n         " +
                    "Tente novamente";

                MessageBox.Show(error);

                usernameTextBox.Clear();
                passwordTextBox.Clear();
            }
        }

    }
}