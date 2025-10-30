using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WordGame_DZ_ {
    public partial class Form1 : Form {
        private int count_r, count_w = 0;
        private int currentWord = 0;
        List<string> words = new List<string> {
            "Окно",
            "Рама",
            "Тарелка",
            "Цифра",
            "Капкан",
            "Клоун"
        };
        string wordEnter;
        public Form1() {
            InitializeComponent();
            word.Text = words[currentWord];
        }

        private void CheckWord() {
            if (enter.Text == words[currentWord]) {
                UpdateRight();
            } else {
                UpdateWrong();
            }
            UpdateWord();
        }

        private void UpdateRight() {
            count_r++;
            right.Text = $"Правильных слов: {count_r}";
        }

        private void UpdateWrong() {
            count_w++;
            wrong.Text = $"Неправильных слов: {count_w}";
        }
        private void UpdateWord() {
            currentWord++;
            if (currentWord == words.Count) currentWord = 0;
            word.Text = words[currentWord];
            enter.Clear();
            enter.Focus();
        }

        private void Enter_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                wordEnter = enter.Text;
                CheckWord();
            }
        }
    }
}