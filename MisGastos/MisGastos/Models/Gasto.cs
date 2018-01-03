using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MisGastos.Models
{
    public class Gasto
    {
        public int ID { get; set; }
        public double Monto { get; set; }
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
    }
}
