//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mercado.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Articulo : MyPOCO.Generic.GenericPoco
    {
        public int IdArticulo { get; set; }
        public int IdEmpresa { get; set; }
        public int IdLocal { get; set; }
        public string IdSector { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public bool Perecedero { get; set; }
        public bool Activo { get; set; }
        public decimal Precio { get; set; }
    }
}
