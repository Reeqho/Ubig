//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hospital
{
    using System;
    using System.Collections.Generic;
    
    public partial class payment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public payment()
        {
            this.payment_detail = new HashSet<payment_detail>();
        }
    
        public int id { get; set; }
        public int meeting_id { get; set; }
        public string card_holder_name { get; set; }
        public string primary_account_number { get; set; }
        public System.DateTime expiration_date { get; set; }
        public int service_code { get; set; }
        public decimal total_payment { get; set; }
        public System.DateTime created_at { get; set; }
        public Nullable<System.DateTime> last_updated_at { get; set; }
        public Nullable<System.DateTime> deleted_at { get; set; }
    
        public virtual meeting meeting { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<payment_detail> payment_detail { get; set; }
    }
}