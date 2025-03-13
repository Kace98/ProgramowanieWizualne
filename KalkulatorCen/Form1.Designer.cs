namespace KalkulatorCen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Komputer = new Button();
            Monitor = new Button();
            label1 = new Label();
            label = new Label();
            SuspendLayout();
            // 
            // Komputer
            // 
            Komputer.Location = new Point(12, 49);
            Komputer.Name = "Komputer";
            Komputer.Size = new Size(75, 23);
            Komputer.TabIndex = 0;
            Komputer.Text = "Komputer";
            Komputer.UseVisualStyleBackColor = true;
            Komputer.Click += Komputer_Click;
            // 
            // Monitor
            // 
            Monitor.Location = new Point(93, 49);
            Monitor.Name = "Monitor";
            Monitor.Size = new Size(75, 23);
            Monitor.TabIndex = 1;
            Monitor.Text = "Monitor";
            Monitor.UseVisualStyleBackColor = true;
            Monitor.Click += Monitor_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.HighlightText;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(174, 49);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 2;
            label1.Click += label1_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(174, 34);
            label.Name = "label";
            label.Size = new Size(45, 15);
            label.TabIndex = 3;
            label.Text = "Cena zł";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 95);
            Controls.Add(label);
            Controls.Add(label1);
            Controls.Add(Monitor);
            Controls.Add(Komputer);
            Name = "Form1";
            Text = "Form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button Komputer;
        private Button Monitor;
        private Label label1;
        private Label label;
    }
}
