using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLightEasy {
    public partial class TrafficLightEasy : Form {
        public TrafficLightEasy() {
            InitializeComponent();
        }

        private void buttonRed_Click(object sender, EventArgs e) {
            SetLight(Color.Red, "Стоп!");
        }

        private void buttonYellow_Click(object sender, EventArgs e) {
            SetLight(Color.Yellow, "Внимание!");
        }

        private void buttonGreen_Click(object sender, EventArgs e) {
            SetLight(Color.Green, "Можно ехать!");
        }

        private void SetLight(Color color, string message) {
            panel1.BackColor = color;
            label1.Text = message;
        }
    }
}
