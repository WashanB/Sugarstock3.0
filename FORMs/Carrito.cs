using SugarStock.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SugarStock.FORMs
{
    public partial class Carrito : Form
    {
        private PostresManager postresManager = new PostresManager();
        
       /// private Carrito carrito;

        public Carrito(string user)
        {
            GestorDeHistorial gestorDeHistorial = new GestorDeHistorial(user);
            CarritoList = gestorDeHistorial.CargarCarrito();
            InitializeComponent();
            postresManager = new PostresManager(); // Inicializa el manager de postres
            //CargarPostres();
            //InicializarDataGridView();
            string usua = user;
            // Llama a la función para inicializar el DataGridView

            // Conectar eventos de botones
            buttonEliminar.Click += buttonEliminar_Click;
            buttonConfirmar.Click += buttonConfirmar_Click;

            // Conectar el evento Load
            this.Load += Carrito_Load; // Asegúrate de que esta línea esté aquí si usas Carrito_Load
        }
        List<Carritos> CarritoList;
        string usua;
        private void InicializarDataGridView()
        {
            dataGridViewCarrito.Columns.Clear();
            dataGridViewCarrito.Columns.Add("nombre", "nombre");
            dataGridViewCarrito.Columns.Add("precio", "precio");
            dataGridViewCarrito.Columns.Add("cantidad", "pantidad");
            dataGridViewCarrito.Columns.Add("total", "total");
        }

        public void cargarCarrito()
        {
            GestorDeHistorial gestorDeHistorial = new GestorDeHistorial(usua);
            CarritoList = gestorDeHistorial.CargarCarrito();
        }
        private void CargarPostres()
        {
            //dataGridViewCarrito.Rows.Clear(); // Limpia las filas existentes
            dataGridViewCarrito.DataSource = null;
            dataGridViewCarrito.DataSource = postresManager.Postres;
            
        }


        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewCarrito.SelectedRows.Count > 0)
            {
                // Crear una lista para almacenar los índices de las filas a eliminar
                List<int> rowsToDelete = new List<int>();

                // Recorrer las filas seleccionadas y almacenar los índices
                foreach (DataGridViewRow row in dataGridViewCarrito.SelectedRows)
                {
                    if (!row.IsNewRow) // Verificar que no sea una nueva fila
                    {
                        rowsToDelete.Add(row.Index);
                    }
                }

                // Eliminar las filas en orden inverso para evitar problemas de índice
                for (int i = rowsToDelete.Count - 1; i >= 0; i--)
                {
                    dataGridViewCarrito.Rows.RemoveAt(rowsToDelete[i]);
                }

                // Actualizar total después de eliminar
                // ActualizarTotal(); 
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un postre para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (dataGridViewCarrito.Rows.Count == 0)
            {
                MessageBox.Show("No hay postres en el carrito para confirmar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Aquí puedes implementar la lógica para procesar el pedido
            string pedidoDetalles = "Detalles del pedido:\n";

            foreach (DataGridViewRow row in dataGridViewCarrito.Rows)
            {
                if (row.Cells["Nombre"].Value != null)
                {
                    string nombre = row.Cells["Nombre"].Value.ToString();
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    double precio = Convert.ToDouble(row.Cells["Precio"].Value.ToString().Replace("C$", "").Trim());
                    double total = cantidad * precio;

                    pedidoDetalles += $"{nombre} - Cantidad: {cantidad}, Total: {total.ToString("C", CultureInfo.CurrentCulture)}\n";
                }
            }

            // Validar el contenido de LabelTotal
            double totalFinal = 0;
            try
            {
                totalFinal = Convert.ToDouble(LabelTotal.Text.Replace("Total: C$", "").Trim());
            }
            catch (FormatException)
            {
                MessageBox.Show("El total no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pedidoDetalles += $"\nTotal a pagar: {totalFinal.ToString("C", CultureInfo.CurrentCulture)}";

            // Aquí puedes implementar la lógica para guardar el pedido o enviarlo a una base de datos

            MessageBox.Show(pedidoDetalles, "Confirmación de Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar el carrito después de confirmar
            dataGridViewCarrito.Rows.Clear();
            LabelTotal.Text = "Total: C$0"; // Reiniciar el total
        }


        private void Carrito_Load(object sender, EventArgs e)
        {
            dataGridViewCarrito.DataSource = CarritoList;
        }

      
            private void dataGridViewCarrito_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewCarrito.Columns["Cantidad"].Index)
            {
                try
                {
                    int cantidad = Convert.ToInt32(dataGridViewCarrito.Rows[e.RowIndex].Cells["Cantidad"].Value);
                    if (cantidad < 0) throw new Exception("La cantidad no puede ser negativa.");

                    double precio = Convert.ToDouble(dataGridViewCarrito.Rows[e.RowIndex].Cells["Precio"].Value.ToString().Replace("C$", "").Trim());
                    dataGridViewCarrito.Rows[e.RowIndex].Cells["Total"].Value = (cantidad * precio).ToString("C");
                    //ActualizarTotal();
                }
                catch
                {
                    MessageBox.Show("Por favor, ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridViewCarrito.Rows[e.RowIndex].Cells["Cantidad"].Value = 1; // Revertir a un valor predeterminado
                }
            }
        }
        

        private void dataGridViewCarrito_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void LabelTotal_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        internal void AgregarProducto(string nombreProducto, double precioProducto, int cantidadProducto)
        {
            dataGridViewCarrito.Rows.Add(nombreProducto,precioProducto, cantidadProducto, (precioProducto*cantidadProducto ));
            Carritos cart = new Carritos();
            cart.nombre = nombreProducto;
            cart.precio = precioProducto;
            cart.cantidad = cantidadProducto;
            cart.total = precioProducto * cantidadProducto;
            CarritoList.Add(cart);
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

  }




