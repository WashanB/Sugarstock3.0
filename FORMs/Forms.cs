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
            
            //maximized(estado);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            // Suscribirse a los eventos KeyPress de ambos TextBox
            TxtUser.KeyPress += TxtUser_KeyPress;
            TxtPassword.KeyPress += TxtPassword_KeyPress;
            Gestor_credenciales credenciales = new Gestor_credenciales();
            
        }
        

        public bool max;
        
        public void maximized(FormWindowState estate)
        {
            
            if (estate == FormWindowState.Maximized)
            {
                this.WindowState = estate;
            }
            else if (estate == FormWindowState.Normal)
            {
                this.WindowState= FormWindowState.Normal;
            }

        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void LblUser_Click(object sender, EventArgs e)
        {

        }

        private void BtnCreate_MouseHover(object sender, EventArgs e)
        {
            BtnLogin.ForeColor = Color.White;
            BtnLogin.BackColor = Color.Black;

        }

        private void BtnCreate_MouseLeave(object sender, EventArgs e)
        {
            BtnLogin.BackColor = Color.White;
            BtnLogin.ForeColor = Color.Black;
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
               
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                

                    
                
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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // Obtener el texto de los TextBox
            string usuario = TxtUser.Text;
            string contraseña = TxtPassword.Text;

            // Verificar que los campos no contengan los placeholders
            if (usuario != "Username:" && contraseña != "Password:")
            {
                // Crear una instancia de Gestor_credenciales
                Gestor_credenciales gestorCredenciales = new Gestor_credenciales();

                // Validar las credenciales
                if (gestorCredenciales.ValidarCredenciales(usuario, contraseña))
                {
                    AllProgram programstart = new AllProgram(this.WindowState, usuario);
                    GestorDeHistorial gestorDeHistorial = new GestorDeHistorial(usuario);
                    
                    gestorDeHistorial.CargarCarrito();
                    // Si las credenciales son válidas, abrir el nuevo formulario
                    programstart.Show(); // Muestra el nuevo formulario
                    this.Hide(); // Oculta el formulario de login actual
                    

                }
                else
                {
                    // Mensaje si las credenciales son incorrectas
                    IsIncorrect.Visible = true;
                    IsIncorrect.Text = "Credenciales incorrectas. Intenta de nuevo.";
                    TxtPassword.Text = "Password:";
                    TxtPassword.ForeColor = Color.LightGray;
                    TxtPassword.PasswordChar = (char)0;
                    TxtUser.Text = "Username:";
                    TxtUser.ForeColor = Color.LightGray;
                }
            }
            else
            {
                // Mensaje si los campos son inválidos
                IsIncorrect.Visible= true;
                IsIncorrect.Text = "Por favor, ingresa un nombre de usuario y una contraseña válidos.";
                TxtPassword.Text = "Password:";
                TxtPassword.ForeColor = Color.LightGray;
                TxtPassword.PasswordChar = (char)0;
                TxtUser.Text = "Username:";
                TxtUser.ForeColor = Color.LightGray;
            }

        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void BtnMAX_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register register = new Register(this.WindowState);
            register.Show();
            this.Hide();
        }
    }
}
