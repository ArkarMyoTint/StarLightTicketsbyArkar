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
    
    public partial class Cinema_fix
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cinema_fix()
        {
            this.Cinemas = new HashSet<Cinema>();
        }
    
        public int CID { get; set; }
        public string Cinemaname { get; set; }
        public string Location { get; set; }
        public string Lng { get; set; }
        public string Lat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cinema> Cinemas { get; set; }
    }
}
