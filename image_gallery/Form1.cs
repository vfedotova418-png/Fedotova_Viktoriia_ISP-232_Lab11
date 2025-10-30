using System;
using System.Windows.Forms;

namespace image_gallery {
    public partial class Form1 : Form {
        int currentIndex = 1;
        private readonly object[] images = {
            Properties.Resources.snow,
            Properties.Resources.them,
            Properties.Resources.pat,
            Properties.Resources.him,
            Properties.Resources.viollin,
            Properties.Resources.lucifer,
            Properties.Resources.coldwire
    };
        public Form1() {
            InitializeComponent();
            ShowImage();
        }

        private void buttonNext(object sender, EventArgs e) {
            currentIndex++;
            if (currentIndex >= images.Length) currentIndex = 0;
            ShowImage();
        }

        private void buttonBack(object sender, EventArgs e) {
            currentIndex--;
            if (currentIndex < 0) currentIndex = images.Length - 1;
            ShowImage();
        }

        private void ShowImage() {
            pictureBox1.Image = (System.Drawing.Image)images[currentIndex];
        }
    }
}