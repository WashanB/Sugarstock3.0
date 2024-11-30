using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SugarStock.Models
{
    internal class Credenciales
    {
     
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
