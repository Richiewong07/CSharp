using System;

namespace StopwatchExercise
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _isRunning = false;
        private TimeSpan _totalDuration;

        public TimeSpan Duration
		{
			get { return _totalDuration; }
			private set { _totalDuration += value;  }
		}

        public void Start()
		{
			if (!_isRunning)
			{
				_startTime = DateTime.Now;
				_isRunning = true;
			}
			else
			{
				throw new InvalidOperationException("The stopwatch is already started and so cannot be started again until it has been stopped.");
			}
		}

        public void Stop()
		{
			if (_isRunning)
			{
				_endTime = DateTime.Now;
				Duration = _endTime - _startTime;
				_isRunning = false; 
			}
			else
			{
				throw new InvalidOperationException("The stopwatch must be started before it can be stopped.");
			}
		}

        public void Reset()
		{
			_totalDuration = TimeSpan.Zero;
			_startTime = DateTime.MinValue;
			_endTime = DateTime.MinValue;
			_isRunning = false;
		}
    }
}
