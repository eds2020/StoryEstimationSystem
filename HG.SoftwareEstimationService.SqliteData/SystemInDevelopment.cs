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
    
    public partial class SystemInDevelopment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SystemInDevelopment()
        {
            this.Stories = new HashSet<Story>();
            this.Stories1 = new HashSet<Story>();
        }
    
        public long SystemId { get; set; }
        public long OwnerId { get; set; }
        public string Name { get; set; }
        public bool LogicalDelete { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Story> Stories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Story> Stories1 { get; set; }
    }
}
