namespace GerenciadorVeiculo1.View.GerEntradaSaida
{
    partial class FmrSaida
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
            this.label12 = new System.Windows.Forms.Label();
            this.cbxEmpresa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxMotorista = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCnh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChassis = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxPlaca = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOdo = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.dateHora = new System.Windows.Forms.Timer(this.components);
            this.txtData = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 16);
            this.label12.TabIndex = 61;
            this.label12.Text = "Empresa: ";
            // 
            // cbxEmpresa
            // 
            this.cbxEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEmpresa.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEmpresa.FormattingEnabled = true;
            this.cbxEmpresa.Location = new System.Drawing.Point(13, 39);
            this.cbxEmpresa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxEmpresa.Name = "cbxEmpresa";
            this.cbxEmpresa.Size = new System.Drawing.Size(150, 23);
            this.cbxEmpresa.TabIndex = 60;
            this.cbxEmpresa.SelectedIndexChanged += new System.EventHandler(this.cbxEmpresa_SelectedIndexChanged);
            this.cbxEmpresa.SelectionChangeCommitted += new System.EventHandler(this.cbxEmpresa_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 62;
            this.label1.Text = "Motorista: ";
            // 
            // cbxMotorista
            // 
            this.cbxMotorista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMotorista.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMotorista.FormattingEnabled = true;
            this.cbxMotorista.Location = new System.Drawing.Point(188, 39);
            this.cbxMotorista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxMotorista.Name = "cbxMotorista";
            this.cbxMotorista.Size = new System.Drawing.Size(271, 23);
            this.cbxMotorista.TabIndex = 63;
            this.cbxMotorista.SelectedIndexChanged += new System.EventHandler(this.cbxMotorista_SelectedIndexChanged);
            this.cbxMotorista.SelectionChangeCommitted += new System.EventHandler(this.cbxMotorista_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 65;
            this.label2.Text = "CNH:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCnh);
            this.groupBox1.Controls.Add(this.cbxMotorista);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxEmpresa);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(14, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(636, 85);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtCnh
            // 
            this.txtCnh.Enabled = false;
            this.txtCnh.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnh.Location = new System.Drawing.Point(486, 41);
            this.txtCnh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCnh.Name = "txtCnh";
            this.txtCnh.Size = new System.Drawing.Size(139, 21);
            this.txtCnh.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 71;
            this.label5.Text = "Placa: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 73;
            this.label6.Text = "Chassis: ";
            // 
            // txtChassis
            // 
            this.txtChassis.Enabled = false;
            this.txtChassis.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChassis.Location = new System.Drawing.Point(386, 42);
            this.txtChassis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtChassis.MaxLength = 17;
            this.txtChassis.Name = "txtChassis";
            this.txtChassis.Size = new System.Drawing.Size(137, 21);
            this.txtChassis.TabIndex = 74;
            this.txtChassis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtModelo);
            this.groupBox2.Controls.Add(this.txtMarca);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbxPlaca);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtOdo);
            this.groupBox2.Controls.Add(this.txtChassis);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(14, 122);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(636, 86);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            // 
            // txtModelo
            // 
            this.txtModelo.Enabled = false;
            this.txtModelo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(257, 43);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(116, 21);
            this.txtModelo.TabIndex = 82;
            this.txtModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(124, 42);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(116, 21);
            this.txtMarca.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 78;
            this.label3.Text = "Marca: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 80;
            this.label4.Text = "Modelo: ";
            // 
            // cbxPlaca
            // 
            this.cbxPlaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPlaca.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPlaca.FormattingEnabled = true;
            this.cbxPlaca.Location = new System.Drawing.Point(13, 42);
            this.cbxPlaca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxPlaca.Name = "cbxPlaca";
            this.cbxPlaca.Size = new System.Drawing.Size(91, 23);
            this.cbxPlaca.TabIndex = 77;
            this.cbxPlaca.SelectedIndexChanged += new System.EventHandler(this.cbxPlaca_SelectedIndexChanged);
            this.cbxPlaca.SelectionChangeCommitted += new System.EventHandler(this.cbxPlaca_SelectionChangeCommitted);
            this.cbxPlaca.SelectedValueChanged += new System.EventHandler(this.cbxPlaca_SelectedValueChanged);
            this.cbxPlaca.Click += new System.EventHandler(this.cbxPlaca_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(531, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 76;
            this.label8.Text = "Odômetro: ";
            // 
            // txtOdo
            // 
            this.txtOdo.Enabled = false;
            this.txtOdo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOdo.Location = new System.Drawing.Point(534, 42);
            this.txtOdo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOdo.MaxLength = 7;
            this.txtOdo.Name = "txtOdo";
            this.txtOdo.Size = new System.Drawing.Size(94, 21);
            this.txtOdo.TabIndex = 75;
            this.txtOdo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtObs
            // 
            this.txtObs.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.Location = new System.Drawing.Point(14, 244);
            this.txtObs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtObs.MaxLength = 100;
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(373, 59);
            this.txtObs.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 77;
            this.label7.Text = "Observação: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::GerenciadorVeiculo1.Properties.Resources.gravar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(554, 308);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 32);
            this.button1.TabIndex = 79;
            this.button1.Text = "     Salvar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::GerenciadorVeiculo1.Properties.Resources.fechar;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(453, 309);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 32);
            this.button3.TabIndex = 81;
            this.button3.Text = "     Fechar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblData.Location = new System.Drawing.Point(558, 11);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(79, 20);
            this.lblData.TabIndex = 82;
            this.lblData.Text = "00:00:00";
            // 
            // dateHora
            // 
            this.dateHora.Enabled = true;
            this.dateHora.Tick += new System.EventHandler(this.dateHora_Tick);
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(50, 16);
            this.txtData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(103, 21);
            this.txtData.TabIndex = 83;
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtData);
            this.groupBox3.Location = new System.Drawing.Point(489, 215);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(161, 52);
            this.groupBox3.TabIndex = 84;
            this.groupBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(8, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 84;
            this.label9.Text = "Data:";
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(23, 314);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(14, 20);
            this.lblAviso.TabIndex = 85;
            this.lblAviso.Text = ".";
            // 
            // FmrSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(78)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(661, 351);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FmrSaida";
            this.Text = "Saída de veículo";
            this.Load += new System.EventHandler(this.FmrSaida_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxMotorista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChassis;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOdo;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxPlaca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Timer dateHora;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCnh;
        private System.Windows.Forms.Label lblAviso;
    }
}