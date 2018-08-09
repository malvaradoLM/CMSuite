using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCoForm.Class
{
    public class clsTerminal
    {
        public int TerminalID
        {
            get;
            set;
        }

        public string Descripcion
        {
            get;
            set;
        }

        public List<clsTerminal> FillList(DataTable dt)
        {
            //Creamos una lista de Categorias con la clave Categoria
            List<clsTerminal> Terminal = new List<clsTerminal>();
            IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;

            foreach (DataRow dr in query)
            {
                Terminal.Add
                    (new clsTerminal()
                    {
                        TerminalID = dr.Field<int>("TerminalID"),
                        Descripcion = dr.Field<string>("Descripcion")
                    }
                    );

            }
            return Terminal;


        }
    }
}
