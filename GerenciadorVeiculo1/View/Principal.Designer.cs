namespace GerenciadorVeiculo1.View
{
    partial class Principal
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
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconRestaurar = new System.Windows.Forms.Panel();
            this.iconMaximiza = new System.Windows.Forms.PictureBox();
            this.iconRestaura = new System.Windows.Forms.PictureBox();
            this.iconMinimizar = new System.Windows.Forms.PictureBox();
            this.iconEncerrar = new System.Windows.Forms.PictureBox();
            this.btnSlider = new System.Windows.Forms.PictureBox();
            this.bntUsuarios = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MenuVertical.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximiza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestaura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MenuVertical.Controls.Add(this.button3);
            this.MenuVertical.Controls.Add(this.button2);
            this.MenuVertical.Controls.Add(this.button1);
            this.MenuVertical.Controls.Add(this.bntUsuarios);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 484);
            this.MenuVertical.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconMaximiza);
            this.panel1.Controls.Add(this.iconRestaura);
            this.panel1.Controls.Add(this.iconMinimizar);
            this.panel1.Controls.Add(this.iconEncerrar);
            this.panel1.Controls.Add(this.btnSlider);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(250, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 50);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // iconRestaurar
            // 
            this.iconRestaurar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconRestaurar.Location = new System.Drawing.Point(250, 50);
            this.iconRestaurar.Name = "iconRestaurar";
            this.iconRestaurar.Size = new System.Drawing.Size(482, 434);
            this.iconRestaurar.TabIndex = 2;
            this.iconRestaurar.Paint += new System.Windows.Forms.PaintEventHandler(this.iconRestaurar_Paint);
            // 
            // iconMaximiza
            // 
            this.iconMaximiza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMaximiza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMaximiza.Location = new System.Drawing.Point(431, 3);
            this.iconMaximiza.Name = "iconMaximiza";
            this.iconMaximiza.Size = new System.Drawing.Size(21, 18);
            this.iconMaximiza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMaximiza.TabIndex = 5;
            this.iconMaximiza.TabStop = false;
            this.iconMaximiza.Click += new System.EventHandler(this.iconMaximiza_Click);
            // 
            // iconRestaura
            // 
            this.iconRestaura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconRestaura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconRestaura.Location = new System.Drawing.Point(431, 3);
            this.iconRestaura.Name = "iconRestaura";
            this.iconRestaura.Size = new System.Drawing.Size(21, 18);
            this.iconRestaura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconRestaura.TabIndex = 4;
            this.iconRestaura.TabStop = false;
            this.iconRestaura.Visible = false;
            this.iconRestaura.Click += new System.EventHandler(this.iconRestaura_Click);
            // 
            // iconMinimizar
            // 
            this.iconMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMinimizar.Location = new System.Drawing.Point(404, 3);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(21, 18);
            this.iconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMinimizar.TabIndex = 3;
            this.iconMinimizar.TabStop = false;
            this.iconMinimizar.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // iconEncerrar
            // 
            this.iconEncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconEncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconEncerrar.Location = new System.Drawing.Point(458, 3);
            this.iconEncerrar.Name = "iconEncerrar";
            this.iconEncerrar.Size = new System.Drawing.Size(21, 18);
            this.iconEncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconEncerrar.TabIndex = 1;
            this.iconEncerrar.TabStop = false;
            this.iconEncerrar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSlider
            // 
            this.btnSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlider.Location = new System.Drawing.Point(6, 8);
            this.btnSlider.Name = "btnSlider";
            this.btnSlider.Size = new System.Drawing.Size(35, 35);
            this.btnSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSlider.TabIndex = 0;
            this.btnSlider.TabStop = false;
            this.btnSlider.Click += new System.EventHandler(this.btnSlider_Click);
            // 
            // bntUsuarios
            // 
            this.bntUsuarios.FlatAppearance.BorderSize = 0;
            this.bntUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bntUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntUsuarios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntUsuarios.ForeColor = System.Drawing.Color.White;
            this.bntUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntUsuarios.Location = new System.Drawing.Point(5, 69);
            this.bntUsuarios.Name = "bntUsuarios";
            this.bntUsuarios.Size = new System.Drawing.Size(245, 40);
            this.bntUsuarios.TabIndex = 0;
            this.bntUsuarios.Text = "      Gerenciar usuários";
            this.bntUsuarios.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 213);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(247, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "      Gerenciar motorista";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "      Gerenciar empresa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(2, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "      Gerenciar veículo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(732, 484);
            this.Controls.Add(this.iconRestaurar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuVertical);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Text = "Fmrprincipal";
            this.Load += new System.EventHandler(this.FmrPrincipal_Load);
            this.MenuVertical.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximiza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestaura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel iconRestaurar;
        private System.Windows.Forms.PictureBox btnSlider;
        private System.Windows.Forms.PictureBox iconEncerrar;
        private System.Windows.Forms.PictureBox iconMinimizar;
        private System.Windows.Forms.PictureBox iconRestaura;
        private System.Windows.Forms.PictureBox iconMaximiza;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bntUsuarios;
    }
}