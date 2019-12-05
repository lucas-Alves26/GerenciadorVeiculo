namespace GerenciadorVeiculo1.View
{
    partial class FmrDadosUs
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
            this.btnAbrir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CV = new System.Windows.Forms.Label();
            this.lblNascUs = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblRgUs = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDdd = new System.Windows.Forms.Label();
            this.lblTelefoneUS = new System.Windows.Forms.Label();
            this.lblCelularUs = new System.Windows.Forms.Label();
            this.lblOpUs = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNasc = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDdd = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.txtOpe = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.cbxSex = new System.Windows.Forms.ComboBox();
            this.cbxCargo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRuaUs = new System.Windows.Forms.Label();
            this.lblNumeroUs = new System.Windows.Forms.Label();
            this.lblComplementoUs = new System.Windows.Forms.Label();
            this.lblBairroUs = new System.Windows.Forms.Label();
            this.lblCidadeUs = new System.Windows.Forms.Label();
            this.lblEstadoUs = new System.Windows.Forms.Label();
            this.lblCepUs = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtComp = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.cbxCidade = new System.Windows.Forms.ComboBox();
            this.txtTele = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.pcBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.txtTele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.Color.White;
            this.btnAbrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrir.FlatAppearance.BorderSize = 0;
            this.btnAbrir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAbrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrir.ForeColor = System.Drawing.Color.Black;
            this.btnAbrir.Image = global::GerenciadorVeiculo1.Properties.Resources.abririMenor;
            this.btnAbrir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrir.Location = new System.Drawing.Point(62, 161);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(69, 24);
            this.btnAbrir.TabIndex = 22;
            this.btnAbrir.Text = "        Abrir";
            this.btnAbrir.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAbrir);
            this.groupBox1.Controls.Add(this.pcBox);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 190);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Foto usuário";
            // 
            // CV
            // 
            this.CV.AutoSize = true;
            this.CV.Location = new System.Drawing.Point(14, 25);
            this.CV.Name = "CV";
            this.CV.Size = new System.Drawing.Size(107, 16);
            this.CV.TabIndex = 23;
            this.CV.Text = "Nome completo:";
            // 
            // lblNascUs
            // 
            this.lblNascUs.AutoSize = true;
            this.lblNascUs.ForeColor = System.Drawing.Color.White;
            this.lblNascUs.Location = new System.Drawing.Point(316, 25);
            this.lblNascUs.Name = "lblNascUs";
            this.lblNascUs.Size = new System.Drawing.Size(71, 16);
            this.lblNascUs.TabIndex = 24;
            this.lblNascUs.Text = "Data Nasc:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(399, 26);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(33, 16);
            this.lblCpf.TabIndex = 25;
            this.lblCpf.Text = "CPF:";
            // 
            // lblRgUs
            // 
            this.lblRgUs.AutoSize = true;
            this.lblRgUs.Location = new System.Drawing.Point(14, 73);
            this.lblRgUs.Name = "lblRgUs";
            this.lblRgUs.Size = new System.Drawing.Size(28, 16);
            this.lblRgUs.TabIndex = 26;
            this.lblRgUs.Text = "RG:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "E-Mail:";
            // 
            // lblDdd
            // 
            this.lblDdd.AutoSize = true;
            this.lblDdd.Location = new System.Drawing.Point(87, 119);
            this.lblDdd.Name = "lblDdd";
            this.lblDdd.Size = new System.Drawing.Size(35, 16);
            this.lblDdd.TabIndex = 30;
            this.lblDdd.Text = "DDD:";
            // 
            // lblTelefoneUS
            // 
            this.lblTelefoneUS.AutoSize = true;
            this.lblTelefoneUS.Location = new System.Drawing.Point(131, 119);
            this.lblTelefoneUS.Name = "lblTelefoneUS";
            this.lblTelefoneUS.Size = new System.Drawing.Size(62, 16);
            this.lblTelefoneUS.TabIndex = 31;
            this.lblTelefoneUS.Text = "Telefone:";
            // 
            // lblCelularUs
            // 
            this.lblCelularUs.AutoSize = true;
            this.lblCelularUs.Location = new System.Drawing.Point(210, 119);
            this.lblCelularUs.Name = "lblCelularUs";
            this.lblCelularUs.Size = new System.Drawing.Size(53, 16);
            this.lblCelularUs.TabIndex = 33;
            this.lblCelularUs.Text = "Celular:";
            // 
            // lblOpUs
            // 
            this.lblOpUs.AutoSize = true;
            this.lblOpUs.Location = new System.Drawing.Point(294, 119);
            this.lblOpUs.Name = "lblOpUs";
            this.lblOpUs.Size = new System.Drawing.Size(77, 16);
            this.lblOpUs.TabIndex = 34;
            this.lblOpUs.Text = "Operadora:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(17, 42);
            this.txtName.MaxLength = 60;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(286, 21);
            this.txtName.TabIndex = 36;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtNasc
            // 
            this.txtNasc.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNasc.ForeColor = System.Drawing.Color.Black;
            this.txtNasc.Location = new System.Drawing.Point(319, 42);
            this.txtNasc.MaxLength = 10;
            this.txtNasc.Name = "txtNasc";
            this.txtNasc.Size = new System.Drawing.Size(68, 21);
            this.txtNasc.TabIndex = 37;
            this.txtNasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNasc.TextChanged += new System.EventHandler(this.txtNasc_TextChanged);
            this.txtNasc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNasc_KeyPress);
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.ForeColor = System.Drawing.Color.Black;
            this.txtCpf.Location = new System.Drawing.Point(402, 42);
            this.txtCpf.MaxLength = 11;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(85, 21);
            this.txtCpf.TabIndex = 38;
            this.txtCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpf_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(132, 89);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(238, 21);
            this.txtEmail.TabIndex = 41;
            // 
            // txtDdd
            // 
            this.txtDdd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDdd.ForeColor = System.Drawing.Color.Black;
            this.txtDdd.Location = new System.Drawing.Point(90, 135);
            this.txtDdd.MaxLength = 3;
            this.txtDdd.Name = "txtDdd";
            this.txtDdd.Size = new System.Drawing.Size(28, 21);
            this.txtDdd.TabIndex = 44;
            this.txtDdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDdd_KeyPress);
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.ForeColor = System.Drawing.Color.Black;
            this.txtTel.Location = new System.Drawing.Point(134, 135);
            this.txtTel.MaxLength = 8;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(63, 21);
            this.txtTel.TabIndex = 45;
            this.txtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // txtCel
            // 
            this.txtCel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCel.ForeColor = System.Drawing.Color.Black;
            this.txtCel.Location = new System.Drawing.Point(213, 135);
            this.txtCel.MaxLength = 9;
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(68, 21);
            this.txtCel.TabIndex = 46;
            this.txtCel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCel_KeyPress);
            // 
            // txtOpe
            // 
            this.txtOpe.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpe.ForeColor = System.Drawing.Color.Black;
            this.txtOpe.Location = new System.Drawing.Point(297, 135);
            this.txtOpe.MaxLength = 15;
            this.txtOpe.Name = "txtOpe";
            this.txtOpe.Size = new System.Drawing.Size(73, 21);
            this.txtOpe.TabIndex = 47;
            this.txtOpe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOpe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOpe_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRg);
            this.groupBox2.Controls.Add(this.cbxSex);
            this.groupBox2.Controls.Add(this.txtOpe);
            this.groupBox2.Controls.Add(this.txtCel);
            this.groupBox2.Controls.Add(this.txtTel);
            this.groupBox2.Controls.Add(this.txtDdd);
            this.groupBox2.Controls.Add(this.cbxCargo);
            this.groupBox2.Controls.Add(this.txtEmail);
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
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(166, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 190);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Pessoais";
            // 
            // txtRg
            // 
            this.txtRg.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.ForeColor = System.Drawing.Color.Black;
            this.txtRg.Location = new System.Drawing.Point(17, 89);
            this.txtRg.MaxLength = 9;
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(100, 21);
            this.txtRg.TabIndex = 49;
            this.txtRg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRg_KeyPress);
            // 
            // cbxSex
            // 
            this.cbxSex.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSex.ForeColor = System.Drawing.Color.Black;
            this.cbxSex.FormattingEnabled = true;
            this.cbxSex.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cbxSex.Location = new System.Drawing.Point(16, 134);
            this.cbxSex.Name = "cbxSex";
            this.cbxSex.Size = new System.Drawing.Size(65, 23);
            this.cbxSex.TabIndex = 48;
            // 
            // cbxCargo
            // 
            this.cbxCargo.DisplayMember = "n";
            this.cbxCargo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCargo.ForeColor = System.Drawing.Color.Black;
            this.cbxCargo.FormattingEnabled = true;
            this.cbxCargo.Items.AddRange(new object[] {
            "Usuário",
            "Administrador"});
            this.cbxCargo.Location = new System.Drawing.Point(387, 89);
            this.cbxCargo.MaxLength = 30;
            this.cbxCargo.Name = "cbxCargo";
            this.cbxCargo.Size = new System.Drawing.Size(100, 23);
            this.cbxCargo.TabIndex = 42;
            this.cbxCargo.Tag = "";
            this.cbxCargo.ValueMember = "n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Sexo :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Cargo:";
            // 
            // lblRuaUs
            // 
            this.lblRuaUs.AutoSize = true;
            this.lblRuaUs.Location = new System.Drawing.Point(14, 25);
            this.lblRuaUs.Name = "lblRuaUs";
            this.lblRuaUs.Size = new System.Drawing.Size(33, 16);
            this.lblRuaUs.TabIndex = 15;
            this.lblRuaUs.Text = "Rua:";
            // 
            // lblNumeroUs
            // 
            this.lblNumeroUs.AutoSize = true;
            this.lblNumeroUs.Location = new System.Drawing.Point(310, 25);
            this.lblNumeroUs.Name = "lblNumeroUs";
            this.lblNumeroUs.Size = new System.Drawing.Size(25, 16);
            this.lblNumeroUs.TabIndex = 16;
            this.lblNumeroUs.Text = "N°:";
            // 
            // lblComplementoUs
            // 
            this.lblComplementoUs.AutoSize = true;
            this.lblComplementoUs.Location = new System.Drawing.Point(375, 25);
            this.lblComplementoUs.Name = "lblComplementoUs";
            this.lblComplementoUs.Size = new System.Drawing.Size(95, 16);
            this.lblComplementoUs.TabIndex = 17;
            this.lblComplementoUs.Text = "Complemento:";
            // 
            // lblBairroUs
            // 
            this.lblBairroUs.AutoSize = true;
            this.lblBairroUs.Location = new System.Drawing.Point(394, 75);
            this.lblBairroUs.Name = "lblBairroUs";
            this.lblBairroUs.Size = new System.Drawing.Size(45, 16);
            this.lblBairroUs.TabIndex = 18;
            this.lblBairroUs.Text = "Bairro:";
            // 
            // lblCidadeUs
            // 
            this.lblCidadeUs.AutoSize = true;
            this.lblCidadeUs.Location = new System.Drawing.Point(154, 75);
            this.lblCidadeUs.Name = "lblCidadeUs";
            this.lblCidadeUs.Size = new System.Drawing.Size(55, 16);
            this.lblCidadeUs.TabIndex = 19;
            this.lblCidadeUs.Text = "Cidade:";
            // 
            // lblEstadoUs
            // 
            this.lblEstadoUs.AutoSize = true;
            this.lblEstadoUs.Location = new System.Drawing.Point(14, 75);
            this.lblEstadoUs.Name = "lblEstadoUs";
            this.lblEstadoUs.Size = new System.Drawing.Size(49, 16);
            this.lblEstadoUs.TabIndex = 20;
            this.lblEstadoUs.Text = "Estado:";
            // 
            // lblCepUs
            // 
            this.lblCepUs.AutoSize = true;
            this.lblCepUs.Location = new System.Drawing.Point(292, 75);
            this.lblCepUs.Name = "lblCepUs";
            this.lblCepUs.Size = new System.Drawing.Size(33, 16);
            this.lblCepUs.TabIndex = 22;
            this.lblCepUs.Text = "CEP:";
            // 
            // txtRua
            // 
            this.txtRua.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.ForeColor = System.Drawing.Color.Black;
            this.txtRua.Location = new System.Drawing.Point(17, 42);
            this.txtRua.MaxLength = 60;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(280, 21);
            this.txtRua.TabIndex = 23;
            this.txtRua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRua_KeyPress);
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.ForeColor = System.Drawing.Color.Black;
            this.txtNum.Location = new System.Drawing.Point(313, 42);
            this.txtNum.MaxLength = 10;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(49, 21);
            this.txtNum.TabIndex = 24;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // txtComp
            // 
            this.txtComp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComp.ForeColor = System.Drawing.Color.Black;
            this.txtComp.Location = new System.Drawing.Point(378, 42);
            this.txtComp.MaxLength = 60;
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(154, 21);
            this.txtComp.TabIndex = 25;
            this.txtComp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComp_KeyPress);
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.ForeColor = System.Drawing.Color.Black;
            this.txtBairro.Location = new System.Drawing.Point(397, 91);
            this.txtBairro.MaxLength = 30;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(135, 21);
            this.txtBairro.TabIndex = 26;
            this.txtBairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBairro_KeyPress);
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.ForeColor = System.Drawing.Color.Black;
            this.txtCep.Location = new System.Drawing.Point(294, 92);
            this.txtCep.MaxLength = 8;
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(87, 21);
            this.txtCep.TabIndex = 29;
            this.txtCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress);
            // 
            // cbxEstado
            // 
            this.cbxEstado.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstado.ForeColor = System.Drawing.Color.Black;
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(17, 91);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(121, 23);
            this.cbxEstado.TabIndex = 32;
            this.cbxEstado.SelectedIndexChanged += new System.EventHandler(this.cbxEstado_SelectedIndexChanged);
            this.cbxEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxEstado_KeyPress);
            // 
            // cbxCidade
            // 
            this.cbxCidade.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCidade.ForeColor = System.Drawing.Color.Black;
            this.cbxCidade.FormattingEnabled = true;
            this.cbxCidade.Location = new System.Drawing.Point(157, 91);
            this.cbxCidade.Name = "cbxCidade";
            this.cbxCidade.Size = new System.Drawing.Size(121, 23);
            this.cbxCidade.TabIndex = 33;
            this.cbxCidade.SelectedIndexChanged += new System.EventHandler(this.cbxCidade_SelectedIndexChanged);
            this.cbxCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxCidade_KeyPress);
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
            this.txtTele.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTele.ForeColor = System.Drawing.Color.White;
            this.txtTele.Location = new System.Drawing.Point(13, 208);
            this.txtTele.Name = "txtTele";
            this.txtTele.Size = new System.Drawing.Size(651, 120);
            this.txtTele.TabIndex = 36;
            this.txtTele.TabStop = false;
            this.txtTele.Text = "Endereço";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::GerenciadorVeiculo1.Properties.Resources.gravar;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(561, 346);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(103, 32);
            this.btnSalvar.TabIndex = 39;
            this.btnSalvar.Text = "     Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::GerenciadorVeiculo1.Properties.Resources.fechar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(335, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 32);
            this.button1.TabIndex = 40;
            this.button1.Text = "     Fechar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::GerenciadorVeiculo1.Properties.Resources.editar;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(448, 346);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(103, 32);
            this.btnEditar.TabIndex = 38;
            this.btnEditar.Text = "     Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // pcBox
            // 
            this.pcBox.Location = new System.Drawing.Point(11, 19);
            this.pcBox.Name = "pcBox";
            this.pcBox.Size = new System.Drawing.Size(117, 136);
            this.pcBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcBox.TabIndex = 19;
            this.pcBox.TabStop = false;
            // 
            // FmrDadosUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(78)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(677, 390);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtTele);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FmrDadosUs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados do usuário";
            this.Load += new System.EventHandler(this.DmrDadosUs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.txtTele.ResumeLayout(false);
            this.txtTele.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcBox;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label CV;
        private System.Windows.Forms.Label lblNascUs;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblRgUs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDdd;
        private System.Windows.Forms.Label lblTelefoneUS;
        private System.Windows.Forms.Label lblCelularUs;
        private System.Windows.Forms.Label lblOpUs;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNasc;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDdd;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.TextBox txtOpe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblRuaUs;
        private System.Windows.Forms.Label lblNumeroUs;
        private System.Windows.Forms.Label lblComplementoUs;
        private System.Windows.Forms.Label lblBairroUs;
        private System.Windows.Forms.Label lblCidadeUs;
        private System.Windows.Forms.Label lblEstadoUs;
        private System.Windows.Forms.Label lblCepUs;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtComp;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.ComboBox cbxCidade;
        private System.Windows.Forms.GroupBox txtTele;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxSex;
        private System.Windows.Forms.ComboBox cbxCargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}