using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCoForm.Class
{
    public class clsProductoIEPS
    {
        public int TerminalID { get; set; }
        public int ProductoIEPSID { get; set; }
        public double Precio { get; set; }
        public DateTime Fecha { get; set; }
        public double Producto87 { get; set; }
        public double Producto91 { get; set; }
        public double ProductoDiesel { get; set; }
        public int Producto87ID { get; set; }
        public int Producto91ID { get; set; }
        public int ProductoDieselID { get; set; }
        public double IEPS87 { get; set; }
        public double IEPS91 { get; set; }
        public double IEPSDiesel { get; set; }
        public int Ejercicio { get; set; }
        public int Periodo { get; set; }
        public int Dia { get; set; }
        public double IVA { get; set; }
        public int UsuarioID { get; set; }
    }
}
