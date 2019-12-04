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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrTelaUsuario));
            this.dgUsuario = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnNovoUsuario = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAtualiza = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgUsuario
            // 
            this.dgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgUsuario.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgUsuario.Location = new System.Drawing.Point(8, 28);
            this.dgUsuario.Name = "dgUsuario";
            this.dgUsuario.Size = new System.Drawing.Size(430, 185);
            this.dgUsuario.TabIndex = 0;
            this.dgUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsuario_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAtualiza);
            this.groupBox1.Controls.Add(this.dgUsuario);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 261);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(34, 217);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(41, 21);
            this.txtId.TabIndex = 3;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.FlatAppearance.BorderSize = 0;
            this.btnNovoUsuario.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnNovoUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNovoUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnNovoUsuario.Location = new System.Drawing.Point(194, 306);
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnNovoUsuario.TabIndex = 2;
            this.btnNovoUsuario.Text = "Novo +";
            this.btnNovoUsuario.UseVisualStyleBackColor = true;
            this.btnNovoUsuario.Click += new System.EventHandler(this.btnNovoUsuario_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(12, 306);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnBuscar.Location = new System.Drawing.Point(103, 306);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Consultar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAtualiza
            // 
            this.btnAtualiza.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualiza.ForeColor = System.Drawing.Color.Black;
            this.btnAtualiza.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualiza.Image")));
            this.btnAtualiza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualiza.Location = new System.Drawing.Point(335, 219);
            this.btnAtualiza.Name = "btnAtualiza";
            this.btnAtualiza.Size = new System.Drawing.Size(103, 32);
            this.btnAtualiza.TabIndex = 7;
            this.btnAtualiza.Text = "     Atualizar";
            this.btnAtualiza.UseVisualStyleBackColor = true;
            this.btnAtualiza.Click += new System.EventHandler(this.btnAtualiza_Click);
            // 
            // fmrTelaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(474, 353);
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
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAtualiza;
    }
}