namespace _3_Laboratorinis_OSPFWinForm
{
    partial class DeleteRoute
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
            this.textBox_PathNumber = new System.Windows.Forms.TextBox();
            this.button_Istrinti = new System.Windows.Forms.Button();
            this.button_Atsaukti = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kelio numeris";
            // 
            // textBox_PathNumber
            // 
            this.textBox_PathNumber.Location = new System.Drawing.Point(184, 101);
            this.textBox_PathNumber.Name = "textBox_PathNumber";
            this.textBox_PathNumber.Size = new System.Drawing.Size(214, 20);
            this.textBox_PathNumber.TabIndex = 1;
            // 
            // button_Istrinti
            // 
            this.button_Istrinti.Location = new System.Drawing.Point(85, 157);
            this.button_Istrinti.Name = "button_Istrinti";
            this.button_Istrinti.Size = new System.Drawing.Size(107, 40);
            this.button_Istrinti.TabIndex = 2;
            this.button_Istrinti.Text = "Ištrinti";
            this.button_Istrinti.UseVisualStyleBackColor = true;
            this.button_Istrinti.Click += new System.EventHandler(this.button_Istrinti_Click);
            // 
            // button_Atsaukti
            // 
            this.button_Atsaukti.Location = new System.Drawing.Point(300, 157);
            this.button_Atsaukti.Name = "button_Atsaukti";
            this.button_Atsaukti.Size = new System.Drawing.Size(98, 40);
            this.button_Atsaukti.TabIndex = 3;
            this.button_Atsaukti.Text = "Atšaukti";
            this.button_Atsaukti.UseVisualStyleBackColor = true;
            this.button_Atsaukti.Click += new System.EventHandler(this.button_Atsaukti_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(178, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ištrinti kelią";
            // 
            // DeleteRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Atsaukti);
            this.Controls.Add(this.button_Istrinti);
            this.Controls.Add(this.textBox_PathNumber);
            this.Controls.Add(this.label1);
            this.Name = "DeleteRoute";
            this.Text = "DeleteRoute";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_PathNumber;
        private System.Windows.Forms.Button button_Istrinti;
        private System.Windows.Forms.Button button_Atsaukti;
        private System.Windows.Forms.Label label2;
    }
}