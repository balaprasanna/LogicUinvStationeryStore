//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebForm_V1.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class delivery_order
    {
        public delivery_order()
        {
            this.delivery_order_detail = new HashSet<delivery_order_detail>();
        }
    
        public int delivery_order_id { get; set; }
        public string delivery_order_number { get; set; }
        public System.DateTime delivery_order_date { get; set; }
        public string delivery_order_status { get; set; }
        public string delivery_order_remark { get; set; }
        public int purchase_order_purchase_order_id { get; set; }
    
        public virtual ICollection<delivery_order_detail> delivery_order_detail { get; set; }
        public virtual purchase_order purchase_order { get; set; }
    }
}
