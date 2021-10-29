
namespace StoryGame2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.optionButtonA = new System.Windows.Forms.Button();
            this.optionButtonB = new System.Windows.Forms.Button();
            this.optionAOutputLabel = new System.Windows.Forms.Label();
            this.optionBOutputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.optionCOutputLabel = new System.Windows.Forms.Label();
            this.optionButtonC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox1.Image = global::StoryGame2.Properties.Resources.hauntedHouse1;
            this.pictureBox1.Location = new System.Drawing.Point(8, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // optionButtonA
            // 
            this.optionButtonA.BackColor = System.Drawing.Color.OrangeRed;
            this.optionButtonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionButtonA.Location = new System.Drawing.Point(12, 326);
            this.optionButtonA.Name = "optionButtonA";
            this.optionButtonA.Size = new System.Drawing.Size(77, 46);
            this.optionButtonA.TabIndex = 2;
            this.optionButtonA.Text = "A";
            this.optionButtonA.UseVisualStyleBackColor = false;
            this.optionButtonA.Click += new System.EventHandler(this.optionButtonA_Click);
            // 
            // optionButtonB
            // 
            this.optionButtonB.BackColor = System.Drawing.Color.OrangeRed;
            this.optionButtonB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionButtonB.Location = new System.Drawing.Point(12, 392);
            this.optionButtonB.Name = "optionButtonB";
            this.optionButtonB.Size = new System.Drawing.Size(77, 46);
            this.optionButtonB.TabIndex = 3;
            this.optionButtonB.Text = "B";
            this.optionButtonB.UseVisualStyleBackColor = false;
            this.optionButtonB.Click += new System.EventHandler(this.optionButtonB_Click);
            // 
            // optionAOutputLabel
            // 
            this.optionAOutputLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionAOutputLabel.Location = new System.Drawing.Point(95, 339);
            this.optionAOutputLabel.Name = "optionAOutputLabel";
            this.optionAOutputLabel.Size = new System.Drawing.Size(146, 18);
            this.optionAOutputLabel.TabIndex = 4;
            this.optionAOutputLabel.Text = "optionAOutputLabel";
            // 
            // optionBOutputLabel
            // 
            this.optionBOutputLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionBOutputLabel.Location = new System.Drawing.Point(95, 405);
            this.optionBOutputLabel.Name = "optionBOutputLabel";
            this.optionBOutputLabel.Size = new System.Drawing.Size(146, 18);
            this.optionBOutputLabel.TabIndex = 5;
            this.optionBOutputLabel.Text = "optionBOutputLabel";
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.LightCoral;
            this.outputLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(5, 232);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(424, 80);
            this.outputLabel.TabIndex = 6;
            this.outputLabel.Text = "outputLabel";
            // 
            // optionCOutputLabel
            // 
            this.optionCOutputLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionCOutputLabel.Location = new System.Drawing.Point(95, 467);
            this.optionCOutputLabel.Name = "optionCOutputLabel";
            this.optionCOutputLabel.Size = new System.Drawing.Size(147, 18);
            this.optionCOutputLabel.TabIndex = 8;
            this.optionCOutputLabel.Text = "optionCOutputLabel";
            // 
            // optionButtonC
            // 
            this.optionButtonC.BackColor = System.Drawing.Color.OrangeRed;
            this.optionButtonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionButtonC.Location = new System.Drawing.Point(12, 454);
            this.optionButtonC.Name = "optionButtonC";
            this.optionButtonC.Size = new System.Drawing.Size(77, 46);
            this.optionButtonC.TabIndex = 7;
            this.optionButtonC.Text = "C";
            this.optionButtonC.UseVisualStyleBackColor = false;
            this.optionButtonC.Click += new System.EventHandler(this.optionButtonC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(439, 514);
            this.Controls.Add(this.optionCOutputLabel);
            this.Controls.Add(this.optionButtonC);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.optionBOutputLabel);
            this.Controls.Add(this.optionAOutputLabel);
            this.Controls.Add(this.optionButtonB);
            this.Controls.Add(this.optionButtonA);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button optionButtonA;
        private System.Windows.Forms.Button optionButtonB;
        private System.Windows.Forms.Label optionAOutputLabel;
        private System.Windows.Forms.Label optionBOutputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label optionCOutputLabel;
        private System.Windows.Forms.Button optionButtonC;
    }
}

