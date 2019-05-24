namespace _3_Laboratorinis_OSPFWinForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_Komanda = new System.Windows.Forms.Label();
            this.textBox_Komanda = new System.Windows.Forms.TextBox();
            this.button_Ivykdyti = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(345, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "OSPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(202, 71);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(338, 131);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "1. Prideti routeri\r\n2. Prideti rysi \r\n3. Pasalinti routeri   \r\n4. Pasalinti rysi " +
    "\r\n5. Siusti zinute \r\n6. Perziureti lentele \r\n";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Komanda
            // 
            this.label_Komanda.AutoSize = true;
            this.label_Komanda.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label_Komanda.Location = new System.Drawing.Point(313, 212);
            this.label_Komanda.Name = "label_Komanda";
            this.label_Komanda.Size = new System.Drawing.Size(135, 18);
            this.label_Komanda.TabIndex = 3;
            this.label_Komanda.Text = "Komandos numeris";
            // 
            // textBox_Komanda
            // 
            this.textBox_Komanda.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBox_Komanda.Location = new System.Drawing.Point(285, 245);
            this.textBox_Komanda.Name = "textBox_Komanda";
            this.textBox_Komanda.Size = new System.Drawing.Size(186, 22);
            this.textBox_Komanda.TabIndex = 4;
            this.textBox_Komanda.TextChanged += new System.EventHandler(this.textBox_Komanda_TextChanged);
            // 
            // button_Ivykdyti
            // 
            this.button_Ivykdyti.AutoSize = true;
            this.button_Ivykdyti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_Ivykdyti.Font = new System.Drawing.Font("Open Sans ExtraBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button_Ivykdyti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_Ivykdyti.Location = new System.Drawing.Point(337, 283);
            this.button_Ivykdyti.Name = "button_Ivykdyti";
            this.button_Ivykdyti.Size = new System.Drawing.Size(88, 33);
            this.button_Ivykdyti.TabIndex = 5;
            this.button_Ivykdyti.Text = "Įvykdyti";
            this.button_Ivykdyti.UseVisualStyleBackColor = false;
            this.button_Ivykdyti.Click += new System.EventHandler(this.button_Ivykdyti_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(199, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "*Output yra įdėtas į Console";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Ivykdyti);
            this.Controls.Add(this.textBox_Komanda);
            this.Controls.Add(this.label_Komanda);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_Komanda;
        private System.Windows.Forms.TextBox textBox_Komanda;
        private System.Windows.Forms.Button button_Ivykdyti;
        private System.Windows.Forms.Label label3;
    }
}

