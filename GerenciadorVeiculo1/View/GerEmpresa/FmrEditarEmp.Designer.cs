namespace GerenciadorVeiculo1.View.GerEmpresa
{
    partial class FmrEditarEmp
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.txtTele.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(369, 433);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 42;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(10, 435);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(16, 24);
            this.lblAviso.TabIndex = 41;
            this.lblAviso.Text = ".";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbxStatus);
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
            this.groupBox2.Location = new System.Drawing.Point(10, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 206);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados da Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Status:";
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cbxStatus.Location = new System.Drawing.Point(149, 147);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(77, 21);
            this.cbxStatus.TabIndex = 58;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(240, 147);
            this.txtDesc.MaxLength = 100;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(180, 41);
            this.txtDesc.TabIndex = 57;
            this.txtDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesc_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(192, 91);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(228, 20);
            this.txtEmail.TabIndex = 56;
            // 
            // txtDdd
            // 
            this.txtDdd.Location = new System.Drawing.Point(102, 147);
            this.txtDdd.MaxLength = 3;
            this.txtDdd.Name = "txtDdd";
            this.txtDdd.Size = new System.Drawing.Size(31, 20);
            this.txtDdd.TabIndex = 55;
            this.txtDdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDdd_KeyPress);
            // 
            // txtFixo
            // 
            this.txtFixo.Location = new System.Drawing.Point(17, 147);
            this.txtFixo.MaxLength = 8;
            this.txtFixo.Name = "txtFixo";
            this.txtFixo.Size = new System.Drawing.Size(68, 20);
            this.txtFixo.TabIndex = 54;
            this.txtFixo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFixo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFixo_KeyPress);
            // 
            // txtOpe
            // 
            this.txtOpe.Location = new System.Drawing.Point(102, 91);
            this.txtOpe.MaxLength = 15;
            this.txtOpe.Name = "txtOpe";
            this.txtOpe.Size = new System.Drawing.Size(74, 20);
            this.txtOpe.TabIndex = 53;
            this.txtOpe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOpe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOpe_KeyPress);
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(17, 91);
            this.txtCelular.MaxLength = 9;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(68, 20);
            this.txtCelular.TabIndex = 52;
            this.txtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(289, 42);
            this.txtCnpj.MaxLength = 14;
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(131, 20);
            this.txtCnpj.TabIndex = 51;
            this.txtCnpj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCnpj_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(17, 42);
            this.txtName.MaxLength = 60;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(253, 20);
            this.txtName.TabIndex = 50;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Descrição da empresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "E-Mail:";
            // 
            // lblOpUs
            // 
            this.lblOpUs.AutoSize = true;
            this.lblOpUs.Location = new System.Drawing.Point(99, 75);
            this.lblOpUs.Name = "lblOpUs";
            this.lblOpUs.Size = new System.Drawing.Size(60, 13);
            this.lblOpUs.TabIndex = 34;
            this.lblOpUs.Text = "Operadora:";
            // 
            // lblCelularUs
            // 
            this.lblCelularUs.AutoSize = true;
            this.lblCelularUs.Location = new System.Drawing.Point(14, 75);
            this.lblCelularUs.Name = "lblCelularUs";
            this.lblCelularUs.Size = new System.Drawing.Size(48, 13);
            this.lblCelularUs.TabIndex = 33;
            this.lblCelularUs.Text = "Celular : ";
            // 
            // lblTelefoneUS
            // 
            this.lblTelefoneUS.AutoSize = true;
            this.lblTelefoneUS.Location = new System.Drawing.Point(14, 131);
            this.lblTelefoneUS.Name = "lblTelefoneUS";
            this.lblTelefoneUS.Size = new System.Drawing.Size(52, 13);
            this.lblTelefoneUS.TabIndex = 31;
            this.lblTelefoneUS.Text = "Telefone:";
            // 
            // lblDdd
            // 
            this.lblDdd.AutoSize = true;
            this.lblDdd.Location = new System.Drawing.Point(99, 131);
            this.lblDdd.Name = "lblDdd";
            this.lblDdd.Size = new System.Drawing.Size(34, 13);
            this.lblDdd.TabIndex = 30;
            this.lblDdd.Text = "DDD:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(286, 26);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(44, 13);
            this.lblCpf.TabIndex = 25;
            this.lblCpf.Text = "CNPJ: *";
            // 
            // CV
            // 
            this.CV.AutoSize = true;
            this.CV.Location = new System.Drawing.Point(14, 26);
            this.CV.Name = "CV";
            this.CV.Size = new System.Drawing.Size(103, 13);
            this.CV.TabIndex = 23;
            this.CV.Text = "Nome da empresa: *";
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
            this.txtTele.Location = new System.Drawing.Point(10, 224);
            this.txtTele.Name = "txtTele";
            this.txtTele.Size = new System.Drawing.Size(434, 194);
            this.txtTele.TabIndex = 39;
            this.txtTele.TabStop = false;
            this.txtTele.Text = "Endereço";
            // 
            // txtComp
            // 
            this.txtComp.Location = new System.Drawing.Point(182, 141);
            this.txtComp.MaxLength = 100;
            this.txtComp.Multiline = true;
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(238, 37);
            this.txtComp.TabIndex = 38;
            this.txtComp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComp_KeyPress);
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(17, 141);
            this.txtBairro.MaxLength = 60;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(142, 20);
            this.txtBairro.TabIndex = 37;
            this.txtBairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBairro_KeyPress);
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(334, 91);
            this.txtCep.MaxLength = 8;
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(86, 20);
            this.txtCep.TabIndex = 36;
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(371, 41);
            this.txtNum.MaxLength = 5;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(49, 20);
            this.txtNum.TabIndex = 35;
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(17, 42);
            this.txtRua.MaxLength = 60;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(335, 20);
            this.txtRua.TabIndex = 34;
            this.txtRua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRua_KeyPress);
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
            this.cbxCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxCidade_KeyPress);
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
            // lblCepUs
            // 
            this.lblCepUs.AutoSize = true;
            this.lblCepUs.Location = new System.Drawing.Point(331, 74);
            this.lblCepUs.Name = "lblCepUs";
            this.lblCepUs.Size = new System.Drawing.Size(34, 13);
            this.lblCepUs.TabIndex = 22;
            this.lblCepUs.Text = "CEP: ";
            // 
            // lblEstadoUs
            // 
            this.lblEstadoUs.AutoSize = true;
            this.lblEstadoUs.Location = new System.Drawing.Point(14, 75);
            this.lblEstadoUs.Name = "lblEstadoUs";
            this.lblEstadoUs.Size = new System.Drawing.Size(50, 13);
            this.lblEstadoUs.TabIndex = 20;
            this.lblEstadoUs.Text = "Estado: *";
            // 
            // lblCidadeUs
            // 
            this.lblCidadeUs.AutoSize = true;
            this.lblCidadeUs.Location = new System.Drawing.Point(154, 75);
            this.lblCidadeUs.Name = "lblCidadeUs";
            this.lblCidadeUs.Size = new System.Drawing.Size(50, 13);
            this.lblCidadeUs.TabIndex = 19;
            this.lblCidadeUs.Text = "Cidade: *";
            // 
            // lblBairroUs
            // 
            this.lblBairroUs.AutoSize = true;
            this.lblBairroUs.Location = new System.Drawing.Point(17, 124);
            this.lblBairroUs.Name = "lblBairroUs";
            this.lblBairroUs.Size = new System.Drawing.Size(47, 13);
            this.lblBairroUs.TabIndex = 18;
            this.lblBairroUs.Text = "Bairro:  *";
            // 
            // lblComplementoUs
            // 
            this.lblComplementoUs.AutoSize = true;
            this.lblComplementoUs.Location = new System.Drawing.Point(179, 124);
            this.lblComplementoUs.Name = "lblComplementoUs";
            this.lblComplementoUs.Size = new System.Drawing.Size(74, 13);
            this.lblComplementoUs.TabIndex = 17;
            this.lblComplementoUs.Text = "Complemento:";
            // 
            // lblNumeroUs
            // 
            this.lblNumeroUs.AutoSize = true;
            this.lblNumeroUs.Location = new System.Drawing.Point(368, 25);
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
            this.lblRuaUs.Size = new System.Drawing.Size(37, 13);
            this.lblRuaUs.TabIndex = 15;
            this.lblRuaUs.Text = "Rua: *";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(277, 435);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 43;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // FmrEditarEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 468);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtTele);
            this.Name = "FmrEditarEmp";
            this.Text = "Dados da Empresa";
            this.Load += new System.EventHandler(this.FmrEditarEmp_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.txtTele.ResumeLayout(false);
            this.txtTele.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDdd;
        private System.Windows.Forms.TextBox txtFixo;
        private System.Windows.Forms.TextBox txtOpe;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOpUs;
        private System.Windows.Forms.Label lblCelularUs;
        private System.Windows.Forms.Label lblTelefoneUS;
        private System.Windows.Forms.Label lblDdd;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label CV;
        private System.Windows.Forms.GroupBox txtTele;
        private System.Windows.Forms.TextBox txtComp;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.ComboBox cbxCidade;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Label lblCepUs;
        private System.Windows.Forms.Label lblEstadoUs;
        private System.Windows.Forms.Label lblCidadeUs;
        private System.Windows.Forms.Label lblBairroUs;
        private System.Windows.Forms.Label lblComplementoUs;
        private System.Windows.Forms.Label lblNumeroUs;
        private System.Windows.Forms.Label lblRuaUs;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label3;
    }
}