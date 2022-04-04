namespace Week_7_Praktikum
{
    partial class FormQuizPanda
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
            this.lblKalimat = new System.Windows.Forms.Label();
            this.lblHuruf = new System.Windows.Forms.Label();
            this.lblMenjadi = new System.Windows.Forms.Label();
            this.lblHasil = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtBoxInputKalimat = new System.Windows.Forms.TextBox();
            this.txtBoxHurufAwal = new System.Windows.Forms.TextBox();
            this.txtBoxHurufDiganti = new System.Windows.Forms.TextBox();
            this.btnKonversi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKalimat
            // 
            this.lblKalimat.AutoSize = true;
            this.lblKalimat.Location = new System.Drawing.Point(22, 26);
            this.lblKalimat.Name = "lblKalimat";
            this.lblKalimat.Size = new System.Drawing.Size(164, 25);
            this.lblKalimat.TabIndex = 0;
            this.lblKalimat.Text = "Masukkan Kalimat :";
            // 
            // lblHuruf
            // 
            this.lblHuruf.AutoSize = true;
            this.lblHuruf.Location = new System.Drawing.Point(22, 97);
            this.lblHuruf.Name = "lblHuruf";
            this.lblHuruf.Size = new System.Drawing.Size(151, 25);
            this.lblHuruf.TabIndex = 1;
            this.lblHuruf.Text = "Masukkan Huruf :";
            // 
            // lblMenjadi
            // 
            this.lblMenjadi.AutoSize = true;
            this.lblMenjadi.Location = new System.Drawing.Point(379, 97);
            this.lblMenjadi.Name = "lblMenjadi";
            this.lblMenjadi.Size = new System.Drawing.Size(84, 25);
            this.lblMenjadi.TabIndex = 2;
            this.lblMenjadi.Text = "Menjadi :";
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.Location = new System.Drawing.Point(22, 241);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(59, 25);
            this.lblHasil.TabIndex = 3;
            this.lblHasil.Text = "Hasil :";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(201, 241);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(20, 25);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "..";
            // 
            // txtBoxInputKalimat
            // 
            this.txtBoxInputKalimat.Location = new System.Drawing.Point(201, 23);
            this.txtBoxInputKalimat.Name = "txtBoxInputKalimat";
            this.txtBoxInputKalimat.Size = new System.Drawing.Size(448, 31);
            this.txtBoxInputKalimat.TabIndex = 5;
            // 
            // txtBoxHurufAwal
            // 
            this.txtBoxHurufAwal.Location = new System.Drawing.Point(201, 94);
            this.txtBoxHurufAwal.Name = "txtBoxHurufAwal";
            this.txtBoxHurufAwal.Size = new System.Drawing.Size(131, 31);
            this.txtBoxHurufAwal.TabIndex = 6;
            // 
            // txtBoxHurufDiganti
            // 
            this.txtBoxHurufDiganti.Location = new System.Drawing.Point(507, 94);
            this.txtBoxHurufDiganti.Name = "txtBoxHurufDiganti";
            this.txtBoxHurufDiganti.Size = new System.Drawing.Size(142, 31);
            this.txtBoxHurufDiganti.TabIndex = 7;
            // 
            // btnKonversi
            // 
            this.btnKonversi.Location = new System.Drawing.Point(201, 164);
            this.btnKonversi.Name = "btnKonversi";
            this.btnKonversi.Size = new System.Drawing.Size(448, 34);
            this.btnKonversi.TabIndex = 8;
            this.btnKonversi.Text = "Konversi!";
            this.btnKonversi.UseVisualStyleBackColor = true;
            this.btnKonversi.Click += new System.EventHandler(this.btnKonversi_Click);
            // 
            // FormQuizPanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 319);
            this.Controls.Add(this.btnKonversi);
            this.Controls.Add(this.txtBoxHurufDiganti);
            this.Controls.Add(this.txtBoxHurufAwal);
            this.Controls.Add(this.txtBoxInputKalimat);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblHasil);
            this.Controls.Add(this.lblMenjadi);
            this.Controls.Add(this.lblHuruf);
            this.Controls.Add(this.lblKalimat);
            this.Name = "FormQuizPanda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Panda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKalimat;
        private System.Windows.Forms.Label lblHuruf;
        private System.Windows.Forms.Label lblMenjadi;
        private System.Windows.Forms.Label lblHasil;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtBoxInputKalimat;
        private System.Windows.Forms.TextBox txtBoxHurufAwal;
        private System.Windows.Forms.TextBox txtBoxHurufDiganti;
        private System.Windows.Forms.Button btnKonversi;
    }
}
