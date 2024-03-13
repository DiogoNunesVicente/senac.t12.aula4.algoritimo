namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtCidade = new TextBox();
            label6 = new Label();
            txtCEP = new TextBox();
            label5 = new Label();
            txtBairro = new TextBox();
            label4 = new Label();
            txtSobrenome = new TextBox();
            label3 = new Label();
            txtEndereco = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            btnImprimir = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnNome = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCidade);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtCEP);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtBairro);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSobrenome);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtEndereco);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(24, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(695, 295);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de Usuário";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(332, 181);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(240, 27);
            txtCidade.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(332, 163);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 10;
            label6.Text = "Cidade:";
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(25, 181);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(226, 27);
            txtCEP.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 163);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 8;
            label5.Text = "CEP:";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(332, 103);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(240, 27);
            txtBairro.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(332, 85);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 6;
            label4.Text = "Bairro:";
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(332, 37);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(240, 27);
            txtSobrenome.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(332, 19);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 4;
            label3.Text = "Sobrenome:";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(25, 103);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(226, 27);
            txtEndereco.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 85);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "Endereço:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(25, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(226, 27);
            txtNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 19);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnImprimir);
            groupBox3.Controls.Add(btnExcluir);
            groupBox3.Controls.Add(btnSalvar);
            groupBox3.Controls.Add(btnEditar);
            groupBox3.Controls.Add(btnNome);
            groupBox3.Font = new Font("Segoe UI", 12F);
            groupBox3.Location = new Point(24, 301);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(695, 137);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ações";
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(563, 34);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(80, 37);
            btnImprimir.TabIndex = 4;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(423, 34);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 37);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(304, 34);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 37);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(160, 34);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 37);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNome
            // 
            btnNome.Location = new Point(33, 34);
            btnNome.Name = "btnNome";
            btnNome.Size = new Size(75, 37);
            btnNome.TabIndex = 0;
            btnNome.Text = "Novo";
            btnNome.UseVisualStyleBackColor = true;
            btnNome.Click += btnNome_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnNome;
        private TextBox txtNome;
        private Label label1;
        private Button btnImprimir;
        private TextBox txtSobrenome;
        private Label label3;
        private TextBox txtEndereco;
        private Label label2;
        private TextBox txtCidade;
        private Label label6;
        private TextBox txtCEP;
        private Label label5;
        private TextBox txtBairro;
        private Label label4;
    }
}
