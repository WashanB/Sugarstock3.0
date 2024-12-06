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
       

    }
}
