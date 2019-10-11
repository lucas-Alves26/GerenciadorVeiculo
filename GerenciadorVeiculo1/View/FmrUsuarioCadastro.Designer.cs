namespace GerenciadorVeiculo1.View
{
    partial class fmrCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) { 
        //{
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.CV = new System.Windows.Forms.Label();
            this.lblNascUs = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblRgUs = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxSex = new System.Windows.Forms.ComboBox();
            this.txtOpe = new System.Windows.Forms.TextBox();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtDdd = new System.Windows.Forms.TextBox();
            this.cbxCargo = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNasc = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOpUs = new System.Windows.Forms.Label();
            this.lblCelularUs = new System.Windows.Forms.Label();
            this.lblTelefoneUS = new System.Windows.Forms.Label();
            this.lblDdd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTele = new System.Windows.Forms.GroupBox();
            this.cbxCidade = new System.Windows.Forms.ComboBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtComp = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblCepUs = new System.Windows.Forms.Label();
            this.lblEstadoUs = new System.Windows.Forms.Label();
            this.lblCidadeUs = new System.Windows.Forms.Label();
            this.lblBairroUs = new System.Windows.Forms.Label();
            this.lblComplementoUs = new System.Windows.Forms.Label();
            this.lblNumeroUs = new System.Windows.Forms.Label();
            this.lblRuaUs = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtSenha2 = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblLoginUs = new System.Windows.Forms.Label();
            this.lblConfirSenha = new System.Windows.Forms.Label();
            this.lblSenhaUs = new System.Windows.Forms.Label();
            this.btnSalvarUs = new System.Windows.Forms.Button();
            this.btnLimparUs = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.txtTele.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(11, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAbrir);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(561, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 190);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Foto usuário";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(68, 161);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(60, 23);
            this.btnAbrir.TabIndex = 22;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // CV
            // 
            this.CV.AutoSize = true;
            this.CV.Location = new System.Drawing.Point(14, 25);
            this.CV.Name = "CV";
            this.CV.Size = new System.Drawing.Size(88, 13);
            this.CV.TabIndex = 23;
            this.CV.Text = "Nome completo *";
            // 
            // lblNascUs
            // 
            this.lblNascUs.AutoSize = true;
            this.lblNascUs.Location = new System.Drawing.Point(316, 25);
            this.lblNascUs.Name = "lblNascUs";
            this.lblNascUs.Size = new System.Drawing.Size(65, 13);
            this.lblNascUs.TabIndex = 24;
            this.lblNascUs.Text = "Data Nasc *";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(399, 26);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(34, 13);
            this.lblCpf.TabIndex = 25;
            this.lblCpf.Text = "CPF *";
            // 
            // lblRgUs
            // 
            this.lblRgUs.AutoSize = true;
            this.lblRgUs.Location = new System.Drawing.Point(14, 73);
            this.lblRgUs.Name = "lblRgUs";
            this.lblRgUs.Size = new System.Drawing.Size(27, 13);
            this.lblRgUs.TabIndex = 26;
            this.lblRgUs.Text = "RG*";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxSex);
            this.groupBox2.Controls.Add(this.txtOpe);
            this.groupBox2.Controls.Add(this.txtCel);
            this.groupBox2.Controls.Add(this.txtTel);
            this.groupBox2.Controls.Add(this.txtDdd);
            this.groupBox2.Controls.Add(this.cbxCargo);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtRg);
            this.groupBox2.Controls.Add(this.txtCpf);
            this.groupBox2.Controls.Add(this.txtNasc);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblOpUs);
            this.groupBox2.Controls.Add(this.lblCelularUs);
            this.groupBox2.Controls.Add(this.lblTelefoneUS);
            this.groupBox2.Controls.Add(this.lblDdd);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblRgUs);
            this.groupBox2.Controls.Add(this.lblCpf);
            this.groupBox2.Controls.Add(this.lblNascUs);
            this.groupBox2.Controls.Add(this.CV);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 190);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Pessoais";
            // 
            // cbxSex
            // 
            this.cbxSex.FormattingEnabled = true;
            this.cbxSex.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cbxSex.Location = new System.Drawing.Point(17, 135);
            this.cbxSex.Name = "cbxSex";
            this.cbxSex.Size = new System.Drawing.Size(65, 21);
            this.cbxSex.TabIndex = 48;
            this.cbxSex.SelectedIndexChanged += new System.EventHandler(this.cbxSex_SelectedIndexChanged);
            this.cbxSex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxSex_KeyPress);
            // 
            // txtOpe
            // 
            this.txtOpe.Location = new System.Drawing.Point(298, 135);
            this.txtOpe.MaxLength = 15;
            this.txtOpe.Name = "txtOpe";
            this.txtOpe.Size = new System.Drawing.Size(73, 20);
            this.txtOpe.TabIndex = 47;
            this.txtOpe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOpe_KeyPress);
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(214, 135);
            this.txtCel.MaxLength = 9;
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(68, 20);
            this.txtCel.TabIndex = 46;
            this.txtCel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCel.TextChanged += new System.EventHandler(this.txtCel_TextChanged);
            this.txtCel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCel_KeyPress);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(135, 135);
            this.txtTel.MaxLength = 8;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(63, 20);
            this.txtTel.TabIndex = 45;
            this.txtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTel.TextChanged += new System.EventHandler(this.txtTel_TextChanged);
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            this.txtTel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTel_KeyUp);
            // 
            // txtDdd
            // 
            this.txtDdd.Location = new System.Drawing.Point(91, 135);
            this.txtDdd.MaxLength = 3;
            this.txtDdd.Name = "txtDdd";
            this.txtDdd.Size = new System.Drawing.Size(28, 20);
            this.txtDdd.TabIndex = 44;
            this.txtDdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDdd_KeyPress);
            // 
            // cbxCargo
            // 
            this.cbxCargo.DisplayMember = "n";
            this.cbxCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCargo.FormattingEnabled = true;
            this.cbxCargo.Items.AddRange(new object[] {
            "Usuário",
            "Administrador"});
            this.cbxCargo.Location = new System.Drawing.Point(132, 89);
            this.cbxCargo.MaxLength = 30;
            this.cbxCargo.Name = "cbxCargo";
            this.cbxCargo.Size = new System.Drawing.Size(100, 21);
            this.cbxCargo.TabIndex = 42;
            this.cbxCargo.Tag = "";
            this.cbxCargo.ValueMember = "n";
            this.cbxCargo.SelectedIndexChanged += new System.EventHandler(this.cbxCargo_SelectedIndexChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(251, 90);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(238, 20);
            this.txtEmail.TabIndex = 41;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(17, 90);
            this.txtRg.MaxLength = 9;
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(100, 20);
            this.txtRg.TabIndex = 39;
            this.txtRg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRg_KeyPress);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(402, 42);
            this.txtCpf.MaxLength = 11;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(85, 20);
            this.txtCpf.TabIndex = 38;
            this.txtCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCpf.TextChanged += new System.EventHandler(this.txtCpf_TextChanged);
            this.txtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpf_KeyPress);
            // 
            // txtNasc
            // 
            this.txtNasc.Location = new System.Drawing.Point(319, 42);
            this.txtNasc.MaxLength = 10;
            this.txtNasc.Name = "txtNasc";
            this.txtNasc.Size = new System.Drawing.Size(68, 20);
            this.txtNasc.TabIndex = 37;
            this.txtNasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNasc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNasc_KeyPress);
            this.txtNasc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNasc_KeyUp);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(17, 42);
            this.txtName.MaxLength = 60;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(286, 20);
            this.txtName.TabIndex = 36;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Sexo *";
            // 
            // lblOpUs
            // 
            this.lblOpUs.AutoSize = true;
            this.lblOpUs.Location = new System.Drawing.Point(295, 119);
            this.lblOpUs.Name = "lblOpUs";
            this.lblOpUs.Size = new System.Drawing.Size(57, 13);
            this.lblOpUs.TabIndex = 34;
            this.lblOpUs.Text = "Operadora";
            // 
            // lblCelularUs
            // 
            this.lblCelularUs.AutoSize = true;
            this.lblCelularUs.Location = new System.Drawing.Point(211, 119);
            this.lblCelularUs.Name = "lblCelularUs";
            this.lblCelularUs.Size = new System.Drawing.Size(46, 13);
            this.lblCelularUs.TabIndex = 33;
            this.lblCelularUs.Text = "Celular *";
            // 
            // lblTelefoneUS
            // 
            this.lblTelefoneUS.AutoSize = true;
            this.lblTelefoneUS.Location = new System.Drawing.Point(132, 119);
            this.lblTelefoneUS.Name = "lblTelefoneUS";
            this.lblTelefoneUS.Size = new System.Drawing.Size(49, 13);
            this.lblTelefoneUS.TabIndex = 31;
            this.lblTelefoneUS.Text = "Telefone";
            // 
            // lblDdd
            // 
            this.lblDdd.AutoSize = true;
            this.lblDdd.Location = new System.Drawing.Point(88, 119);
            this.lblDdd.Name = "lblDdd";
            this.lblDdd.Size = new System.Drawing.Size(31, 13);
            this.lblDdd.TabIndex = 30;
            this.lblDdd.Text = "DDD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Cargo *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "E-Mail";
            // 
            // txtTele
            // 
            this.txtTele.Controls.Add(this.cbxCidade);
            this.txtTele.Controls.Add(this.cbxEstado);
            this.txtTele.Controls.Add(this.txtCep);
            this.txtTele.Controls.Add(this.txtBairro);
            this.txtTele.Controls.Add(this.txtComp);
            this.txtTele.Controls.Add(this.txtNum);
            this.txtTele.Controls.Add(this.txtRua);
            this.txtTele.Controls.Add(this.lblCepUs);
            this.txtTele.Controls.Add(this.lblEstadoUs);
            this.txtTele.Controls.Add(this.lblCidadeUs);
            this.txtTele.Controls.Add(this.lblBairroUs);
            this.txtTele.Controls.Add(this.lblComplementoUs);
            this.txtTele.Controls.Add(this.lblNumeroUs);
            this.txtTele.Controls.Add(this.lblRuaUs);
            this.txtTele.Location = new System.Drawing.Point(12, 220);
            this.txtTele.Name = "txtTele";
            this.txtTele.Size = new System.Drawing.Size(688, 120);
            this.txtTele.TabIndex = 29;
            this.txtTele.TabStop = false;
            this.txtTele.Text = "Endereço";
            // 
            // cbxCidade
            // 
            this.cbxCidade.FormattingEnabled = true;
            this.cbxCidade.Location = new System.Drawing.Point(157, 91);
            this.cbxCidade.Name = "cbxCidade";
            this.cbxCidade.Size = new System.Drawing.Size(146, 21);
            this.cbxCidade.TabIndex = 33;
            this.cbxCidade.SelectedIndexChanged += new System.EventHandler(this.cbxCidade_SelectedIndexChanged);
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(17, 91);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(121, 21);
            this.cbxEstado.TabIndex = 32;
            this.cbxEstado.SelectedIndexChanged += new System.EventHandler(this.cbxEstado_SelectedIndexChanged);
            this.cbxEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxEstado_KeyPress);
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(319, 92);
            this.txtCep.MaxLength = 8;
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(87, 20);
            this.txtCep.TabIndex = 29;
            this.txtCep.TextChanged += new System.EventHandler(this.txtCep_TextChanged);
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress);
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(549, 41);
            this.txtBairro.MaxLength = 30;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(135, 20);
            this.txtBairro.TabIndex = 26;
            this.txtBairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBairro_KeyPress);
            // 
            // txtComp
            // 
            this.txtComp.Location = new System.Drawing.Point(378, 42);
            this.txtComp.MaxLength = 60;
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(154, 20);
            this.txtComp.TabIndex = 25;
            this.txtComp.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.txtComp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComp_KeyPress);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(313, 42);
            this.txtNum.MaxLength = 10;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(49, 20);
            this.txtNum.TabIndex = 24;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(17, 42);
            this.txtRua.MaxLength = 60;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(280, 20);
            this.txtRua.TabIndex = 23;
            this.txtRua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRua_KeyPress);
            // 
            // lblCepUs
            // 
            this.lblCepUs.AutoSize = true;
            this.lblCepUs.Location = new System.Drawing.Point(317, 75);
            this.lblCepUs.Name = "lblCepUs";
            this.lblCepUs.Size = new System.Drawing.Size(35, 13);
            this.lblCepUs.TabIndex = 22;
            this.lblCepUs.Text = "CEP *";
            this.lblCepUs.Click += new System.EventHandler(this.lblCepUs_Click);
            // 
            // lblEstadoUs
            // 
            this.lblEstadoUs.AutoSize = true;
            this.lblEstadoUs.Location = new System.Drawing.Point(14, 75);
            this.lblEstadoUs.Name = "lblEstadoUs";
            this.lblEstadoUs.Size = new System.Drawing.Size(44, 13);
            this.lblEstadoUs.TabIndex = 20;
            this.lblEstadoUs.Text = "Estado*";
            // 
            // lblCidadeUs
            // 
            this.lblCidadeUs.AutoSize = true;
            this.lblCidadeUs.Location = new System.Drawing.Point(154, 75);
            this.lblCidadeUs.Name = "lblCidadeUs";
            this.lblCidadeUs.Size = new System.Drawing.Size(44, 13);
            this.lblCidadeUs.TabIndex = 19;
            this.lblCidadeUs.Text = "Cidade*";
            // 
            // lblBairroUs
            // 
            this.lblBairroUs.AutoSize = true;
            this.lblBairroUs.Location = new System.Drawing.Point(546, 25);
            this.lblBairroUs.Name = "lblBairroUs";
            this.lblBairroUs.Size = new System.Drawing.Size(41, 13);
            this.lblBairroUs.TabIndex = 18;
            this.lblBairroUs.Text = "Bairro *";
            // 
            // lblComplementoUs
            // 
            this.lblComplementoUs.AutoSize = true;
            this.lblComplementoUs.Location = new System.Drawing.Point(375, 25);
            this.lblComplementoUs.Name = "lblComplementoUs";
            this.lblComplementoUs.Size = new System.Drawing.Size(71, 13);
            this.lblComplementoUs.TabIndex = 17;
            this.lblComplementoUs.Text = "Complemento";
            // 
            // lblNumeroUs
            // 
            this.lblNumeroUs.AutoSize = true;
            this.lblNumeroUs.Location = new System.Drawing.Point(310, 25);
            this.lblNumeroUs.Name = "lblNumeroUs";
            this.lblNumeroUs.Size = new System.Drawing.Size(26, 13);
            this.lblNumeroUs.TabIndex = 16;
            this.lblNumeroUs.Text = "N° *";
            // 
            // lblRuaUs
            // 
            this.lblRuaUs.AutoSize = true;
            this.lblRuaUs.Location = new System.Drawing.Point(14, 25);
            this.lblRuaUs.Name = "lblRuaUs";
            this.lblRuaUs.Size = new System.Drawing.Size(34, 13);
            this.lblRuaUs.TabIndex = 15;
            this.lblRuaUs.Text = "Rua *";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtSenha2);
            this.groupBox4.Controls.Add(this.txtSenha);
            this.groupBox4.Controls.Add(this.txtLogin);
            this.groupBox4.Controls.Add(this.lblLoginUs);
            this.groupBox4.Controls.Add(this.lblConfirSenha);
            this.groupBox4.Controls.Add(this.lblSenhaUs);
            this.groupBox4.Location = new System.Drawing.Point(12, 346);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(392, 72);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Acesso";
            // 
            // txtSenha2
            // 
            this.txtSenha2.Location = new System.Drawing.Point(249, 42);
            this.txtSenha2.MaxLength = 20;
            this.txtSenha2.Name = "txtSenha2";
            this.txtSenha2.Size = new System.Drawing.Size(100, 20);
            this.txtSenha2.TabIndex = 29;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(133, 42);
            this.txtSenha.MaxLength = 20;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 28;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(17, 42);
            this.txtLogin.MaxLength = 20;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 27;
            // 
            // lblLoginUs
            // 
            this.lblLoginUs.AutoSize = true;
            this.lblLoginUs.Location = new System.Drawing.Point(14, 24);
            this.lblLoginUs.Name = "lblLoginUs";
            this.lblLoginUs.Size = new System.Drawing.Size(40, 13);
            this.lblLoginUs.TabIndex = 26;
            this.lblLoginUs.Text = "Login *";
            // 
            // lblConfirSenha
            // 
            this.lblConfirSenha.AutoSize = true;
            this.lblConfirSenha.Location = new System.Drawing.Point(247, 24);
            this.lblConfirSenha.Name = "lblConfirSenha";
            this.lblConfirSenha.Size = new System.Drawing.Size(90, 13);
            this.lblConfirSenha.TabIndex = 25;
            this.lblConfirSenha.Text = "Confirmar senha *";
            // 
            // lblSenhaUs
            // 
            this.lblSenhaUs.AutoSize = true;
            this.lblSenhaUs.Location = new System.Drawing.Point(130, 24);
            this.lblSenhaUs.Name = "lblSenhaUs";
            this.lblSenhaUs.Size = new System.Drawing.Size(45, 13);
            this.lblSenhaUs.TabIndex = 23;
            this.lblSenhaUs.Text = "Senha *";
            // 
            // btnSalvarUs
            // 
            this.btnSalvarUs.Location = new System.Drawing.Point(536, 370);
            this.btnSalvarUs.Name = "btnSalvarUs";
            this.btnSalvarUs.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarUs.TabIndex = 31;
            this.btnSalvarUs.Text = "Salver";
            this.btnSalvarUs.UseVisualStyleBackColor = true;
            this.btnSalvarUs.Click += new System.EventHandler(this.btnSalvarUs_Click);
            // 
            // btnLimparUs
            // 
            this.btnLimparUs.Location = new System.Drawing.Point(626, 370);
            this.btnLimparUs.Name = "btnLimparUs";
            this.btnLimparUs.Size = new System.Drawing.Size(75, 23);
            this.btnLimparUs.TabIndex = 33;
            this.btnLimparUs.Text = "Limpar";
            this.btnLimparUs.UseVisualStyleBackColor = true;
            this.btnLimparUs.Click += new System.EventHandler(this.btnLimparUs_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fmrCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 434);
            this.Controls.Add(this.btnLimparUs);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtTele);
            this.Controls.Add(this.btnSalvarUs);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fmrCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro usuário";
            this.Load += new System.EventHandler(this.FmrUsuarioCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.txtTele.ResumeLayout(false);
            this.txtTele.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label CV;
        private System.Windows.Forms.Label lblNascUs;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblRgUs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDdd;
        private System.Windows.Forms.Label lblCelularUs;
        private System.Windows.Forms.Label lblTelefoneUS;
        private System.Windows.Forms.Label lblOpUs;
        private System.Windows.Forms.GroupBox txtTele;
        private System.Windows.Forms.Label lblRuaUs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumeroUs;
        private System.Windows.Forms.Label lblComplementoUs;
        private System.Windows.Forms.Label lblBairroUs;
        private System.Windows.Forms.Label lblCidadeUs;
        private System.Windows.Forms.Label lblEstadoUs;
        private System.Windows.Forms.Label lblCepUs;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblSenhaUs;
        private System.Windows.Forms.Label lblConfirSenha;
        private System.Windows.Forms.Label lblLoginUs;
        private System.Windows.Forms.Button btnSalvarUs;
        private System.Windows.Forms.Button btnLimparUs;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNasc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.ComboBox cbxCargo;
        private System.Windows.Forms.TextBox txtDdd;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.TextBox txtOpe;
        private System.Windows.Forms.TextBox txtComp;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtSenha2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.ComboBox cbxSex;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.ComboBox cbxCidade;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}