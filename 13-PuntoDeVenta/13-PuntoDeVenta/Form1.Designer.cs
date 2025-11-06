namespace _13_PuntoDeVenta
{
    partial class Form1
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
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnNueva = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.QuantityInfantil = new System.Windows.Forms.TextBox();
            this.QuantityDuo = new System.Windows.Forms.TextBox();
            this.QuantityFamiliar = new System.Windows.Forms.TextBox();
            this.QuantityTrio = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TxtPagar = new System.Windows.Forms.TextBox();
            this.TxtIva = new System.Windows.Forms.TextBox();
            this.TxtSubtotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CboInfantil = new System.Windows.Forms.CheckBox();
            this.CboDuo = new System.Windows.Forms.CheckBox();
            this.CboFamiliar = new System.Windows.Forms.CheckBox();
            this.CboTrio = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.BtnSalir);
            this.groupBox1.Controls.Add(this.BtnNueva);
            this.groupBox1.Controls.Add(this.BtnAceptar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 460);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar los combos";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(25, 263);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(107, 47);
            this.BtnAceptar.TabIndex = 1;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnNueva
            // 
            this.BtnNueva.Location = new System.Drawing.Point(25, 322);
            this.BtnNueva.Name = "BtnNueva";
            this.BtnNueva.Size = new System.Drawing.Size(107, 60);
            this.BtnNueva.TabIndex = 2;
            this.BtnNueva.Text = "Nueva Compra";
            this.BtnNueva.UseVisualStyleBackColor = true;
            this.BtnNueva.Click += new System.EventHandler(this.BtnNueva_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(316, 401);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(104, 32);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CboTrio);
            this.groupBox2.Controls.Add(this.QuantityTrio);
            this.groupBox2.Controls.Add(this.CboFamiliar);
            this.groupBox2.Controls.Add(this.QuantityFamiliar);
            this.groupBox2.Controls.Add(this.CboDuo);
            this.groupBox2.Controls.Add(this.QuantityDuo);
            this.groupBox2.Controls.Add(this.CboInfantil);
            this.groupBox2.Controls.Add(this.QuantityInfantil);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(25, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 209);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cantidad";
            // 
            // QuantityInfantil
            // 
            this.QuantityInfantil.Enabled = false;
            this.QuantityInfantil.Location = new System.Drawing.Point(22, 44);
            this.QuantityInfantil.Name = "QuantityInfantil";
            this.QuantityInfantil.Size = new System.Drawing.Size(33, 30);
            this.QuantityInfantil.TabIndex = 1;
            // 
            // QuantityDuo
            // 
            this.QuantityDuo.Enabled = false;
            this.QuantityDuo.Location = new System.Drawing.Point(22, 84);
            this.QuantityDuo.Name = "QuantityDuo";
            this.QuantityDuo.Size = new System.Drawing.Size(33, 30);
            this.QuantityDuo.TabIndex = 2;
            // 
            // QuantityFamiliar
            // 
            this.QuantityFamiliar.Enabled = false;
            this.QuantityFamiliar.Location = new System.Drawing.Point(22, 124);
            this.QuantityFamiliar.Name = "QuantityFamiliar";
            this.QuantityFamiliar.Size = new System.Drawing.Size(33, 30);
            this.QuantityFamiliar.TabIndex = 3;
            // 
            // QuantityTrio
            // 
            this.QuantityTrio.Enabled = false;
            this.QuantityTrio.Location = new System.Drawing.Point(22, 164);
            this.QuantityTrio.Name = "QuantityTrio";
            this.QuantityTrio.Size = new System.Drawing.Size(33, 30);
            this.QuantityTrio.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(297, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(123, 209);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "$85";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "$90";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "$105";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "$95.50";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.TxtPagar);
            this.groupBox4.Controls.Add(this.TxtIva);
            this.groupBox4.Controls.Add(this.TxtSubtotal);
            this.groupBox4.Location = new System.Drawing.Point(157, 251);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 144);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // TxtPagar
            // 
            this.TxtPagar.Enabled = false;
            this.TxtPagar.Location = new System.Drawing.Point(153, 101);
            this.TxtPagar.Name = "TxtPagar";
            this.TxtPagar.Size = new System.Drawing.Size(81, 30);
            this.TxtPagar.TabIndex = 5;
            // 
            // TxtIva
            // 
            this.TxtIva.Enabled = false;
            this.TxtIva.Location = new System.Drawing.Point(153, 65);
            this.TxtIva.Name = "TxtIva";
            this.TxtIva.Size = new System.Drawing.Size(81, 30);
            this.TxtIva.TabIndex = 6;
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.Enabled = false;
            this.TxtSubtotal.Location = new System.Drawing.Point(153, 29);
            this.TxtSubtotal.Name = "TxtSubtotal";
            this.TxtSubtotal.Size = new System.Drawing.Size(81, 30);
            this.TxtSubtotal.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Subtotal: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "IVA: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total a pagar: ";
            // 
            // CboInfantil
            // 
            this.CboInfantil.AutoSize = true;
            this.CboInfantil.Location = new System.Drawing.Point(62, 44);
            this.CboInfantil.Name = "CboInfantil";
            this.CboInfantil.Size = new System.Drawing.Size(168, 29);
            this.CboInfantil.TabIndex = 6;
            this.CboInfantil.Text = "Paquete Infantil";
            this.CboInfantil.UseVisualStyleBackColor = true;
            this.CboInfantil.CheckedChanged += new System.EventHandler(this.CboInfantil_CheckedChanged);
            // 
            // CboDuo
            // 
            this.CboDuo.AutoSize = true;
            this.CboDuo.Location = new System.Drawing.Point(62, 90);
            this.CboDuo.Name = "CboDuo";
            this.CboDuo.Size = new System.Drawing.Size(148, 29);
            this.CboDuo.TabIndex = 7;
            this.CboDuo.Text = "Paquete Duo";
            this.CboDuo.UseVisualStyleBackColor = true;
            this.CboDuo.CheckedChanged += new System.EventHandler(this.CboDuo_CheckedChanged);
            // 
            // CboFamiliar
            // 
            this.CboFamiliar.AutoSize = true;
            this.CboFamiliar.Location = new System.Drawing.Point(62, 132);
            this.CboFamiliar.Name = "CboFamiliar";
            this.CboFamiliar.Size = new System.Drawing.Size(180, 29);
            this.CboFamiliar.TabIndex = 8;
            this.CboFamiliar.Text = "Paquete Familiar";
            this.CboFamiliar.UseVisualStyleBackColor = true;
            this.CboFamiliar.CheckedChanged += new System.EventHandler(this.CboFamiliar_CheckedChanged);
            // 
            // CboTrio
            // 
            this.CboTrio.AutoSize = true;
            this.CboTrio.Location = new System.Drawing.Point(62, 171);
            this.CboTrio.Name = "CboTrio";
            this.CboTrio.Size = new System.Drawing.Size(166, 29);
            this.CboTrio.TabIndex = 9;
            this.CboTrio.Text = "Paquete el Trio";
            this.CboTrio.UseVisualStyleBackColor = true;
            this.CboTrio.CheckedChanged += new System.EventHandler(this.CboTrio_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 487);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnNueva;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox QuantityTrio;
        private System.Windows.Forms.TextBox QuantityFamiliar;
        private System.Windows.Forms.TextBox QuantityDuo;
        private System.Windows.Forms.TextBox QuantityInfantil;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPagar;
        private System.Windows.Forms.TextBox TxtIva;
        private System.Windows.Forms.TextBox TxtSubtotal;
        private System.Windows.Forms.CheckBox CboDuo;
        private System.Windows.Forms.CheckBox CboInfantil;
        private System.Windows.Forms.CheckBox CboTrio;
        private System.Windows.Forms.CheckBox CboFamiliar;
    }
}

