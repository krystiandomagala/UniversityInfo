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
    
    public partial class modules
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public modules()
        {
            this.modules1 = new HashSet<modules>();
            this.students_modules = new HashSet<students_modules>();
        }
    
        public int module_id { get; set; }
        public string module_name { get; set; }
        public byte no_of_hours { get; set; }
        public Nullable<int> lecturer_id { get; set; }
        public Nullable<int> preceding_module { get; set; }
        public string department { get; set; }
    
        public virtual departments departments { get; set; }
        public virtual lecturers lecturers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<modules> modules1 { get; set; }
        public virtual modules modules2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<students_modules> students_modules { get; set; }
    }
}