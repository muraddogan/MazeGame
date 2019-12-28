namespace LabirentProblemi
{
    partial class FormLabirent
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLabirent));
            this.buttonBilgisayar = new System.Windows.Forms.Button();
            this.buttonTekOyuncu = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelYol = new System.Windows.Forms.Label();
            this.pictureBoxYol = new System.Windows.Forms.PictureBox();
            this.pictureBoxDuvar = new System.Windows.Forms.PictureBox();
            this.labelDuvar = new System.Windows.Forms.Label();
            this.buttonUst = new System.Windows.Forms.Button();
            this.buttonSol = new System.Windows.Forms.Button();
            this.buttonSag = new System.Windows.Forms.Button();
            this.buttonAlt = new System.Windows.Forms.Button();
            this.timerOyun = new System.Windows.Forms.Timer(this.components);
            this.labelHamle = new System.Windows.Forms.Label();
            this.labelZaman = new System.Windows.Forms.Label();
            this.progressBarZaman = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDuvar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBilgisayar
            // 
            this.buttonBilgisayar.Location = new System.Drawing.Point(0, 0);
            this.buttonBilgisayar.Name = "buttonBilgisayar";
            this.buttonBilgisayar.Size = new System.Drawing.Size(75, 23);
            this.buttonBilgisayar.TabIndex = 0;
            this.buttonBilgisayar.Text = "Bilgisayar";
            this.buttonBilgisayar.UseVisualStyleBackColor = true;
            this.buttonBilgisayar.Click += new System.EventHandler(this.buttonBilgisayar_Click);
            // 
            // buttonTekOyuncu
            // 
            this.buttonTekOyuncu.Location = new System.Drawing.Point(81, 0);
            this.buttonTekOyuncu.Name = "buttonTekOyuncu";
            this.buttonTekOyuncu.Size = new System.Drawing.Size(75, 23);
            this.buttonTekOyuncu.TabIndex = 1;
            this.buttonTekOyuncu.Text = "Tek Oyuncu";
            this.buttonTekOyuncu.UseVisualStyleBackColor = true;
            this.buttonTekOyuncu.Click += new System.EventHandler(this.buttonTekOyuncu_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(398, 0);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelYol
            // 
            this.labelYol.AutoSize = true;
            this.labelYol.Location = new System.Drawing.Point(194, 9);
            this.labelYol.Name = "labelYol";
            this.labelYol.Size = new System.Drawing.Size(22, 13);
            this.labelYol.TabIndex = 3;
            this.labelYol.Text = "Yol";
            // 
            // pictureBoxYol
            // 
            this.pictureBoxYol.BackColor = System.Drawing.Color.White;
            this.pictureBoxYol.Location = new System.Drawing.Point(162, 0);
            this.pictureBoxYol.Name = "pictureBoxYol";
            this.pictureBoxYol.Size = new System.Drawing.Size(26, 23);
            this.pictureBoxYol.TabIndex = 4;
            this.pictureBoxYol.TabStop = false;
            this.pictureBoxYol.Click += new System.EventHandler(this.pictureBoxYol_Click);
            // 
            // pictureBoxDuvar
            // 
            this.pictureBoxDuvar.BackColor = System.Drawing.Color.Black;
            this.pictureBoxDuvar.Location = new System.Drawing.Point(235, 0);
            this.pictureBoxDuvar.Name = "pictureBoxDuvar";
            this.pictureBoxDuvar.Size = new System.Drawing.Size(26, 23);
            this.pictureBoxDuvar.TabIndex = 5;
            this.pictureBoxDuvar.TabStop = false;
            this.pictureBoxDuvar.Click += new System.EventHandler(this.pictureBoxDuvar_Click);
            // 
            // labelDuvar
            // 
            this.labelDuvar.AutoSize = true;
            this.labelDuvar.Location = new System.Drawing.Point(267, 9);
            this.labelDuvar.Name = "labelDuvar";
            this.labelDuvar.Size = new System.Drawing.Size(36, 13);
            this.labelDuvar.TabIndex = 6;
            this.labelDuvar.Text = "Duvar";
            // 
            // buttonUst
            // 
            this.buttonUst.Image = ((System.Drawing.Image)(resources.GetObject("buttonUst.Image")));
            this.buttonUst.Location = new System.Drawing.Point(398, 64);
            this.buttonUst.Name = "buttonUst";
            this.buttonUst.Size = new System.Drawing.Size(75, 60);
            this.buttonUst.TabIndex = 7;
            this.buttonUst.UseVisualStyleBackColor = true;
            this.buttonUst.Click += new System.EventHandler(this.buttonUst_Click);
            // 
            // buttonSol
            // 
            this.buttonSol.Image = ((System.Drawing.Image)(resources.GetObject("buttonSol.Image")));
            this.buttonSol.Location = new System.Drawing.Point(358, 130);
            this.buttonSol.Name = "buttonSol";
            this.buttonSol.Size = new System.Drawing.Size(75, 60);
            this.buttonSol.TabIndex = 8;
            this.buttonSol.UseVisualStyleBackColor = true;
            this.buttonSol.Click += new System.EventHandler(this.buttonSol_Click);
            // 
            // buttonSag
            // 
            this.buttonSag.Image = ((System.Drawing.Image)(resources.GetObject("buttonSag.Image")));
            this.buttonSag.Location = new System.Drawing.Point(439, 130);
            this.buttonSag.Name = "buttonSag";
            this.buttonSag.Size = new System.Drawing.Size(75, 60);
            this.buttonSag.TabIndex = 9;
            this.buttonSag.UseVisualStyleBackColor = true;
            this.buttonSag.Click += new System.EventHandler(this.buttonSag_Click);
            // 
            // buttonAlt
            // 
            this.buttonAlt.Image = ((System.Drawing.Image)(resources.GetObject("buttonAlt.Image")));
            this.buttonAlt.Location = new System.Drawing.Point(398, 196);
            this.buttonAlt.Name = "buttonAlt";
            this.buttonAlt.Size = new System.Drawing.Size(75, 60);
            this.buttonAlt.TabIndex = 10;
            this.buttonAlt.UseVisualStyleBackColor = true;
            this.buttonAlt.Click += new System.EventHandler(this.buttonAlt_Click);
            // 
            // timerOyun
            // 
            this.timerOyun.Tick += new System.EventHandler(this.timerOyun_Tick);
            // 
            // labelHamle
            // 
            this.labelHamle.AutoSize = true;
            this.labelHamle.Location = new System.Drawing.Point(411, 307);
            this.labelHamle.Name = "labelHamle";
            this.labelHamle.Size = new System.Drawing.Size(37, 13);
            this.labelHamle.TabIndex = 11;
            this.labelHamle.Text = "Hamle";
            // 
            // labelZaman
            // 
            this.labelZaman.AutoSize = true;
            this.labelZaman.Location = new System.Drawing.Point(474, 415);
            this.labelZaman.Name = "labelZaman";
            this.labelZaman.Size = new System.Drawing.Size(40, 13);
            this.labelZaman.TabIndex = 12;
            this.labelZaman.Text = "Zaman";
            // 
            // progressBarZaman
            // 
            this.progressBarZaman.Location = new System.Drawing.Point(12, 415);
            this.progressBarZaman.Name = "progressBarZaman";
            this.progressBarZaman.Size = new System.Drawing.Size(439, 23);
            this.progressBarZaman.TabIndex = 13;
            // 
            // FormLabirent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.progressBarZaman);
            this.Controls.Add(this.labelZaman);
            this.Controls.Add(this.labelHamle);
            this.Controls.Add(this.buttonAlt);
            this.Controls.Add(this.buttonSag);
            this.Controls.Add(this.buttonSol);
            this.Controls.Add(this.buttonUst);
            this.Controls.Add(this.labelDuvar);
            this.Controls.Add(this.pictureBoxDuvar);
            this.Controls.Add(this.pictureBoxYol);
            this.Controls.Add(this.labelYol);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonTekOyuncu);
            this.Controls.Add(this.buttonBilgisayar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLabirent";
            this.Text = "Labirent Problemi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDuvar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBilgisayar;
        private System.Windows.Forms.Button buttonTekOyuncu;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelYol;
        private System.Windows.Forms.PictureBox pictureBoxYol;
        private System.Windows.Forms.PictureBox pictureBoxDuvar;
        private System.Windows.Forms.Label labelDuvar;
        private System.Windows.Forms.Button buttonUst;
        private System.Windows.Forms.Button buttonSol;
        private System.Windows.Forms.Button buttonSag;
        private System.Windows.Forms.Button buttonAlt;
        private System.Windows.Forms.Timer timerOyun;
        private System.Windows.Forms.Label labelHamle;
        private System.Windows.Forms.Label labelZaman;
        private System.Windows.Forms.ProgressBar progressBarZaman;
    }
}

