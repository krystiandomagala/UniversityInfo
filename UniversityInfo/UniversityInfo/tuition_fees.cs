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
    
    public partial class tuition_fees
    {
        public int payment_id { get; set; }
        public int student_id { get; set; }
        public decimal fee_amount { get; set; }
        public System.DateTime date_of_payment { get; set; }
    
        public virtual students students { get; set; }
    }
}
