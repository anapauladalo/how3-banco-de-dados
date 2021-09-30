using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace how_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private MySqlConnectionStringBuilder conexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "livraria";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }
        private void atualizarGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open();

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM livro WHERE ativoLivro = 1";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dtgrid.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dtgrid.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//codigo
                    row.Cells[1].Value = reader.GetString(1);//genero
                    row.Cells[2].Value = reader.GetString(2);//titulo
                    row.Cells[3].Value = reader.GetString(3);//autor
                    row.Cells[4].Value = reader.GetInt32(4);//ANO
                    row.Cells[5].Value = reader.GetString(5);//editora               
                    row.Cells[6].Value = reader.GetString(6);//descricao
                    dtgrid.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                realizaConexaoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void botao_cancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
        private void limparCampos()

        {
            tbCodigo.Clear();
            tbGenero.Text = "";
            tbTitulo.Clear();
            tbAutor.Clear();
            tbAno.Clear();
            tbEditora.Clear();
            tbDescricao.Clear();
        }

        private void botao_salvar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open();

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand();


                comandoMySql.CommandText = "INSERT INTO livro (generoLivro,tituloLivro,autorLivro,anolivro,editoraLivro,descricaoLivro) " +
                      "VALUES('" + tbGenero.Text + "', '" + tbTitulo.Text + "','" + tbAutor.Text + "', " + Convert.ToInt16(tbAno.Text) + ",'" + tbEditora.Text + "','" + tbDescricao.Text + "')";


                comandoMySql.ExecuteNonQuery();

                realizaConexaoBD.Close();
                MessageBox.Show("Inserido com sucesso");
                atualizarGrid();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void botao_editar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand(); //Crio um comando SQL
                comandoMySql.CommandText = "UPDATE livro SET generoLivro = '" + tbGenero.Text + "', " +
                    "tituloLivro = '" + tbTitulo.Text + "', " +
                    "autorLivro = '" + tbAutor.Text + "', " +
                     "editoraLivro = '" + tbEditora.Text + "', " +
                    "descricaoLivro = '" + tbDescricao.Text + "', " +
                    "anoLivro = " + Convert.ToInt16(tbAno.Text) +
                    " WHERE codigoLivro = " + tbCodigo.Text + "";
                comandoMySql.ExecuteNonQuery();

                realizaConexaoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Atualizado com sucesso"); //Exibo mensagem de aviso
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void botao_excluir_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand(); //Crio um comando SQL
                // "DELETE FROM filme WHERE idFilme = "+ textBoxId.Text +""
                //comandoMySql.CommandText = "DELETE FROM filme WHERE id Filme = " + tbID.Text + "";
                comandoMySql.CommandText = "DELETE FROM livro WHERE codigoLivro = " + tbCodigo.Text + "";

                comandoMySql.ExecuteNonQuery();

                realizaConexaoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Deletado com sucesso"); //Exibo mensagem de aviso
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void dtgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dtgrid.CurrentRow.Selected = true;
                //preenche os textbox com as células da linha selecionada
                tbCodigo.Text = dtgrid.Rows[e.RowIndex].Cells["Column1"].FormattedValue.ToString();
                tbGenero.Text = dtgrid.Rows[e.RowIndex].Cells["Column2"].FormattedValue.ToString();
                tbTitulo.Text = dtgrid.Rows[e.RowIndex].Cells["Column3"].FormattedValue.ToString();
                tbAutor.Text = dtgrid.Rows[e.RowIndex].Cells["Column4"].FormattedValue.ToString();
                tbAno.Text = dtgrid.Rows[e.RowIndex].Cells["Column5"].FormattedValue.ToString();
                tbEditora.Text = dtgrid.Rows[e.RowIndex].Cells["Column6"].FormattedValue.ToString();
                tbDescricao.Text = dtgrid.Rows[e.RowIndex].Cells["Column7"].FormattedValue.ToString();
            }
        }

        private void botao_novo_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
    }
}