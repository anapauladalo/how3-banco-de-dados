
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dtgrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // 
            // botao_excluir
            // 
            this.botao_excluir.Location = new System.Drawing.Point(107, 29);
            this.botao_excluir.Name = "botao_excluir";
            this.botao_excluir.Size = new System.Drawing.Size(75, 23);
            this.botao_excluir.TabIndex = 1;
            this.botao_excluir.Text = "EXCLUIR";
            this.botao_excluir.UseVisualStyleBackColor = true;
            // 
            // botao_salvar
            // 
            this.botao_salvar.Location = new System.Drawing.Point(188, 29);
            this.botao_salvar.Name = "botao_salvar";
            this.botao_salvar.Size = new System.Drawing.Size(75, 23);
            this.botao_salvar.TabIndex = 2;
            this.botao_salvar.Text = "SALVAR";
            this.botao_salvar.UseVisualStyleBackColor = true;
            // 
            // botao_editar
            // 
            this.botao_editar.Location = new System.Drawing.Point(269, 29);
            this.botao_editar.Name = "botao_editar";
            this.botao_editar.Size = new System.Drawing.Size(75, 23);
            this.botao_editar.TabIndex = 3;
            this.botao_editar.Text = "EDITAR";
            this.botao_editar.UseVisualStyleBackColor = true;
            // 
            // botao_cancelar
            // 
            this.botao_cancelar.Location = new System.Drawing.Point(350, 29);
            this.botao_cancelar.Name = "botao_cancelar";
            this.botao_cancelar.Size = new System.Drawing.Size(75, 23);
            this.botao_cancelar.TabIndex = 4;
            this.botao_cancelar.Text = "CANCELAR";
            this.botao_cancelar.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 20);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(86, 174);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(165, 20);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(86, 206);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(52, 20);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(86, 235);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(165, 20);
            this.textBox5.TabIndex = 16;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(86, 265);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(165, 117);
            this.textBox6.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 21);
            this.comboBox1.TabIndex = 18;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.dtgrid);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dtgrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}

