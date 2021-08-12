
namespace Proekt_Vizuelno
{
    partial class Start
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
            this.kakoSeigra = new System.Windows.Forms.Button();
            this.zapochni = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kakoSeigra
            // 
            this.kakoSeigra.Location = new System.Drawing.Point(219, 443);
            this.kakoSeigra.Name = "kakoSeigra";
            this.kakoSeigra.Size = new System.Drawing.Size(150, 23);
            this.kakoSeigra.TabIndex = 5;
            this.kakoSeigra.Text = "Како се игра";
            this.kakoSeigra.UseVisualStyleBackColor = true;
            this.kakoSeigra.Click += new System.EventHandler(this.button2_Click);
            // 
            // zapochni
            // 
            this.zapochni.Location = new System.Drawing.Point(21, 443);
            this.zapochni.Name = "zapochni";
            this.zapochni.Size = new System.Drawing.Size(148, 23);
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(86, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 61);
            this.label1.TabIndex = 6;
            this.label1.Text = "Добредојдовте на \"Oops\" базирана на класичната игра со карти";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(80, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 7;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 520);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kakoSeigra);
            this.Controls.Add(this.zapochni);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Start";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Pochetok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kakoSeigra;
        private System.Windows.Forms.Button zapochni;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}

