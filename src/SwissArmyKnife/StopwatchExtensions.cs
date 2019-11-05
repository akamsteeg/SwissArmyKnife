using System;
using System.Diagnostics;

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
        public static TimeSpan GetElapsedAndRestart(this Stopwatch sw)
        {
            sw.Stop();
            var result = sw.Elapsed;

            sw.Reset();
            sw.Start();

            return result;
        }
    }
}
