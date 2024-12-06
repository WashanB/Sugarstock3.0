using Microsoft.Reporting.WinForms;
using SugarStock.DataSet;
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
        private BindingList<Carritos> bindingList;
        List<Carritos> CarritoList;

        /// private Carrito carrito;

        public Carrito(string user)
        {
            GestorDeHistorial gestorDeHistorial = new GestorDeHistorial(user);
            CarritoList = gestorDeHistorial.CargarCarrito();
            InitializeComponent();
            bindingList = new BindingList<Carritos>(CarritoList);
            postresManager = new PostresManager(); // Inicializa el manager de postres
            //CargarPostres();
            //InicializarDataGridView();
            usua = user;
            // Llama a la función para inicializar el DataGridView

            // Conectar eventos de botones
            buttonEliminar.Click += buttonEliminar_Click;
            buttonConfirmar.Click += buttonConfirmar_Click;
            dataGridViewCarrito.DataSource = bindingList;
            // Conectar el evento Load
            this.Load += Carrito_Load; // Asegúrate de que esta línea esté aquí si usas Carrito_Load
        }
        
        

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
                GestorDeHistorial gestor = new GestorDeHistorial(usua);
                // Crear una lista para almacenar los elementos a eliminar
                List<Carritos> itemsToDelete = new List<Carritos>();

                // Recorrer las filas seleccionadas y agregar los elementos correspondientes a la lista
                foreach (DataGridViewRow row in dataGridViewCarrito.SelectedRows)
                {
                    if (!row.IsNewRow) // Asegurarse de que no sea una nueva fila
                    {
                        // Obtener el elemento correspondiente del BindingList
                        Carritos item = (Carritos)row.DataBoundItem;
                        itemsToDelete.Add(item);
                    }
                }

                // Eliminar los elementos de la BindingList y de CarritoList
                foreach (var item in itemsToDelete)
                {
                    bindingList.Remove(item); // Esto actualizará automáticamente el DataGridView
                    CarritoList.Remove(item);
                    gestor.EliminarItemDelCarrito(item.nombre); // Asegúrate de que EliminarItemDelCarrito acepte el ID
                }

                // Actualizar el archivo del carrito después de eliminar
                gestor.guardarCarrito(CarritoList);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un ítem para eliminar.");
            }
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (CarritoList.Count == 0)
            {
                MessageBox.Show("No hay postres en el carrito para confirmar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Preparar detalles del pedido
            string pedidoDetalles = "Detalles del pedido:\n";
            double totalFinal = 0;

            foreach (var item in bindingList)
            {
                pedidoDetalles += $"{item.nombre} - Cantidad: {item.cantidad}, Total: {item.total.ToString("C", CultureInfo.CurrentCulture)}\n";
                totalFinal += item.total;
            }

            pedidoDetalles += $"\nTotal a pagar: {totalFinal.ToString("C", CultureInfo.CurrentCulture)}";

            MessageBox.Show(pedidoDetalles, "Confirmación de Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar el carrito después de confirmar
            bindingList.Clear(); // Esto actualizará automáticamente el DataGridView
            CarritoList.Clear(); // Limpiar la lista de carrito

            // Actualizar el archivo del carrito (eliminarlo ya que está vacío)
            GestorDeHistorial gestor = new GestorDeHistorial(usua);
            gestor.ActualizarCarrito(CarritoList); // Asegúrate de que este método elimine todos los datos del archivo

        }


        private void Carrito_Load(object sender, EventArgs e)
        {
            
                dataGridViewCarrito.DataSource = bindingList; // Vincula el DataGridView a la BindingList
            
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

        private void BtnRport_Click(object sender, EventArgs e)
        {
          
            ReportDataSource dataSource = new ReportDataSource("DsCart", bindingList);

            FrmReportes frm = new FrmReportes();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(dataSource);
            // Configurar el archivo de reporte
            frm.reportViewer1.LocalReport.ReportEmbeddedResource =
                        "SugarStock.Reportes.RptCarrito.rdlc";
            frm.reportViewer1.RefreshReport();
            frm.ShowDialog();
            
        }
    }
}

  




