//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Doctor.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_appointment
    {
        public int id { get; set; }
        public System.TimeSpan hour { get; set; }
        public System.DateTime date { get; set; }
        public int id_doctor { get; set; }
        public string id_patient { get; set; }
        public int id_receptionist { get; set; }
        public Nullable<bool> state { get; set; }
    
        public virtual tb_doctor tb_doctor { get; set; }
        public virtual tb_patient tb_patient { get; set; }
    }
}
