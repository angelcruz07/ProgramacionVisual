namespace _04_JuegoDeDatos
{
    partial class RegistroDeUsuarios
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
            TxtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TxtFirstLastName = new TextBox();
            label3 = new Label();
            TxtSecondLastName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            TxtColony = new TextBox();
            label6 = new Label();
            TxtStreet = new TextBox();
            DateRegister = new DateTimePicker();
            Photo = new PictureBox();
            BtnSelectImage = new Button();
            label7 = new Label();
            CboState = new ComboBox();
            LstUsers = new ListBox();
            label8 = new Label();
            button1 = new Button();
            TxtUrl = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            lbl = new Label();
            ((System.ComponentModel.ISupportInitialize)Photo).BeginInit();
            SuspendLayout();
            // 
            // TxtName
            // 
            TxtName.Location = new Point(149, 93);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(221, 27);
            TxtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 100);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 144);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 3;
            label2.Text = "Apellido Paterno";
            // 
            // TxtFirstLastName
            // 
            TxtFirstLastName.Location = new Point(149, 137);
            TxtFirstLastName.Name = "TxtFirstLastName";
            TxtFirstLastName.Size = new Size(221, 27);
            TxtFirstLastName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 192);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 5;
            label3.Text = "Apelido Materno";
            // 
            // TxtSecondLastName
            // 
            TxtSecondLastName.Location = new Point(149, 185);
            TxtSecondLastName.Name = "TxtSecondLastName";
            TxtSecondLastName.Size = new Size(221, 27);
            TxtSecondLastName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 239);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 7;
            label4.Text = "Estado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 279);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 9;
            label5.Text = "Colonia";
            // 
            // TxtColony
            // 
            TxtColony.Location = new Point(149, 272);
            TxtColony.Name = "TxtColony";
            TxtColony.Size = new Size(221, 27);
            TxtColony.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(81, 322);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 11;
            label6.Text = "Calle";
            // 
            // TxtStreet
            // 
            TxtStreet.Location = new Point(149, 322);
            TxtStreet.Name = "TxtStreet";
            TxtStreet.Size = new Size(221, 27);
            TxtStreet.TabIndex = 10;
            // 
            // DateRegister
            // 
            DateRegister.Location = new Point(149, 373);
            DateRegister.Name = "DateRegister";
            DateRegister.Size = new Size(210, 27);
            DateRegister.TabIndex = 12;
            // 
            // Photo
            // 
            Photo.Location = new Point(200, 415);
            Photo.Name = "Photo";
            Photo.Size = new Size(105, 97);
            Photo.TabIndex = 13;
            Photo.TabStop = false;
            // 
            // BtnSelectImage
            // 
            BtnSelectImage.Location = new Point(149, 518);
            BtnSelectImage.Name = "BtnSelectImage";
            BtnSelectImage.Size = new Size(196, 29);
            BtnSelectImage.TabIndex = 14;
            BtnSelectImage.Text = "SELECIONAR IMAGEN";
            BtnSelectImage.UseVisualStyleBackColor = true;
            BtnSelectImage.Click += BtnSelectImage_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 373);
            label7.Name = "label7";
            label7.Size = new Size(123, 20);
            label7.TabIndex = 15;
            label7.Text = "Fecha de registro";
            // 
            // CboState
            // 
            CboState.FormattingEnabled = true;
            CboState.Items.AddRange(new object[] { "Estados de México", "Aguascalientes", "Baja California", " Baja California Sur", " Campeche", "  Chiapas", "  Chihuahua", "  Coahuila de Zaragoza", "  Colima", "  Durango", "  Guanajuato", " Guerrero", " Hidalgo", "    Jalisco", "    México", "    Michoacán de Ocampo", "    Morelos", "    Nayarit", "    Nuevo León", "    Oaxaca", "    Puebla", "    Querétaro", "    Quintana Roo", " San Luis Potosí", "   Sinaloa", "    Sonora", "    Tabasco", "    Tamaulipas", "    Tlaxcala", "    Veracruz", "    Yucatán", "    Zacatecas", "    Ciudad de México (Entidad federativa)" });
            CboState.Location = new Point(149, 231);
            CboState.Name = "CboState";
            CboState.Size = new Size(221, 28);
            CboState.TabIndex = 16;
            // 
            // LstUsers
            // 
            LstUsers.FormattingEnabled = true;
            LstUsers.Location = new Point(439, 93);
            LstUsers.Name = "LstUsers";
            LstUsers.Size = new Size(541, 364);
            LstUsers.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(84, 415);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 18;
            label8.Text = "Foto";
            // 
            // button1
            // 
            button1.Location = new Point(379, 629);
            button1.Name = "button1";
            button1.Size = new Size(196, 29);
            button1.TabIndex = 19;
            button1.Text = "Registar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnRegistrar;
            // 
            // TxtUrl
            // 
            TxtUrl.Location = new Point(69, 438);
            TxtUrl.Name = "TxtUrl";
            TxtUrl.Size = new Size(125, 27);
            TxtUrl.TabIndex = 20;
            TxtUrl.Visible = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(406, 31);
            lbl.Name = "lbl";
            lbl.Size = new Size(139, 20);
            lbl.TabIndex = 21;
            lbl.Text = "Registro de Usuario";
            // 
            // RegistroDeUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 703);
            Controls.Add(lbl);
            Controls.Add(TxtUrl);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(LstUsers);
            Controls.Add(CboState);
            Controls.Add(label7);
            Controls.Add(BtnSelectImage);
            Controls.Add(Photo);
            Controls.Add(DateRegister);
            Controls.Add(label6);
            Controls.Add(TxtStreet);
            Controls.Add(label5);
            Controls.Add(TxtColony);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TxtSecondLastName);
            Controls.Add(label2);
            Controls.Add(TxtFirstLastName);
            Controls.Add(label1);
            Controls.Add(TxtName);
            Name = "RegistroDeUsuarios";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Photo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtName;
        private Label label1;
        private Label label2;
        private TextBox TxtFirstLastName;
        private Label label3;
        private TextBox TxtSecondLastName;
        private Label label4;
        private Label label5;
        private TextBox TxtColony;
        private Label label6;
        private TextBox TxtStreet;
        private DateTimePicker DateRegister;
        private PictureBox Photo;
        private Button BtnSelectImage;
        private Label label7;
        private ComboBox CboState;
        private ListBox listBox1;
        private Label label8;
        private Button button1;
        private TextBox TxtUrl;
        private OpenFileDialog openFileDialog1;
        private ListBox LstUsers;
        private Label lbl;
    }
}