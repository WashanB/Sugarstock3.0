using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SugarStock.Models
{
    internal class Gestor_credenciales
    {
        private string archivo = "credenciales.bin";

        public Gestor_credenciales()
        {
            InicializarCredencialesPorDefecto();
        }

        public void GuardarCredenciales(Credenciales credenciales)
        {
            List<Credenciales> listaCredenciales = CargarCredenciales();
            listaCredenciales.Add(credenciales);

            using (FileStream fs = new FileStream(archivo, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, listaCredenciales);
            }
        }

        public List<Credenciales> CargarCredenciales()
        {
            
            if (!File.Exists(archivo))
            {
                return new List<Credenciales>();
            }

            using (FileStream fs = new FileStream(archivo, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (List<Credenciales>)formatter.Deserialize(fs);
            }
        }
        public bool ValidarCredenciales(string usuario, string contraseña)
        {
            List<Credenciales> listaCredenciales = CargarCredenciales();
            foreach (var credencial in listaCredenciales)
            {
                if (credencial.User == usuario && credencial.Password == contraseña)
                {
                    return true;
                }
            }
            return false;
        }
        private void InicializarCredencialesPorDefecto()
        {
            if (!File.Exists(archivo))
            {
                List<Credenciales> listaCredenciales = new List<Credenciales>
                {
                    new Credenciales("1234", "5678"),
                    new Credenciales("0000", "Admin00")
                };

                using (FileStream fs = new FileStream(archivo, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, listaCredenciales);
                }
            }
        }
    }
}
