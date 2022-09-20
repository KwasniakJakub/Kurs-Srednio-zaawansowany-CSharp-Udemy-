using System;
using System.Threading;

namespace StopWatch
{
    public class StopWatch
    {
        private DateTime _startTime { get; set; }
        private DateTime _endTime { get; set; }
        private bool _running = false;
        public void Start()
        {
            if (_running)
                throw new InvalidOperationException("Stopwatch is already running.");

            _startTime = DateTime.Now;
            _running = true;
        }
        public void Stop()
        {
            if (!_running)
                throw new InvalidOperationException("Stopwatch is not running!");

            _endTime = DateTime.Now;
            _running = false;

        }
        public TimeSpan GetInterval()
        {
            return _endTime - _startTime;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new StopWatch();

            for (var i = 0; i < 2; i++)
            {
                stopwatch.Start();
                Thread.Sleep(1000);

                //stopwatch.Start(DateTime.Now);
                stopwatch.Stop();
                Console.WriteLine("Duration:  " + stopwatch.GetInterval());
                Console.WriteLine("Press Enter to run the stopwatch one more time");
                Console.ReadLine();
            }
        }
    }
}
