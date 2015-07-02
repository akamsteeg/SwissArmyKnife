using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace SwissArmyKnife
{
    /// <summary>
    /// Extension methods for <see cref="Stopwatch"/>
    /// </summary>
    public static class StopwatchExtensions
    {
        /// <summary>
        /// Get the current value of the <see cref="Stopwatch"/>
        /// and restart the timer
        /// </summary>
        /// <param name="sw"></param>
        /// <returns></returns>
        public static TimeSpan GetValueAndReset(this Stopwatch sw)
        {
            sw.Stop();
            var result = sw.Elapsed;
            
            sw = Stopwatch.StartNew();

            return result;
        }

    }
}
