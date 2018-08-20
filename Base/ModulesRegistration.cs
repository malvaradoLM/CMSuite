using RedCoForm.Forms.Catalogos;
using RedCoForm.Forms.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCoForm.Base
{
        // Clase global de modulos registrados
        public class ModulesRegistration

        {
            // Regitrar aqui todos los modulos 
            static public void Register()
            {
            ModuleInfoCollection.Add("CatalogoPedido", typeof(Forms.Catalogos.frmCatPedido));
            ModuleInfoCollection.Add("CatalogoEstacion", typeof(Forms.Catalogos.frmCatEstaciones));
            ModuleInfoCollection.Add("CatalogoVehiculo", typeof(Forms.Catalogos.frmCatVehiculo));
            ModuleInfoCollection.Add("CatalogoProducto", typeof(Forms.Catalogos.frmCatProducto));
            ModuleInfoCollection.Add("CatalogoTerminal", typeof(Forms.Catalogos.frmCatTerminal));
            //    ModuleInfoCollection.Add("Module1", typeof(frmCatalogoEstacion));
            //    ModuleInfoCollection.Add("Module2", typeof(Form2));
            //    ModuleInfoCollection.Add("CatalogoCliente", typeof(frmCatalogoCliente));
            //    ModuleInfoCollection.Add("CatalogoBanco", typeof(frmCatalogoBanco));
            //    ModuleInfoCollection.Add("CatalogoReportes", typeof(frmCatalogoReportes));
                ModuleInfoCollection.Add("CatalogoCategoria", typeof(frmCatalogoCategoria));
            //    ModuleInfoCollection.Add("CatalogoProducto", typeof(frmCatalogoProducto));
            //    ModuleInfoCollection.Add("CatalogoCuentaBancaria", typeof(frmCatalogoCuentaBancaria));
                ModuleInfoCollection.Add("CatalogoProveedor", typeof(frmCatalogoProveedor));
                ModuleInfoCollection.Add("CatalogoFormadePago", typeof(frmCatalogoFormadePago));
            //    ModuleInfoCollection.Add("CatalogoEstacion", typeof(frmCatalogoEstacion));
            //    ModuleInfoCollection.Add("CatalogoGrupoNomina", typeof(frmCatalogoGrupoNomina));
            //    ModuleInfoCollection.Add("CatalogoEmpleado", typeof(frmCatalogoEmpleadocs));
            //    ModuleInfoCollection.Add("CatalogoTipoDocumento", typeof(frmCatalogoTipoDocumento));
            //    ModuleInfoCollection.Add("CatalogoDiaFestivo", typeof(frmCatalogoDiaFestivo));
            //    ModuleInfoCollection.Add("CatalogoTerminalBiometrica", typeof(frmCatalogoTerminalBiometrica));
            ModuleInfoCollection.Add("CatalogoVendedor", typeof(frmCatalogoVendedor));

            //// Facturacion
            //ModuleInfoCollection.Add("FacturacionContado", typeof(frmFacturaContado));


            ////Almacen
            //ModuleInfoCollection.Add("Almacen", typeof(frmAlmacen));

            // Configuracion
            ModuleInfoCollection.Add("Comercializadora", typeof(frmComercializadora));
            ModuleInfoCollection.Add("RegimenFiscal", typeof(frmRegimenFiscal));



        }
    }    
}
