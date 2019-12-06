namespace GerenciadorVeiculo1.View.GerManutencao
{
    partial class FmrManut
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgManutencao = new System.Windows.Forms.DataGridView();
            this.MAN_INT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VEI_STR_PLACA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VEI_STR_MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VEI_STR_MODELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VEI_STR_COMBUSTIVEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VEI_DOUBLE_KM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgManutencao)).BeginInit();
            this.SuspendLayout();
            // 
            // dgManutencao
            // 
            this.dgManutencao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgManutencao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAN_INT_ID,
            this.VEI_STR_PLACA,
            this.VEI_STR_MARCA,
            this.VEI_STR_MODELO,
            this.VEI_STR_COMBUSTIVEL,
            this.Data,
            this.VEI_DOUBLE_KM});
            this.dgManutencao.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgManutencao.Location = new System.Drawing.Point(12, 61);
            this.dgManutencao.Name = "dgManutencao";
            this.dgManutencao.Size = new System.Drawing.Size(566, 241);
            this.dgManutencao.TabIndex = 3;
            this.dgManutencao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgManutencao_CellContentClick);
            // 
            // MAN_INT_ID
            // 
            this.MAN_INT_ID.DataPropertyName = "MAN_INT_ID";
            this.MAN_INT_ID.HeaderText = "ID";
            this.MAN_INT_ID.Name = "MAN_INT_ID";
            this.MAN_INT_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MAN_INT_ID.Width = 43;
            // 
            // VEI_STR_PLACA
            // 
            this.VEI_STR_PLACA.DataPropertyName = "VEI_STR_PLACA";
            this.VEI_STR_PLACA.HeaderText = "Placa";
            this.VEI_STR_PLACA.Name = "VEI_STR_PLACA";
            this.VEI_STR_PLACA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.VEI_STR_PLACA.Width = 70;
            // 
            // VEI_STR_MARCA
            // 
            this.VEI_STR_MARCA.DataPropertyName = "VEI_STR_MARCA";
            this.VEI_STR_MARCA.HeaderText = "Marca";
            this.VEI_STR_MARCA.Name = "VEI_STR_MARCA";
            this.VEI_STR_MARCA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.VEI_STR_MARCA.Width = 90;
            // 
            // VEI_STR_MODELO
            // 
            this.VEI_STR_MODELO.DataPropertyName = "VEI_STR_MODELO";
            this.VEI_STR_MODELO.HeaderText = "Modelo";
            this.VEI_STR_MODELO.Name = "VEI_STR_MODELO";
            this.VEI_STR_MODELO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.VEI_STR_MODELO.Width = 90;
            // 
            // VEI_STR_COMBUSTIVEL
            // 
            this.VEI_STR_COMBUSTIVEL.DataPropertyName = "VEI_STR_COMBUSTIVEL";
            this.VEI_STR_COMBUSTIVEL.HeaderText = "Combustivel";
            this.VEI_STR_COMBUSTIVEL.Name = "VEI_STR_COMBUSTIVEL";
            this.VEI_STR_COMBUSTIVEL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.VEI_STR_COMBUSTIVEL.Width = 90;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Data.DefaultCellStyle = dataGridViewCellStyle1;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Data.Width = 70;
            // 
            // VEI_DOUBLE_KM
            // 
            this.VEI_DOUBLE_KM.DataPropertyName = "VEI_DOUBLE_KM";
            this.VEI_DOUBLE_KM.HeaderText = "Odômetro";
            this.VEI_DOUBLE_KM.Name = "VEI_DOUBLE_KM";
            this.VEI_DOUBLE_KM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.VEI_DOUBLE_KM.Width = 90;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(483, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 31);
            this.button2.TabIndex = 5;
            this.button2.Text = "Atualizar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.White;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Image = global::GerenciadorVeiculo1.Properties.Resources.buscar;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(12, 308);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(95, 31);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "     Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.White;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::GerenciadorVeiculo1.Properties.Resources.adc;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(113, 308);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(95, 31);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "     Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.button1_Click);
            // 
            // FmrManut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(78)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(590, 374);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgManutencao);
            this.Name = "FmrManut";
            this.Text = "Ger. Manutenção";
            this.Load += new System.EventHandler(this.FmrManut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgManutencao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dgManutencao;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAN_INT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VEI_STR_PLACA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VEI_STR_MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VEI_STR_MODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VEI_STR_COMBUSTIVEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn VEI_DOUBLE_KM;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnConsultar;
    }
}