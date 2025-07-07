using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers)
        {
            //Implement statistics here
            Stats stats = new Stats();

            if (numbers == null || numbers.Count == 0) {
                stats.average = double.NaN;
                stats.max = double.NaN;
                stats.min = double.NaN;
                return stats;
            }

            stats.average = numbers.Average();
            stats.max = numbers.Max();
            stats.min = numbers.Min();

            return stats;
        }
    }
}
