namespace HastaneProje
{
    partial class DoktorForm
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
            listBoxRandevular = new ListBox();
            btnSil = new Button();
            btnDegistir = new Button();
            btnCikis = new Button();
            SuspendLayout();
            // 
            // listBoxRandevular
            // 
            listBoxRandevular.FormattingEnabled = true;
            listBoxRandevular.Location = new Point(474, 103);
            listBoxRandevular.Name = "listBoxRandevular";
            listBoxRandevular.Size = new Size(150, 104);
            listBoxRandevular.TabIndex = 0;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(338, 103);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 1;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnDegistir
            // 
            btnDegistir.Location = new Point(338, 174);
            btnDegistir.Name = "btnDegistir";
            btnDegistir.Size = new Size(94, 29);
            btnDegistir.TabIndex = 2;
            btnDegistir.Text = "Değiştir";
            btnDegistir.UseVisualStyleBackColor = true;
            btnDegistir.Click += btnDegistir_Click;
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(338, 250);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(94, 29);
            btnCikis.TabIndex = 3;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // DoktorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCikis);
            Controls.Add(btnDegistir);
            Controls.Add(btnSil);
            Controls.Add(listBoxRandevular);
            Name = "DoktorForm";
            Text = "DoktorForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxRandevular;
        private Button btnSil;
        private Button btnDegistir;
        private Button btnCikis;
    }
}