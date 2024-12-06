using SugarStock.Models;
using SugarStock.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SugarStock.FORMs
{
    public partial class Menu_principal : Form
    {
       
        private AllProgram mainForm;

        public Menu_principal(AllProgram mainForm, string user)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            usuario = user;
        }
        string usuario;
       
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string pname = "Pan de Banano";
            string pdesc = "Clásico de la repostería casera, conocido por su sabor dulce y su textura húmeda y esponjosa. Se elabora con bananas maduras, que aportan un dulzor natural y una textura única. ";
            string image = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "images 3.png");
            double pprice = 120;
            

            // Abre el formulario ORDENAR pasando los datos necesarios
            mainForm.OpenChildForm(new ORDENAR(pname, pdesc, image, pprice, usuario));
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string pname = "Cheesecake";
            string pdesc = "Un postre cremoso y delicioso, hecho a base de queso , huevos, azúcar y una base crujiente, normalmente de galletas trituradas. Su textura suave y su sabor ligeramente ácido lo convierten en un postre muy popular en todo el mundo";
            string image = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "images 4.png");
            double pprice = 200;
            

            // Abre el formulario ORDENAR pasando los datos necesarios
            mainForm.OpenChildForm(new ORDENAR(pname, pdesc, image, pprice,usuario));
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string pname = "Suspiros";
            string pdesc = "Son pequeños bocados de aire puro, ligeros y dulces. Se elaboran principalmente con claras de huevo batidas a punto de nieve y azúcar glasé. Su textura es crujiente por fuera y suave por dentro, con un sabor dulce y delicado";
            string image = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Merengue-Frances-Receta-6 1.png");
            double pprice = 40;
            

            // Abre el formulario ORDENAR pasando los datos necesarios
            mainForm.OpenChildForm(new ORDENAR(pname, pdesc, image, pprice, usuario));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string pname = "Brownie";
            string pdesc = "Tiene una textura densa y húmeda, con un sabor intenso a chocolate. Su consistencia puede variar entre un centro más jugoso y un exterior ligeramente crujiente. Se suele preparar con chocolate, mantequilla, azúcar, huevos, harina y a menudo nueces.";
            string image = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "brownies-de-chocolate-2 1.png");
            double pprice = 180;
            

            // Abre el formulario ORDENAR pasando los datos necesarios
            mainForm.OpenChildForm(new ORDENAR(pname, pdesc, image, pprice, usuario));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string pname = "Tiramisú";
            string pdesc = " Postre italiano, compuesto por capas de bizcocho empapado en café, intercaladas con una crema suave y cremosa a base de queso mascarpone, huevos y azúcar. Se suele espolvorear con cacao en polvo.";
            string image = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "image 6.png");
            double pprice = 180;
            

            // Abre el formulario ORDENAR pasando los datos necesarios
            mainForm.OpenChildForm(new ORDENAR(pname, pdesc, image, pprice, usuario));

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string pname = "Créme brulée";
            string pdesc = "El crème brûlée es un postre francés clásico que se caracteriza por su base cremosa y su capa superior de caramelo crujiente. Es un postre perfecto para cualquier ocasión, ya que es elegante, delicioso y fácil de preparar";
            //string image = "C:\\Users\\carlo\\OneDrive\\Music\\PROYECTO METODLOGIA\\SugarStock\\Resources\\images11.png";
            string image = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "images11.png");
            double pprice = 150;
            

            // Abre el formulario ORDENAR pasando los datos necesarios
            mainForm.OpenChildForm(new ORDENAR(pname, pdesc, image, pprice, usuario));
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string pname = "Alfajores";
            string pdesc = "El alfajor es un dulce tradicional de América Latina y España, compuesto por dos capas de masa suave rellenas de dulce de leche y, a menudo, cubierto con chocolate o azúcar glas. Se disfruta especialmente en festividades y tiene varias variantes regionales.";
            string image = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Untitled 1.png");
            double pprice = 200;
            

            // Abre el formulario ORDENAR pasando los datos necesarios
            mainForm.OpenChildForm(new ORDENAR(pname, pdesc, image, pprice, usuario));
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            string pname = "Imposible";
            string pdesc = "El imposible es un postre tradicional de América Latina, similar a un flan, hecho con capas de caramelo y una mezcla de leche, azúcar, huevos y vainilla. Su textura es suave y cremosa, y se caracteriza por su sabor dulce y su presentación en capas, con el caramelo en la base que se convierte en un delicioso sirope.";
            string image = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Untitled 2.png");
            double pprice = 350;
            

            // Abre el formulario ORDENAR pasando los datos necesarios
            mainForm.OpenChildForm(new ORDENAR(pname, pdesc, image, pprice, usuario));



        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            string pname = "Galletas decoradas";
            string pdesc = "Galletas de vainilla con decoraciones de todo tipo, haz brillar tu imaginacion con estas deliciosas galletas que te llevaran a mundos increibles e imaginarios. Ahora al alcance de tu paladar.";
            string image = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Cook");
            double pprice = 50;
            

            // Abre el formulario ORDENAR pasando los datos necesarios
            mainForm.OpenChildForm(new ORDENAR(pname, pdesc, image, pprice, usuario));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}