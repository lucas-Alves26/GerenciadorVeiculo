namespace GerenciadorVeiculo1.View.GerEmpresa
{
    partial class FmrCadastroEmp
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
            this.txtTele = new System.Windows.Forms.GroupBox();
            this.txtComp = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.cbxCidade = new System.Windows.Forms.ComboBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.lblCepUs = new System.Windows.Forms.Label();
            this.lblEstadoUs = new System.Windows.Forms.Label();
            this.lblCidadeUs = new System.Windows.Forms.Label();
            this.lblBairroUs = new System.Windows.Forms.Label();
            this.lblComplementoUs = new System.Windows.Forms.Label();
            this.lblNumeroUs = new System.Windows.Forms.Label();
            this.lblRuaUs = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDdd = new System.Windows.Forms.TextBox();
            this.txtFixo = new System.Windows.Forms.TextBox();
            this.txtOpe = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOpUs = new System.Windows.Forms.Label();
            this.lblCelularUs = new System.Windows.Forms.Label();
            this.lblTelefoneUS = new System.Windows.Forms.Label();
            this.lblDdd = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.CV = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtTele.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTele
            // 
            this.txtTele.Controls.Add(this.txtComp);
            this.txtTele.Controls.Add(this.txtBairro);
            this.txtTele.Controls.Add(this.txtCep);
            this.txtTele.Controls.Add(this.txtNum);
            this.txtTele.Controls.Add(this.txtRua);
            this.txtTele.Controls.Add(this.cbxCidade);
            this.txtTele.Controls.Add(this.cbxEstado);
            this.txtTele.Controls.Add(this.lblCepUs);
            this.txtTele.Controls.Add(this.lblEstadoUs);
            this.txtTele.Controls.Add(this.lblCidadeUs);
            this.txtTele.Controls.Add(this.lblBairroUs);
            this.txtTele.Controls.Add(this.lblComplementoUs);
            this.txtTele.Controls.Add(this.lblNumeroUs);
            this.txtTele.Controls.Add(this.lblRuaUs);
            this.txtTele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTele.ForeColor = System.Drawing.Color.White;
            this.txtTele.Location = new System.Drawing.Point(22, 276);
            this.txtTele.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTele.Name = "txtTele";
            this.txtTele.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTele.Size = new System.Drawing.Size(521, 239);
            this.txtTele.TabIndex = 30;
            this.txtTele.TabStop = false;
            this.txtTele.Text = "Endereço";
            // 
            // txtComp
            // 
            this.txtComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComp.Location = new System.Drawing.Point(212, 174);
            this.txtComp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtComp.MaxLength = 100;
            this.txtComp.Multiline = true;
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(277, 45);
            this.txtComp.TabIndex = 38;
            this.txtComp.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.txtComp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComp_KeyPress);
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(20, 174);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBairro.MaxLength = 60;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(165, 20);
            this.txtBairro.TabIndex = 37;
            this.txtBairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBairro_KeyPress);
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(390, 112);
            this.txtCep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCep.MaxLength = 8;
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 20);
            this.txtCep.TabIndex = 36;
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress);
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(433, 50);
            this.txtNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNum.MaxLength = 5;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(56, 20);
            this.txtNum.TabIndex = 35;
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // txtRua
            // 
            this.txtRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(20, 52);
            this.txtRua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRua.MaxLength = 60;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(390, 20);
            this.txtRua.TabIndex = 34;
            this.txtRua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRua_KeyPress);
            // 
            // cbxCidade
            // 
            this.cbxCidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCidade.FormattingEnabled = true;
            this.cbxCidade.Location = new System.Drawing.Point(183, 112);
            this.cbxCidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxCidade.Name = "cbxCidade";
            this.cbxCidade.Size = new System.Drawing.Size(170, 21);
            this.cbxCidade.TabIndex = 33;
            this.cbxCidade.SelectedIndexChanged += new System.EventHandler(this.cbxCidade_SelectedIndexChanged);
            // 
            // cbxEstado
            // 
            this.cbxEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(20, 112);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(140, 21);
            this.cbxEstado.TabIndex = 32;
            this.cbxEstado.SelectedIndexChanged += new System.EventHandler(this.cbxEstado_SelectedIndexChanged);
            // 
            // lblCepUs
            // 
            this.lblCepUs.AutoSize = true;
            this.lblCepUs.Location = new System.Drawing.Point(386, 91);
            this.lblCepUs.Name = "lblCepUs";
            this.lblCepUs.Size = new System.Drawing.Size(42, 15);
            this.lblCepUs.TabIndex = 22;
            this.lblCepUs.Text = "CEP: ";
            // 
            // lblEstadoUs
            // 
            this.lblEstadoUs.AutoSize = true;
            this.lblEstadoUs.Location = new System.Drawing.Point(16, 92);
            this.lblEstadoUs.Name = "lblEstadoUs";
            this.lblEstadoUs.Size = new System.Drawing.Size(65, 15);
            this.lblEstadoUs.TabIndex = 20;
            this.lblEstadoUs.Text = "Estado: *";
            // 
            // lblCidadeUs
            // 
            this.lblCidadeUs.AutoSize = true;
            this.lblCidadeUs.Location = new System.Drawing.Point(180, 92);
            this.lblCidadeUs.Name = "lblCidadeUs";
            this.lblCidadeUs.Size = new System.Drawing.Size(66, 15);
            this.lblCidadeUs.TabIndex = 19;
            this.lblCidadeUs.Text = "Cidade: *";
            // 
            // lblBairroUs
            // 
            this.lblBairroUs.AutoSize = true;
            this.lblBairroUs.Location = new System.Drawing.Point(20, 153);
            this.lblBairroUs.Name = "lblBairroUs";
            this.lblBairroUs.Size = new System.Drawing.Size(64, 15);
            this.lblBairroUs.TabIndex = 18;
            this.lblBairroUs.Text = "Bairro:  *";
            // 
            // lblComplementoUs
            // 
            this.lblComplementoUs.AutoSize = true;
            this.lblComplementoUs.Location = new System.Drawing.Point(209, 153);
            this.lblComplementoUs.Name = "lblComplementoUs";
            this.lblComplementoUs.Size = new System.Drawing.Size(100, 15);
            this.lblComplementoUs.TabIndex = 17;
            this.lblComplementoUs.Text = "Complemento:";
            // 
            // lblNumeroUs
            // 
            this.lblNumeroUs.AutoSize = true;
            this.lblNumeroUs.Location = new System.Drawing.Point(429, 31);
            this.lblNumeroUs.Name = "lblNumeroUs";
            this.lblNumeroUs.Size = new System.Drawing.Size(33, 15);
            this.lblNumeroUs.TabIndex = 16;
            this.lblNumeroUs.Text = "N° *";
            // 
            // lblRuaUs
            // 
            this.lblRuaUs.AutoSize = true;
            this.lblRuaUs.Location = new System.Drawing.Point(16, 31);
            this.lblRuaUs.Name = "lblRuaUs";
            this.lblRuaUs.Size = new System.Drawing.Size(47, 15);
            this.lblRuaUs.TabIndex = 15;
            this.lblRuaUs.Text = "Rua: *";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDesc);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtDdd);
            this.groupBox2.Controls.Add(this.txtFixo);
            this.groupBox2.Controls.Add(this.txtOpe);
            this.groupBox2.Controls.Add(this.txtCelular);
            this.groupBox2.Controls.Add(this.txtCnpj);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblOpUs);
            this.groupBox2.Controls.Add(this.lblCelularUs);
            this.groupBox2.Controls.Add(this.lblTelefoneUS);
            this.groupBox2.Controls.Add(this.lblDdd);
            this.groupBox2.Controls.Add(this.lblCpf);
            this.groupBox2.Controls.Add(this.CV);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(22, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(521, 254);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados da Empresa";
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(175, 181);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDesc.MaxLength = 100;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(314, 50);
            this.txtDesc.TabIndex = 57;
            this.txtDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesc_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(224, 112);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(265, 20);
            this.txtEmail.TabIndex = 56;
            // 
            // txtDdd
            // 
            this.txtDdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDdd.Location = new System.Drawing.Point(119, 181);
            this.txtDdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDdd.MaxLength = 3;
            this.txtDdd.Name = "txtDdd";
            this.txtDdd.Size = new System.Drawing.Size(35, 20);
            this.txtDdd.TabIndex = 55;
            this.txtDdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDdd_KeyPress);
            // 
            // txtFixo
            // 
            this.txtFixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFixo.Location = new System.Drawing.Point(20, 181);
            this.txtFixo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFixo.MaxLength = 8;
            this.txtFixo.Name = "txtFixo";
            this.txtFixo.Size = new System.Drawing.Size(79, 20);
            this.txtFixo.TabIndex = 54;
            this.txtFixo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFixo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFixo_KeyPress);
            // 
            // txtOpe
            // 
            this.txtOpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpe.Location = new System.Drawing.Point(119, 112);
            this.txtOpe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOpe.MaxLength = 15;
            this.txtOpe.Name = "txtOpe";
            this.txtOpe.Size = new System.Drawing.Size(86, 20);
            this.txtOpe.TabIndex = 53;
            this.txtOpe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOpe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOpe_KeyPress);
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(20, 112);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCelular.MaxLength = 9;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(79, 20);
            this.txtCelular.TabIndex = 52;
            this.txtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // txtCnpj
            // 
            this.txtCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpj.Location = new System.Drawing.Point(337, 50);
            this.txtCnpj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCnpj.MaxLength = 14;
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(152, 20);
            this.txtCnpj.TabIndex = 51;
            this.txtCnpj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCnpj_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(20, 52);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.MaxLength = 60;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(294, 20);
            this.txtName.TabIndex = 50;
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 15);
            this.label1.TabIndex = 49;
            this.label1.Text = "Descrição da empresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "E-Mail:";
            // 
            // lblOpUs
            // 
            this.lblOpUs.AutoSize = true;
            this.lblOpUs.Location = new System.Drawing.Point(115, 92);
            this.lblOpUs.Name = "lblOpUs";
            this.lblOpUs.Size = new System.Drawing.Size(79, 15);
            this.lblOpUs.TabIndex = 34;
            this.lblOpUs.Text = "Operadora:";
            // 
            // lblCelularUs
            // 
            this.lblCelularUs.AutoSize = true;
            this.lblCelularUs.Location = new System.Drawing.Point(16, 92);
            this.lblCelularUs.Name = "lblCelularUs";
            this.lblCelularUs.Size = new System.Drawing.Size(65, 15);
            this.lblCelularUs.TabIndex = 33;
            this.lblCelularUs.Text = "Celular : ";
            // 
            // lblTelefoneUS
            // 
            this.lblTelefoneUS.AutoSize = true;
            this.lblTelefoneUS.Location = new System.Drawing.Point(16, 161);
            this.lblTelefoneUS.Name = "lblTelefoneUS";
            this.lblTelefoneUS.Size = new System.Drawing.Size(67, 15);
            this.lblTelefoneUS.TabIndex = 31;
            this.lblTelefoneUS.Text = "Telefone:";
            // 
            // lblDdd
            // 
            this.lblDdd.AutoSize = true;
            this.lblDdd.Location = new System.Drawing.Point(115, 161);
            this.lblDdd.Name = "lblDdd";
            this.lblDdd.Size = new System.Drawing.Size(41, 15);
            this.lblDdd.TabIndex = 30;
            this.lblDdd.Text = "DDD:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(334, 31);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(56, 15);
            this.lblCpf.TabIndex = 25;
            this.lblCpf.Text = "CNPJ: *";
            // 
            // CV
            // 
            this.CV.AutoSize = true;
            this.CV.Location = new System.Drawing.Point(16, 31);
            this.CV.Name = "CV";
            this.CV.Size = new System.Drawing.Size(139, 15);
            this.CV.TabIndex = 23;
            this.CV.Text = "Nome da empresa: *";
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.White;
            this.lblAviso.Location = new System.Drawing.Point(18, 535);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(14, 20);
            this.lblAviso.TabIndex = 36;
            this.lblAviso.Text = ".";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::GerenciadorVeiculo1.Properties.Resources.gravar;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(440, 527);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(103, 32);
            this.btnSalvar.TabIndex = 37;
            this.btnSalvar.Text = "     Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::GerenciadorVeiculo1.Properties.Resources.fechar;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(329, 527);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 32);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "     Fechar";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FmrCadastroEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(78)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(563, 576);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtTele);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FmrCadastroEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Empresa";
            this.Load += new System.EventHandler(this.FmrCadastroEmp_Load);
            this.txtTele.ResumeLayout(false);
            this.txtTele.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox txtTele;
        private System.Windows.Forms.ComboBox cbxCidade;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Label lblCepUs;
        private System.Windows.Forms.Label lblEstadoUs;
        private System.Windows.Forms.Label lblCidadeUs;
        private System.Windows.Forms.Label lblBairroUs;
        private System.Windows.Forms.Label lblComplementoUs;
        private System.Windows.Forms.Label lblNumeroUs;
        private System.Windows.Forms.Label lblRuaUs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblOpUs;
        private System.Windows.Forms.Label lblCelularUs;
        private System.Windows.Forms.Label lblTelefoneUS;
        private System.Windows.Forms.Label lblDdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label CV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDdd;
        private System.Windows.Forms.TextBox txtFixo;
        private System.Windows.Forms.TextBox txtOpe;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtComp;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnClose;
    }
}