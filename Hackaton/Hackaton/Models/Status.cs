using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackaton.Models
{
    public class Status
    {
        public int ID { get; set; }

        public List<RiskStatus> status { get; set; }
    }
}
