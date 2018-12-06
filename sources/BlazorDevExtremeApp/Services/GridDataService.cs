using BlazorDevExtremeApp.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDevExtremeApp.Services
{
    public class GridDataService
    {
        private static string[] Names = new[]
        {
            "Pearson","Miller-Cross","Lucky","Foster","Colt","Burke","O'Leary","Pentwhistle","Clegg"
        };

        private static string[] FirstNames = new[]
        {
            "Michael","Louise","Ken","Janet","Charles","John","Seamus","Sally-May","Gillian","Geoffrey"
        };

        private static bool[] Male = new[]
        {
            false,true
        };

        public Task<GridData[]> GetDataAsync()
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 50).Select(index => new GridData
            {
                Firstname = FirstNames[rng.Next(FirstNames.Length)],
                Name = Names[rng.Next(Names.Length)],
                Male = Male[rng.Next(Male.Length)],
            }).ToArray());
        }
    }
}
