//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Yazilim_Mimarisi_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_DIYETLER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_DIYETLER()
        {
            this.Tbl_HASTA = new HashSet<Tbl_HASTA>();
        }
    
        public int DiyetId { get; set; }
        public string DiyetAd { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_HASTA> Tbl_HASTA { get; set; }
    }
}
