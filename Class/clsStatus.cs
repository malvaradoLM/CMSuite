using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCoForm.Class
{
    public class clsStatus
    {
        public int StatusID
        {
            get;
            set;
        }

        public string Nombre
        {
            get;
            set;
        }

        public List<clsStatus> FillList(DataTable dt)
        {
            //Creamos una lista de Categorias con la clave Categoria
            List<clsStatus> Status = new List<clsStatus>();
            IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;

            foreach (DataRow dr in query)
            {
                Status.Add
                    (new clsStatus()
                    {
                        StatusID = dr.Field<int>("StatusID"),
                        Nombre = dr.Field<string>("Nombre")
                    }
                    );

            }
            return Status;


        }
    }
}
