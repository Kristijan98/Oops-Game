
namespace Proekt_Vizuelno
{
    partial class Pochetok
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
            this.kakoSeigra = new System.Windows.Forms.Button();
            this.zapochni = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kakoSeigra
            // 
            this.kakoSeigra.Location = new System.Drawing.Point(225, 443);
            this.kakoSeigra.Name = "kakoSeigra";
            this.kakoSeigra.Size = new System.Drawing.Size(129, 23);
            this.kakoSeigra.TabIndex = 5;
            this.kakoSeigra.Text = "Како се игра";
            this.kakoSeigra.UseVisualStyleBackColor = true;
            this.kakoSeigra.Click += new System.EventHandler(this.button2_Click);
            // 
            // zapochni
            // 
            this.zapochni.Location = new System.Drawing.Point(32, 443);
            this.zapochni.Name = "zapochni";
            this.zapochni.Size = new System.Drawing.Size(127, 23);
            this.zapochni.TabIndex = 4;
            this.zapochni.Text = "Започни";
            this.zapochni.UseVisualStyleBackColor = true;
            this.zapochni.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proekt_Vizuelno.Properties.Resources.Screenshot_11;
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 425);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Pochetok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 520);
            this.Controls.Add(this.kakoSeigra);
            this.Controls.Add(this.zapochni);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Pochetok";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kakoSeigra;
        private System.Windows.Forms.Button zapochni;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

