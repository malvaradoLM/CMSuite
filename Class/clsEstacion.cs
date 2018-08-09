using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCoForm.Class
{
    public class clsEstacion
    {
        public int EstacionID
        {
            get;
            set;
        }

        public string Nombre
        {
            get;
            set;
        }

        public List<clsEstacion> FillList(DataTable dt)
        {
            //Creamos una lista de Categorias con la clave Categoria
            List<clsEstacion> Estacion = new List<clsEstacion>();
            IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;

            foreach (DataRow dr in query)
            {
                Estacion.Add
                    (new clsEstacion()
                        {
                            EstacionID = dr.Field<int>("EstacionId"),
                            Nombre = dr.Field<string>("Nombre")
                        }
                    );

            }
            return Estacion;


        }
    }
}
