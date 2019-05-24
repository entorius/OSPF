namespace _3_Laboratorinis_OSPFWinForm
{
    partial class SendMessage
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
            this.button_Send = new System.Windows.Forms.Button();
            this.textBox_StartRouter = new System.Windows.Forms.TextBox();
            this.textBox_EndingRouter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.textBox_Message = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(147, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Išsiūsti žinutę";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pradžios routerio numeris";
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(79, 220);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(92, 39);
            this.button_Send.TabIndex = 2;
            this.button_Send.Text = "Siųsti";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // textBox_StartRouter
            // 
            this.textBox_StartRouter.Location = new System.Drawing.Point(217, 97);
            this.textBox_StartRouter.Name = "textBox_StartRouter";
            this.textBox_StartRouter.Size = new System.Drawing.Size(127, 20);
            this.textBox_StartRouter.TabIndex = 3;
            // 
            // textBox_EndingRouter
            // 
            this.textBox_EndingRouter.Location = new System.Drawing.Point(217, 142);
            this.textBox_EndingRouter.Name = "textBox_EndingRouter";
            this.textBox_EndingRouter.Size = new System.Drawing.Size(127, 20);
            this.textBox_EndingRouter.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pabaigos routerio numeris";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button_Cancel.Location = new System.Drawing.Point(252, 220);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(92, 39);
            this.button_Cancel.TabIndex = 6;
            this.button_Cancel.Text = "Atšaukti";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // textBox_Message
            // 
            this.textBox_Message.Location = new System.Drawing.Point(217, 183);
            this.textBox_Message.Name = "textBox_Message";
            this.textBox_Message.Size = new System.Drawing.Size(127, 20);
            this.textBox_Message.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Žinutė";
            // 
            // SendMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 283);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Message);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_EndingRouter);
            this.Controls.Add(this.textBox_StartRouter);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SendMessage";
            this.Text = "SendMessage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.TextBox textBox_StartRouter;
        private System.Windows.Forms.TextBox textBox_EndingRouter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.TextBox textBox_Message;
        private System.Windows.Forms.Label label4;
    }
}