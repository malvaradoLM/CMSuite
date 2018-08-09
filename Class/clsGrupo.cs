using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCoForm.Class
{
    public class clsGrupo
    {
        public int GrupoID
        {
            get;
            set;
        }

        public string Descripcion
        {
            get;
            set;
        }

        public List<clsGrupo> FillList(DataTable dt)
        {
            //Creamos una lista de Categorias con la clave Categoria
            List<clsGrupo> Grupo = new List<clsGrupo>();
            IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;

            foreach (DataRow dr in query)
            {
                Grupo.Add
                    (new clsGrupo()
                    {
                        GrupoID = dr.Field<int>("GrupoID"),
                        Descripcion = dr.Field<string>("Descripcion")
                    }
                    );

            }
            return Grupo;


        }
    }
}
