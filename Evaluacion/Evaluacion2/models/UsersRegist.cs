using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion2.models
{
    //Programa para lleavr registro de 100 usuarios donde se
    //le pide su nickname y contraseña para mostrar si esta verificado
    internal class UserRegistry
    {
        User[] users = new User[25];

        public void AgregarUsuario(User user, int pos)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));
            if (pos < 0 || pos >= users.Length)
                throw new ArgumentOutOfRangeException(nameof(pos));

            users[pos] = user;
        }

        public bool VerificarUsuario(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            for (int i = 0; i < users.Length; i++)
            {
                if (users[i] != null)
                {
                    if (users[i].Nickname == user.Nickname &&
                        users[i].Password == user.Password)
                    {
                        return true; // Indica usuario registrado
                    }
                }
            }
            return false;
        }

        internal bool VerificarUsuario(Users user)
        {
            throw new NotImplementedException();
        }
    }

    internal class User
    {
        public string Nickname { get; set; }
        public string Password { get; set; }
    }
}