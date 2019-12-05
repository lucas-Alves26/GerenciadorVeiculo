namespace GerenciadorVeiculo1.View.GerEntradaSaida
{
    partial class FmrConsultaSaida
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxConsulta = new System.Windows.Forms.ComboBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.dgSaida = new System.Windows.Forms.DataGridView();
            this.SAI_INT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VEI_STR_PLACA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VEI_STR_MODELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOT_STR_NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMP_STR_NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SAI_DATE_DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaida = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaida)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxConsulta);
            this.groupBox1.Controls.Add(this.btnAtualizar);
            this.groupBox1.Controls.Add(this.dgSaida);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 254);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // cbxConsulta
            // 
            this.cbxConsulta.DisplayMember = "Todas";
            this.cbxConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxConsulta.FormattingEnabled = true;
            this.cbxConsulta.Items.AddRange(new object[] {
            "Todas",
            "Dia"});
            this.cbxConsulta.Location = new System.Drawing.Point(298, 217);
            this.cbxConsulta.Name = "cbxConsulta";
            this.cbxConsulta.Size = new System.Drawing.Size(103, 24);
            this.cbxConsulta.TabIndex = 5;
            this.cbxConsulta.ValueMember = "Todas";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.White;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.Black;
            this.btnAtualizar.Location = new System.Drawing.Point(417, 212);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(95, 31);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // dgSaida
            // 
            this.dgSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSaida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SAI_INT_ID,
            this.VEI_STR_PLACA,
            this.VEI_STR_MODELO,
            this.MOT_STR_NOME,
            this.EMP_STR_NOME,
            this.SAI_DATE_DATA});
            this.dgSaida.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgSaida.Location = new System.Drawing.Point(6, 19);
            this.dgSaida.Name = "dgSaida";
            this.dgSaida.Size = new System.Drawing.Size(506, 185);
            this.dgSaida.TabIndex = 0;
            this.dgSaida.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSaida_CellContentClick);
            // 
            // SAI_INT_ID
            // 
            this.SAI_INT_ID.DataPropertyName = "ID";
            this.SAI_INT_ID.HeaderText = "Id";
            this.SAI_INT_ID.Name = "SAI_INT_ID";
            this.SAI_INT_ID.Width = 28;
            // 
            // VEI_STR_PLACA
            // 
            this.VEI_STR_PLACA.DataPropertyName = "Placa";
            this.VEI_STR_PLACA.HeaderText = "Placa";
            this.VEI_STR_PLACA.Name = "VEI_STR_PLACA";
            this.VEI_STR_PLACA.Width = 60;
            // 
            // VEI_STR_MODELO
            // 
            this.VEI_STR_MODELO.DataPropertyName = "Modelo";
            this.VEI_STR_MODELO.HeaderText = "Modelo";
            this.VEI_STR_MODELO.Name = "VEI_STR_MODELO";
            this.VEI_STR_MODELO.Width = 90;
            // 
            // MOT_STR_NOME
            // 
            this.MOT_STR_NOME.DataPropertyName = "Motorista";
            this.MOT_STR_NOME.HeaderText = "Motorista";
            this.MOT_STR_NOME.Name = "MOT_STR_NOME";
            this.MOT_STR_NOME.Width = 145;
            // 
            // EMP_STR_NOME
            // 
            this.EMP_STR_NOME.DataPropertyName = "Empresa";
            this.EMP_STR_NOME.HeaderText = "Empresa";
            this.EMP_STR_NOME.Name = "EMP_STR_NOME";
            this.EMP_STR_NOME.Width = 70;
            // 
            // SAI_DATE_DATA
            // 
            this.SAI_DATE_DATA.DataPropertyName = "DATA";
            this.SAI_DATE_DATA.HeaderText = "Data";
            this.SAI_DATE_DATA.Name = "SAI_DATE_DATA";
            this.SAI_DATE_DATA.Width = 70;
            // 
            // btnSaida
            // 
            this.btnSaida.BackColor = System.Drawing.Color.White;
            this.btnSaida.FlatAppearance.BorderSize = 0;
            this.btnSaida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaida.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaida.Image = global::GerenciadorVeiculo1.Properties.Resources.setaverd;
            this.btnSaida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaida.Location = new System.Drawing.Point(214, 272);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(95, 31);
            this.btnSaida.TabIndex = 18;
            this.btnSaida.Text = "     Saida";
            this.btnSaida.UseVisualStyleBackColor = false;
            this.btnSaida.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::GerenciadorVeiculo1.Properties.Resources.buscar;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(12, 272);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 31);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "     Consultar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEntrada
            // 
            this.btnEntrada.BackColor = System.Drawing.Color.White;
            this.btnEntrada.FlatAppearance.BorderSize = 0;
            this.btnEntrada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEntrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrada.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.Image = global::GerenciadorVeiculo1.Properties.Resources.setaver;
            this.btnEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrada.Location = new System.Drawing.Point(113, 272);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(95, 31);
            this.btnEntrada.TabIndex = 15;
            this.btnEntrada.Text = "     Entrada";
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.Click += new System.EventHandler(this.btnNovoUsuario_Click);
            // 
            // FmrConsultaSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(78)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(542, 318);
            this.Controls.Add(this.btnSaida);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.groupBox1);
            this.Name = "FmrConsultaSaida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Saída";
            this.Load += new System.EventHandler(this.FmrConsultaSaida_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSaida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DataGridView dgSaida;
        private System.Windows.Forms.ComboBox cbxConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn SAI_INT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VEI_STR_PLACA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VEI_STR_MODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOT_STR_NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMP_STR_NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SAI_DATE_DATA;
        private System.Windows.Forms.Button btnSaida;
    }
}