
namespace how_3
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
            this.botao_novo = new System.Windows.Forms.Button();
            this.botao_excluir = new System.Windows.Forms.Button();
            this.botao_salvar = new System.Windows.Forms.Button();
            this.botao_editar = new System.Windows.Forms.Button();
            this.botao_cancelar = new System.Windows.Forms.Button();
            this.label_codigo = new System.Windows.Forms.Label();
            this.label_genero = new System.Windows.Forms.Label();
            this.label_titulo = new System.Windows.Forms.Label();
            this.label_autor = new System.Windows.Forms.Label();
            this.label_ano = new System.Windows.Forms.Label();
            this.label_editora = new System.Windows.Forms.Label();
            this.label_descricao = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.tbEditora = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.dtgrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbGenero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // botao_novo
            // 
            this.botao_novo.Location = new System.Drawing.Point(26, 29);
            this.botao_novo.Name = "botao_novo";
            this.botao_novo.Size = new System.Drawing.Size(75, 23);
            this.botao_novo.TabIndex = 0;
            this.botao_novo.Text = "NOVO";
            this.botao_novo.UseVisualStyleBackColor = true;
            this.botao_novo.Click += new System.EventHandler(this.botao_novo_Click);
            // 
            // botao_excluir
            // 
            this.botao_excluir.Location = new System.Drawing.Point(107, 29);
            this.botao_excluir.Name = "botao_excluir";
            this.botao_excluir.Size = new System.Drawing.Size(75, 23);
            this.botao_excluir.TabIndex = 1;
            this.botao_excluir.Text = "EXCLUIR";
            this.botao_excluir.UseVisualStyleBackColor = true;
            this.botao_excluir.Click += new System.EventHandler(this.botao_excluir_Click);
            // 
            // botao_salvar
            // 
            this.botao_salvar.Location = new System.Drawing.Point(188, 29);
            this.botao_salvar.Name = "botao_salvar";
            this.botao_salvar.Size = new System.Drawing.Size(75, 23);
            this.botao_salvar.TabIndex = 2;
            this.botao_salvar.Text = "SALVAR";
            this.botao_salvar.UseVisualStyleBackColor = true;
            this.botao_salvar.Click += new System.EventHandler(this.botao_salvar_Click);
            // 
            // botao_editar
            // 
            this.botao_editar.Location = new System.Drawing.Point(269, 29);
            this.botao_editar.Name = "botao_editar";
            this.botao_editar.Size = new System.Drawing.Size(75, 23);
            this.botao_editar.TabIndex = 3;
            this.botao_editar.Text = "EDITAR";
            this.botao_editar.UseVisualStyleBackColor = true;
            this.botao_editar.Click += new System.EventHandler(this.botao_editar_Click);
            // 
            // botao_cancelar
            // 
            this.botao_cancelar.Location = new System.Drawing.Point(350, 29);
            this.botao_cancelar.Name = "botao_cancelar";
            this.botao_cancelar.Size = new System.Drawing.Size(75, 23);
            this.botao_cancelar.TabIndex = 4;
            this.botao_cancelar.Text = "CANCELAR";
            this.botao_cancelar.UseVisualStyleBackColor = true;
            this.botao_cancelar.Click += new System.EventHandler(this.botao_cancelar_Click);
            // 
            // label_codigo
            // 
            this.label_codigo.AutoSize = true;
            this.label_codigo.Location = new System.Drawing.Point(33, 85);
            this.label_codigo.Name = "label_codigo";
            this.label_codigo.Size = new System.Drawing.Size(40, 13);
            this.label_codigo.TabIndex = 5;
            this.label_codigo.Text = "Código";
            // 
            // label_genero
            // 
            this.label_genero.AutoSize = true;
            this.label_genero.Location = new System.Drawing.Point(33, 118);
            this.label_genero.Name = "label_genero";
            this.label_genero.Size = new System.Drawing.Size(42, 13);
            this.label_genero.TabIndex = 6;
            this.label_genero.Text = "Gênero";
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Location = new System.Drawing.Point(33, 150);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(35, 13);
            this.label_titulo.TabIndex = 7;
            this.label_titulo.Text = "Título";
            // 
            // label_autor
            // 
            this.label_autor.AutoSize = true;
            this.label_autor.Location = new System.Drawing.Point(33, 182);
            this.label_autor.Name = "label_autor";
            this.label_autor.Size = new System.Drawing.Size(32, 13);
            this.label_autor.TabIndex = 8;
            this.label_autor.Text = "Autor";
            // 
            // label_ano
            // 
            this.label_ano.AutoSize = true;
            this.label_ano.Location = new System.Drawing.Point(33, 212);
            this.label_ano.Name = "label_ano";
            this.label_ano.Size = new System.Drawing.Size(26, 13);
            this.label_ano.TabIndex = 9;
            this.label_ano.Text = "Ano";
            // 
            // label_editora
            // 
            this.label_editora.AutoSize = true;
            this.label_editora.Location = new System.Drawing.Point(33, 243);
            this.label_editora.Name = "label_editora";
            this.label_editora.Size = new System.Drawing.Size(40, 13);
            this.label_editora.TabIndex = 10;
            this.label_editora.Text = "Editora";
            // 
            // label_descricao
            // 
            this.label_descricao.AutoSize = true;
            this.label_descricao.Location = new System.Drawing.Point(33, 272);
            this.label_descricao.Name = "label_descricao";
            this.label_descricao.Size = new System.Drawing.Size(55, 13);
            this.label_descricao.TabIndex = 11;
            this.label_descricao.Text = "Descrição";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(86, 85);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(52, 20);
            this.tbCodigo.TabIndex = 12;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(86, 142);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(165, 20);
            this.tbTitulo.TabIndex = 13;
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(86, 174);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(165, 20);
            this.tbAutor.TabIndex = 14;
            // 
            // tbAno
            // 
            this.tbAno.Location = new System.Drawing.Point(86, 206);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(52, 20);
            this.tbAno.TabIndex = 15;
            // 
            // tbEditora
            // 
            this.tbEditora.Location = new System.Drawing.Point(86, 235);
            this.tbEditora.Name = "tbEditora";
            this.tbEditora.Size = new System.Drawing.Size(165, 20);
            this.tbEditora.TabIndex = 16;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(86, 265);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(165, 117);
            this.tbDescricao.TabIndex = 17;
            // 
            // dtgrid
            // 
            this.dtgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dtgrid.Location = new System.Drawing.Point(12, 398);
            this.dtgrid.Name = "dtgrid";
            this.dtgrid.Size = new System.Drawing.Size(776, 150);
            this.dtgrid.TabIndex = 19;
            this.dtgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Gênero";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Título";
            this.Column3.Name = "Column3";
            this.Column3.Width = 170;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Autor";
            this.Column4.Name = "Column4";
            this.Column4.Width = 170;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ano";
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Editora";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Descrição";
            this.Column7.Name = "Column7";
            this.Column7.Width = 200;
            // 
            // tbGenero
            // 
            this.tbGenero.Location = new System.Drawing.Point(86, 115);
            this.tbGenero.Name = "tbGenero";
            this.tbGenero.Size = new System.Drawing.Size(165, 20);
            this.tbGenero.TabIndex = 20;
            this.tbGenero.Text = "Roman";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.tbGenero);
            this.Controls.Add(this.dtgrid);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.tbEditora);
            this.Controls.Add(this.tbAno);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.label_descricao);
            this.Controls.Add(this.label_editora);
            this.Controls.Add(this.label_ano);
            this.Controls.Add(this.label_autor);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.label_genero);
            this.Controls.Add(this.label_codigo);
            this.Controls.Add(this.botao_cancelar);
            this.Controls.Add(this.botao_editar);
            this.Controls.Add(this.botao_salvar);
            this.Controls.Add(this.botao_excluir);
            this.Controls.Add(this.botao_novo);
            this.Name = "Form1";
            this.Text = "Cadastro de Livros";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botao_novo;
        private System.Windows.Forms.Button botao_excluir;
        private System.Windows.Forms.Button botao_salvar;
        private System.Windows.Forms.Button botao_editar;
        private System.Windows.Forms.Button botao_cancelar;
        private System.Windows.Forms.Label label_codigo;
        private System.Windows.Forms.Label label_genero;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label_autor;
        private System.Windows.Forms.Label label_ano;
        private System.Windows.Forms.Label label_editora;
        private System.Windows.Forms.Label label_descricao;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.TextBox tbEditora;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.DataGridView dtgrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TextBox tbGenero;
    }
}

