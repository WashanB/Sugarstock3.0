using SugarStock.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SugarStock.FORMs
{
    public partial class Register : Form
    {
        public Register(FormWindowState estado)
        {
            InitializeComponent();
            this.WindowState = estado;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Forms forms = new Forms();
            //forms.maximized(this.WindowState);
            forms.Show();
            this.Hide();
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

        private void TxtConfirm_Enter(object sender, EventArgs e)
        {
            if (TxtConfirm.Text == "Confirm password:")
            {
                TxtConfirm.Text = "";
                TxtConfirm.ForeColor = Color.Black;
                TxtConfirm.PasswordChar = Convert.ToChar("•");
            }
        }

        private void TxtConfirm_Leave(object sender, EventArgs e)
        {
            if (TxtConfirm.Text == "")
            {
                TxtConfirm.Text = "Confirm password:";
                TxtConfirm.ForeColor = Color.LightGray;
                TxtConfirm.PasswordChar = (char)0;
                BtnlookpasCFM.IconColor = Color.White;
                BtnlookpasCFM.IconSize = 1;
                BtnlookpasCFM.Enabled = false;
            }
        }

        private void BtnlookpasCFM_Click(object sender, EventArgs e)
        {
            if (BtnlookpasCFM.Enabled == true)
            {
                if (TxtConfirm.PasswordChar == Convert.ToChar("•"))
                {
                    TxtConfirm.PasswordChar = (char)0;
                    BtnlookpasCFM.IconChar = FontAwesome.Sharp.IconChar.Eye;
                }
                else if (TxtConfirm.PasswordChar == (char)0)
                {
                    TxtConfirm.PasswordChar = Convert.ToChar("•");
                    BtnlookpasCFM.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                }
            }
        }

        private void TxtConfirm_TextChanged(object sender, EventArgs e)
        {
            bool isTextNotEmpty = !string.IsNullOrEmpty(TxtConfirm.Text);

            if (isTextNotEmpty)
            {
                BtnlookpasCFM.IconColor = Color.Black;
                BtnlookpasCFM.IconSize = 25;
                BtnlookpasCFM.Enabled = true;
            }

            else
            {
                BtnlookpasCFM.IconColor = Color.White;
                BtnlookpasCFM.IconSize = 1;
                BtnlookpasCFM.Enabled = false;
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (TxtPassword.Text == TxtConfirm.Text)
            {
                // Obtener el texto de los TextBox
                string usuario = TxtUser.Text;
                string contraseña = TxtPassword.Text;

                // Verificar que los campos no estén vacíos
                if (!string.IsNullOrWhiteSpace(usuario) && !string.IsNullOrWhiteSpace(contraseña))
                {
                    try
                    {
                        // Crear una instancia de Gestor_credenciales
                        Gestor_credenciales gestorCredenciales = new Gestor_credenciales();

                        // Crear un objeto de Credenciales
                        var nuevaCredencial = new Credenciales(usuario, contraseña);

                        // Guardar las credenciales
                        gestorCredenciales.GuardarCredenciales(nuevaCredencial);

                        // Informar al usuario que las credenciales se han guardado
                        IsIncorrect.Text = "Credenciales guardadas exitosamente.";
                        IsIncorrect.ForeColor = Color.Green;
                        IsIncorrect.Visible = true;
                        TxtConfirm.Clear();
                        TxtUser.Clear();
                        TxtPassword.Clear();

                        // Opcional: Cerrar el formulario de registro después de guardar
                        //this.Close();
                    }
                    catch (Exception ex)
                    {
                        // Manejo de excepciones en caso de error al guardar
                        System.Windows.Forms.MessageBox.Show($"Error al guardar las credenciales: {ex.Message}");
                    }
                }
                else
                {
                    // Mensaje si los campos son inválidos
                    IsIncorrect.Text = "Por favor, ingresa un nombre de usuario y una contraseña válidos.";
                    IsIncorrect.ForeColor = Color.Red;
                    IsIncorrect.Visible = true;
                }
            }
            else {
                IsIncorrect.Text = "The passwords are not the same";
                IsIncorrect.Visible = true;
            }
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
