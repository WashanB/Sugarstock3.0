using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using SugarStock;

namespace SugarStock.Models
{
    internal class GestorDeHistorial
    {
        public GestorDeHistorial(string usuario) {
            Archivo = $"{usuario}_Cart.bin";
            if (!File.Exists(Archivo))
            {
                using (FileStream fs = File.Create(Archivo))
                {

                }
            }
        }
        string Archivo;


        public void guardarCarrito(List<Carritos> Cart)
        {
            using (FileStream fs = new FileStream(Archivo, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, Cart);
            }

        }

        public List<Carritos> CargarCarrito()
        {

            if (!File.Exists(Archivo))
            {
                return new List<Carritos>(); // Retorna una lista vacía si el archivo no existe
            }

            using (FileStream fs = new FileStream(Archivo, FileMode.Open))
            {
                // Verifica si el archivo está vacío antes de deserializar
                if (fs.Length == 0)
                {
                    return new List<Carritos>(); // Retorna una lista vacía si el archivo está vacío
                }

                BinaryFormatter formatter = new BinaryFormatter();
                return (List<Carritos>)formatter.Deserialize(fs);
            }


        }
       
        public void ActualizarCarrito(List<Carritos> cart)
        {
            // Sobrescribir el archivo binario con una lista vacía
            using (FileStream fs = new FileStream(Archivo, FileMode.Create))
            {
                // No escribir nada para dejar el archivo vacío
            }
            
        }
        public void EliminarItemDelCarrito(string nombre)
        {
            // Cargar el carrito actual desde el archivo
            List<Carritos> carrito = CargarCarrito();

            // Buscar el ítem a eliminar por su ID
            var itemAEliminar = carrito.FirstOrDefault(i => i.nombre == nombre);

            if (itemAEliminar != null)
            {
                // Eliminar el ítem de la lista
                carrito.Remove(itemAEliminar);

                // Guardar los cambios en el archivo
                if (carrito.Count == 0)
                {
                    // Si el carrito queda vacío, eliminar el archivo
                    if (File.Exists(Archivo))
                    {
                        File.Delete(Archivo);
                    }
                }
                else
                {
                    // Sobrescribir el archivo con los datos actualizados
                    guardarCarrito(carrito);
                }
            }
            else
            {
                // Manejo de caso donde el ítem no se encuentra
                Console.WriteLine("El ítem no se encontró en el carrito.");
            }
        }
        


    }
}
