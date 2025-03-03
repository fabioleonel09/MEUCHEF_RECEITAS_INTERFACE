namespace ProjetoMeuChef
{
    partial class frmTelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaPrincipal));
            this.tlpGeral = new System.Windows.Forms.TableLayoutPanel();
            this.gbDadosGerais = new System.Windows.Forms.GroupBox();
            this.gbGradeDados = new System.Windows.Forms.GroupBox();
            this.dgvReceitas = new System.Windows.Forms.DataGridView();
            this.lblGradeReceitas = new System.Windows.Forms.Label();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbObservacao = new System.Windows.Forms.RadioButton();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtIngredientes = new System.Windows.Forms.TextBox();
            this.lblIngredientes = new System.Windows.Forms.Label();
            this.txtModoPreparo = new System.Windows.Forms.TextBox();
            this.lblModoPreparo = new System.Windows.Forms.Label();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.txtPesoFinal = new System.Windows.Forms.TextBox();
            this.lblPesoFinal = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnLimpaBusca = new System.Windows.Forms.Button();
            this.tlpGeral.SuspendLayout();
            this.gbDadosGerais.SuspendLayout();
            this.gbGradeDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceitas)).BeginInit();
            this.gbBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpGeral
            // 
            this.tlpGeral.ColumnCount = 2;
            this.tlpGeral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGeral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGeral.Controls.Add(this.gbDadosGerais, 0, 0);
            this.tlpGeral.Controls.Add(this.gbGradeDados, 1, 0);
            this.tlpGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGeral.Location = new System.Drawing.Point(0, 0);
            this.tlpGeral.Name = "tlpGeral";
            this.tlpGeral.RowCount = 1;
            this.tlpGeral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGeral.Size = new System.Drawing.Size(800, 450);
            this.tlpGeral.TabIndex = 0;
            // 
            // gbDadosGerais
            // 
            this.gbDadosGerais.Controls.Add(this.label1);
            this.gbDadosGerais.Controls.Add(this.txtPesoFinal);
            this.gbDadosGerais.Controls.Add(this.lblPesoFinal);
            this.gbDadosGerais.Controls.Add(this.txtObservacoes);
            this.gbDadosGerais.Controls.Add(this.lblObservacoes);
            this.gbDadosGerais.Controls.Add(this.txtModoPreparo);
            this.gbDadosGerais.Controls.Add(this.lblModoPreparo);
            this.gbDadosGerais.Controls.Add(this.txtIngredientes);
            this.gbDadosGerais.Controls.Add(this.lblIngredientes);
            this.gbDadosGerais.Controls.Add(this.txtDescricao);
            this.gbDadosGerais.Controls.Add(this.lblDescricao);
            this.gbDadosGerais.Controls.Add(this.txtNome);
            this.gbDadosGerais.Controls.Add(this.lblNome);
            this.gbDadosGerais.Controls.Add(this.lblBuscar);
            this.gbDadosGerais.Controls.Add(this.gbBuscar);
            this.gbDadosGerais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDadosGerais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDadosGerais.Location = new System.Drawing.Point(3, 3);
            this.gbDadosGerais.Name = "gbDadosGerais";
            this.gbDadosGerais.Size = new System.Drawing.Size(394, 444);
            this.gbDadosGerais.TabIndex = 0;
            this.gbDadosGerais.TabStop = false;
            // 
            // gbGradeDados
            // 
            this.gbGradeDados.Controls.Add(this.btnExcluir);
            this.gbGradeDados.Controls.Add(this.btnEditar);
            this.gbGradeDados.Controls.Add(this.btnAdicionar);
            this.gbGradeDados.Controls.Add(this.lblGradeReceitas);
            this.gbGradeDados.Controls.Add(this.dgvReceitas);
            this.gbGradeDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGradeDados.Location = new System.Drawing.Point(403, 3);
            this.gbGradeDados.Name = "gbGradeDados";
            this.gbGradeDados.Size = new System.Drawing.Size(394, 444);
            this.gbGradeDados.TabIndex = 1;
            this.gbGradeDados.TabStop = false;
            // 
            // dgvReceitas
            // 
            this.dgvReceitas.AllowUserToAddRows = false;
            this.dgvReceitas.AllowUserToDeleteRows = false;
            this.dgvReceitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceitas.Location = new System.Drawing.Point(6, 45);
            this.dgvReceitas.Name = "dgvReceitas";
            this.dgvReceitas.ReadOnly = true;
            this.dgvReceitas.Size = new System.Drawing.Size(382, 326);
            this.dgvReceitas.TabIndex = 0;
            this.dgvReceitas.SelectionChanged += new System.EventHandler(this.dgvReceitas_SelectionChanged);
            // 
            // lblGradeReceitas
            // 
            this.lblGradeReceitas.AutoSize = true;
            this.lblGradeReceitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeReceitas.ForeColor = System.Drawing.Color.White;
            this.lblGradeReceitas.Location = new System.Drawing.Point(2, 16);
            this.lblGradeReceitas.Name = "lblGradeReceitas";
            this.lblGradeReceitas.Size = new System.Drawing.Size(140, 20);
            this.lblGradeReceitas.TabIndex = 1;
            this.lblGradeReceitas.Text = "Grade de receitas:";
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.btnLimpaBusca);
            this.gbBuscar.Controls.Add(this.txtBuscar);
            this.gbBuscar.Controls.Add(this.btnBuscar);
            this.gbBuscar.Controls.Add(this.rbObservacao);
            this.gbBuscar.Controls.Add(this.rbNome);
            this.gbBuscar.Location = new System.Drawing.Point(8, 41);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(379, 83);
            this.gbBuscar.TabIndex = 0;
            this.gbBuscar.TabStop = false;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.White;
            this.lblBuscar.Location = new System.Drawing.Point(5, 16);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(90, 20);
            this.lblBuscar.TabIndex = 2;
            this.lblBuscar.Text = "Buscar por:";
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNome.ForeColor = System.Drawing.Color.White;
            this.rbNome.Location = new System.Drawing.Point(6, 19);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(69, 24);
            this.rbNome.TabIndex = 0;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // rbObservacao
            // 
            this.rbObservacao.AutoSize = true;
            this.rbObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbObservacao.ForeColor = System.Drawing.Color.White;
            this.rbObservacao.Location = new System.Drawing.Point(126, 19);
            this.rbObservacao.Name = "rbObservacao";
            this.rbObservacao.Size = new System.Drawing.Size(112, 24);
            this.rbObservacao.TabIndex = 3;
            this.rbObservacao.TabStop = true;
            this.rbObservacao.Text = "Observação";
            this.rbObservacao.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(165)))), ((int)(((byte)(106)))));
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(165)))), ((int)(((byte)(106)))));
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(6, 380);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(111, 36);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(138)))), ((int)(((byte)(218)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(138)))), ((int)(((byte)(218)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(142, 380);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(111, 36);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(277, 380);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(111, 36);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(4, 143);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(135, 20);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome da receita:*";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(7, 166);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(379, 26);
            this.txtNome.TabIndex = 4;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(7, 218);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(379, 26);
            this.txtDescricao.TabIndex = 6;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.White;
            this.lblDescricao.Location = new System.Drawing.Point(4, 195);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(164, 20);
            this.lblDescricao.TabIndex = 5;
            this.lblDescricao.Text = "Descrição da receita:*";
            // 
            // txtIngredientes
            // 
            this.txtIngredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredientes.Location = new System.Drawing.Point(7, 270);
            this.txtIngredientes.Name = "txtIngredientes";
            this.txtIngredientes.Size = new System.Drawing.Size(379, 26);
            this.txtIngredientes.TabIndex = 8;
            // 
            // lblIngredientes
            // 
            this.lblIngredientes.AutoSize = true;
            this.lblIngredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredientes.ForeColor = System.Drawing.Color.White;
            this.lblIngredientes.Location = new System.Drawing.Point(4, 247);
            this.lblIngredientes.Name = "lblIngredientes";
            this.lblIngredientes.Size = new System.Drawing.Size(108, 20);
            this.lblIngredientes.TabIndex = 7;
            this.lblIngredientes.Text = "Ingredientes:*";
            // 
            // txtModoPreparo
            // 
            this.txtModoPreparo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModoPreparo.Location = new System.Drawing.Point(7, 322);
            this.txtModoPreparo.Name = "txtModoPreparo";
            this.txtModoPreparo.Size = new System.Drawing.Size(379, 26);
            this.txtModoPreparo.TabIndex = 10;
            // 
            // lblModoPreparo
            // 
            this.lblModoPreparo.AutoSize = true;
            this.lblModoPreparo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModoPreparo.ForeColor = System.Drawing.Color.White;
            this.lblModoPreparo.Location = new System.Drawing.Point(4, 299);
            this.lblModoPreparo.Name = "lblModoPreparo";
            this.lblModoPreparo.Size = new System.Drawing.Size(140, 20);
            this.lblModoPreparo.TabIndex = 9;
            this.lblModoPreparo.Text = "Modo de preparo:*";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacoes.Location = new System.Drawing.Point(7, 374);
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(247, 26);
            this.txtObservacoes.TabIndex = 12;
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacoes.ForeColor = System.Drawing.Color.White;
            this.lblObservacoes.Location = new System.Drawing.Point(4, 351);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(106, 20);
            this.lblObservacoes.TabIndex = 11;
            this.lblObservacoes.Text = "Observações:";
            // 
            // txtPesoFinal
            // 
            this.txtPesoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoFinal.Location = new System.Drawing.Point(256, 374);
            this.txtPesoFinal.Name = "txtPesoFinal";
            this.txtPesoFinal.Size = new System.Drawing.Size(130, 26);
            this.txtPesoFinal.TabIndex = 14;
            // 
            // lblPesoFinal
            // 
            this.lblPesoFinal.AutoSize = true;
            this.lblPesoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoFinal.ForeColor = System.Drawing.Color.White;
            this.lblPesoFinal.Location = new System.Drawing.Point(252, 351);
            this.lblPesoFinal.Name = "lblPesoFinal";
            this.lblPesoFinal.Size = new System.Drawing.Size(121, 20);
            this.lblPesoFinal.TabIndex = 13;
            this.lblPesoFinal.Text = "Peso final (Kg):*";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(100)))), ((int)(((byte)(60)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(100)))), ((int)(((byte)(60)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::ProjetoMeuChef.Properties.Resources.buscarMedio;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.Location = new System.Drawing.Point(244, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(74, 64);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "*Preenchimento obrigatório!";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(6, 49);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(232, 26);
            this.txtBuscar.TabIndex = 5;
            // 
            // btnLimpaBusca
            // 
            this.btnLimpaBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(158)))), ((int)(((byte)(60)))));
            this.btnLimpaBusca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpaBusca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(158)))), ((int)(((byte)(60)))));
            this.btnLimpaBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpaBusca.Image = global::ProjetoMeuChef.Properties.Resources.limpa;
            this.btnLimpaBusca.Location = new System.Drawing.Point(325, 11);
            this.btnLimpaBusca.Name = "btnLimpaBusca";
            this.btnLimpaBusca.Size = new System.Drawing.Size(48, 64);
            this.btnLimpaBusca.TabIndex = 6;
            this.btnLimpaBusca.UseVisualStyleBackColor = false;
            this.btnLimpaBusca.Click += new System.EventHandler(this.btnLimpaBusca_Click);
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpGeral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meu Chef - Gerenciador de Receitas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTelaPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmTelaPrincipal_Load);
            this.tlpGeral.ResumeLayout(false);
            this.gbDadosGerais.ResumeLayout(false);
            this.gbDadosGerais.PerformLayout();
            this.gbGradeDados.ResumeLayout(false);
            this.gbGradeDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceitas)).EndInit();
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpGeral;
        private System.Windows.Forms.GroupBox gbDadosGerais;
        private System.Windows.Forms.GroupBox gbGradeDados;
        private System.Windows.Forms.DataGridView dgvReceitas;
        private System.Windows.Forms.Label lblGradeReceitas;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.RadioButton rbObservacao;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtPesoFinal;
        private System.Windows.Forms.Label lblPesoFinal;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.TextBox txtModoPreparo;
        private System.Windows.Forms.Label lblModoPreparo;
        private System.Windows.Forms.TextBox txtIngredientes;
        private System.Windows.Forms.Label lblIngredientes;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnLimpaBusca;
    }
}