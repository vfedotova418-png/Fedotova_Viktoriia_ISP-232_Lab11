using System;
using System.Windows.Forms;

namespace Stopwatch {
    public partial class Form1 : Form {
        private readonly StopwatchModel stopwatch;
        public Form1() {
            InitializeComponent();
            stopwatch = new StopwatchModel(15);
            timer1.Interval = 10;
        }

        private void startBTN_Click(object sender, EventArgs e) => timer1.Start();

        private void stopBTN_Click(object sender, EventArgs e) => timer1.Stop();

        private void resetBTN_Click(object sender, EventArgs e) {
            timer1.Stop();
            stopwatch.Reset();
            UpdateLabel();
        }

        private void UpdateLabel() {
            label1.Text = stopwatch.GetFormattedTime();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            stopwatch.Tick();
            UpdateLabel();
        }
    }
}