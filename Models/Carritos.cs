using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SugarStock.Models
{
    [Serializable]
    internal class Carritos
    {
        public string nombre { get; set; }  
        public int cantidad { get; set; }
        public double precio { get; set; }
        public double total { set; get; }   
        






    }

}
