namespace TrafficLightHard {
    partial class TrafficLightHard {
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
            this.components = new System.ComponentModel.Container();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.FlowLayoutPanel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelYellow.Location = new System.Drawing.Point(36, 139);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(151, 78);
            this.panelYellow.TabIndex = 0;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelGreen.Location = new System.Drawing.Point(37, 249);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(150, 73);
            this.panelGreen.TabIndex = 1;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelRed.Location = new System.Drawing.Point(36, 27);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(151, 78);
            this.panelRed.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Moccasin;
            this.buttonStart.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(37, 369);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(153, 44);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TrafficLightHard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 450);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.panelRed);
            this.Controls.Add(this.panelGreen);
            this.Controls.Add(this.panelYellow);
            this.Name = "TrafficLightHard";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.FlowLayoutPanel panelGreen;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timer1;
    }
}

