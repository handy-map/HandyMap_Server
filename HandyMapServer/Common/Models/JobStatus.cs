using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public enum JobStatus
    {
        Completed = 0,
        InProgress = 1,
        Declined = 2,
        Accepted = 3,
        Reschedule = 4
    }
}
