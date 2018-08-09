using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCoForm.Class
{
    public class clsVehiculo
    {
        public int VehiculoID
        {
            get;
            set;
        }

        public string NoEconomico
        {
            get;
            set;
        }

        public string Marca
        {
            get;
            set;
        }

        public string Modelo
        {
            get;
            set;
        }

        public int NoToneles
        {
            get;
            set;
        }

        public int Capacidad
        {
            get;
            set;
        }

        public List<clsVehiculo> FillList(DataTable dt)
        {
            //Creamos una lista de Categorias con la clave Categoria
            List<clsVehiculo> Vehiculo = new List<clsVehiculo>();
            IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;

            foreach (DataRow dr in query)
            {
                Vehiculo.Add
                    (new clsVehiculo()
                    {
                        VehiculoID = dr.Field<int>("VehiculoID"),
                        NoEconomico = dr.Field<string>("NoEconomico"),
                        Marca = dr.Field<string>("Marca"),
                        Modelo = dr.Field<string>("Modelo"),
                        NoToneles = dr.Field<int>("NoToneles"),
                        Capacidad = dr.Field<int>("Capacidad")
                    }
                    );

            }
            return Vehiculo;


        }
    }
}
