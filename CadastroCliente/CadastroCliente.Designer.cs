namespace CadastroCliente
{
    partial class CadastroCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BTNCADASTRAR = new System.Windows.Forms.Button();
            this.textnome = new System.Windows.Forms.TextBox();
            this.textlogadouro = new System.Windows.Forms.TextBox();
            this.textnumero = new System.Windows.Forms.TextBox();
            this.comboBoxcidade = new System.Windows.Forms.ComboBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.textemail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textrg = new System.Windows.Forms.TextBox();
            this.textcpf = new System.Windows.Forms.MaskedTextBox();
            this.texttelefone = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BTNDeletar = new System.Windows.Forms.Button();
            this.BTNPESQUISAR = new System.Windows.Forms.Button();
            this.gridpesquisa = new System.Windows.Forms.DataGridView();
            this.BTNALTERAR = new System.Windows.Forms.Button();
            this.BTNADICIONAR = new System.Windows.Forms.Button();
            this.Btncarregar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridpesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNCADASTRAR
            // 
            this.BTNCADASTRAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BTNCADASTRAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNCADASTRAR.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BTNCADASTRAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BTNCADASTRAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BTNCADASTRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCADASTRAR.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCADASTRAR.Location = new System.Drawing.Point(19, 509);
            this.BTNCADASTRAR.Name = "BTNCADASTRAR";
            this.BTNCADASTRAR.Size = new System.Drawing.Size(100, 23);
            this.BTNCADASTRAR.TabIndex = 9;
            this.BTNCADASTRAR.Text = "Cadastrar";
            this.toolTip1.SetToolTip(this.BTNCADASTRAR, "Clique para cadastrar o cliente ");
            this.BTNCADASTRAR.UseVisualStyleBackColor = false;
            this.BTNCADASTRAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // textnome
            // 
            this.textnome.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textnome.Enabled = false;
            this.textnome.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnome.Location = new System.Drawing.Point(12, 230);
            this.textnome.Name = "textnome";
            this.textnome.Size = new System.Drawing.Size(309, 22);
            this.textnome.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textnome, "Digite o seu Nome");
            this.textnome.TextChanged += new System.EventHandler(this.textnome_TextChanged);
            // 
            // textlogadouro
            // 
            this.textlogadouro.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textlogadouro.Enabled = false;
            this.textlogadouro.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textlogadouro.Location = new System.Drawing.Point(6, 287);
            this.textlogadouro.Name = "textlogadouro";
            this.textlogadouro.Size = new System.Drawing.Size(315, 22);
            this.textlogadouro.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textlogadouro, "Digite seu ENDEREÇO");
            // 
            // textnumero
            // 
            this.textnumero.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textnumero.Enabled = false;
            this.textnumero.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnumero.Location = new System.Drawing.Point(341, 287);
            this.textnumero.Name = "textnumero";
            this.textnumero.Size = new System.Drawing.Size(60, 22);
            this.textnumero.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textnumero, "Digite o número da residência");
            // 
            // comboBoxcidade
            // 
            this.comboBoxcidade.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBoxcidade.Enabled = false;
            this.comboBoxcidade.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxcidade.FormattingEnabled = true;
            this.comboBoxcidade.Items.AddRange(new object[] {
            "São Paulo",
            "Rio de Janeiro",
            "Espiríto Santo",
            "Minas Gerais"});
            this.comboBoxcidade.Location = new System.Drawing.Point(6, 342);
            this.comboBoxcidade.Name = "comboBoxcidade";
            this.comboBoxcidade.Size = new System.Drawing.Size(121, 24);
            this.comboBoxcidade.TabIndex = 3;
            this.toolTip1.SetToolTip(this.comboBoxcidade, "Cique na Seta e escolha seu estado");
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBoxEstado.Enabled = false;
            this.comboBoxEstado.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "ES",
            "MG"});
            this.comboBoxEstado.Location = new System.Drawing.Point(165, 342);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(61, 24);
            this.comboBoxEstado.TabIndex = 4;
            this.toolTip1.SetToolTip(this.comboBoxEstado, "Cique na Seta e escolha seu estado");
            // 
            // textemail
            // 
            this.textemail.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textemail.Enabled = false;
            this.textemail.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textemail.Location = new System.Drawing.Point(6, 463);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(181, 22);
            this.textemail.TabIndex = 8;
            this.toolTip1.SetToolTip(this.textemail, "Digite o seu Email");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Logadouro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nº:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(166, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cpf:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(145, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Rg:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(308, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Telefone:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 441);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "E-mail:";
            // 
            // textrg
            // 
            this.textrg.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textrg.Enabled = false;
            this.textrg.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textrg.Location = new System.Drawing.Point(122, 404);
            this.textrg.Name = "textrg";
            this.textrg.Size = new System.Drawing.Size(169, 22);
            this.textrg.TabIndex = 6;
            this.toolTip1.SetToolTip(this.textrg, "Digite o RG");
            // 
            // textcpf
            // 
            this.textcpf.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textcpf.Enabled = false;
            this.textcpf.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcpf.Location = new System.Drawing.Point(6, 404);
            this.textcpf.Mask = "00.000.000-00";
            this.textcpf.Name = "textcpf";
            this.textcpf.Size = new System.Drawing.Size(100, 22);
            this.textcpf.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textcpf, "Digite seu CPF");
            // 
            // texttelefone
            // 
            this.texttelefone.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.texttelefone.Enabled = false;
            this.texttelefone.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texttelefone.Location = new System.Drawing.Point(312, 404);
            this.texttelefone.Mask = "(99)00000-0000";
            this.texttelefone.Name = "texttelefone";
            this.texttelefone.Size = new System.Drawing.Size(131, 22);
            this.texttelefone.TabIndex = 7;
            this.toolTip1.SetToolTip(this.texttelefone, "Digite o seu TELEFONE");
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // BTNDeletar
            // 
            this.BTNDeletar.BackColor = System.Drawing.Color.DarkGray;
            this.BTNDeletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNDeletar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BTNDeletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BTNDeletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BTNDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNDeletar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDeletar.Location = new System.Drawing.Point(149, 509);
            this.BTNDeletar.Name = "BTNDeletar";
            this.BTNDeletar.Size = new System.Drawing.Size(100, 23);
            this.BTNDeletar.TabIndex = 10;
            this.BTNDeletar.TabStop = false;
            this.BTNDeletar.Text = "Deletar";
            this.toolTip1.SetToolTip(this.BTNDeletar, "Clique para apagar um registro");
            this.BTNDeletar.UseVisualStyleBackColor = false;
            this.BTNDeletar.Click += new System.EventHandler(this.BTNDeletar_Click);
            // 
            // BTNPESQUISAR
            // 
            this.BTNPESQUISAR.BackColor = System.Drawing.Color.Transparent;
            this.BTNPESQUISAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNPESQUISAR.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BTNPESQUISAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BTNPESQUISAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BTNPESQUISAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNPESQUISAR.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNPESQUISAR.Location = new System.Drawing.Point(557, 20);
            this.BTNPESQUISAR.Name = "BTNPESQUISAR";
            this.BTNPESQUISAR.Size = new System.Drawing.Size(80, 23);
            this.BTNPESQUISAR.TabIndex = 13;
            this.BTNPESQUISAR.Text = "Pesquisar";
            this.toolTip1.SetToolTip(this.BTNPESQUISAR, "Clique para pesquisar um registro");
            this.BTNPESQUISAR.UseVisualStyleBackColor = false;
            this.BTNPESQUISAR.Click += new System.EventHandler(this.BTNPESQUISAR_Click);
            // 
            // gridpesquisa
            // 
            this.gridpesquisa.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.gridpesquisa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridpesquisa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.gridpesquisa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.gridpesquisa.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridpesquisa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridpesquisa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridpesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridpesquisa.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridpesquisa.Location = new System.Drawing.Point(364, 49);
            this.gridpesquisa.Name = "gridpesquisa";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.gridpesquisa.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridpesquisa.Size = new System.Drawing.Size(904, 166);
            this.gridpesquisa.TabIndex = 15;
            this.toolTip1.SetToolTip(this.gridpesquisa, "Clique para alerar algum registro");
            this.gridpesquisa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridpesquisa_CellContentClick);
            // 
            // BTNALTERAR
            // 
            this.BTNALTERAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BTNALTERAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNALTERAR.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BTNALTERAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BTNALTERAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BTNALTERAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNALTERAR.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNALTERAR.Location = new System.Drawing.Point(270, 509);
            this.BTNALTERAR.Name = "BTNALTERAR";
            this.BTNALTERAR.Size = new System.Drawing.Size(100, 23);
            this.BTNALTERAR.TabIndex = 11;
            this.BTNALTERAR.TabStop = false;
            this.BTNALTERAR.Text = "Alterar";
            this.toolTip1.SetToolTip(this.BTNALTERAR, "Clique para Alterar");
            this.BTNALTERAR.UseVisualStyleBackColor = false;
            this.BTNALTERAR.Click += new System.EventHandler(this.BTNALTERAR_Click);
            // 
            // BTNADICIONAR
            // 
            this.BTNADICIONAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BTNADICIONAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNADICIONAR.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BTNADICIONAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BTNADICIONAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BTNADICIONAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNADICIONAR.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNADICIONAR.Location = new System.Drawing.Point(396, 509);
            this.BTNADICIONAR.Name = "BTNADICIONAR";
            this.BTNADICIONAR.Size = new System.Drawing.Size(100, 23);
            this.BTNADICIONAR.TabIndex = 12;
            this.BTNADICIONAR.Text = "Adicionar";
            this.toolTip1.SetToolTip(this.BTNADICIONAR, "Clique para Adicionar Cliente");
            this.BTNADICIONAR.UseVisualStyleBackColor = false;
            this.BTNADICIONAR.Click += new System.EventHandler(this.BTNADICIONAR_Click);
            // 
            // Btncarregar
            // 
            this.Btncarregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btncarregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btncarregar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Btncarregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Btncarregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Btncarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btncarregar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btncarregar.Location = new System.Drawing.Point(531, 509);
            this.Btncarregar.Name = "Btncarregar";
            this.Btncarregar.Size = new System.Drawing.Size(106, 23);
            this.Btncarregar.TabIndex = 19;
            this.Btncarregar.Text = "Carregar";
            this.toolTip1.SetToolTip(this.Btncarregar, "Clique para SALVAR ");
            this.Btncarregar.UseVisualStyleBackColor = false;
            this.Btncarregar.Click += new System.EventHandler(this.Btncarregar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(364, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 20);
            this.textBox1.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1268, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "CADASTRO de CLIENTE";
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1268, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btncarregar);
            this.Controls.Add(this.BTNADICIONAR);
            this.Controls.Add(this.BTNALTERAR);
            this.Controls.Add(this.gridpesquisa);
            this.Controls.Add(this.BTNPESQUISAR);
            this.Controls.Add(this.BTNDeletar);
            this.Controls.Add(this.texttelefone);
            this.Controls.Add(this.textcpf);
            this.Controls.Add(this.textrg);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.comboBoxcidade);
            this.Controls.Add(this.textnumero);
            this.Controls.Add(this.textlogadouro);
            this.Controls.Add(this.textnome);
            this.Controls.Add(this.BTNCADASTRAR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ROCHA SISTEMAS";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridpesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNCADASTRAR;
        private System.Windows.Forms.TextBox textnome;
        private System.Windows.Forms.TextBox textlogadouro;
        private System.Windows.Forms.TextBox textnumero;
        private System.Windows.Forms.ComboBox comboBoxcidade;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textrg;
        private System.Windows.Forms.MaskedTextBox textcpf;
        private System.Windows.Forms.MaskedTextBox texttelefone;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BTNDeletar;
        private System.Windows.Forms.Button BTNPESQUISAR;
        private System.Windows.Forms.DataGridView gridpesquisa;
        private System.Windows.Forms.Button BTNALTERAR;
        private System.Windows.Forms.Button BTNADICIONAR;
        private System.Windows.Forms.Button Btncarregar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
    }
}

