namespace _10_Calificaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidadAlumnos = new System.Windows.Forms.TextBox();
            this.TablaAlumnos = new System.Windows.Forms.DataGridView();
            this.btnTabla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.listPromedio = new System.Windows.Forms.ListBox();
            this.lblGeneral = new System.Windows.Forms.Label();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrimerParcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSegundoParcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTercerParcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TablaAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control de calificaciones - Ingeniería en Sistemas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de alumnos:";
            // 
            // txtCantidadAlumnos
            // 
            this.txtCantidadAlumnos.Location = new System.Drawing.Point(279, 123);
            this.txtCantidadAlumnos.Name = "txtCantidadAlumnos";
            this.txtCantidadAlumnos.Size = new System.Drawing.Size(140, 26);
            this.txtCantidadAlumnos.TabIndex = 2;
            // 
            // TablaAlumnos
            // 
            this.TablaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.ColPrimerParcial,
            this.ColSegundoParcial,
            this.ColTercerParcial});
            this.TablaAlumnos.Location = new System.Drawing.Point(118, 185);
            this.TablaAlumnos.Name = "TablaAlumnos";
            this.TablaAlumnos.RowHeadersWidth = 62;
            this.TablaAlumnos.RowTemplate.Height = 28;
            this.TablaAlumnos.Size = new System.Drawing.Size(807, 321);
            this.TablaAlumnos.TabIndex = 3;
            // 
            // btnTabla
            // 
            this.btnTabla.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTabla.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTabla.Location = new System.Drawing.Point(753, 108);
            this.btnTabla.Name = "btnTabla";
            this.btnTabla.Size = new System.Drawing.Size(172, 41);
            this.btnTabla.TabIndex = 4;
            this.btnTabla.Text = "Crear Tabla";
            this.btnTabla.UseVisualStyleBackColor = false;
            this.btnTabla.Click += new System.EventHandler(this.btnTabla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Promedio Individual: ";
            // 
            // btnPromedio
            // 
            this.btnPromedio.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPromedio.ForeColor = System.Drawing.Color.White;
            this.btnPromedio.Location = new System.Drawing.Point(757, 512);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(172, 41);
            this.btnPromedio.TabIndex = 7;
            this.btnPromedio.Text = "Calcular Promedio";
            this.btnPromedio.UseVisualStyleBackColor = false;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // listPromedio
            // 
            this.listPromedio.FormattingEnabled = true;
            this.listPromedio.ItemHeight = 20;
            this.listPromedio.Location = new System.Drawing.Point(118, 567);
            this.listPromedio.Name = "listPromedio";
            this.listPromedio.Size = new System.Drawing.Size(297, 204);
            this.listPromedio.TabIndex = 8;
            // 
            // lblGeneral
            // 
            this.lblGeneral.AutoSize = true;
            this.lblGeneral.Location = new System.Drawing.Point(540, 645);
            this.lblGeneral.Name = "lblGeneral";
            this.lblGeneral.Size = new System.Drawing.Size(211, 20);
            this.lblGeneral.TabIndex = 9;
            this.lblGeneral.Text = "Promedio general del grupo: ";
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Nombre";
            this.ColName.MinimumWidth = 8;
            this.ColName.Name = "ColName";
            this.ColName.Width = 120;
            // 
            // ColPrimerParcial
            // 
            this.ColPrimerParcial.HeaderText = "Primer Parcial";
            this.ColPrimerParcial.MinimumWidth = 8;
            this.ColPrimerParcial.Name = "ColPrimerParcial";
            this.ColPrimerParcial.Width = 150;
            // 
            // ColSegundoParcial
            // 
            this.ColSegundoParcial.HeaderText = "Segundo Parcial";
            this.ColSegundoParcial.MinimumWidth = 8;
            this.ColSegundoParcial.Name = "ColSegundoParcial";
            this.ColSegundoParcial.Width = 150;
            // 
            // ColTercerParcial
            // 
            this.ColTercerParcial.HeaderText = "Tercer Parcial";
            this.ColTercerParcial.MinimumWidth = 8;
            this.ColTercerParcial.Name = "ColTercerParcial";
            this.ColTercerParcial.Width = 180;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 999);
            this.Controls.Add(this.lblGeneral);
            this.Controls.Add(this.listPromedio);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTabla);
            this.Controls.Add(this.TablaAlumnos);
            this.Controls.Add(this.txtCantidadAlumnos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TablaAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidadAlumnos;
        private System.Windows.Forms.DataGridView TablaAlumnos;
        private System.Windows.Forms.Button btnTabla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.ListBox listPromedio;
        private System.Windows.Forms.Label lblGeneral;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrimerParcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSegundoParcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTercerParcial;
    }
}

