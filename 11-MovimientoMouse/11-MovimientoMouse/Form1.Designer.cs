namespace MovimientoMouse
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
            this.Image1 = new System.Windows.Forms.PictureBox();
            this.Image2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image2)).BeginInit();
            this.SuspendLayout();
            // 
            // Image1
            // 
            this.Image1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Image1.Location = new System.Drawing.Point(184, 100);
            this.Image1.Name = "Image1";
            this.Image1.Size = new System.Drawing.Size(100, 139);
            this.Image1.TabIndex = 0;
            this.Image1.TabStop = false;
            this.Image1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Image1_MouseDown);
            this.Image1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Image1_MouseMove);
            this.Image1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Image1_MouseUp);
            // 
            // Image2
            // 
            this.Image2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Image2.Location = new System.Drawing.Point(412, 100);
            this.Image2.Name = "Image2";
            this.Image2.Size = new System.Drawing.Size(100, 139);
            this.Image2.TabIndex = 1;
            this.Image2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Image2);
            this.Controls.Add(this.Image1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Image1;
        private System.Windows.Forms.PictureBox Image2;
    }
}

