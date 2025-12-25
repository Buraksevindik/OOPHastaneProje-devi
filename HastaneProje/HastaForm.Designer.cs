namespace HastaneProje
{
    partial class HastaForm
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
            listBoxDoktorlar = new ListBox();
            listBoxSaatler = new ListBox();
            btnRandevuOlustur = new Button();
            listBoxBolumler = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // listBoxDoktorlar
            // 
            listBoxDoktorlar.FormattingEnabled = true;
            listBoxDoktorlar.Location = new Point(278, 72);
            listBoxDoktorlar.Name = "listBoxDoktorlar";
            listBoxDoktorlar.Size = new Size(150, 104);
            listBoxDoktorlar.TabIndex = 0;
            listBoxDoktorlar.SelectedIndexChanged += listBoxDoktorlar_SelectedIndexChanged_1;
            // 
            // listBoxSaatler
            // 
            listBoxSaatler.FormattingEnabled = true;
            listBoxSaatler.Location = new Point(549, 72);
            listBoxSaatler.Name = "listBoxSaatler";
            listBoxSaatler.Size = new Size(150, 104);
            listBoxSaatler.TabIndex = 1;
            // 
            // btnRandevuOlustur
            // 
            btnRandevuOlustur.Location = new Point(334, 260);
            btnRandevuOlustur.Name = "btnRandevuOlustur";
            btnRandevuOlustur.Size = new Size(133, 44);
            btnRandevuOlustur.TabIndex = 2;
            btnRandevuOlustur.Text = "Randevu Oluştur";
            btnRandevuOlustur.UseVisualStyleBackColor = true;
            btnRandevuOlustur.Click += btnRandevuOlustur_Click_1;
            // 
            // listBoxBolumler
            // 
            listBoxBolumler.FormattingEnabled = true;
            listBoxBolumler.Location = new Point(12, 72);
            listBoxBolumler.Name = "listBoxBolumler";
            listBoxBolumler.Size = new Size(150, 104);
            listBoxBolumler.TabIndex = 3;
            listBoxBolumler.SelectedIndexChanged += listBoxBolumler_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 4;
            label1.Text = "Bölümler";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 28);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 5;
            label2.Text = "Doktorlar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(549, 28);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 6;
            label3.Text = "Saatler";
            // 
            // HastaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxBolumler);
            Controls.Add(btnRandevuOlustur);
            Controls.Add(listBoxSaatler);
            Controls.Add(listBoxDoktorlar);
            Name = "HastaForm";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxDoktorlar;
        private ListBox listBoxSaatler;
        private Button btnRandevuOlustur;
        private ListBox listBoxBolumler;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}