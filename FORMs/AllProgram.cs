using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using FontAwesome.Sharp;
using SugarStock.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SugarStock.FORMs
{
    public partial class AllProgram : Form
    {
        private IconButton currentBtn;
        private System.Windows.Forms.Panel leftBorderBtn;
        private Form currentChildForm;
        private PostresManager postresManager;
        
        public AllProgram(FormWindowState estado,string usuario)
        {
            InitializeComponent();
            user = usuario;
            leftBorderBtn = new System.Windows.Forms.Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelAside.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            postresManager = new PostresManager();
            this.WindowState = estado;
        }

        string user;
        
        private struct Colors
        {
            public static Color color1 = Color.FromArgb(162,18,47);
            public static Color color2 = Color.FromArgb(128, 179, 255);
            public static Color color3 = Color.FromArgb(105, 55, 38);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(188, 143, 143);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                IconRef.IconChar = currentBtn.IconChar;
                TabName.Text = currentBtn.Text;
                IconRef.IconColor = color;
            }
        }
        private void DisableButton() {
            if (currentBtn != null) {
                currentBtn.BackColor = Color.Transparent;
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        public void OpenChildForm(Form childForm)
        {
            // Cierra el formulario hijo actual si existe
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;

            // Configura el nuevo formulario hijo
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Agrega el formulario hijo al panel
            Fillpanel.Controls.Add(childForm);
            Fillpanel.Tag = childForm;

            // Muestra el formulario hijo
            childForm.BringToFront();
            childForm.Show();
        }
        private void AccountBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Colors.color1);
            OpenChildForm(new idk());
        }

        private void CartBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Colors.color2);
            OpenChildForm(new Carrito(user));
        }

        private void ProductsBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Colors.color3);
            OpenChildForm(new Menu_principal(this, user));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reset();
            leftBorderBtn.Visible = false;
            IconRef.IconChar = IconChar.Home;
            TabName.Text = "Home";
            IconRef.IconColor = Color.Black;
        }

        private void Reset()
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            DisableButton();
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Headerpanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaxBtn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void TabName_Click(object sender, EventArgs e)
        {

        }

        private void Fillpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
