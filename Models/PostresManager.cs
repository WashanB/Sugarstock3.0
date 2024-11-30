using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SugarStock
{
    [Serializable] // Asegúrate de que la clase Postres sea serializable
    public class Postres
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }

        public Postres(int id, string nombre, string descripcion, double precio)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
        }
    }

    internal class PostresManager
    {
        private string filePath = "postres.bin";
        public List<Postres> Postres { get; private set; }

        public PostresManager()
        {
            Postres = CargarPostres();
            if (Postres.Count == 0)
            {
                InicializarPostresPorDefecto();
            }
        }

        // Método para guardar postres en un archivo binario
        public void GuardarPostres()
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, Postres);
            }
        }

        private void InicializarPostresPorDefecto()
        {
            Postres = new List<Postres>
            {
                new Postres(1, "Créme brulée", "El crème brûlée es un postre francés clásico que se caracteriza por su base cremosa y su capa superior de caramelo crujiente. Es un postre perfecto para cualquier ocasión, ya que es elegante, delicioso y fácil de preparar.", 150),
                new Postres(2, "Tiramisú", "Postre italiano, compuesto por capas de bizcocho empapado en café, intercaladas con una crema suave y cremosa a base de queso mascarpone, huevos y azúcar. Se suele espolvorear con cacao en polvo.", 180),
                new Postres(3, "Brownie", "Tiene una textura densa y húmeda, con un sabor intenso a chocolate. Su consistencia puede variar entre un centro más jugoso y un exterior ligeramente crujiente. Se suele preparar con chocolate, mantequilla, azúcar, huevos, harina y a menudo nueces.", 180),
                new Postres(4,"Alfajores", "El alfajor es un dulce tradicional de América Latina y España, compuesto por dos capas de masa suave rellenas de dulce de leche y, a menudo, cubierto con chocolate o azúcar glas. Se disfruta especialmente en festividades y tiene varias variantes regionales.",200),
                new Postres(5, "Imposible", "El imposible es un postre tradicional de América Latina, similar a un flan, hecho con capas de caramelo y una mezcla de leche, azúcar, huevos y vainilla. Su textura es suave y cremosa, y se caracteriza por su sabor dulce y su presentación en capas, con el caramelo en la base que se convierte en un delicioso sirope.", 350),
                new Postres(6, "Galletas decoradas", "Galletas de vainilla con decoraciones de todo tipo, haz brillar tu imaginacion con estas deliciosas galletas que te llevaran a mundos increibles e imaginarios. Ahora al alcance de tu paladar.", 50)
            };

            // Guardar los postres por defecto en el archivo binario
            GuardarPostres();
            Console.WriteLine("Postres por defecto guardados exitosamente.");
        }

        // Método para cargar postres desde un archivo binario
        public List<Postres> CargarPostres()
        {
            if (!File.Exists(filePath))
            {
                return new List<Postres>(); // Devuelve una lista vacía si el archivo no existe
            }

            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (List<Postres>)formatter.Deserialize(stream);
            }
        }
    }
}