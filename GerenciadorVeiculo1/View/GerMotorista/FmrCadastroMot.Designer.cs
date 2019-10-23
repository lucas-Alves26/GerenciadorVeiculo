namespace GerenciadorVeiculo1.View.GerMotorista
{
    partial class FmrCadastroMot
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
            this.btnLimparUs = new System.Windows.Forms.Button();
            this.txtTele = new System.Windows.Forms.GroupBox();
            this.lblAviso = new System.Windows.Forms.Label();
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
            this.btnSalvarMot = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxEmpresa = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCnh = new System.Windows.Forms.TextBox();
            this.cbxSex = new System.Windows.Forms.ComboBox();
            this.txtOpe = new System.Windows.Forms.TextBox();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtDdd = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNasc = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOpUs = new System.Windows.Forms.Label();
            this.lblCelularUs = new System.Windows.Forms.Label();
            this.lblTelefoneUS = new System.Windows.Forms.Label();
            this.lblDdd = new System.Windows.Forms.Label();
            this.lblRgUs = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNascUs = new System.Windows.Forms.Label();
            this.CV = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtTele.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimparUs
            // 
            this.btnLimparUs.Location = new System.Drawing.Point(626, 405);
            this.btnLimparUs.Name = "btnLimparUs";
            this.btnLimparUs.Size = new System.Drawing.Size(75, 23);
            this.btnLimparUs.TabIndex = 39;
            this.btnLimparUs.Text = "Limpar";
            this.btnLimparUs.UseVisualStyleBackColor = true;
            // 
            // txtTele
            // 
            this.txtTele.Controls.Add(this.lblAviso);
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
            this.txtTele.Location = new System.Drawing.Point(12, 255);
            this.txtTele.Name = "txtTele";
            this.txtTele.Size = new System.Drawing.Size(688, 120);
            this.txtTele.TabIndex = 36;
            this.txtTele.TabStop = false;
            this.txtTele.Text = "Endereço";
            this.txtTele.Enter += new System.EventHandler(this.txtTele_Enter);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(453, 91);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(14, 20);
            this.lblAviso.TabIndex = 34;
            this.lblAviso.Text = ".";
            // 
            // cbxCidade
            // 
            this.cbxCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCidade.FormattingEnabled = true;
            this.cbxCidade.Location = new System.Drawing.Point(157, 91);
            this.cbxCidade.Name = "cbxCidade";
            this.cbxCidade.Size = new System.Drawing.Size(146, 21);
            this.cbxCidade.TabIndex = 33;
            this.cbxCidade.SelectedIndexChanged += new System.EventHandler(this.cbxCidade_SelectedIndexChanged);
            // 
            // cbxEstado
            // 
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(17, 91);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(121, 21);
            this.cbxEstado.TabIndex = 32;
            this.cbxEstado.SelectedIndexChanged += new System.EventHandler(this.cbxEstado_SelectedIndexChanged);
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(319, 92);
            this.txtCep.MaxLength = 8;
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(87, 20);
            this.txtCep.TabIndex = 29;
            this.txtCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.txtComp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComp_KeyPress);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(313, 42);
            this.txtNum.MaxLength = 5;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(49, 20);
            this.txtNum.TabIndex = 24;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // btnSalvarMot
            // 
            this.btnSalvarMot.Location = new System.Drawing.Point(536, 405);
            this.btnSalvarMot.Name = "btnSalvarMot";
            this.btnSalvarMot.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarMot.TabIndex = 38;
            this.btnSalvarMot.Text = "Salver";
            this.btnSalvarMot.UseVisualStyleBackColor = true;
            this.btnSalvarMot.Click += new System.EventHandler(this.btnSalvarUs_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbxEmpresa);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbxCategoria);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtValidade);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtCnh);
            this.groupBox2.Controls.Add(this.cbxSex);
            this.groupBox2.Controls.Add(this.txtOpe);
            this.groupBox2.Controls.Add(this.txtCel);
            this.groupBox2.Controls.Add(this.txtTel);
            this.groupBox2.Controls.Add(this.txtDdd);
            this.groupBox2.Controls.Add(this.txtRg);
            this.groupBox2.Controls.Add(this.txtCpf);
            this.groupBox2.Controls.Add(this.txtNasc);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblOpUs);
            this.groupBox2.Controls.Add(this.lblCelularUs);
            this.groupBox2.Controls.Add(this.lblTelefoneUS);
            this.groupBox2.Controls.Add(this.lblDdd);
            this.groupBox2.Controls.Add(this.lblRgUs);
            this.groupBox2.Controls.Add(this.lblCpf);
            this.groupBox2.Controls.Add(this.lblNascUs);
            this.groupBox2.Controls.Add(this.CV);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 223);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Pessoais";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(314, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Empresa*";
            // 
            // cbxEmpresa
            // 
            this.cbxEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEmpresa.FormattingEnabled = true;
            this.cbxEmpresa.Location = new System.Drawing.Point(317, 139);
            this.cbxEmpresa.Name = "cbxEmpresa";
            this.cbxEmpresa.Size = new System.Drawing.Size(129, 21);
            this.cbxEmpresa.TabIndex = 56;
            this.cbxEmpresa.SelectedIndexChanged += new System.EventHandler(this.cbxEmpresa_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "DDD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Categoria *";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "AC",
            "AD",
            "AE"});
            this.cbxCategoria.Location = new System.Drawing.Point(353, 89);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(56, 21);
            this.cbxCategoria.TabIndex = 53;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(17, 188);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(247, 20);
            this.txtEmail.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Validade CNH*";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "E-Mail";
            // 
            // txtValidade
            // 
            this.txtValidade.Location = new System.Drawing.Point(251, 90);
            this.txtValidade.MaxLength = 10;
            this.txtValidade.Name = "txtValidade";
            this.txtValidade.Size = new System.Drawing.Size(85, 20);
            this.txtValidade.TabIndex = 51;
            this.txtValidade.TextChanged += new System.EventHandler(this.txtValidade_TextChanged);
            this.txtValidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValidade_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "CNH*";
            // 
            // txtCnh
            // 
            this.txtCnh.Location = new System.Drawing.Point(134, 90);
            this.txtCnh.MaxLength = 11;
            this.txtCnh.Name = "txtCnh";
            this.txtCnh.Size = new System.Drawing.Size(100, 20);
            this.txtCnh.TabIndex = 49;
            this.txtCnh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCnh_KeyPress);
            // 
            // cbxSex
            // 
            this.cbxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSex.FormattingEnabled = true;
            this.cbxSex.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cbxSex.Location = new System.Drawing.Point(440, 89);
            this.cbxSex.Name = "cbxSex";
            this.cbxSex.Size = new System.Drawing.Size(55, 21);
            this.cbxSex.TabIndex = 48;
            // 
            // txtOpe
            // 
            this.txtOpe.Location = new System.Drawing.Point(103, 140);
            this.txtOpe.MaxLength = 15;
            this.txtOpe.Name = "txtOpe";
            this.txtOpe.Size = new System.Drawing.Size(73, 20);
            this.txtOpe.TabIndex = 47;
            this.txtOpe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOpe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOpe_KeyPress);
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(18, 140);
            this.txtCel.MaxLength = 9;
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(68, 20);
            this.txtCel.TabIndex = 46;
            this.txtCel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCel_KeyPress);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(193, 140);
            this.txtTel.MaxLength = 8;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(63, 20);
            this.txtTel.TabIndex = 45;
            this.txtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // txtDdd
            // 
            this.txtDdd.Location = new System.Drawing.Point(272, 140);
            this.txtDdd.MaxLength = 3;
            this.txtDdd.Name = "txtDdd";
            this.txtDdd.Size = new System.Drawing.Size(28, 20);
            this.txtDdd.TabIndex = 44;
            this.txtDdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDdd_KeyPress);
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(17, 90);
            this.txtRg.MaxLength = 9;
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(100, 20);
            this.txtRg.TabIndex = 39;
            this.txtRg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRg_KeyPress);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(402, 42);
            this.txtCpf.MaxLength = 11;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(93, 20);
            this.txtCpf.TabIndex = 38;
            this.txtCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(17, 42);
            this.txtName.MaxLength = 60;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(286, 20);
            this.txtName.TabIndex = 36;
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Sexo *";
            // 
            // lblOpUs
            // 
            this.lblOpUs.AutoSize = true;
            this.lblOpUs.Location = new System.Drawing.Point(100, 124);
            this.lblOpUs.Name = "lblOpUs";
            this.lblOpUs.Size = new System.Drawing.Size(57, 13);
            this.lblOpUs.TabIndex = 34;
            this.lblOpUs.Text = "Operadora";
            // 
            // lblCelularUs
            // 
            this.lblCelularUs.AutoSize = true;
            this.lblCelularUs.Location = new System.Drawing.Point(15, 122);
            this.lblCelularUs.Name = "lblCelularUs";
            this.lblCelularUs.Size = new System.Drawing.Size(46, 13);
            this.lblCelularUs.TabIndex = 33;
            this.lblCelularUs.Text = "Celular *";
            // 
            // lblTelefoneUS
            // 
            this.lblTelefoneUS.AutoSize = true;
            this.lblTelefoneUS.Location = new System.Drawing.Point(190, 124);
            this.lblTelefoneUS.Name = "lblTelefoneUS";
            this.lblTelefoneUS.Size = new System.Drawing.Size(49, 13);
            this.lblTelefoneUS.TabIndex = 31;
            this.lblTelefoneUS.Text = "Telefone";
            // 
            // lblDdd
            // 
            this.lblDdd.AutoSize = true;
            this.lblDdd.Location = new System.Drawing.Point(55, 143);
            this.lblDdd.Name = "lblDdd";
            this.lblDdd.Size = new System.Drawing.Size(31, 13);
            this.lblDdd.TabIndex = 30;
            this.lblDdd.Text = "DDD";
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
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(399, 26);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(34, 13);
            this.lblCpf.TabIndex = 25;
            this.lblCpf.Text = "CPF *";
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
            // CV
            // 
            this.CV.AutoSize = true;
            this.CV.Location = new System.Drawing.Point(14, 25);
            this.CV.Name = "CV";
            this.CV.Size = new System.Drawing.Size(88, 13);
            this.CV.TabIndex = 23;
            this.CV.Text = "Nome completo *";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAbrir);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(561, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 190);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Foto motorista";
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
            this.btnAbrir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnAbrir_KeyPress);
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FmrCadastroMot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 434);
            this.Controls.Add(this.btnLimparUs);
            this.Controls.Add(this.txtTele);
            this.Controls.Add(this.btnSalvarMot);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FmrCadastroMot";
            this.Text = "Cadastro Motorista";
            this.Load += new System.EventHandler(this.FmrCadastroMot_Load);
            this.txtTele.ResumeLayout(false);
            this.txtTele.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLimparUs;
        private System.Windows.Forms.GroupBox txtTele;
        private System.Windows.Forms.ComboBox cbxCidade;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtComp;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblCepUs;
        private System.Windows.Forms.Label lblEstadoUs;
        private System.Windows.Forms.Label lblCidadeUs;
        private System.Windows.Forms.Label lblBairroUs;
        private System.Windows.Forms.Label lblComplementoUs;
        private System.Windows.Forms.Label lblNumeroUs;
        private System.Windows.Forms.Label lblRuaUs;
        private System.Windows.Forms.Button btnSalvarMot;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxSex;
        private System.Windows.Forms.TextBox txtOpe;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtDdd;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNasc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOpUs;
        private System.Windows.Forms.Label lblCelularUs;
        private System.Windows.Forms.Label lblTelefoneUS;
        private System.Windows.Forms.Label lblDdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRgUs;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNascUs;
        private System.Windows.Forms.Label CV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCnh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValidade;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxEmpresa;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblAviso;
    }
}