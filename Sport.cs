//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StarLight_Ticket
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sport()
        {
            this.Sport_Save = new HashSet<Sport_Save>();
        }
    
        public int Id { get; set; }
        public Nullable<int> Sid { get; set; }
        public string SportTheatre { get; set; }
        public Nullable<System.DateTime> ShowDate { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string Play { get; set; }
        public Nullable<int> Price { get; set; }
    
        public virtual Sport_fix Sport_fix { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sport_Save> Sport_Save { get; set; }
    }
}
