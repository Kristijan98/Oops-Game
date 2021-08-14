
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
            this.kakoSeigra.Location = new System.Drawing.Point(292, 545);
            this.kakoSeigra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kakoSeigra.Name = "kakoSeigra";
            this.kakoSeigra.Size = new System.Drawing.Size(200, 28);
            this.kakoSeigra.TabIndex = 5;
            this.kakoSeigra.Text = "Како се игра";
            this.kakoSeigra.UseVisualStyleBackColor = true;
            this.kakoSeigra.Click += new System.EventHandler(this.button2_Click);
            // 
            // zapochni
            // 
            this.zapochni.Location = new System.Drawing.Point(28, 545);
            this.zapochni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zapochni.Name = "zapochni";
            this.zapochni.Size = new System.Drawing.Size(197, 28);
            this.zapochni.TabIndex = 4;
            this.zapochni.Text = "Започни";
            this.zapochni.UseVisualStyleBackColor = true;
            this.zapochni.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proekt_Vizuelno.Properties.Resources.Screenshot_11;
            this.pictureBox1.Location = new System.Drawing.Point(28, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(464, 523);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(115, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 75);
            this.label1.TabIndex = 6;
            this.label1.Text = "Добредојдовте на \"Oops\". Базирана на класичната игра со карти";
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
            this.label2.Location = new System.Drawing.Point(107, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 7;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 640);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kakoSeigra);
            this.Controls.Add(this.zapochni);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

