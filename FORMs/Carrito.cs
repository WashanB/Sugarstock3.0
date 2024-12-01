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
    public partial class Carrito : Form
    {
        private PostresManager postresManager = new PostresManager();
       /// private Carrito carrito;

        public Carrito()
        {
            InitializeComponent();
            postresManager = new PostresManager(); // Inicializa el manager de postres
            //CargarPostres();
            InicializarDataGridView();
            //InicializarDataGridView(); // Llama a la función para inicializar el DataGridView

            // Conectar eventos de botones
            buttonEliminar.Click += buttonEliminar_Click;
            buttonConfirmar.Click += buttonConfirmar_Click;

            // Conectar el evento Load
            this.Load += Carrito_Load; // Asegúrate de que esta línea esté aquí si usas Carrito_Load
        }
        private void InicializarDataGridView()
        {
            dataGridViewCarrito.Columns.Clear();
            dataGridViewCarrito.Columns.Add("Id", "ID");
            dataGridViewCarrito.Columns.Add("Nombre", "Nombre");
            dataGridViewCarrito.Columns.Add("Descripcion", "Descripción");
            dataGridViewCarrito.Columns.Add("Precio", "Precio");
            dataGridViewCarrito.Columns.Add("Cantidad", "Cantidad");
            dataGridViewCarrito.Columns.Add("Total", "Total");
        }
        private void CargarPostres()
        {
            //dataGridViewCarrito.Rows.Clear(); // Limpia las filas existentes
            dataGridViewCarrito.DataSource = null;
            dataGridViewCarrito.DataSource = postresManager.Postres;
            /*foreach (var postre in postresManager.Postres)
            {
                // Agregar una nueva fila con los datos del postre
                dataGridViewCarrito.Rows.Add(postre.Id, postre.Nombre, postre.Descripcion, postre.Precio.ToString("C"), 1, postre.Precio.ToString("C")); // Asumimos cantidad 1
                dataGridViewCarrito.Columns["Cantidad"].ReadOnly = false; // Hacer que la columna de cantidad sea editable
            }*/

            //ActualizarTotal(); // Actualiza el total al cargar los postres
        }
        //private void ActualizarTotal()
        //{
        //    double total = 0;

        //    foreach (DataGridViewRow row in dataGridViewCarrito.Rows)
        //    {
        //        if (row.Cells["Precio"].Value != null && row.Cells["Cantidad"].Value != null)
        //        {
        //            double precio = Convert.ToDouble(row.Cells["Precio"].Value.ToString().Replace("C$", "").Trim());
        //            int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
        //            total += precio * cantidad; // Sumar el total
        //        }
        //    }

        //    LabelTotal.Text = $"Total: {total.ToString("C")}";
        //}
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewCarrito.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewCarrito.SelectedRows)
                {
                    dataGridViewCarrito.Rows.RemoveAt(row.Index); // Eliminar fila seleccionada
                }

                //ActualizarTotal(); // Actualizar el total después de eliminar
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

                    pedidoDetalles += $"{nombre} - Cantidad: {cantidad}, Total: {total.ToString("C")}\n";
                }
            }

            // Mostrar detalles del pedido y el total
            double totalFinal = Convert.ToDouble(LabelTotal.Text.Replace("Total: C$", "").Trim());
            pedidoDetalles += $"\nTotal a pagar: {totalFinal.ToString("C")}";

            // Aquí puedes implementar la lógica para guardar el pedido o enviarlo a una base de datos

            MessageBox.Show(pedidoDetalles, "Confirmación de Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar el carrito después de confirmar
            dataGridViewCarrito.Rows.Clear();
            LabelTotal.Text = "Total: C$0"; // Reiniciar el total

        }
       
        
        private void Carrito_Load(object sender, EventArgs e)
        {
            // Aquí puedes agregar cualquier lógica que necesites al cargar el formulario
            //CargarPostres(); // Puedes llamar a CargarPostres si es necesario
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
    }

  }




