//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data.DB_Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Address
    {
        public int job_id { get; set; }
        public int client_id { get; set; }
        public string address_line_1 { get; set; }
        public string address_line_2 { get; set; }
        public string address_line_3 { get; set; }
        public string province { get; set; }
        public string city { get; set; }
        public string zip_code { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Job Job { get; set; }
    }
}
