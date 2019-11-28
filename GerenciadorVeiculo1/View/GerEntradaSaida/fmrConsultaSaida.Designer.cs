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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNovoUsuario = new System.Windows.Forms.Button();
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
            this.lblID = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaida)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 280);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Consultar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.Location = new System.Drawing.Point(99, 280);
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnNovoUsuario.TabIndex = 15;
            this.btnNovoUsuario.Text = "Entrada";
            this.btnNovoUsuario.UseVisualStyleBackColor = true;
            this.btnNovoUsuario.Click += new System.EventHandler(this.btnNovoUsuario_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxConsulta);
            this.groupBox1.Controls.Add(this.btnAtualizar);
            this.groupBox1.Controls.Add(this.dgSaida);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 254);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Saídas";
            // 
            // cbxConsulta
            // 
            this.cbxConsulta.DisplayMember = "Todas";
            this.cbxConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxConsulta.FormattingEnabled = true;
            this.cbxConsulta.Items.AddRange(new object[] {
            "Todas",
            "Dia"});
            this.cbxConsulta.Location = new System.Drawing.Point(319, 217);
            this.cbxConsulta.Name = "cbxConsulta";
            this.cbxConsulta.Size = new System.Drawing.Size(103, 21);
            this.cbxConsulta.TabIndex = 5;
            this.cbxConsulta.ValueMember = "Todas";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(437, 215);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
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
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 220);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(34, 217);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(41, 20);
            this.txtId.TabIndex = 3;
            // 
            // FmrConsultaSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 307);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNovoUsuario);
            this.Controls.Add(this.groupBox1);
            this.Name = "FmrConsultaSaida";
            this.Text = "fmrConsultaSaida";
            this.Load += new System.EventHandler(this.FmrConsultaSaida_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnNovoUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DataGridView dgSaida;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cbxConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn SAI_INT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VEI_STR_PLACA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VEI_STR_MODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOT_STR_NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMP_STR_NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SAI_DATE_DATA;
    }
}