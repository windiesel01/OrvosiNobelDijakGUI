namespace OrvosiNobelDijakGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ev = new System.Windows.Forms.TextBox();
            this.textBox_neve = new System.Windows.Forms.TextBox();
            this.textBox_sz_h = new System.Windows.Forms.TextBox();
            this.textBox_orszag = new System.Windows.Forms.TextBox();
            this.button_adatok_mentese = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(26, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Év:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(26, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(26, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sz/H:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(26, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ország:";
            // 
            // textBox_ev
            // 
            this.textBox_ev.Location = new System.Drawing.Point(97, 51);
            this.textBox_ev.Name = "textBox_ev";
            this.textBox_ev.Size = new System.Drawing.Size(100, 20);
            this.textBox_ev.TabIndex = 4;
            // 
            // textBox_neve
            // 
            this.textBox_neve.Location = new System.Drawing.Point(97, 77);
            this.textBox_neve.Name = "textBox_neve";
            this.textBox_neve.Size = new System.Drawing.Size(121, 20);
            this.textBox_neve.TabIndex = 5;
            // 
            // textBox_sz_h
            // 
            this.textBox_sz_h.Location = new System.Drawing.Point(97, 103);
            this.textBox_sz_h.Name = "textBox_sz_h";
            this.textBox_sz_h.Size = new System.Drawing.Size(100, 20);
            this.textBox_sz_h.TabIndex = 6;
            // 
            // textBox_orszag
            // 
            this.textBox_orszag.Location = new System.Drawing.Point(97, 131);
            this.textBox_orszag.Name = "textBox_orszag";
            this.textBox_orszag.Size = new System.Drawing.Size(100, 20);
            this.textBox_orszag.TabIndex = 7;
            // 
            // button_adatok_mentese
            // 
            this.button_adatok_mentese.Location = new System.Drawing.Point(116, 194);
            this.button_adatok_mentese.Name = "button_adatok_mentese";
            this.button_adatok_mentese.Size = new System.Drawing.Size(143, 23);
            this.button_adatok_mentese.TabIndex = 8;
            this.button_adatok_mentese.Text = "Adatok mentése";
            this.button_adatok_mentese.UseVisualStyleBackColor = true;
            this.button_adatok_mentese.Click += new System.EventHandler(this.button_adatok_mentese_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 252);
            this.Controls.Add(this.button_adatok_mentese);
            this.Controls.Add(this.textBox_orszag);
            this.Controls.Add(this.textBox_sz_h);
            this.Controls.Add(this.textBox_neve);
            this.Controls.Add(this.textBox_ev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Orvosi Nobel-díjasok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_ev;
        private System.Windows.Forms.TextBox textBox_neve;
        private System.Windows.Forms.TextBox textBox_sz_h;
        private System.Windows.Forms.TextBox textBox_orszag;
        private System.Windows.Forms.Button button_adatok_mentese;
    }
}

