//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HG.SoftwareEstimationService.SqliteData
{
    using System;
    using System.Collections.Generic;
    
    public partial class PartTypeProperty
    {
        public long PartTypePropertyId { get; set; }
        public long PartTypeId { get; set; }
        public long PropertyId { get; set; }
    
        public virtual PartType PartType { get; set; }
        public virtual Property Property { get; set; }
    }
}
