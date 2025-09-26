namespace _04_JuegoDeDatos
{
    partial class Imagenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Imagenes));
            label1 = new Label();
            foto = new PictureBox();
            btnBuscar = new Button();
            label2 = new Label();
            txtUrl = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)foto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 65);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Fotografía";
            label1.Click += label1_Click;
            // 
            // foto
            // 
            foto.Location = new Point(336, 79);
            foto.Name = "foto";
            foto.Size = new Size(125, 62);
            foto.TabIndex = 1;
            foto.TabStop = false;
            foto.Click += pictureBox1_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackgroundImage = (Image)resources.GetObject("btnBuscar.BackgroundImage");
            btnBuscar.Location = new Point(521, 279);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(81, 86);
            btnBuscar.TabIndex = 2;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 312);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 3;
            label2.Text = "URL";
            label2.Click += label2_Click;
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(232, 309);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(245, 27);
            txtUrl.TabIndex = 4;
            txtUrl.TextChanged += textBox1_TextChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtUrl);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(foto);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)foto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox foto;
        private Button btnBuscar;
        private Label label2;
        private TextBox txtUrl;
        private OpenFileDialog openFileDialog1;
    }
}