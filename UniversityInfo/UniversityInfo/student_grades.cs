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
    
    public partial class student_grades
    {
        public int student_id { get; set; }
        public int module_id { get; set; }
        public System.DateTime exam_date { get; set; }
        public decimal grade { get; set; }
    
        public virtual grades grades { get; set; }
        public virtual students_modules students_modules { get; set; }
    }
}
