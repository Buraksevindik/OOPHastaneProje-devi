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
            listBoxRandevular.Location = new Point(288, 61);
            listBoxRandevular.Name = "listBoxRandevular";
            listBoxRandevular.Size = new Size(227, 204);
            listBoxRandevular.TabIndex = 0;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnSil.Location = new Point(111, 61);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(114, 43);
            btnSil.TabIndex = 1;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnDegistir
            // 
            btnDegistir.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnDegistir.Location = new Point(111, 132);
            btnDegistir.Name = "btnDegistir";
            btnDegistir.Size = new Size(114, 43);
            btnDegistir.TabIndex = 2;
            btnDegistir.Text = "Değiştir";
            btnDegistir.UseVisualStyleBackColor = true;
            btnDegistir.Click += btnDegistir_Click;
            // 
            // btnCikis
            // 
            btnCikis.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnCikis.Location = new Point(111, 208);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(114, 43);
            btnCikis.TabIndex = 3;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // DoktorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
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