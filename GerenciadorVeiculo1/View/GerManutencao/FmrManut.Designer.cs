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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.dgManutencao = new System.Windows.Forms.DataGridView();
            this.MAN_INT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VEI_STR_PLACA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VEI_STR_MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VEI_STR_MODELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VEI_STR_COMBUSTIVEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VEI_DOUBLE_KM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgManutencao)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Novo+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dgManutencao.Location = new System.Drawing.Point(12, 95);
            this.dgManutencao.Name = "dgManutencao";
            this.dgManutencao.Size = new System.Drawing.Size(566, 241);
            this.dgManutencao.TabIndex = 3;
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Data.DefaultCellStyle = dataGridViewCellStyle8;
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
            // FmrManut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 357);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgManutencao);
            this.Name = "FmrManut";
            this.Text = "FmrManut";
            this.Load += new System.EventHandler(this.FmrManut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgManutencao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgManutencao;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAN_INT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VEI_STR_PLACA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VEI_STR_MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VEI_STR_MODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VEI_STR_COMBUSTIVEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn VEI_DOUBLE_KM;
    }
}