using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDevExtremeApp.Objects
{
    public class SchedulerData
    {
        public String text { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public Boolean allDay { get; set; }

        public SchedulerData(String subject, DateTime from, DateTime to, Boolean day)
        {
            text = subject;
            startDate = from;
            endDate = to;
            allDay = day;

        }
    }
}
