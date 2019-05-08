using System;
using System.Collections.Generic;

namespace Common.Models
{
    public class JobModel
    {
        public int Job_id { get; set; }
        public int Client_id { get; set; }
        public int Worker_id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? Start_datetime { get; set; }
        public DateTime? End_datetime { get; set; }
        public JobStatus Job_status { get; set; }

        public virtual AddressModel Address { get; set; }
    }
}