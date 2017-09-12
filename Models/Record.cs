using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecordAuction.Models
{
    public class Record
    {
        public string Artist { get; set; }
        public string SideA { get; set; }
        public string SideB { get; set; }
        public string Notes { get; set; }
        public string Label { get; set; }
        public int RecordNumber { get; set; }
        public int ConditionID { get; set; }
        public RecordCondition Condition { get; set; }
        public decimal MinValue { get; set; }
        public int ID { get; set; }
    }
}
