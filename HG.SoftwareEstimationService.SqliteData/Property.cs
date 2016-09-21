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
    
    public partial class Property
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Property()
        {
            this.PartTypeProperties = new HashSet<PartTypeProperty>();
            this.StoryPartProperties = new HashSet<StoryPartProperty>();
        }
    
        public long PropertyId { get; set; }
        public string Description { get; set; }
        public Nullable<long> EnumerationId { get; set; }
    
        public virtual Enumeration Enumeration { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartTypeProperty> PartTypeProperties { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoryPartProperty> StoryPartProperties { get; set; }
    }
}