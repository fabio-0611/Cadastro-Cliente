using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;// para chamar outro formulário

namespace Aplicativos
{
    public partial class senha : Form
    {
        Thread Novo;//variável para poder declarar
        public senha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (usuario.Text == "1234" && login.Text =="1234")
            {
                MessageBox.Show("SEJÁ BEM-VINDO AO SISTEMA");
                this.Close();//fecha o formulário que esta utilizando
                Novo = new Thread(novoForm);
                Novo.SetApartmentState(ApartmentState.STA);
                Novo.Start();
               
            
            }
            else
            {
                MessageBox.Show("USUÁRIO ou SENHA inválido");//se estiver errado vira esta mensagem ao usuário
            }
        }
        private void Sair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void novoForm()
        {
            Application.Run(new CadastroCliente.CadastroCliente());
        }
    }
    }

