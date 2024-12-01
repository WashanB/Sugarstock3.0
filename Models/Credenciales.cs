using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SugarStock.Models
{
    [Serializable]
    internal class Credenciales
    {
        public string User { get; set ; }
        public string Password { get;set; }

        public Credenciales(string usuario, string contraseña)
        {
            if (string.IsNullOrWhiteSpace(usuario))
            {
                throw new ArgumentException("El usuario no puede estar vacío", nameof(usuario));
            }

            if (string.IsNullOrWhiteSpace(contraseña))
            {
                throw new ArgumentException("La contraseña no puede estar vacía", nameof(contraseña));
            }

            User = usuario;
            Password = contraseña;
        }

        

        public bool Textcorrect(int id , string password)
        {

          
            if (id == 1234 && password == "5678")
            {
                MessageBox.Show("WELCOME COSTUMER");
                return true;
            }
            else if(id == 0000 && password == "Admin00")
            {
                MessageBox.Show("WELCOME OWNER");
                return false;
            }
            else
            {
                MessageBox.Show("INVALID LOGIN");
                return false;
            }

    
        }
    }
}
