namespace GerenciadorVeiculo1.View
{
    partial class fmrTelaUsuario
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
            this.dgUsuario = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnNovoUsuario = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgUsuario
            // 
            this.dgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuario.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgUsuario.Location = new System.Drawing.Point(6, 19);
            this.dgUsuario.Name = "dgUsuario";
            this.dgUsuario.Size = new System.Drawing.Size(430, 185);
            this.dgUsuario.TabIndex = 0;
            this.dgUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsuario_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAtualizar);
            this.groupBox1.Controls.Add(this.dgUsuario);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 254);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de usuário";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(361, 210);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 220);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "ID:";
            this.lblID.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(34, 217);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(41, 20);
            this.txtId.TabIndex = 3;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.Location = new System.Drawing.Point(194, 275);
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnNovoUsuario.TabIndex = 2;
            this.btnNovoUsuario.Text = "Novo +";
            this.btnNovoUsuario.UseVisualStyleBackColor = true;
            this.btnNovoUsuario.Click += new System.EventHandler(this.btnNovoUsuario_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 275);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(103, 275);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Consultar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // fmrTelaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 307);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNovoUsuario);
            this.Controls.Add(this.groupBox1);
            this.Name = "fmrTelaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de usuário";
            this.Load += new System.EventHandler(this.fmrTelaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNovoUsuario;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnBuscar;
    }
}