using SugarStock.Models;
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
        
        public ORDENAR(string nombre, string desc, string imagepath, double price, string user)
        {
            InitializeComponent();
            changeCont(nombre, desc, imagepath, price);
            GestorDeHistorial gestorDeHistorial = new GestorDeHistorial(user);
            carritos = gestorDeHistorial.CargarCarrito() ?? new List<Carritos>(); // Asegúrate de que carritos no sea null
            
            usuario = user;
            
        }
        int cant = 1;
        List<Carritos> carritos;
        string usuario;
        public void changeCont(string nombre, string desc, string imagepath, double price)
        {
            try
            {
                Namelb.Text = nombre;
                DescLB.Text = desc;
                PBimage.Image = Image.FromFile(imagepath);
                PriceLB.Text = $"{price}";
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
            // Obtener información del producto
            string nombreProducto = Namelb.Text; // Nombre del postre
            int cantidadP = int.Parse(CantLB.Text);
            double precioProducto = Double.Parse(PriceLB.Text);

            // Intentar obtener el precio y manejar posibles errores
            if (!double.TryParse(PriceLB.Text.Replace(" C$", "").Trim(), out precioProducto))
            {
                MessageBox.Show("Error al obtener el precio del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Intentar obtener la cantidad y manejar posibles errores
            else if (!int.TryParse(CantLB.Text, out cantidadP) || cantidadP <= 0)
            {
                MessageBox.Show("Por favor, selecciona una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else {
                Console.WriteLine($"theBook{usuario}");
                try
                {

                    // Obtener referencia al formulario Carrito
                    Carrito carritoForm = new Carrito(usuario);
                    Carritos cart = new Carritos();
                    cart.nombre = nombreProducto;
                    cart.precio = precioProducto;
                    cart.cantidad = cantidadP;
                    cart.total = precioProducto * cantidadP;
                    carritos.Add(cart);
                    carritoForm.cargarCarrito();
                    GestorDeHistorial gestorDeH = new GestorDeHistorial(usuario);
                    gestorDeH.guardarCarrito(carritos);
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
                }
            }

            // Si el carrito no está abierto, crear una nueva instancia
            //if (carritoForm == null)
            //{
            // carritoForm = new Carrito();
            //carritoForm.Show();
            // }

            // Agregar el producto al carrito
            //carritoForm.AgregarProducto(nombreProducto, precioProducto, cantidadP);

            // Mostrar un mensaje de confirmación
            MessageBox.Show($"Se han agregado {cantidadP} {nombreProducto}(s) correctamente al carrito",
                            "Confirmación",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            // Opcional: cerrar el formulario de orden o resetear la cantidad
            this.Close(); // Cierra el formulario de orden
        }

        private void Namelb_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
