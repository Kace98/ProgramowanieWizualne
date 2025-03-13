namespace KalkulatorCen
{
    partial class Form2
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            DyskWyb = new Label();
            label6 = new Label();
            Dysk1 = new RadioButton();
            Dysk2 = new RadioButton();
            Dysk3 = new RadioButton();
            label7 = new Label();
            Anuluj = new Button();
            ProcWyb = new Label();
            Procesory = new ComboBox();
            CenaLaczna = new Label();
            OK = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 37);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Procesor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 37);
            label3.Name = "label3";
            label3.Size = new Size(15, 15);
            label3.TabIndex = 2;
            label3.Text = "zł";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(240, 139);
            label4.Name = "label4";
            label4.Size = new Size(15, 15);
            label4.TabIndex = 6;
            label4.Text = "zł";
            // 
            // DyskWyb
            // 
            DyskWyb.BackColor = SystemColors.HighlightText;
            DyskWyb.BorderStyle = BorderStyle.FixedSingle;
            DyskWyb.Location = new Point(98, 138);
            DyskWyb.Name = "DyskWyb";
            DyskWyb.Size = new Size(100, 23);
            DyskWyb.TabIndex = 5;
            DyskWyb.Click += DyskWyb_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 139);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 4;
            label6.Text = "Dysk";
            // 
            // Dysk1
            // 
            Dysk1.AutoSize = true;
            Dysk1.Location = new Point(51, 175);
            Dysk1.Name = "Dysk1";
            Dysk1.Size = new Size(84, 19);
            Dysk1.TabIndex = 7;
            Dysk1.TabStop = true;
            Dysk1.Text = "240 GB SSD";
            Dysk1.UseVisualStyleBackColor = true;
            Dysk1.CheckedChanged += Dysk1_CheckedChanged;
            // 
            // Dysk2
            // 
            Dysk2.AutoSize = true;
            Dysk2.Location = new Point(51, 200);
            Dysk2.Name = "Dysk2";
            Dysk2.Size = new Size(91, 19);
            Dysk2.TabIndex = 8;
            Dysk2.TabStop = true;
            Dysk2.Text = "500 GB SATA";
            Dysk2.UseVisualStyleBackColor = true;
            Dysk2.CheckedChanged += Dysk2_CheckedChanged;
            // 
            // Dysk3
            // 
            Dysk3.AutoSize = true;
            Dysk3.Location = new Point(51, 225);
            Dysk3.Name = "Dysk3";
            Dysk3.Size = new Size(97, 19);
            Dysk3.TabIndex = 9;
            Dysk3.TabStop = true;
            Dysk3.Text = "1000 GB SATA";
            Dysk3.UseVisualStyleBackColor = true;
            Dysk3.CheckedChanged += Dysk3_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 268);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 10;
            label7.Text = "Cena łączna:";
            // 
            // Anuluj
            // 
            Anuluj.Location = new Point(148, 323);
            Anuluj.Name = "Anuluj";
            Anuluj.Size = new Size(131, 23);
            Anuluj.TabIndex = 13;
            Anuluj.Text = "Anuluj";
            Anuluj.UseVisualStyleBackColor = true;
            Anuluj.Click += Anuluj_Click;
            // 
            // ProcWyb
            // 
            ProcWyb.BackColor = SystemColors.HighlightText;
            ProcWyb.BorderStyle = BorderStyle.FixedSingle;
            ProcWyb.Location = new Point(98, 37);
            ProcWyb.Name = "ProcWyb";
            ProcWyb.Size = new Size(100, 23);
            ProcWyb.TabIndex = 14;
            ProcWyb.Click += ProcWyb_Click;
            // 
            // Procesory
            // 
            Procesory.FormattingEnabled = true;
            Procesory.Location = new Point(12, 82);
            Procesory.Name = "Procesory";
            Procesory.Size = new Size(231, 23);
            Procesory.TabIndex = 15;
            Procesory.SelectedIndexChanged += Procesory_SelectedIndexChanged;
            // 
            // CenaLaczna
            // 
            CenaLaczna.BackColor = SystemColors.HighlightText;
            CenaLaczna.BorderStyle = BorderStyle.FixedSingle;
            CenaLaczna.Location = new Point(98, 267);
            CenaLaczna.Name = "CenaLaczna";
            CenaLaczna.Size = new Size(100, 23);
            CenaLaczna.TabIndex = 16;
            CenaLaczna.Click += CenaLaczna_Click;
            // 
            // OK
            // 
            OK.Location = new Point(12, 323);
            OK.Name = "OK";
            OK.Size = new Size(130, 23);
            OK.TabIndex = 17;
            OK.Text = "OK";
            OK.UseVisualStyleBackColor = true;
            OK.Click += OK_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 358);
            Controls.Add(OK);
            Controls.Add(CenaLaczna);
            Controls.Add(Procesory);
            Controls.Add(ProcWyb);
            Controls.Add(Anuluj);
            Controls.Add(label7);
            Controls.Add(Dysk3);
            Controls.Add(Dysk2);
            Controls.Add(Dysk1);
            Controls.Add(label4);
            Controls.Add(DyskWyb);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label DyskWyb;
        private Label label6;
        private RadioButton Dysk1;
        private RadioButton Dysk2;
        private RadioButton Dysk3;
        private Label label7;
        private Button Anuluj;
        private Label ProcWyb;
        private ComboBox Procesory;
        private Label CenaLaczna;
        private Button OK;
    }
}