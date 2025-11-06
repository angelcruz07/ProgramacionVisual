namespace BoteBasura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picBote = new System.Windows.Forms.PictureBox();
            this.picBasura = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasura)).BeginInit();
            this.SuspendLayout();
            // 
            // picBote
            // 
            this.picBote.Image = global::BoteBasura.Properties.Resources.trash_with_liner;
            this.picBote.Location = new System.Drawing.Point(633, 205);
            this.picBote.Name = "picBote";
            this.picBote.Size = new System.Drawing.Size(192, 254);
            this.picBote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBote.TabIndex = 1;
            this.picBote.TabStop = false;
            // 
            // picBasura
            // 
            this.picBasura.Image = ((System.Drawing.Image)(resources.GetObject("picBasura.Image")));
            this.picBasura.Location = new System.Drawing.Point(53, 310);
            this.picBasura.Name = "picBasura";
            this.picBasura.Size = new System.Drawing.Size(184, 149);
            this.picBasura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBasura.TabIndex = 2;
            this.picBasura.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 513);
            this.Controls.Add(this.picBasura);
            this.Controls.Add(this.picBote);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBote;
        private System.Windows.Forms.PictureBox picBasura;
    }
}

