namespace WordGame_DZ_ {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.right = new System.Windows.Forms.Label();
            this.wrong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.word = new System.Windows.Forms.Label();
            this.enter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // right
            // 
            this.right.AutoSize = true;
            this.right.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.right.Location = new System.Drawing.Point(12, 66);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(212, 29);
            this.right.TabIndex = 0;
            this.right.Text = "Правильных слов: 0";
            // 
            // wrong
            // 
            this.wrong.AutoSize = true;
            this.wrong.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wrong.Location = new System.Drawing.Point(401, 66);
            this.wrong.Name = "wrong";
            this.wrong.Size = new System.Drawing.Size(233, 29);
            this.wrong.TabIndex = 1;
            this.wrong.Text = "Неправильных слов: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(144, 518);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Нажмите Enter чтобы ввести слово";
            // 
            // word
            // 
            this.word.AutoSize = true;
            this.word.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.word.Location = new System.Drawing.Point(280, 303);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(72, 29);
            this.word.TabIndex = 3;
            this.word.Text = "Слово";
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(170, 428);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(300, 22);
            this.enter.TabIndex = 4;
            this.enter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 628);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.word);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wrong);
            this.Controls.Add(this.right);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label right;
        private System.Windows.Forms.Label wrong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label word;
        private System.Windows.Forms.TextBox enter;
    }
}

