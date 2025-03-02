namespace ProjetoMeuChef
{
    partial class frmTelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaLogin));
            this.pnlImagemInicial = new System.Windows.Forms.Panel();
            this.lblMeuChef = new System.Windows.Forms.Label();
            this.lblReceitas = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.pbImagemInicial = new System.Windows.Forms.PictureBox();
            this.pnlImagemInicial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemInicial)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlImagemInicial
            // 
            this.pnlImagemInicial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.pnlImagemInicial.Controls.Add(this.pbImagemInicial);
            this.pnlImagemInicial.Location = new System.Drawing.Point(0, 0);
            this.pnlImagemInicial.Name = "pnlImagemInicial";
            this.pnlImagemInicial.Size = new System.Drawing.Size(158, 216);
            this.pnlImagemInicial.TabIndex = 1;
            // 
            // lblMeuChef
            // 
            this.lblMeuChef.AutoSize = true;
            this.lblMeuChef.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeuChef.ForeColor = System.Drawing.Color.White;
            this.lblMeuChef.Location = new System.Drawing.Point(178, 45);
            this.lblMeuChef.Name = "lblMeuChef";
            this.lblMeuChef.Size = new System.Drawing.Size(232, 55);
            this.lblMeuChef.TabIndex = 2;
            this.lblMeuChef.Text = "MeuChef";
            // 
            // lblReceitas
            // 
            this.lblReceitas.AutoSize = true;
            this.lblReceitas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceitas.ForeColor = System.Drawing.Color.White;
            this.lblReceitas.Location = new System.Drawing.Point(319, 100);
            this.lblReceitas.Name = "lblReceitas";
            this.lblReceitas.Size = new System.Drawing.Size(97, 24);
            this.lblReceitas.TabIndex = 3;
            this.lblReceitas.Text = "Receitas";
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(218, 160);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(192, 30);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "Clique aqui!";
            this.btnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // pbImagemInicial
            // 
            this.pbImagemInicial.BackColor = System.Drawing.Color.Transparent;
            this.pbImagemInicial.Image = global::ProjetoMeuChef.Properties.Resources.chef2;
            this.pbImagemInicial.Location = new System.Drawing.Point(-24, 0);
            this.pbImagemInicial.Name = "pbImagemInicial";
            this.pbImagemInicial.Size = new System.Drawing.Size(182, 227);
            this.pbImagemInicial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagemInicial.TabIndex = 0;
            this.pbImagemInicial.TabStop = false;
            // 
            // frmTelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(430, 214);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblReceitas);
            this.Controls.Add(this.lblMeuChef);
            this.Controls.Add(this.pnlImagemInicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meu Chef - Gerenciador de Receitas";
            this.pnlImagemInicial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemInicial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagemInicial;
        private System.Windows.Forms.Panel pnlImagemInicial;
        private System.Windows.Forms.Label lblMeuChef;
        private System.Windows.Forms.Label lblReceitas;
        private System.Windows.Forms.Button btnIniciar;
    }
}

