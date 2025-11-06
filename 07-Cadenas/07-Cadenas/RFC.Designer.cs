namespace Cadenas
{
    partial class RFC
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtRfc = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCurp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del alumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "CURP";
            // 
            // txtRfc
            // 
            this.txtRfc.AutoSize = true;
            this.txtRfc.Location = new System.Drawing.Point(129, 182);
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.Size = new System.Drawing.Size(37, 16);
            this.txtRfc.TabIndex = 2;
            this.txtRfc.Text = "RFC:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(188, 87);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(143, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // txtCurp
            // 
            this.txtCurp.Location = new System.Drawing.Point(188, 115);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(143, 22);
            this.txtCurp.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Procesar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RFC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 327);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCurp);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtRfc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RFC";
            this.Text = "RFC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtRfc;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCurp;
        private System.Windows.Forms.Button button1;
    }
}