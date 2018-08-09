using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCoForm.Class
{
    public class clsUsuario
    {
        public int UsuarioID
        {
            get;
            set;
        }

        public string Nombre
        {
            get;
            set;
        }

        public List<clsUsuario> FillList(DataTable dt)
        {
            //Creamos una lista de Categorias con la clave Categoria
            List<clsUsuario> Usuario = new List<clsUsuario>();
            IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;

            foreach (DataRow dr in query)
            {
                Usuario.Add
                    (new clsUsuario()
                    {
                        UsuarioID = dr.Field<int>("UsuarioID"),
                        Nombre = dr.Field<string>("Nombre")
                    }
                    );

            }
            return Usuario;


        }
    }
}
