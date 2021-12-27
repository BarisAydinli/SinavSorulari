namespace Sınav1
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
            this.txtTextBir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTextIki = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.lblBirinci = new System.Windows.Forms.Label();
            this.lblIkinci = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTextBir
            // 
            this.txtTextBir.Location = new System.Drawing.Point(102, 9);
            this.txtTextBir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTextBir.Name = "txtTextBir";
            this.txtTextBir.Size = new System.Drawing.Size(324, 27);
            this.txtTextBir.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Metin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "2. Metin:";
            // 
            // txtTextIki
            // 
            this.txtTextIki.Location = new System.Drawing.Point(102, 65);
            this.txtTextIki.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTextIki.Name = "txtTextIki";
            this.txtTextIki.Size = new System.Drawing.Size(324, 27);
            this.txtTextIki.TabIndex = 2;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(102, 125);
            this.btnResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(326, 33);
            this.btnResult.TabIndex = 4;
            this.btnResult.Text = "Sonuç";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // lblBirinci
            // 
            this.lblBirinci.AutoSize = true;
            this.lblBirinci.Location = new System.Drawing.Point(436, 13);
            this.lblBirinci.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirinci.Name = "lblBirinci";
            this.lblBirinci.Size = new System.Drawing.Size(82, 19);
            this.lblBirinci.TabIndex = 5;
            this.lblBirinci.Text = "<Uzunluk>";
            // 
            // lblIkinci
            // 
            this.lblIkinci.AutoSize = true;
            this.lblIkinci.Location = new System.Drawing.Point(436, 68);
            this.lblIkinci.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIkinci.Name = "lblIkinci";
            this.lblIkinci.Size = new System.Drawing.Size(82, 19);
            this.lblIkinci.TabIndex = 6;
            this.lblIkinci.Text = "<Uzunluk>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(717, 176);
            this.Controls.Add(this.lblIkinci);
            this.Controls.Add(this.lblBirinci);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTextIki);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTextBir);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextBir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTextIki;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label lblBirinci;
        private System.Windows.Forms.Label lblIkinci;
    }
}

