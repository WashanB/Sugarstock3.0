using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SugarStock.FORMs
{
    public partial class ORDENAR : Form
    {
        public ORDENAR(string nombre, string desc, string imagepath, double price)
        {
            InitializeComponent();
            changeCont(nombre, desc, imagepath, price);
        }
        int cant = 1;

        public void changeCont(string nombre, string desc, string imagepath, double price)
        {
            try
            {
                Namelb.Text = nombre;
                DescLB.Text = desc;
                PBimage.Image = Image.FromFile(imagepath);
                PriceLB.Text = $"{price} C$";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.Parse(CantLB.Text) > 0)
            {
                Lesscant.Enabled = true;
            }
            cant = int.Parse(CantLB.Text);
            cant += 1;
            CantLB.Text  = cant.ToString();
            
        }

        private void Lesscant_Click(object sender, EventArgs e)
        {
            if (int.Parse(CantLB.Text) < 2) { 
                Lesscant.Enabled=false;
            }
            else
            {
                int cant = int.Parse(CantLB.Text);
                cant -= 1;
                CantLB.Text = cant.ToString();
            }
            
        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PBimage_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCart_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Se han agregado {cant} productos correctamente al carrito");
        }

        private void Namelb_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
