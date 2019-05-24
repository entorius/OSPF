namespace _3_Laboratorinis_OSPFWinForm
{
    partial class DeleteRouter
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
            this.button_Atsaukti = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_RouterNumber = new System.Windows.Forms.TextBox();
            this.button_Istrinti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Atsaukti
            // 
            this.button_Atsaukti.Location = new System.Drawing.Point(280, 144);
            this.button_Atsaukti.Name = "button_Atsaukti";
            this.button_Atsaukti.Size = new System.Drawing.Size(88, 39);
            this.button_Atsaukti.TabIndex = 0;
            this.button_Atsaukti.Text = "Atšaukti";
            this.button_Atsaukti.UseVisualStyleBackColor = true;
            this.button_Atsaukti.Click += new System.EventHandler(this.button_Atsaukti_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(632, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(157, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ištrinti routerį";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Routerio numeris";
            // 
            // textBox_RouterNumber
            // 
            this.textBox_RouterNumber.Location = new System.Drawing.Point(182, 97);
            this.textBox_RouterNumber.Name = "textBox_RouterNumber";
            this.textBox_RouterNumber.Size = new System.Drawing.Size(186, 20);
            this.textBox_RouterNumber.TabIndex = 5;
            // 
            // button_Istrinti
            // 
            this.button_Istrinti.Location = new System.Drawing.Point(69, 144);
            this.button_Istrinti.Name = "button_Istrinti";
            this.button_Istrinti.Size = new System.Drawing.Size(88, 39);
            this.button_Istrinti.TabIndex = 6;
            this.button_Istrinti.Text = "Ištrinti";
            this.button_Istrinti.UseVisualStyleBackColor = true;
            this.button_Istrinti.Click += new System.EventHandler(this.button_Istrinti_Click);
            // 
            // DeleteRouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 240);
            this.Controls.Add(this.button_Istrinti);
            this.Controls.Add(this.textBox_RouterNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_Atsaukti);
            this.Name = "DeleteRouter";
            this.Text = "DeleteRouter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Atsaukti;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_RouterNumber;
        private System.Windows.Forms.Button button_Istrinti;
    }
}