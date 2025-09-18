namespace _03_Clases
{
    partial class Controles
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.CboAntojitos = new System.Windows.Forms.ComboBox();
            this.lstAntojito = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.lstCopia = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(65, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedido";
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(170, 160);
            this.txtDato.MaxLength = 5;
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(267, 22);
            this.txtDato.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRegistrar.Location = new System.Drawing.Point(241, 378);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(140, 32);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(170, 246);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComentarios.Size = new System.Drawing.Size(267, 103);
            this.txtComentarios.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(65, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Observaciones";
            // 
            // lstDatos
            // 
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.ItemHeight = 16;
            this.lstDatos.Location = new System.Drawing.Point(489, 160);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(130, 148);
            this.lstDatos.TabIndex = 5;
            // 
            // CboAntojitos
            // 
            this.CboAntojitos.FormattingEnabled = true;
            this.CboAntojitos.Items.AddRange(new object[] {
            "Tostadas",
            "Tacos",
            "Aguas",
            "Pambazos",
            "Quesadillas"});
            this.CboAntojitos.Location = new System.Drawing.Point(170, 201);
            this.CboAntojitos.Name = "CboAntojitos";
            this.CboAntojitos.Size = new System.Drawing.Size(267, 24);
            this.CboAntojitos.TabIndex = 6;
            this.CboAntojitos.SelectedIndexChanged += new System.EventHandler(this.Controles_Load);
            // 
            // lstAntojito
            // 
            this.lstAntojito.FormattingEnabled = true;
            this.lstAntojito.ItemHeight = 16;
            this.lstAntojito.Location = new System.Drawing.Point(671, 163);
            this.lstAntojito.Name = "lstAntojito";
            this.lstAntojito.Size = new System.Drawing.Size(130, 148);
            this.lstAntojito.TabIndex = 7;
            this.lstAntojito.SelectedIndexChanged += new System.EventHandler(this.lstAntojito_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(519, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pedidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(699, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Productos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(65, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(353, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Aplicación de pedidos";
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnVisualizar.Location = new System.Drawing.Point(584, 378);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(140, 32);
            this.btnVisualizar.TabIndex = 12;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // lstCopia
            // 
            this.lstCopia.FormattingEnabled = true;
            this.lstCopia.ItemHeight = 16;
            this.lstCopia.Location = new System.Drawing.Point(425, 354);
            this.lstCopia.Name = "lstCopia";
            this.lstCopia.Size = new System.Drawing.Size(130, 148);
            this.lstCopia.TabIndex = 13;
            // 
            // Controles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 514);
            this.Controls.Add(this.lstCopia);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstAntojito);
            this.Controls.Add(this.CboAntojitos);
            this.Controls.Add(this.lstDatos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtComentarios);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.label1);
            this.Name = "Controles";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Controles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstDatos;
        private System.Windows.Forms.ComboBox CboAntojitos;
        private System.Windows.Forms.ListBox lstAntojito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.ListBox lstCopia;
    }
}

