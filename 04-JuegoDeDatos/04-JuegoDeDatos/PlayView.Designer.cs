namespace _04_JuegoDeDatos
{
    partial class PlayView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayView));
            label1 = new Label();
            label2 = new Label();
            ScorePlayer1 = new ListView();
            ScorePlayer2 = new ListView();
            Face3 = new PictureBox();
            Face5 = new PictureBox();
            Face6 = new PictureBox();
            Face4 = new PictureBox();
            Face2 = new PictureBox();
            Face1 = new PictureBox();
            btnStart = new Button();
            btnParar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lblTurno = new Label();
            ((System.ComponentModel.ISupportInitialize)Face3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Face5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Face6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Face4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Face2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Face1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 124);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Jugador 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(580, 124);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Jugador 2";
            // 
            // ScorePlayer1
            // 
            ScorePlayer1.Location = new Point(88, 142);
            ScorePlayer1.Name = "ScorePlayer1";
            ScorePlayer1.Size = new Size(202, 41);
            ScorePlayer1.TabIndex = 2;
            ScorePlayer1.UseCompatibleStateImageBehavior = false;
            // 
            // ScorePlayer2
            // 
            ScorePlayer2.Location = new Point(508, 142);
            ScorePlayer2.Name = "ScorePlayer2";
            ScorePlayer2.Size = new Size(202, 41);
            ScorePlayer2.TabIndex = 3;
            ScorePlayer2.UseCompatibleStateImageBehavior = false;
            // 
            // Face3
            // 
            Face3.Image = (Image)resources.GetObject("Face3.Image");
            Face3.Location = new Point(373, 179);
            Face3.Name = "Face3";
            Face3.Size = new Size(58, 58);
            Face3.SizeMode = PictureBoxSizeMode.AutoSize;
            Face3.TabIndex = 9;
            Face3.TabStop = false;
            // 
            // Face5
            // 
            Face5.Image = (Image)resources.GetObject("Face5.Image");
            Face5.Location = new Point(371, 182);
            Face5.Name = "Face5";
            Face5.Size = new Size(58, 55);
            Face5.SizeMode = PictureBoxSizeMode.AutoSize;
            Face5.TabIndex = 10;
            Face5.TabStop = false;
            // 
            // Face6
            // 
            Face6.Image = (Image)resources.GetObject("Face6.Image");
            Face6.Location = new Point(371, 181);
            Face6.Name = "Face6";
            Face6.Size = new Size(58, 59);
            Face6.SizeMode = PictureBoxSizeMode.AutoSize;
            Face6.TabIndex = 11;
            Face6.TabStop = false;
            // 
            // Face4
            // 
            Face4.Image = (Image)resources.GetObject("Face4.Image");
            Face4.Location = new Point(371, 180);
            Face4.Name = "Face4";
            Face4.Size = new Size(58, 60);
            Face4.SizeMode = PictureBoxSizeMode.AutoSize;
            Face4.TabIndex = 12;
            Face4.TabStop = false;
            // 
            // Face2
            // 
            Face2.Image = (Image)resources.GetObject("Face2.Image");
            Face2.Location = new Point(371, 180);
            Face2.Name = "Face2";
            Face2.Size = new Size(58, 56);
            Face2.SizeMode = PictureBoxSizeMode.AutoSize;
            Face2.TabIndex = 13;
            Face2.TabStop = false;
            // 
            // Face1
            // 
            Face1.Image = (Image)resources.GetObject("Face1.Image");
            Face1.Location = new Point(373, 179);
            Face1.Name = "Face1";
            Face1.Size = new Size(56, 57);
            Face1.SizeMode = PictureBoxSizeMode.AutoSize;
            Face1.TabIndex = 14;
            Face1.TabStop = false;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(281, 276);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(115, 23);
            btnStart.TabIndex = 15;
            btnStart.Text = "Lanzar Dados";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnParar
            // 
            btnParar.Location = new Point(417, 276);
            btnParar.Name = "btnParar";
            btnParar.Size = new Size(107, 23);
            btnParar.TabIndex = 16;
            btnParar.Text = "Parar";
            btnParar.UseVisualStyleBackColor = true;
            btnParar.Click += btnParar_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(348, 96);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(111, 15);
            lblTurno.TabIndex = 17;
            lblTurno.Text = "Turno dei jugador 1";
            // 
            // PlayView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTurno);
            Controls.Add(Face6);
            Controls.Add(Face5);
            Controls.Add(Face2);
            Controls.Add(btnParar);
            Controls.Add(btnStart);
            Controls.Add(Face4);
            Controls.Add(Face3);
            Controls.Add(ScorePlayer2);
            Controls.Add(ScorePlayer1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Face1);
            Name = "PlayView";
            Text = "Form1";
            Load += PlayView_Load;
            ((System.ComponentModel.ISupportInitialize)Face3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Face5).EndInit();
            ((System.ComponentModel.ISupportInitialize)Face6).EndInit();
            ((System.ComponentModel.ISupportInitialize)Face4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Face2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Face1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListView ScorePlayer1;
        private ListView ScorePlayer2;
        private PictureBox Face3;
        private PictureBox Face5;
        private PictureBox Face6;
        private PictureBox Face4;
        private PictureBox Face2;
        private PictureBox Face1;
        private Button btnStart;
        private Button btnParar;
        private System.Windows.Forms.Timer timer1;
        private Label lblTurno;
    }
}
