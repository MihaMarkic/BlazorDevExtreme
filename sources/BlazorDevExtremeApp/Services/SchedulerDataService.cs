using BlazorDevExtremeApp.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDevExtremeApp.Services
{
    public class SchedulerDataService
    {
        public Task<SchedulerData[]> GetDataAsync()
        {
            List<SchedulerData> schedule = new List<SchedulerData>();

            schedule.Add(new SchedulerData("Feed the dog", DateTime.Now.Date.AddHours(8), DateTime.Now.Date.AddHours(9), false));
            schedule.Add(new SchedulerData("Go to the dentist", DateTime.Now.Date.AddDays(1).AddHours(13), DateTime.Now.Date.AddDays(1).AddHours(14), false));
            schedule.Add(new SchedulerData("Visit gym", DateTime.Now.Date.AddDays(1).AddHours(18), DateTime.Now.Date.AddDays(1).AddHours(19), false));
            schedule.Add(new SchedulerData("Meet with friends", DateTime.Now.Date.AddDays(2), DateTime.Now.Date.AddDays(2), true));
            schedule.Add(new SchedulerData("Relax", DateTime.Now.Date.AddDays(3).AddHours(12), DateTime.Now.Date.AddDays(3).AddHours(13), false));

            return Task.FromResult(schedule.ToArray());

        }
    }
}
