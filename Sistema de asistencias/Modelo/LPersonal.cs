using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_asistencias.Modelo
{

    public class LPersonal
    {
        public int idPersonal { get; set; }
        public String nombre{ get; set; }
        public String identificacion { get; set; }
        public String pais { get; set; }
        public int idCargo { get; set; }
        public double sueldoPorHora{ get; set; }
        public String estado { get; set; }
        public String codigo { get; set; }
    }
}
