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
    
    public partial class tb_cashier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_cashier()
        {
            this.tb_proof_of_purchase = new HashSet<tb_proof_of_purchase>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string a_p { get; set; }
        public string a_m { get; set; }
        public string dni { get; set; }
        public Nullable<bool> state { get; set; }
        public string password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_proof_of_purchase> tb_proof_of_purchase { get; set; }
    }
}
