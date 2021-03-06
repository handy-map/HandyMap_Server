﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class ClientModel
    {
        public int Client_id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Contact_number { get; set; }
        public byte[] ProfilePicture { get; set; }
        public virtual IList<JobModel> Jobs { get; set; }
    }
}
