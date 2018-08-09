using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCoForm.Class
{
    public class clsProducto
    {
        public int ProductoID
        {
            get;
            set;
        }

        public string Descripcion
        {
            get;
            set;
        }

        public double Precio
        {
            get;
            set;
        }

        public List<clsProducto> FillList(DataTable dt)
        {
            //Creamos una lista de Categorias con la clave Categoria
            List<clsProducto> Producto = new List<clsProducto>();
            IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;

            foreach (DataRow dr in query)
            {
                Producto.Add
                    (new clsProducto()
                    {
                        ProductoID = dr.Field<int>("ProductoID"),
                        Descripcion = dr.Field<string>("Descripcion"),
                        Precio = dr.Field<double>("Precio")                     
                    }
                    );

            }
            return Producto;


        }
    }
}
