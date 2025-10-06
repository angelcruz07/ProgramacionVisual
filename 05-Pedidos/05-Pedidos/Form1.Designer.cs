namespace _05_Pedidos
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
            this.nombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.CboProducto = new System.Windows.Forms.ComboBox();
            this.CboCliente = new System.Windows.Forms.ComboBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtSubtotal = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.Tabla = new System.Windows.Forms.DataGridView();
            this.ColProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TxtIva = new System.Windows.Forms.TextBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.TxtPedido = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UbuntuMono Nerd Font", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dirección";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("UbuntuMono Nerd Font", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(50, 31);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(105, 13);
            this.nombre.TabIndex = 1;
            this.nombre.Text = "Nombre cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UbuntuMono Nerd Font", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UbuntuMono Nerd Font", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(276, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("UbuntuMono Nerd Font", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(618, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pedido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("UbuntuMono Nerd Font", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(429, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("UbuntuMono Nerd Font", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(618, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("UbuntuMono Nerd Font", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(776, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Iva";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("UbuntuMono Nerd Font", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(750, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "SubTotal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("UbuntuMono Nerd Font", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(766, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Total";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(670, 159);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 33);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(935, 227);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 11;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(935, 276);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtnNuevo.TabIndex = 12;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // CboProducto
            // 
            this.CboProducto.FormattingEnabled = true;
            this.CboProducto.Items.AddRange(new object[] {
            "Cars",
            "Toy Story",
            "Terminator"});
            this.CboProducto.Location = new System.Drawing.Point(176, 122);
            this.CboProducto.Name = "CboProducto";
            this.CboProducto.Size = new System.Drawing.Size(121, 24);
            this.CboProducto.TabIndex = 13;
            // 
            // CboCliente
            // 
            this.CboCliente.FormattingEnabled = true;
            this.CboCliente.Items.AddRange(new object[] {
            "Angel Cruz",
            "Jose Manuel",
            "Angel Axel",
            "Juan"});
            this.CboCliente.Location = new System.Drawing.Point(176, 26);
            this.CboCliente.Name = "CboCliente";
            this.CboCliente.Size = new System.Drawing.Size(121, 24);
            this.CboCliente.TabIndex = 14;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(140, 80);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(157, 22);
            this.TxtDireccion.TabIndex = 15;
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.Enabled = false;
            this.TxtSubtotal.Location = new System.Drawing.Point(823, 228);
            this.TxtSubtotal.Name = "TxtSubtotal";
            this.TxtSubtotal.Size = new System.Drawing.Size(100, 22);
            this.TxtSubtotal.TabIndex = 16;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(484, 172);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(80, 22);
            this.TxtPrecio.TabIndex = 17;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(346, 170);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(52, 22);
            this.TxtCantidad.TabIndex = 18;
            // 
            // Tabla
            // 
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProducto,
            this.ColCantidad,
            this.ColPrecio,
            this.ColSubtotal});
            this.Tabla.Location = new System.Drawing.Point(53, 227);
            this.Tabla.Name = "Tabla";
            this.Tabla.RowHeadersWidth = 51;
            this.Tabla.RowTemplate.Height = 24;
            this.Tabla.Size = new System.Drawing.Size(571, 211);
            this.Tabla.TabIndex = 19;
            // 
            // ColProducto
            // 
            this.ColProducto.HeaderText = "Producto";
            this.ColProducto.MinimumWidth = 6;
            this.ColProducto.Name = "ColProducto";
            this.ColProducto.Width = 125;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.MinimumWidth = 6;
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.Width = 125;
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.MinimumWidth = 6;
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.Width = 125;
            // 
            // ColSubtotal
            // 
            this.ColSubtotal.HeaderText = "Subtotal";
            this.ColSubtotal.MinimumWidth = 6;
            this.ColSubtotal.Name = "ColSubtotal";
            this.ColSubtotal.Width = 125;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(670, 84);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // TxtIva
            // 
            this.TxtIva.Enabled = false;
            this.TxtIva.Location = new System.Drawing.Point(823, 259);
            this.TxtIva.Name = "TxtIva";
            this.TxtIva.Size = new System.Drawing.Size(100, 22);
            this.TxtIva.TabIndex = 21;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Location = new System.Drawing.Point(822, 290);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(100, 22);
            this.TxtTotal.TabIndex = 22;
            // 
            // TxtPedido
            // 
            this.TxtPedido.Location = new System.Drawing.Point(670, 53);
            this.TxtPedido.Name = "TxtPedido";
            this.TxtPedido.Size = new System.Drawing.Size(34, 22);
            this.TxtPedido.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 506);
            this.Controls.Add(this.TxtPedido);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.TxtIva);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Tabla);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.TxtSubtotal);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.CboCliente);
            this.Controls.Add(this.CboProducto);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.ComboBox CboProducto;
        private System.Windows.Forms.ComboBox CboCliente;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtSubtotal;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.DataGridView Tabla;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox TxtIva;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubtotal;
        private System.Windows.Forms.TextBox TxtPedido;
    }
}

