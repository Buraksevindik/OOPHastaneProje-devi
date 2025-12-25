namespace HastaneProje
{
    partial class GirisForm
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
            comboBoxRol = new ComboBox();
            txtSifre = new TextBox();
            btnGiris = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // comboBoxRol
            // 
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Location = new Point(178, 117);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(151, 28);
            comboBoxRol.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(178, 175);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(125, 27);
            txtSifre.TabIndex = 1;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.White;
            btnGiris.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGiris.Location = new Point(427, 140);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(93, 41);
            btnGiris.TabIndex = 2;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Fluent Icons", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 117);
            label1.Name = "label1";
            label1.Size = new Size(47, 28);
            label1.TabIndex = 3;
            label1.Text = "Rol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(93, 175);
            label2.Name = "label2";
            label2.Size = new Size(64, 31);
            label2.TabIndex = 4;
            label2.Text = "Şifre";
            // 
            // GirisForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(comboBoxRol);
            Name = "GirisForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxRol;
        private TextBox txtSifre;
        private Button btnGiris;
        private Label label1;
        private Label label2;
    }
}
