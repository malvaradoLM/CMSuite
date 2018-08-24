using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCoForm.Class
{
    class clsTransportista
    {




        public int TransportistaID
        {
            get;
            set;
        }

        public string Nombre
        {
            get;
            set;
        }

        public List<clsTransportista> FillList(DataTable dt)
        {
            //Creamos una lista de Categorias con la clave Categoria
            List<clsTransportista> Estacion = new List<clsTransportista>();
            IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;

            foreach (DataRow dr in query)
            {
                Estacion.Add
                    (new clsTransportista()
                    {
                        TransportistaID = dr.Field<int>("TransportistaID"),
                        Nombre = dr.Field<string>("Nombre")
                    }
                    );

            }
            return Estacion;


        }
    

    }
}
