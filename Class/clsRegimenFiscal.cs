using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCoForm.Class
{
    class clsRegimenFiscal
    {
        public int RegimenFiscalID
        {
            get;
            set;
        }

        public string Descripcion
        {
            get;
            set;
        }

        public string CodigoSAT
        {
            get;
            set;
        }

        public List<clsRegimenFiscal> FillList(DataTable dt)
        {
            //Creamos una lista de Categorias con la clave Categoria
            List<clsRegimenFiscal> Estacion = new List<clsRegimenFiscal>();
            IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;

            foreach (DataRow dr in query)
            {
                Estacion.Add
                    (new clsRegimenFiscal()
                    {
                        RegimenFiscalID = dr.Field<int>("RegimenFiscalID"),
                        Descripcion = dr.Field<string>("Descripcion"),
                        CodigoSAT = dr.Field<string>("CodigoSAT")
                    }
                    );

            }
            return Estacion;
            
        }


    }
}
