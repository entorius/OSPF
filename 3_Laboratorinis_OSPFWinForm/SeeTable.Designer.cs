namespace _3_Laboratorinis_OSPFWinForm
{
    partial class SeeTable
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
            this.button_Parodyti = new System.Windows.Forms.Button();
            this.button_Atsaukti = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_RouterNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Parodyti
            // 
            this.button_Parodyti.Location = new System.Drawing.Point(83, 151);
            this.button_Parodyti.Name = "button_Parodyti";
            this.button_Parodyti.Size = new System.Drawing.Size(89, 40);
            this.button_Parodyti.TabIndex = 0;
            this.button_Parodyti.Text = "Parodyti";
            this.button_Parodyti.UseVisualStyleBackColor = true;
            this.button_Parodyti.Click += new System.EventHandler(this.button_Parodyti_Click);
            // 
            // button_Atsaukti
            // 
            this.button_Atsaukti.Location = new System.Drawing.Point(301, 151);
            this.button_Atsaukti.Name = "button_Atsaukti";
            this.button_Atsaukti.Size = new System.Drawing.Size(89, 40);
            this.button_Atsaukti.TabIndex = 1;
            this.button_Atsaukti.Text = "Atšaukti";
            this.button_Atsaukti.UseVisualStyleBackColor = true;
            this.button_Atsaukti.Click += new System.EventHandler(this.button_Atsaukti_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(133, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kurio routerio lentele parodyti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Routerio numeris";
            // 
            // textBox_RouterNumber
            // 
            this.textBox_RouterNumber.Location = new System.Drawing.Point(209, 102);
            this.textBox_RouterNumber.Name = "textBox_RouterNumber";
            this.textBox_RouterNumber.Size = new System.Drawing.Size(181, 20);
            this.textBox_RouterNumber.TabIndex = 4;
            // 
            // SeeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 277);
            this.Controls.Add(this.textBox_RouterNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Atsaukti);
            this.Controls.Add(this.button_Parodyti);
            this.Name = "SeeTable";
            this.Text = "SeeTable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Parodyti;
        private System.Windows.Forms.Button button_Atsaukti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_RouterNumber;
    }
}