//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class mutation
    {
        public int id { get; set; }
        public int job_id { get; set; }
        public int employee_id { get; set; }
        public string status { get; set; }
        public System.DateTime created_at { get; set; }
        public Nullable<System.DateTime> deleted_at { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual job job { get; set; }
    }
}
