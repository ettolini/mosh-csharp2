using System;

namespace StopwatchExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();
            var duration = stopwatch.Duration;

            System.Console.WriteLine("This is the quickest I could press the button: " + duration);
        }
    }

    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _running;
        private bool _started;

        public TimeSpan Duration
        {
            get
            {   
                if (this._running)
                    throw new InvalidOperationException("The Stopwatch is currently running.");
                if (!this._started)
                    throw new InvalidOperationException("The Stopwatch has not been started yet.");
                return this._stopTime - this._startTime;
            }
        }

        public void Start()
        {
            if (!this._started)
                this._started = true;
            else
                if (this._running)
                    throw new InvalidOperationException("The Stopwatch was already started.");
            this._running = true;
            this._startTime = DateTime.Now;
        }

        public void Stop()
        {
            if (!this._running || !this._started)
                throw new InvalidOperationException("The Stopwatch has not started yet.");
            this._running = false;
            this._stopTime = DateTime.Now;

        }
    }
}