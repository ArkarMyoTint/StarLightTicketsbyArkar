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
    
    public partial class Cinema
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cinema()
        {
            this.Cinema_Save = new HashSet<Cinema_Save>();
        }
    
        public int Id { get; set; }
        public Nullable<int> Cid { get; set; }
        public string CinemaName { get; set; }
        public Nullable<System.DateTime> ShowDate { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string MovieName { get; set; }
        public Nullable<int> Price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cinema_Save> Cinema_Save { get; set; }
        public virtual Cinema_fix Cinema_fix { get; set; }
    }
}