//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace examschema
{
    using System;
    using System.Collections.Generic;
    
    public partial class School1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public School1()
        {
            this.Students = new HashSet<Student1>();
        }
    
        public int Sid { get; set; }
        public string Sname { get; set; }
        public string Sloc { get; set; }
        public Nullable<int> Percentage { get; set; }
        public Nullable<int> SecMarks { get; set; }
        public Nullable<int> MaxMarks { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student1> Students { get; set; }
    }
}