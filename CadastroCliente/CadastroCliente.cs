using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Threading;//biblioteca para chamar outra tela
using MySql.Data.MySqlClient;
namespace CadastroCliente
{
    public partial class CadastroCliente : Form
    {
       

        campovazio cam = new campovazio();


        // string conn = "server=127.0.0.1;database=bancodados; Uid=root; pwd=spartak10;";
        string conn = "server=sql10.freesqldatabase.com;database=sql10515956;Uid=sql10515956;pwd=XDwyjYkx37;";

        MySqlDataAdapter obj = new MySqlDataAdapter();
        MySqlCommand comando = new MySqlCommand();

        public CadastroCliente()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregar();
            string conn = "server=sql10.freesqldatabase.com;database=sql10515956;Uid=sql10515956;pwd=XDwyjYkx37;";

            //  string conn = "server=localhost:3306;database=bancodados; Uid=root; pwd=spartak10;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cam.campo(textnome, "Nome"))
                return;
            if (cam.campo(textlogadouro, "Endereço"))
                return;
            if (cam.campo(textnumero, "Número"))
                return;
            if (cam.campo(comboBoxcidade, "Cidade"))
                return;
            if (cam.campo(comboBoxEstado, "Estado"))
                return;
            if (cam.campo(textcpf, "Cpf"))
                return;
            if (cam.campo(textrg, "Rg"))
                return;
            if (cam.campo(texttelefone, "Telefone"))
                return;
            if (cam.campo(textemail, "E-Mail"))
                return;

            if (MessageBox.Show("Deseja salvar o registro?", "Pergunta?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                try
                {

                    MySqlConnection abrir = new MySqlConnection(conn);
                    abrir.Open();
                    comando.Connection = abrir;

                    comando.CommandText = "INSERT INTO cliente(Nome, endereco, Num, cidade, estado, Cpf, Rg, telefone, email) VALUES ('"
                        + textnome.Text + "','"
                        + textlogadouro.Text + "','"
                        + textnumero.Text + "','"
                        + comboBoxcidade.Text + "','"
                        + comboBoxEstado.Text + "','"
                        + textcpf.Text + "','"
                        + textrg.Text + "','"
                        + texttelefone.Text + "','"
                        + textemail.Text + "')";
                    comando.ExecuteNonQuery();
                    

                    MessageBox.Show("REGISTRO INSERIDO COM SUCESSO!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    abrir.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocorreu um erro na hora de salvar!", "ERRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                }
            }
            
            else
            {
                MessageBox.Show("Ocorreu um erro na conexão", "ERRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
         }
       

        private void BTNDeletar_Click(object sender, EventArgs e)
        {
            int indice = gridpesquisa.CurrentRow.Index;
            string remover = gridpesquisa[9, indice].Value.ToString();
            comando.CommandText = "DELETE FROM cliente WHERE email LIKE'" + remover + "'";


            if (MessageBox.Show("Deseja EXCLUIR o registro?", "EXCLUIR?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    MySqlConnection abrir = new MySqlConnection(conn);
                    abrir.Open();
                    comando.Connection = abrir;
                    comando.ExecuteNonQuery();
                    

                    MessageBox.Show("REGISTRO EXCLUIDO COM SUCESSO!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    abrir.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Falha na hora de EXCLUIR!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Ocorreu um erro na conexão", "ERRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void BTNPESQUISAR_Click(object sender, EventArgs e)
        {

        string pesq = "SELECT * FROM sql10515956.cliente WHERE Nome LIKE +'%" + textBox1.Text + "%' ORDER BY Nome ASC";
            DataTable data = new DataTable();
            MySqlConnection abrir = new MySqlConnection(conn);




            try
            {
                abrir.Open();
                comando.Connection = abrir;

                 MySqlDataAdapter da = new MySqlDataAdapter(pesq,conn);
                
                da.Fill(data);
                gridpesquisa.DataSource = data;



            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro " + ex);
            }
            finally
            {
                abrir.Close();
            }
            
      }

        private void BTNALTERAR_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja ALTERA o registro?", "Pergunta?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {

                    MySqlConnection abrir = new MySqlConnection(conn);
                    abrir.Open();
                    comando.Connection = abrir;

                    comando.CommandText = "UPDATE cliente set Nome ='" 
                        + textnome.Text + "',endereco='"
                        + textlogadouro.Text + "',Num='"
                        + textnumero.Text + "',cidade='"
                        + comboBoxcidade.Text + "',estado='"
                        + comboBoxEstado.Text + "',Cpf='"
                        + textcpf.Text + "',Rg='"
                        + textrg.Text + "',telefone='"
                        + texttelefone.Text + "',email='"
                        + textemail.Text + "'";
                    comando.ExecuteNonQuery();


                    MessageBox.Show("REGISTRO MODIFICADO COM SUCESSO!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    abrir.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocorreu um erro na hora de MODIFICAR!", "ERRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                }
            }

            else
            {
                MessageBox.Show("Ocorreu um erro na conexão", "ERRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void BTNADICIONAR_Click(object sender, EventArgs e)
        {
            textnome.Enabled = true;
            textlogadouro.Enabled = true;
            textnumero.Enabled = true;
            comboBoxcidade.Enabled = true;
            comboBoxEstado.Enabled = true;
            textcpf.Enabled = true;
            textrg.Enabled = true;
            texttelefone.Enabled = true;
            textemail.Enabled = true;
        }

        private void Btncarregar_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection(conn);

            string pesq = "SELECT * FROM sql10515956.cliente;";

            DataTable data = new DataTable();
            try
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(pesq, conn);

                da.Fill(data);
                gridpesquisa.DataSource = data;



            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro " + ex);
            }

        }
        void carregar()
        {

            MySqlConnection con = new MySqlConnection(conn);

            string pesq = "SELECT * FROM sql10515956.cliente;";

            DataTable data = new DataTable();
            try
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(pesq, conn);

                da.Fill(data);
                gridpesquisa.DataSource = data;



            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro " + ex);
            }

        }

        private void gridpesquisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            carregar();
        }

        private void textnome_TextChanged(object sender, EventArgs e)
        {

        }
        

    }


}
 


