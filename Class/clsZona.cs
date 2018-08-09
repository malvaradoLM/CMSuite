using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCoForm.Class
{
    public class clsZona
    {
        public int ZonaID
        {
            get;
            set;
        }

        public string Descripcion
        {
            get;
            set;
        }

        public List<clsZona> FillList(DataTable dt)
        {
            //Creamos una lista de Categorias con la clave Categoria
            List<clsZona> Zona = new List<clsZona>();
            IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;

            foreach (DataRow dr in query)
            {
                Zona.Add
                    (new clsZona()
                    {
                        ZonaID = dr.Field<int>("ZonaID"),
                        Descripcion = dr.Field<string>("Descripcion")
                    }
                    );

            }
            return Zona;


        }
    }
}
