namespace KalkulatorCen
{
    partial class Form3
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
            listView1 = new ListView();
            label1 = new Label();
            CenaMon = new Label();
            label2 = new Label();
            OK = new Button();
            Anuluj = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(264, 176);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 209);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 1;
            label1.Text = "Cena";
            // 
            // CenaMon
            // 
            CenaMon.BackColor = SystemColors.HighlightText;
            CenaMon.BorderStyle = BorderStyle.FixedSingle;
            CenaMon.Location = new Point(52, 208);
            CenaMon.Name = "CenaMon";
            CenaMon.Size = new Size(203, 23);
            CenaMon.TabIndex = 2;
            CenaMon.Click += CenaMon_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(261, 209);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 3;
            label2.Text = "zł";
            // 
            // OK
            // 
            OK.Location = new Point(12, 248);
            OK.Name = "OK";
            OK.Size = new Size(129, 23);
            OK.TabIndex = 4;
            OK.Text = "OK";
            OK.UseVisualStyleBackColor = true;
            OK.Click += OK_Click;
            // 
            // Anuluj
            // 
            Anuluj.Location = new Point(147, 248);
            Anuluj.Name = "Anuluj";
            Anuluj.Size = new Size(129, 23);
            Anuluj.TabIndex = 5;
            Anuluj.Text = "Anuluj";
            Anuluj.UseVisualStyleBackColor = true;
            Anuluj.Click += Anuluj_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 281);
            Controls.Add(Anuluj);
            Controls.Add(OK);
            Controls.Add(label2);
            Controls.Add(CenaMon);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label1;
        private Label CenaMon;
        private Label label2;
        private Button OK;
        private Button Anuluj;
    }
}