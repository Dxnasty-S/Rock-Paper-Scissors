namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.btnPedra = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnTesoura = new System.Windows.Forms.Button();
            this.Jogador = new System.Windows.Forms.Label();
            this.Computador = new System.Windows.Forms.Label();
            this.txtPontos = new System.Windows.Forms.Label();
            this.txtCronometro = new System.Windows.Forms.Label();
            this.txtRodada = new System.Windows.Forms.Label();
            this.picJogador = new System.Windows.Forms.PictureBox();
            this.picComputador = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComputador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPedra
            // 
            this.btnPedra.Location = new System.Drawing.Point(86, 134);
            this.btnPedra.Name = "btnPedra";
            this.btnPedra.Size = new System.Drawing.Size(75, 23);
            this.btnPedra.TabIndex = 0;
            this.btnPedra.Text = "Pedra";
            this.btnPedra.UseVisualStyleBackColor = true;
            this.btnPedra.Click += new System.EventHandler(this.btnPedra_Click);
            // 
            // btnPapel
            // 
            this.btnPapel.Location = new System.Drawing.Point(86, 193);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(75, 23);
            this.btnPapel.TabIndex = 0;
            this.btnPapel.Text = "Papel";
            this.btnPapel.UseVisualStyleBackColor = true;
            this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(702, 401);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 0;
            this.btnRestart.Text = "Reiniciar";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnTesoura
            // 
            this.btnTesoura.Location = new System.Drawing.Point(86, 256);
            this.btnTesoura.Name = "btnTesoura";
            this.btnTesoura.Size = new System.Drawing.Size(75, 23);
            this.btnTesoura.TabIndex = 0;
            this.btnTesoura.Text = "Tesoura";
            this.btnTesoura.UseVisualStyleBackColor = true;
            this.btnTesoura.Click += new System.EventHandler(this.btnTesoura_Click);
            // 
            // Jogador
            // 
            this.Jogador.AutoSize = true;
            this.Jogador.Location = new System.Drawing.Point(227, 77);
            this.Jogador.Name = "Jogador";
            this.Jogador.Size = new System.Drawing.Size(45, 13);
            this.Jogador.TabIndex = 1;
            this.Jogador.Text = "Jogador";
            // 
            // Computador
            // 
            this.Computador.AutoSize = true;
            this.Computador.Location = new System.Drawing.Point(611, 77);
            this.Computador.Name = "Computador";
            this.Computador.Size = new System.Drawing.Size(64, 13);
            this.Computador.TabIndex = 1;
            this.Computador.Text = "Computador";
            // 
            // txtPontos
            // 
            this.txtPontos.AutoSize = true;
            this.txtPontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPontos.Location = new System.Drawing.Point(360, 118);
            this.txtPontos.Name = "txtPontos";
            this.txtPontos.Size = new System.Drawing.Size(178, 24);
            this.txtPontos.TabIndex = 1;
            this.txtPontos.Text = "Jogador: 0 - PC: 0";
            this.txtPontos.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCronometro
            // 
            this.txtCronometro.AutoSize = true;
            this.txtCronometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCronometro.Location = new System.Drawing.Point(440, 181);
            this.txtCronometro.Name = "txtCronometro";
            this.txtCronometro.Size = new System.Drawing.Size(21, 24);
            this.txtCronometro.TabIndex = 1;
            this.txtCronometro.Text = "5";
            this.txtCronometro.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtRodada
            // 
            this.txtRodada.AutoSize = true;
            this.txtRodada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRodada.Location = new System.Drawing.Point(398, 245);
            this.txtRodada.Name = "txtRodada";
            this.txtRodada.Size = new System.Drawing.Size(105, 24);
            this.txtRodada.TabIndex = 1;
            this.txtRodada.Text = "Rodada: 3";
            this.txtRodada.Click += new System.EventHandler(this.label3_Click);
            // 
            // picJogador
            // 
            this.picJogador.Image = global::WindowsFormsApp1.Properties.Resources.qq;
            this.picJogador.Location = new System.Drawing.Point(196, 144);
            this.picJogador.Name = "picJogador";
            this.picJogador.Size = new System.Drawing.Size(125, 125);
            this.picJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJogador.TabIndex = 2;
            this.picJogador.TabStop = false;
            // 
            // picComputador
            // 
            this.picComputador.Cursor = System.Windows.Forms.Cursors.Default;
            this.picComputador.Image = global::WindowsFormsApp1.Properties.Resources.qq;
            this.picComputador.Location = new System.Drawing.Point(578, 144);
            this.picComputador.Name = "picComputador";
            this.picComputador.Size = new System.Drawing.Size(125, 125);
            this.picComputador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picComputador.TabIndex = 2;
            this.picComputador.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.Atualizar);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picComputador);
            this.Controls.Add(this.picJogador);
            this.Controls.Add(this.Computador);
            this.Controls.Add(this.txtRodada);
            this.Controls.Add(this.txtCronometro);
            this.Controls.Add(this.txtPontos);
            this.Controls.Add(this.Jogador);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnTesoura);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(this.btnPedra);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Pedra, papel ou tesoura";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComputador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPedra;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnTesoura;
        private System.Windows.Forms.Label Jogador;
        private System.Windows.Forms.Label Computador;
        private System.Windows.Forms.Label txtPontos;
        private System.Windows.Forms.Label txtCronometro;
        private System.Windows.Forms.Label txtRodada;
        private System.Windows.Forms.PictureBox picJogador;
        private System.Windows.Forms.PictureBox picComputador;
        private System.Windows.Forms.Timer GameTimer;
    }
}

