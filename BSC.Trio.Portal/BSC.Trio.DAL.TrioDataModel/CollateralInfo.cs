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
    
    public partial class CollateralInfo
    {
        public int CollateralID { get; set; }
        public string FileName { get; set; }
        public string Path { get; set; }
        public string FileType { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDT { get; set; }
        public string UpdatedBY { get; set; }
        public System.DateTime LastUpdatedDT { get; set; }
        public int CollateralInfoId { get; set; }
    
        public virtual CollateralType CollateralType { get; set; }
    }
}
