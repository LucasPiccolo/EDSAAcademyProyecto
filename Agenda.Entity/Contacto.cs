//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Agenda.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contacto
    {
        public int Id { get; set; }
        public string ApellidoYNombre { get; set; }
        public string Genero { get; set; }
        public string Pais { get; set; }
        public string Localidad { get; set; }
        public string Activo { get; set; }
        public System.DateTime FechaIngresoDesde { get; set; }
        public System.DateTime FechaIngresoHasta { get; set; }
        public string ContactoInterno { get; set; }
        public string TelFijoInterno { get; set; }
        public string TelCelular { get; set; }
        public string CuentaSkype { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Organizacion { get; set; }
        public string Area { get; set; }
    }
}