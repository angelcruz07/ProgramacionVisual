namespace _03_Clases
{
    partial class Condicionales
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Condicionales));
            this.view1 = new System.Windows.Forms.PictureBox();
            this.view2 = new System.Windows.Forms.PictureBox();
            this.view4 = new System.Windows.Forms.PictureBox();
            this.view3 = new System.Windows.Forms.PictureBox();
            this.view5 = new System.Windows.Forms.PictureBox();
            this.view6 = new System.Windows.Forms.PictureBox();
            this.btnLanzar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnParar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.view1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view6)).BeginInit();
            this.SuspendLayout();
            // 
            // view1
            // 
            this.view1.Image = ((System.Drawing.Image)(resources.GetObject("view1.Image")));
            this.view1.Location = new System.Drawing.Point(336, 195);
            this.view1.Name = "view1";
            this.view1.Size = new System.Drawing.Size(95, 90);
            this.view1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.view1.TabIndex = 0;
            this.view1.TabStop = false;
            // 
            // view2
            // 
            this.view2.Image = ((System.Drawing.Image)(resources.GetObject("view2.Image")));
            this.view2.Location = new System.Drawing.Point(334, 195);
            this.view2.Name = "view2";
            this.view2.Size = new System.Drawing.Size(97, 89);
            this.view2.TabIndex = 1;
            this.view2.TabStop = false;
            // 
            // view4
            // 
            this.view4.Image = ((System.Drawing.Image)(resources.GetObject("view4.Image")));
            this.view4.Location = new System.Drawing.Point(334, 191);
            this.view4.Name = "view4";
            this.view4.Size = new System.Drawing.Size(58, 60);
            this.view4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.view4.TabIndex = 2;
            this.view4.TabStop = false;
            // 
            // view3
            // 
            this.view3.Image = ((System.Drawing.Image)(resources.GetObject("view3.Image")));
            this.view3.Location = new System.Drawing.Point(334, 193);
            this.view3.Name = "view3";
            this.view3.Size = new System.Drawing.Size(58, 58);
            this.view3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.view3.TabIndex = 3;
            this.view3.TabStop = false;
            // 
            // view5
            // 
            this.view5.Image = ((System.Drawing.Image)(resources.GetObject("view5.Image")));
            this.view5.Location = new System.Drawing.Point(336, 197);
            this.view5.Name = "view5";
            this.view5.Size = new System.Drawing.Size(58, 55);
            this.view5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.view5.TabIndex = 4;
            this.view5.TabStop = false;
            // 
            // view6
            // 
            this.view6.Image = ((System.Drawing.Image)(resources.GetObject("view6.Image")));
            this.view6.Location = new System.Drawing.Point(334, 191);
            this.view6.Name = "view6";
            this.view6.Size = new System.Drawing.Size(97, 92);
            this.view6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.view6.TabIndex = 5;
            this.view6.TabStop = false;
            // 
            // btnLanzar
            // 
            this.btnLanzar.Location = new System.Drawing.Point(245, 303);
            this.btnLanzar.Name = "btnLanzar";
            this.btnLanzar.Size = new System.Drawing.Size(128, 42);
            this.btnLanzar.TabIndex = 6;
            this.btnLanzar.Text = "Lanzar dado";
            this.btnLanzar.UseVisualStyleBackColor = true;
            this.btnLanzar.Click += new System.EventHandler(this.btnLanzar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(403, 303);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(75, 42);
            this.btnParar.TabIndex = 7;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // Condicionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnLanzar);
            this.Controls.Add(this.view6);
            this.Controls.Add(this.view5);
            this.Controls.Add(this.view3);
            this.Controls.Add(this.view4);
            this.Controls.Add(this.view2);
            this.Controls.Add(this.view1);
            this.Name = "Condicionales";
            this.Text = "Condicionales";
            this.Load += new System.EventHandler(this.Condicionales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox view1;
        private System.Windows.Forms.PictureBox view2;
        private System.Windows.Forms.PictureBox view4;
        private System.Windows.Forms.PictureBox view3;
        private System.Windows.Forms.PictureBox view5;
        private System.Windows.Forms.PictureBox view6;
        private System.Windows.Forms.Button btnLanzar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnParar;
    }
}