//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CST2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Nyersanyagok
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nyersanyagok()
        {
            this.Receptek = new HashSet<Receptek>();
        }
    
        public int NyersanyagID { get; set; }
        public string NyersanyagNev { get; set; }
        public Nullable<int> MennyisegiEgysegID { get; set; }
        public Nullable<decimal> Egysegar { get; set; }
    
        public virtual MennyisegiEgysegek MennyisegiEgysegek { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receptek> Receptek { get; set; }
    }
}