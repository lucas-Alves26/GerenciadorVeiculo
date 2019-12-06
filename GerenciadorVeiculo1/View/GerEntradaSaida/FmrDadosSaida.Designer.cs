namespace GerenciadorVeiculo1.View.GerEntradaSaida
{
    partial class FmrDadosSaida
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.cbxPlaca = new System.Windows.Forms.GroupBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOdo = new System.Windows.Forms.TextBox();
            this.txtChassis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCnh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxEmpresa = new System.Windows.Forms.ComboBox();
            this.cbxMotorista = new System.Windows.Forms.ComboBox();
            this.cbxPlacaa = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            this.cbxPlaca.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtData);
            this.groupBox3.Location = new System.Drawing.Point(408, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 42);
            this.groupBox3.TabIndex = 93;
            this.groupBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(7, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 84;
            this.label9.Text = "Data:";
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(54, 15);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(89, 20);
            this.txtData.TabIndex = 83;
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::GerenciadorVeiculo1.Properties.Resources.fechar;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(461, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 31);
            this.button3.TabIndex = 91;
            this.button3.Text = "     Fechar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 15);
            this.label7.TabIndex = 88;
            this.label7.Text = "Observação: ";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(12, 203);
            this.txtObs.MaxLength = 100;
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(320, 49);
            this.txtObs.TabIndex = 89;
            // 
            // cbxPlaca
            // 
            this.cbxPlaca.Controls.Add(this.cbxPlacaa);
            this.cbxPlaca.Controls.Add(this.txtModelo);
            this.cbxPlaca.Controls.Add(this.txtMarca);
            this.cbxPlaca.Controls.Add(this.label3);
            this.cbxPlaca.Controls.Add(this.label4);
            this.cbxPlaca.Controls.Add(this.label8);
            this.cbxPlaca.Controls.Add(this.txtOdo);
            this.cbxPlaca.Controls.Add(this.txtChassis);
            this.cbxPlaca.Controls.Add(this.label6);
            this.cbxPlaca.Controls.Add(this.label5);
            this.cbxPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPlaca.ForeColor = System.Drawing.Color.White;
            this.cbxPlaca.Location = new System.Drawing.Point(12, 104);
            this.cbxPlaca.Name = "cbxPlaca";
            this.cbxPlaca.Size = new System.Drawing.Size(545, 70);
            this.cbxPlaca.TabIndex = 87;
            this.cbxPlaca.TabStop = false;
            // 
            // txtModelo
            // 
            this.txtModelo.Enabled = false;
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(220, 35);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 82;
            this.txtModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(106, 34);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 78;
            this.label3.Text = "Marca: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 80;
            this.label4.Text = "Modelo: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(455, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 15);
            this.label8.TabIndex = 76;
            this.label8.Text = "Odômetro: ";
            // 
            // txtOdo
            // 
            this.txtOdo.Enabled = false;
            this.txtOdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOdo.Location = new System.Drawing.Point(458, 34);
            this.txtOdo.MaxLength = 7;
            this.txtOdo.Name = "txtOdo";
            this.txtOdo.Size = new System.Drawing.Size(81, 20);
            this.txtOdo.TabIndex = 75;
            this.txtOdo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChassis
            // 
            this.txtChassis.Enabled = false;
            this.txtChassis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChassis.Location = new System.Drawing.Point(331, 34);
            this.txtChassis.MaxLength = 17;
            this.txtChassis.Name = "txtChassis";
            this.txtChassis.Size = new System.Drawing.Size(118, 20);
            this.txtChassis.TabIndex = 74;
            this.txtChassis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 73;
            this.label6.Text = "Chassis: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 71;
            this.label5.Text = "Placa: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxMotorista);
            this.groupBox1.Controls.Add(this.cbxEmpresa);
            this.groupBox1.Controls.Add(this.txtCnh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 69);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            // 
            // txtCnh
            // 
            this.txtCnh.Enabled = false;
            this.txtCnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnh.Location = new System.Drawing.Point(417, 33);
            this.txtCnh.Name = "txtCnh";
            this.txtCnh.Size = new System.Drawing.Size(120, 20);
            this.txtCnh.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 65;
            this.label2.Text = "CNH:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 15);
            this.label12.TabIndex = 61;
            this.label12.Text = "Empresa: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 62;
            this.label1.Text = "Motorista: ";
            // 
            // cbxEmpresa
            // 
            this.cbxEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEmpresa.FormattingEnabled = true;
            this.cbxEmpresa.Location = new System.Drawing.Point(11, 33);
            this.cbxEmpresa.Name = "cbxEmpresa";
            this.cbxEmpresa.Size = new System.Drawing.Size(121, 21);
            this.cbxEmpresa.TabIndex = 67;
            // 
            // cbxMotorista
            // 
            this.cbxMotorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMotorista.FormattingEnabled = true;
            this.cbxMotorista.Location = new System.Drawing.Point(159, 33);
            this.cbxMotorista.Name = "cbxMotorista";
            this.cbxMotorista.Size = new System.Drawing.Size(234, 21);
            this.cbxMotorista.TabIndex = 68;
            // 
            // cbxPlacaa
            // 
            this.cbxPlacaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPlacaa.FormattingEnabled = true;
            this.cbxPlacaa.Location = new System.Drawing.Point(11, 33);
            this.cbxPlacaa.Name = "cbxPlacaa";
            this.cbxPlacaa.Size = new System.Drawing.Size(79, 21);
            this.cbxPlacaa.TabIndex = 83;
            // 
            // FmrDadosSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(78)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(570, 320);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.cbxPlaca);
            this.Controls.Add(this.groupBox1);
            this.Name = "FmrDadosSaida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados da saída";
            this.Load += new System.EventHandler(this.FmrDadosSaida_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.cbxPlaca.ResumeLayout(false);
            this.cbxPlaca.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.GroupBox cbxPlaca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOdo;
        private System.Windows.Forms.TextBox txtChassis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCnh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxMotorista;
        private System.Windows.Forms.ComboBox cbxEmpresa;
        private System.Windows.Forms.ComboBox cbxPlacaa;
    }
}