namespace TugasModul3_103082400024
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
            this.labelPertanyaan = new System.Windows.Forms.Label();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.labelJawaban = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPertanyaan
            // 
            this.labelPertanyaan.AutoSize = true;
            this.labelPertanyaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPertanyaan.Location = new System.Drawing.Point(330, 51);
            this.labelPertanyaan.Name = "labelPertanyaan";
            this.labelPertanyaan.Size = new System.Drawing.Size(99, 25);
            this.labelPertanyaan.TabIndex = 0;
            this.labelPertanyaan.Text = "“1 + 1 =?\"";
            this.labelPertanyaan.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonA
            // 
            this.buttonA.Location = new System.Drawing.Point(187, 123);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(147, 70);
            this.buttonA.TabIndex = 1;
            this.buttonA.Text = "A. 2";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonB
            // 
            this.buttonB.Location = new System.Drawing.Point(187, 221);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(147, 70);
            this.buttonB.TabIndex = 2;
            this.buttonB.Text = "B.4";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(423, 123);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(147, 70);
            this.buttonC.TabIndex = 3;
            this.buttonC.Text = "C. Semua Benar";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonD
            // 
            this.buttonD.Location = new System.Drawing.Point(423, 221);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(147, 70);
            this.buttonD.TabIndex = 4;
            this.buttonD.Text = "D. Semua Salah";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelJawaban
            // 
            this.labelJawaban.AutoSize = true;
            this.labelJawaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJawaban.Location = new System.Drawing.Point(299, 331);
            this.labelJawaban.Name = "labelJawaban";
            this.labelJawaban.Size = new System.Drawing.Size(0, 25);
            this.labelJawaban.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelJawaban);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.labelPertanyaan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPertanyaan;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Label labelJawaban;
    }
}

