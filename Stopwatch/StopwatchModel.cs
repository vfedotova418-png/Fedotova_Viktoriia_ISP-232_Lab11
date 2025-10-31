using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch {
    public class StopwatchModel {
        public int Hours { get; private set; }
        public int Minutes { get; private set; }
        public int Seconds { get; private set; }
        public int Milliseconds { get; private set; }
        private readonly int tickStep;

        public StopwatchModel(int tickStep = 15) {
            this.tickStep = tickStep;
        }

        public void Tick() {
            Milliseconds += tickStep;
            if (Milliseconds >= 1000) {
                Milliseconds -= 1000;
                Seconds++;
            }
            if (Seconds >= 60) {
                Seconds -= 60;
                Minutes++;
            }
            if (Minutes >= 60) {
                Minutes -= 60;
                Hours++;
            }
        }

        public void Reset() {
            Hours = Minutes = Seconds = Milliseconds = 0;
        }

        public string GetFormattedTime() {
            return $"{Hours:00}:{Minutes:00}:{Seconds:00}:{Milliseconds / 10:00}";
        }
    }
}