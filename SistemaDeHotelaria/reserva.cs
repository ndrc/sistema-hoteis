//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaDeHotelaria
{
    using System;
    using System.Collections.Generic;
    
    public partial class reserva
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public reserva()
        {
            this.hospedagems = new HashSet<hospedagem>();
        }
    
        public int reservaCodigo { get; set; }
        public System.DateTime reservaCheckin { get; set; }
        public System.DateTime reservaCheckout { get; set; }
        public int quartoCodigo { get; set; }
        public int hospCodigo { get; set; }
        public int funcCodigo { get; set; }
    
        public virtual funcionario funcionario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hospedagem> hospedagems { get; set; }
        public virtual hospede hospede { get; set; }
        public virtual quarto quarto { get; set; }
    }
}
