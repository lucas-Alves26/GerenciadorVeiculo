namespace GerenciadorVeiculo1.View.GerVeiculo
{
    partial class FmrCadastroVei
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
            this.tabVeiculo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblAviso = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbxTipoVei = new System.Windows.Forms.ComboBox();
            this.cbxmodelo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEstadoUs = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.cbxEmpresa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtChassis = new System.Windows.Forms.TextBox();
            this.txtAnoModelo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAnoFab = new System.Windows.Forms.TextBox();
            this.txtrenavam = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.txtCombustivel = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.txtCombus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSalvarMot = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtVigFin = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtVigIni = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxSegura = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabVeiculo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabVeiculo
            // 
            this.tabVeiculo.AccessibleName = "";
            this.tabVeiculo.Controls.Add(this.tabPage1);
            this.tabVeiculo.Controls.Add(this.tabPage2);
            this.tabVeiculo.Location = new System.Drawing.Point(11, 3);
            this.tabVeiculo.Name = "tabVeiculo";
            this.tabVeiculo.SelectedIndex = 0;
            this.tabVeiculo.Size = new System.Drawing.Size(572, 333);
            this.tabVeiculo.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(78)))), ((int)(((byte)(117)))));
            this.tabPage1.Controls.Add(this.lblAviso);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnClose);
            this.tabPage1.Controls.Add(this.btnSalvarMot);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(564, 307);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Veículo";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.White;
            this.lblAviso.Location = new System.Drawing.Point(17, 263);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(14, 20);
            this.lblAviso.TabIndex = 68;
            this.lblAviso.Text = ".";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.cbxTipoVei);
            this.groupBox1.Controls.Add(this.cbxmodelo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxMarca);
            this.groupBox1.Controls.Add(this.cbxEstado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblEstadoUs);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtPlaca);
            this.groupBox1.Controls.Add(this.cbxEmpresa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtChassis);
            this.groupBox1.Controls.Add(this.txtAnoModelo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAnoFab);
            this.groupBox1.Controls.Add(this.txtrenavam);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCor);
            this.groupBox1.Controls.Add(this.txtKm);
            this.groupBox1.Controls.Add(this.txtCombustivel);
            this.groupBox1.Controls.Add(this.txtLugar);
            this.groupBox1.Controls.Add(this.txtCombus);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 233);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do veículo";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(225, 132);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 15);
            this.label17.TabIndex = 63;
            this.label17.Text = "Tipo: *";
            // 
            // cbxTipoVei
            // 
            this.cbxTipoVei.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoVei.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoVei.FormattingEnabled = true;
            this.cbxTipoVei.Items.AddRange(new object[] {
            "Passeio",
            "Caminhão"});
            this.cbxTipoVei.Location = new System.Drawing.Point(228, 148);
            this.cbxTipoVei.Name = "cbxTipoVei";
            this.cbxTipoVei.Size = new System.Drawing.Size(116, 21);
            this.cbxTipoVei.TabIndex = 62;
            // 
            // cbxmodelo
            // 
            this.cbxmodelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxmodelo.FormattingEnabled = true;
            this.cbxmodelo.Location = new System.Drawing.Point(156, 40);
            this.cbxmodelo.Name = "cbxmodelo";
            this.cbxmodelo.Size = new System.Drawing.Size(121, 21);
            this.cbxmodelo.TabIndex = 3;
            this.cbxmodelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxmodelo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca: *";
            // 
            // cbxMarca
            // 
            this.cbxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(18, 40);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(121, 21);
            this.cbxMarca.TabIndex = 1;
            this.cbxMarca.SelectedIndexChanged += new System.EventHandler(this.cbxMarca_SelectedIndexChanged);
            this.cbxMarca.Click += new System.EventHandler(this.cbxMarca_Click);
            this.cbxMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxMarca_KeyPress);
            // 
            // cbxEstado
            // 
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(19, 197);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(121, 21);
            this.cbxEstado.TabIndex = 61;
            this.cbxEstado.SelectedIndexChanged += new System.EventHandler(this.cbxEstado_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo: *";
            // 
            // lblEstadoUs
            // 
            this.lblEstadoUs.AutoSize = true;
            this.lblEstadoUs.Location = new System.Drawing.Point(16, 181);
            this.lblEstadoUs.Name = "lblEstadoUs";
            this.lblEstadoUs.Size = new System.Drawing.Size(65, 15);
            this.lblEstadoUs.TabIndex = 60;
            this.lblEstadoUs.Text = "Estado: *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Placa: *";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(374, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 15);
            this.label12.TabIndex = 59;
            this.label12.Text = "Empresa: *";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(294, 41);
            this.txtPlaca.MaxLength = 7;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(56, 20);
            this.txtPlaca.TabIndex = 5;
            this.txtPlaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxEmpresa
            // 
            this.cbxEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEmpresa.FormattingEnabled = true;
            this.cbxEmpresa.Location = new System.Drawing.Point(377, 148);
            this.cbxEmpresa.Name = "cbxEmpresa";
            this.cbxEmpresa.Size = new System.Drawing.Size(129, 21);
            this.cbxEmpresa.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chassis: *";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(111, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Ano Modelo:";
            // 
            // txtChassis
            // 
            this.txtChassis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChassis.Location = new System.Drawing.Point(369, 41);
            this.txtChassis.MaxLength = 17;
            this.txtChassis.Name = "txtChassis";
            this.txtChassis.Size = new System.Drawing.Size(137, 20);
            this.txtChassis.TabIndex = 7;
            this.txtChassis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtChassis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChassis_KeyPress);
            // 
            // txtAnoModelo
            // 
            this.txtAnoModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnoModelo.Location = new System.Drawing.Point(114, 148);
            this.txtAnoModelo.MaxLength = 7;
            this.txtAnoModelo.Name = "txtAnoModelo";
            this.txtAnoModelo.Size = new System.Drawing.Size(81, 20);
            this.txtAnoModelo.TabIndex = 21;
            this.txtAnoModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAnoModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnoModelo_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Renavam: *";
            // 
            // txtAnoFab
            // 
            this.txtAnoFab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnoFab.Location = new System.Drawing.Point(18, 148);
            this.txtAnoFab.MaxLength = 7;
            this.txtAnoFab.Name = "txtAnoFab";
            this.txtAnoFab.Size = new System.Drawing.Size(70, 20);
            this.txtAnoFab.TabIndex = 20;
            this.txtAnoFab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAnoFab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnoFab_KeyPress);
            // 
            // txtrenavam
            // 
            this.txtrenavam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrenavam.Location = new System.Drawing.Point(18, 94);
            this.txtrenavam.MaxLength = 11;
            this.txtrenavam.Name = "txtrenavam";
            this.txtrenavam.Size = new System.Drawing.Size(79, 20);
            this.txtrenavam.TabIndex = 11;
            this.txtrenavam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtrenavam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrenavam_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ano FAB:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cor: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Quilometragem: *";
            // 
            // txtCor
            // 
            this.txtCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCor.Location = new System.Drawing.Point(114, 94);
            this.txtCor.MaxLength = 20;
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(91, 20);
            this.txtCor.TabIndex = 13;
            this.txtCor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCor_KeyPress);
            // 
            // txtKm
            // 
            this.txtKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKm.Location = new System.Drawing.Point(406, 94);
            this.txtKm.MaxLength = 7;
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(100, 20);
            this.txtKm.TabIndex = 17;
            this.txtKm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKm_KeyPress);
            // 
            // txtCombustivel
            // 
            this.txtCombustivel.AutoSize = true;
            this.txtCombustivel.Location = new System.Drawing.Point(228, 78);
            this.txtCombustivel.Name = "txtCombustivel";
            this.txtCombustivel.Size = new System.Drawing.Size(93, 15);
            this.txtCombustivel.TabIndex = 14;
            this.txtCombustivel.Text = "Combustivel: ";
            // 
            // txtLugar
            // 
            this.txtLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugar.Location = new System.Drawing.Point(344, 94);
            this.txtLugar.MaxLength = 20;
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(39, 20);
            this.txtLugar.TabIndex = 3;
            this.txtLugar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLugar.TextChanged += new System.EventHandler(this.txtLugar_TextChanged);
            this.txtLugar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLugar_KeyPress);
            // 
            // txtCombus
            // 
            this.txtCombus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombus.Location = new System.Drawing.Point(231, 94);
            this.txtCombus.MaxLength = 20;
            this.txtCombus.Name = "txtCombus";
            this.txtCombus.Size = new System.Drawing.Size(91, 20);
            this.txtCombus.TabIndex = 15;
            this.txtCombus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCombus_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Lugares: ";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::GerenciadorVeiculo1.Properties.Resources.fechar;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(351, 251);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 31);
            this.btnClose.TabIndex = 66;
            this.btnClose.Text = "     Fechar";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnLimparUs_Click);
            // 
            // btnSalvarMot
            // 
            this.btnSalvarMot.BackColor = System.Drawing.Color.White;
            this.btnSalvarMot.FlatAppearance.BorderSize = 0;
            this.btnSalvarMot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvarMot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSalvarMot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarMot.Image = global::GerenciadorVeiculo1.Properties.Resources.gravar;
            this.btnSalvarMot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarMot.Location = new System.Drawing.Point(452, 251);
            this.btnSalvarMot.Name = "btnSalvarMot";
            this.btnSalvarMot.Size = new System.Drawing.Size(95, 32);
            this.btnSalvarMot.TabIndex = 65;
            this.btnSalvarMot.Text = "     Salver";
            this.btnSalvarMot.UseVisualStyleBackColor = false;
            this.btnSalvarMot.Click += new System.EventHandler(this.btnSalvarMot_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(78)))), ((int)(((byte)(117)))));
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(564, 307);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Seguro";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtVigFin);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtVigIni);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cbxTipo);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cbxSegura);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(11, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 222);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do seguro";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtVigFin
            // 
            this.txtVigFin.Location = new System.Drawing.Point(441, 38);
            this.txtVigFin.Name = "txtVigFin";
            this.txtVigFin.Size = new System.Drawing.Size(91, 21);
            this.txtVigFin.TabIndex = 9;
            this.txtVigFin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVigFin_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(438, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 15);
            this.label15.TabIndex = 8;
            this.label15.Text = "Vigência final: ";
            // 
            // txtVigIni
            // 
            this.txtVigIni.Location = new System.Drawing.Point(319, 38);
            this.txtVigIni.Name = "txtVigIni";
            this.txtVigIni.Size = new System.Drawing.Size(102, 21);
            this.txtVigIni.TabIndex = 7;
            this.txtVigIni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVigIni_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(316, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 15);
            this.label14.TabIndex = 6;
            this.label14.Text = "Vigência inicial: ";
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Completo",
            "Básico",
            "Furto e Roubo"});
            this.cbxTipo.Location = new System.Drawing.Point(192, 38);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(107, 23);
            this.cbxTipo.TabIndex = 5;
            this.cbxTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxTipo_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(189, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 15);
            this.label13.TabIndex = 4;
            this.label13.Text = "Tipo: ";
            // 
            // cbxSegura
            // 
            this.cbxSegura.FormattingEnabled = true;
            this.cbxSegura.Location = new System.Drawing.Point(16, 39);
            this.cbxSegura.Name = "cbxSegura";
            this.cbxSegura.Size = new System.Drawing.Size(157, 23);
            this.cbxSegura.TabIndex = 3;
            this.cbxSegura.Click += new System.EventHandler(this.cbxSegura_Click);
            this.cbxSegura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxSegura_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(13, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Nome seguradoura: ";
            // 
            // FmrCadastroVei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(78)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(595, 339);
            this.Controls.Add(this.tabVeiculo);
            this.Name = "FmrCadastroVei";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de veículos";
            this.Load += new System.EventHandler(this.FmrCadastroVei_Load);
            this.tabVeiculo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabVeiculo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxmodelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEstadoUs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.ComboBox cbxEmpresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtChassis;
        private System.Windows.Forms.TextBox txtAnoModelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAnoFab;
        private System.Windows.Forms.TextBox txtrenavam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.Label txtCombustivel;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.TextBox txtCombus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSalvarMot;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtVigFin;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtVigIni;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxSegura;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbxTipoVei;
        private System.Windows.Forms.Label lblAviso;
    }
}