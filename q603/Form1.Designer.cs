namespace q603
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startstopButton = new System.Windows.Forms.Button();
            this.tofroButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startstopButton
            // 
            this.startstopButton.Location = new System.Drawing.Point(12, 414);
            this.startstopButton.Name = "startstopButton";
            this.startstopButton.Size = new System.Drawing.Size(75, 23);
            this.startstopButton.TabIndex = 0;
            this.startstopButton.Text = "Start";
            this.startstopButton.UseVisualStyleBackColor = true;
            this.startstopButton.Click += new System.EventHandler(this.startstopButton_Click);
            // 
            // tofroButton
            // 
            this.tofroButton.Location = new System.Drawing.Point(93, 414);
            this.tofroButton.Name = "tofroButton";
            this.tofroButton.Size = new System.Drawing.Size(75, 23);
            this.tofroButton.TabIndex = 1;
            this.tofroButton.Text = "Increase";
            this.tofroButton.UseVisualStyleBackColor = true;
            this.tofroButton.Click += new System.EventHandler(this.tofroButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(174, 414);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 200;
            this.trackBar1.Location = new System.Drawing.Point(255, 418);
            this.trackBar1.Maximum = 2000;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(145, 45);
            this.trackBar1.SmallChange = 10;
            this.trackBar1.TabIndex = 3;
            this.trackBar1.TickFrequency = 50;
            this.trackBar1.Value = 500;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(315, 404);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(25, 13);
            this.intervalLabel.TabIndex = 4;
            this.intervalLabel.Text = "500";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Speed:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 449);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.intervalLabel);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.tofroButton);
            this.Controls.Add(this.startstopButton);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Boss";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button startstopButton;
        private System.Windows.Forms.Button tofroButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.Label label1;
    }
}

