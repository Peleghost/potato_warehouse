using Potato.Domain.Entities;
using Potato.Domain.Repositories;
using System.Runtime.InteropServices;

namespace Potato.WindowsForms
{
    public partial class LoginForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        private readonly IUserRepository _userRepository;

        public LoginForm(IUserRepository userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }


        // ----------------
        // Criar uma nova instancia do usuario para quando estiver em producao
        // Por enquanto usamos admin admin hardcode no loginButton_Click
        // ----------------
        /*
        private User CreateUserInstanceById(int id)
        {
            var temp = new User();
            var user = _userRepository.GetUserById(id).ToList();
            foreach (var item in user)
            {
                temp.UserName = item.UserName;
                temp.Password = item.Password;
            }

            return temp;
        }
        */

        private void loginButton_Click(object sender, EventArgs e)
        {
            //var adminUser = CreateUserInstanceById(101);

            if (usernameTextBox.Text == $"admin" && passwordTextBox.Text == $"admin")
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

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
