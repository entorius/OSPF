namespace _3_Laboratorinis_OSPFWinForm
{
    partial class AddRoute
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
            this.button_Prideti = new System.Windows.Forms.Button();
            this.button_Atsaukti = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_RouterOne = new System.Windows.Forms.TextBox();
            this.textBox_RouterTwo = new System.Windows.Forms.TextBox();
            this.textBox_Length = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Routers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1 Routerio Numeris";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2 Routerio Numeris";
            // 
            // button_Prideti
            // 
            this.button_Prideti.Location = new System.Drawing.Point(32, 199);
            this.button_Prideti.Name = "button_Prideti";
            this.button_Prideti.Size = new System.Drawing.Size(94, 34);
            this.button_Prideti.TabIndex = 2;
            this.button_Prideti.Text = "Pridėti ";
            this.button_Prideti.UseVisualStyleBackColor = true;
            this.button_Prideti.Click += new System.EventHandler(this.button_Prideti_Click);
            // 
            // button_Atsaukti
            // 
            this.button_Atsaukti.Location = new System.Drawing.Point(386, 199);
            this.button_Atsaukti.Name = "button_Atsaukti";
            this.button_Atsaukti.Size = new System.Drawing.Size(94, 34);
            this.button_Atsaukti.TabIndex = 3;
            this.button_Atsaukti.Text = "Atšaukti";
            this.button_Atsaukti.UseVisualStyleBackColor = true;
            this.button_Atsaukti.Click += new System.EventHandler(this.button_Atsaukti_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ilgis";
            // 
            // textBox_RouterOne
            // 
            this.textBox_RouterOne.Location = new System.Drawing.Point(159, 90);
            this.textBox_RouterOne.Name = "textBox_RouterOne";
            this.textBox_RouterOne.Size = new System.Drawing.Size(154, 20);
            this.textBox_RouterOne.TabIndex = 5;
            // 
            // textBox_RouterTwo
            // 
            this.textBox_RouterTwo.Location = new System.Drawing.Point(159, 122);
            this.textBox_RouterTwo.Name = "textBox_RouterTwo";
            this.textBox_RouterTwo.Size = new System.Drawing.Size(154, 20);
            this.textBox_RouterTwo.TabIndex = 6;
            // 
            // textBox_Length
            // 
            this.textBox_Length.Location = new System.Drawing.Point(159, 150);
            this.textBox_Length.Name = "textBox_Length";
            this.textBox_Length.Size = new System.Drawing.Size(154, 20);
            this.textBox_Length.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.Location = new System.Drawing.Point(194, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kelias";
            // 
            // textBox_Routers
            // 
            this.textBox_Routers.Location = new System.Drawing.Point(364, 12);
            this.textBox_Routers.Multiline = true;
            this.textBox_Routers.Name = "textBox_Routers";
            this.textBox_Routers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Routers.Size = new System.Drawing.Size(116, 157);
            this.textBox_Routers.TabIndex = 9;
            // 
            // AddRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 276);
            this.Controls.Add(this.textBox_Routers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Length);
            this.Controls.Add(this.textBox_RouterTwo);
            this.Controls.Add(this.textBox_RouterOne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Atsaukti);
            this.Controls.Add(this.button_Prideti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddRoute";
            this.Text = "CreateRouter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Prideti;
        private System.Windows.Forms.Button button_Atsaukti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_RouterOne;
        private System.Windows.Forms.TextBox textBox_RouterTwo;
        private System.Windows.Forms.TextBox textBox_Length;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox_Routers;
    }
}