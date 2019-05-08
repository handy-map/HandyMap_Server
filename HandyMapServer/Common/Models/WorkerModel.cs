using System;
using System.Collections.Generic;

namespace Common.Models
{
    public class WorkerModel
    {
        public int Worker_id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Contact_number { get; set; }
        public decimal? Rating { get; set; }
        public byte[] ProfilePicture { get; set; }
        public virtual IList<JobModel> Jobs { get; set; }
        public virtual IList<SkillModel> Skills { get; set; }

    }
}
