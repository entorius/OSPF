namespace _3_Laboratorinis_OSPFWinForm
{
    public partial class Consolecs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            this.textBox_Console = new System.Windows.Forms.TextBox();
            this.label_Console = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Console
            // 
            this.textBox_Console.Location = new System.Drawing.Point(33, 75);
            this.textBox_Console.Multiline = true;
            this.textBox_Console.Name = "textBox_Console";
            this.textBox_Console.Size = new System.Drawing.Size(728, 331);
            this.textBox_Console.TabIndex = 0;
            // 
            // label_Console
            // 
            this.label_Console.AutoSize = true;
            this.label_Console.Font = new System.Drawing.Font("Open Sans ExtraBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label_Console.Location = new System.Drawing.Point(323, 9);
            this.label_Console.Name = "label_Console";
            this.label_Console.Size = new System.Drawing.Size(162, 47);
            this.label_Console.TabIndex = 1;
            this.label_Console.Text = "Console";
            // 
            // Consolecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Console);
            this.Controls.Add(this.textBox_Console);
            this.Name = "Consolecs";
            this.Text = "Consolecs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBox_Console;
        private System.Windows.Forms.Label label_Console;
    }
}