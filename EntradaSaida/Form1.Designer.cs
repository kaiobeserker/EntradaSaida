namespace EntradaSaida
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btSait;
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.btlogin = new System.Windows.Forms.Button();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lalnome = new System.Windows.Forms.Label();
            this.labsobrenome = new System.Windows.Forms.Label();
            this.textano = new System.Windows.Forms.TextBox();
            this.lalAno = new System.Windows.Forms.Label();
            this.lalresposta = new System.Windows.Forms.Label();
            this.labelvictoria = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            btSait = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(137, 289);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(142, 20);
            this.txtSobrenome.TabIndex = 1;
            this.txtSobrenome.TextChanged += new System.EventHandler(this.txtSobrenome_TextChanged);
            // 
            // btlogin
            // 
            this.btlogin.BackColor = System.Drawing.Color.Lime;
            this.btlogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btlogin.Location = new System.Drawing.Point(137, 402);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(142, 23);
            this.btlogin.TabIndex = 3;
            this.btlogin.Text = "login";
            this.btlogin.UseVisualStyleBackColor = false;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(137, 196);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(142, 20);
            this.txtnome.TabIndex = 2;
            // 
            // lalnome
            // 
            this.lalnome.AutoSize = true;
            this.lalnome.Location = new System.Drawing.Point(189, 169);
            this.lalnome.Name = "lalnome";
            this.lalnome.Size = new System.Drawing.Size(38, 13);
            this.lalnome.TabIndex = 5;
            this.lalnome.Text = "Nome:";
            // 
            // labsobrenome
            // 
            this.labsobrenome.AutoSize = true;
            this.labsobrenome.Location = new System.Drawing.Point(178, 250);
            this.labsobrenome.Name = "labsobrenome";
            this.labsobrenome.Size = new System.Drawing.Size(64, 13);
            this.labsobrenome.TabIndex = 6;
            this.labsobrenome.Text = "Sobrenome:";
            // 
            // textano
            // 
            this.textano.Location = new System.Drawing.Point(163, 354);
            this.textano.Multiline = true;
            this.textano.Name = "textano";
            this.textano.Size = new System.Drawing.Size(100, 28);
            this.textano.TabIndex = 9;
            // 
            // lalAno
            // 
            this.lalAno.AutoSize = true;
            this.lalAno.Location = new System.Drawing.Point(167, 331);
            this.lalAno.Name = "lalAno";
            this.lalAno.Size = new System.Drawing.Size(88, 13);
            this.lalAno.TabIndex = 12;
            this.lalAno.Text = "Ano Nascimento:";
            // 
            // lalresposta
            // 
            this.lalresposta.AutoSize = true;
            this.lalresposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalresposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lalresposta.Location = new System.Drawing.Point(189, 505);
            this.lalresposta.Name = "lalresposta";
            this.lalresposta.Size = new System.Drawing.Size(0, 25);
            this.lalresposta.TabIndex = 13;
            // 
            // btSait
            // 
            btSait.BackColor = System.Drawing.Color.Black;
            btSait.Cursor = System.Windows.Forms.Cursors.Cross;
            btSait.Enabled = false;
            btSait.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btSait.Location = new System.Drawing.Point(353, -8);
            btSait.Name = "btSait";
            btSait.Size = new System.Drawing.Size(75, 23);
            btSait.TabIndex = 14;
            btSait.Text = "button1";
            btSait.UseVisualStyleBackColor = false;
            // 
            // labelvictoria
            // 
            this.labelvictoria.AutoSize = true;
            this.labelvictoria.Location = new System.Drawing.Point(189, 514);
            this.labelvictoria.Name = "labelvictoria";
            this.labelvictoria.Size = new System.Drawing.Size(0, 13);
            this.labelvictoria.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::EntradaSaida.Properties.Resources.H42C;
            this.pictureBox2.Location = new System.Drawing.Point(163, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EntradaSaida.Properties.Resources.giphy;
            this.pictureBox1.Location = new System.Drawing.Point(-146, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1920, 1080);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(428, 633);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelvictoria);
            this.Controls.Add(btSait);
            this.Controls.Add(this.lalresposta);
            this.Controls.Add(this.lalAno);
            this.Controls.Add(this.textano);
            this.Controls.Add(this.labsobrenome);
            this.Controls.Add(this.lalnome);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Enabled = false;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lalnome;
        private System.Windows.Forms.Label labsobrenome;
        private System.Windows.Forms.TextBox textano;
        private System.Windows.Forms.Label lalAno;
        private System.Windows.Forms.Label lalresposta;
        private System.Windows.Forms.Label labelvictoria;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

