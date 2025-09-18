namespace _02_VelocidadDeTransferenciaDeArchivos
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
            this.txtFileSize = new System.Windows.Forms.Label();
            this.fileSize = new System.Windows.Forms.TextBox();
            this.txtVelocidad = new System.Windows.Forms.Label();
            this.velocidad = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVelocidadCalculada = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtFileSize
            // 
            this.txtFileSize.AutoSize = true;
            this.txtFileSize.Location = new System.Drawing.Point(190, 117);
            this.txtFileSize.Name = "txtFileSize";
            this.txtFileSize.Size = new System.Drawing.Size(130, 16);
            this.txtFileSize.TabIndex = 0;
            this.txtFileSize.Text = "Tamaño del archivo:";
            // 
            // fileSize
            // 
            this.fileSize.Location = new System.Drawing.Point(406, 117);
            this.fileSize.Name = "fileSize";
            this.fileSize.Size = new System.Drawing.Size(191, 22);
            this.fileSize.TabIndex = 1;
            // 
            // txtVelocidad
            // 
            this.txtVelocidad.AutoSize = true;
            this.txtVelocidad.Location = new System.Drawing.Point(190, 188);
            this.txtVelocidad.Name = "txtVelocidad";
            this.txtVelocidad.Size = new System.Drawing.Size(210, 16);
            this.txtVelocidad.TabIndex = 2;
            this.txtVelocidad.Text = "Velocidad de transmisión (Mbps): ";
            // 
            // velocidad
            // 
            this.velocidad.Location = new System.Drawing.Point(406, 185);
            this.velocidad.Name = "velocidad";
            this.velocidad.Size = new System.Drawing.Size(191, 22);
            this.velocidad.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(326, 269);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(164, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "El tiempo estimado de transferencia es: ";
            // 
            // txtVelocidadCalculada
            // 
            this.txtVelocidadCalculada.Enabled = false;
            this.txtVelocidadCalculada.Location = new System.Drawing.Point(449, 341);
            this.txtVelocidadCalculada.Name = "txtVelocidadCalculada";
            this.txtVelocidadCalculada.Size = new System.Drawing.Size(100, 22);
            this.txtVelocidadCalculada.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtVelocidadCalculada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.velocidad);
            this.Controls.Add(this.txtVelocidad);
            this.Controls.Add(this.fileSize);
            this.Controls.Add(this.txtFileSize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtFileSize;
        private System.Windows.Forms.TextBox fileSize;
        private System.Windows.Forms.Label txtVelocidad;
        private System.Windows.Forms.TextBox velocidad;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVelocidadCalculada;
    }
}

