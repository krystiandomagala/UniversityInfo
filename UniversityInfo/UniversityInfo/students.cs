//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniversityInfo
{
    using System;
    using System.Collections.Generic;
    
    public partial class students
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public students()
        {
            this.students_modules = new HashSet<students_modules>();
            this.tuition_fees = new HashSet<tuition_fees>();
        }
    
        public int student_id { get; set; }
        public string surname { get; set; }
        public string first_name { get; set; }
        public Nullable<System.DateTime> date_of_birth { get; set; }
        public string group_no { get; set; }
    
        public virtual groups groups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<students_modules> students_modules { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tuition_fees> tuition_fees { get; set; }
    }
}