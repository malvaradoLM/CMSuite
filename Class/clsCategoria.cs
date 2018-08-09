using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCoForm.Class
{
    public class clsCategoria
    {
        public int CategoriaID
        {
            get;
            set;
        }

        public string Descripcion
        {
            get;
            set;
        }

        public List<clsCategoria> FillList(DataTable dt)
        {
            //Creamos una lista de Categorias con la clave Categoria
            List<clsCategoria> Estacion = new List<clsCategoria>();
            IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;

            foreach (DataRow dr in query)
            {
                Estacion.Add
                    (new clsCategoria()
                    {
                        CategoriaID = dr.Field<int>("CategoriaID"),
                        Descripcion = dr.Field<string>("Descripcion")
                    }
                    );

            }
            return Estacion;


        }
    }
}
