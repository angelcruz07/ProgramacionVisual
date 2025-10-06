namespace _04_JuegoDeDatos
{
    partial class Repeticiones
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
            label1 = new Label();
            btnRepetir = new Button();
            txtTabla = new TextBox();
            cboEstructura = new ComboBox();
            lstTablas = new ListBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 174);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 0;
            label1.Text = "# Tabla";
            // 
            // btnRepetir
            // 
            btnRepetir.Location = new Point(195, 239);
            btnRepetir.Name = "btnRepetir";
            btnRepetir.Size = new Size(94, 29);
            btnRepetir.TabIndex = 2;
            btnRepetir.Text = "Repetir";
            btnRepetir.UseVisualStyleBackColor = true;
            btnRepetir.Click += btnRepetir_Click;
            // 
            // txtTabla
            // 
            txtTabla.Location = new Point(195, 197);
            txtTabla.Name = "txtTabla";
            txtTabla.Size = new Size(199, 27);
            txtTabla.TabIndex = 3;
            // 
            // cboEstructura
            // 
            cboEstructura.FormattingEnabled = true;
            cboEstructura.Items.AddRange(new object[] { "while", "do while", "for" });
            cboEstructura.Location = new Point(195, 136);
            cboEstructura.Name = "cboEstructura";
            cboEstructura.Size = new Size(199, 28);
            cboEstructura.TabIndex = 4;
            cboEstructura.Text = "Seleccione una estructura";
            // 
            // lstTablas
            // 
            lstTablas.FormattingEnabled = true;
            lstTablas.Location = new Point(439, 136);
            lstTablas.Name = "lstTablas";
            lstTablas.Size = new Size(150, 204);
            lstTablas.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 103);
            label2.Name = "label2";
            label2.Size = new Size(158, 20);
            label2.TabIndex = 6;
            label2.Text = "Selecione la estructura";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(312, 56);
            label3.Name = "label3";
            label3.Size = new Size(166, 20);
            label3.TabIndex = 7;
            label3.Text = "Estructura de repetición";
            // 
            // Repeticiones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lstTablas);
            Controls.Add(cboEstructura);
            Controls.Add(txtTabla);
            Controls.Add(btnRepetir);
            Controls.Add(label1);
            Name = "Repeticiones";
            Text = "Repeticiones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRepetir;
        private TextBox txtTabla;
        private ComboBox cboEstructura;
        private ListBox lstTablas;
        private Label label2;
        private Label label3;
    }
}