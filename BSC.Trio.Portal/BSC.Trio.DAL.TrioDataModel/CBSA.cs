//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BSC.Trio.DAL.TrioDataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class CBSA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CBSA()
        {
            this.PCPs = new HashSet<PCP>();
        }
    
        public int CbsaID { get; set; }
        public int CbsaCode { get; set; }
        public string CbsaName { get; set; }
        public string ZipClass { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDT { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime LastUpdatedDT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PCP> PCPs { get; set; }
    }
}
