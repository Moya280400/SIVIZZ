//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cliente_Preorden
    {
        public int id { get; set; }
        public decimal monto { get; set; }
        public string nombre { get; set; }
        public string primerApellido { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public int preorden_id { get; set; }
    
        public virtual Preorden Preorden { get; set; }
    }
}