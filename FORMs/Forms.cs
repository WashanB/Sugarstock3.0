using SugarStock.FORMs;
using SugarStock.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace SugarStock
{
    public partial class Forms : Form
    {
        public Forms()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            // Suscribirse a los eventos KeyPress de ambos TextBox
            TxtUser.KeyPress += TxtUser_KeyPress;
            TxtPassword.KeyPress += TxtPassword_KeyPress;
        }


        Credenciales credenciales = new Credenciales();
        
        AllProgram programstart = new AllProgram();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtUser.Text);
            string password  = TxtPassword.Text;
            this.Hide();


            if (credenciales.Textcorrect(id, password) == true)
            {
                programstart.Show();
                this.Hide();
            }
            else if (id == 0000 && password == "Admin00")
            {
               // Owner Menuowner = new Owner(); 
                //Menuowner.Show();
                this.Hide(); 
            }




        }

        private void LblUser_Click(object sender, EventArgs e)
        {

        }

        private void BtnCreate_MouseHover(object sender, EventArgs e)
        {
            BtnCreate.ForeColor = Color.White;
            BtnCreate.BackColor = Color.Black;

        }

        private void BtnCreate_MouseLeave(object sender, EventArgs e)
        {
            BtnCreate.BackColor = Color.White;
            BtnCreate.ForeColor = Color.Black;
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            bool isTextNotEmpty = !string.IsNullOrEmpty(TxtPassword.Text);

            if (isTextNotEmpty)
            {
                btnlookpass.IconColor = Color.Black;
                btnlookpass.IconSize = 25;
                btnlookpass.Enabled = true;
            }

            else
            {
                btnlookpass.IconColor = Color.White;
                btnlookpass.IconSize = 1;
                btnlookpass.Enabled = false;
            }

        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUser_Enter(object sender, EventArgs e)
        {
            if (TxtUser.Text == "Username:")
            {
                TxtUser.Text = "";
                TxtUser.ForeColor = Color.Black;
            }
        }

        private void TxtUser_Leave(object sender, EventArgs e)
        {
            if (TxtUser.Text == "")
            {
                TxtUser.Text = "Username:";
                TxtUser.ForeColor = Color.LightGray;
            }
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "Password:")
            {
                TxtPassword.Text = "";
                TxtPassword.ForeColor = Color.Black;
                TxtPassword.PasswordChar = Convert.ToChar("•");

            }

        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "")
            {
                TxtPassword.Text = "Password:";
                TxtPassword.ForeColor = Color.LightGray;
                TxtPassword.PasswordChar = (char)0;
                btnlookpass.IconColor = Color.White;
                btnlookpass.IconSize = 1;
                btnlookpass.Enabled = false;

            }
        }

        private void btnlookpass_Click(object sender, EventArgs e)
        {
            if (btnlookpass.Enabled == true)
            {
                if (TxtPassword.PasswordChar == Convert.ToChar("•"))
                {
                    TxtPassword.PasswordChar = (char)0;
                    btnlookpass.IconChar = FontAwesome.Sharp.IconChar.Eye;
                }
                else if (TxtPassword.PasswordChar == (char)0)
                {
                    TxtPassword.PasswordChar = Convert.ToChar("•");
                    btnlookpass.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                }
            }
        }

        private void Ocultarpass()
        {
            if (TxtPassword.PasswordChar == (char)0)
            {
                TxtPassword.PasswordChar = Convert.ToChar("•");
                btnlookpass.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else if (TxtPassword.PasswordChar == Convert.ToChar("•"))
            {
                TxtPassword.PasswordChar = (char)0;
            }
        }

        private void TxtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si se presionó la tecla de espacio
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Si textBox2 está vacío, evitar la entrada del espacio
                if (string.IsNullOrWhiteSpace(TxtPassword.Text))
                {
                    e.Handled = true; // Evitar que se ingrese el espacio
                    
                }
                else if (!string.IsNullOrWhiteSpace(TxtUser.Text) && !string.IsNullOrWhiteSpace(TxtPassword.Text))
                {
                    int id = int.Parse(TxtUser.Text);
                    string password = TxtPassword.Text;
                    


                    if (credenciales.Textcorrect(id, password) == true)
                    {
                        programstart.Show();
                        this.Hide();
                    }
                    else if (id == 0000 && password == "Admin00")
                    {
                       // Owner Menuowner = new Owner();
                       // Menuowner.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Si textBox1 está vacío, evitar la entrada del Enter
                if (string.IsNullOrWhiteSpace(TxtUser.Text))
                {
                    e.Handled = true; // Evitar que se ingrese el Enter
                    
                }
                else if (!string.IsNullOrWhiteSpace(TxtUser.Text) && !string.IsNullOrWhiteSpace(TxtPassword.Text))
                {
                    int id = int.Parse(TxtUser.Text);
                    string password = TxtPassword.Text;
                    


                    if (credenciales.Textcorrect(id, password) == true)
                    {
                        programstart.Show();
                        this.Hide();
                    }
                    else if (id == 0000 && password == "Admin00")
                    {
                      //  Owner Menuowner = new Owner();
                        //Menuowner.Show();
                        this.Hide();
                    }

                    
                }
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void HeaderPANEL_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
