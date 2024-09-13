using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Evaluacion2
{
    public partial class Form1 : Form
    {
        private UserRegistry userRegistry = new UserRegistry();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var user = new Users
            {
                Nickname = tbNickname.Text,
                Password = tbPassword.Text
            };

            try
            {
                userRegistry.AgregarUsuario(user);
                MessageBox.Show("Usuario añadido correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnVerifyUser_Click(object sender, EventArgs e)
        {
            var user = new Users
            {
                Nickname = tbNickname.Text,
                Password = tbPassword.Text
            };

            bool isVerified = userRegistry.VerificarUsuario(user);
            MessageBox.Show(isVerified ? "Usuario verificado!" : "Usuario no encontrado.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class Users
    {
        public string Nickname { get; set; }
        public string Password { get; set; }
    }

    public class UserRegistry
    {
        private List<Users> usersList = new List<Users>();

        public void AgregarUsuario(Users user)
        {
            usersList.Add(user);
        }

        public bool VerificarUsuario(Users user)
        {
            return usersList.Any(u => u.Nickname == user.Nickname && u.Password == user.Password);
        }
    }
}