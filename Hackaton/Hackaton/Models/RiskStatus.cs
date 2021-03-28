using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackaton.Models
{
    public class RiskStatus
    {
        public int pID { get; set; }
        public int ID { get; set; }       

        public string Description { get; set; }
        public Risk Risk { get; set; }
       
        public DateTime Date { get; set; }

        private int RiskNumber_;

        public int RiskNumber
        {
            get { return RiskNumber_; }
            set { 
                RiskNumber_ = value; 
                if(RiskNumber_ < 33)
                {
                    Risk = Risk.Low;
                }
                else if(RiskNumber_ > 66)
                {
                    Risk = Risk.High;
                }
                else{
                    Risk = Risk.Average;
                }
            }
            
        }

    }
}
