namespace Aplicativos
{
    partial class senha
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
            this.components = new System.ComponentModel.Container();
            this.Sair = new System.Windows.Forms.Button();
            this.Conectar = new System.Windows.Forms.Button();
            this.usuario = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Sair
            // 
            this.Sair.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Sair.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sair.Location = new System.Drawing.Point(247, 169);
            this.Sair.Margin = new System.Windows.Forms.Padding(4);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(100, 28);
            this.Sair.TabIndex = 0;
            this.Sair.Text = "Sair";
            this.toolTip1.SetToolTip(this.Sair, "SAIR do Sistema");
            this.Sair.UseVisualStyleBackColor = false;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // Conectar
            // 
            this.Conectar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Conectar.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conectar.Location = new System.Drawing.Point(365, 169);
            this.Conectar.Margin = new System.Windows.Forms.Padding(4);
            this.Conectar.Name = "Conectar";
            this.Conectar.Size = new System.Drawing.Size(100, 28);
            this.Conectar.TabIndex = 3;
            this.Conectar.Text = "Conectar";
            this.toolTip1.SetToolTip(this.Conectar, "Botão CONECTAR");
            this.Conectar.UseVisualStyleBackColor = false;
            this.Conectar.Click += new System.EventHandler(this.button2_Click);
            // 
            // usuario
            // 
            this.usuario.BackColor = System.Drawing.SystemColors.Info;
            this.usuario.Location = new System.Drawing.Point(326, 65);
            this.usuario.Margin = new System.Windows.Forms.Padding(4);
            this.usuario.Name = "usuario";
            this.usuario.PasswordChar = '*';
            this.usuario.Size = new System.Drawing.Size(103, 22);
            this.usuario.TabIndex = 1;
            this.toolTip1.SetToolTip(this.usuario, "Digite o USUÁRIO");
            this.usuario.UseSystemPasswordChar = true;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.Info;
            this.login.Location = new System.Drawing.Point(326, 113);
            this.login.Margin = new System.Windows.Forms.Padding(4);
            this.login.Name = "login";
            this.login.PasswordChar = '*';
            this.login.Size = new System.Drawing.Size(103, 22);
            this.login.TabIndex = 2;
            this.toolTip1.SetToolTip(this.login, "Digite à sua SENHA");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA DE APLICATIVOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::CadastroCliente.Properties.Resources.usuario;
            this.pictureBox2.Image = global::CadastroCliente.Properties.Resources.usuario;
            this.pictureBox2.Location = new System.Drawing.Point(12, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(210, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuário:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CadastroCliente.Properties.Resources.rochas;
            this.ClientSize = new System.Drawing.Size(612, 303);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.Conectar);
            this.Controls.Add(this.Sair);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "senha";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rochas Sistemas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Button Conectar;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}