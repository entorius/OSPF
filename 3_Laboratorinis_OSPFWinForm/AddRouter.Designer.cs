namespace _3_Laboratorinis_OSPFWinForm
{
    partial class AddRouter
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
            this.RouterId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_RouterId = new System.Windows.Forms.TextBox();
            this.textBox_RouterName = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RouterId
            // 
            this.RouterId.AutoSize = true;
            this.RouterId.Location = new System.Drawing.Point(124, 98);
            this.RouterId.Name = "RouterId";
            this.RouterId.Size = new System.Drawing.Size(59, 13);
            this.RouterId.TabIndex = 0;
            this.RouterId.Tag = "Routerio Id";
            this.RouterId.Text = "Routerio Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Routerio vardas";
            // 
            // textBox_RouterId
            // 
            this.textBox_RouterId.Location = new System.Drawing.Point(221, 95);
            this.textBox_RouterId.Name = "textBox_RouterId";
            this.textBox_RouterId.Size = new System.Drawing.Size(162, 20);
            this.textBox_RouterId.TabIndex = 2;
            // 
            // textBox_RouterName
            // 
            this.textBox_RouterName.Location = new System.Drawing.Point(221, 141);
            this.textBox_RouterName.Name = "textBox_RouterName";
            this.textBox_RouterName.Size = new System.Drawing.Size(162, 20);
            this.textBox_RouterName.TabIndex = 3;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(127, 190);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(98, 42);
            this.button_Add.TabIndex = 4;
            this.button_Add.Text = "Pridėti";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(281, 190);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(102, 42);
            this.button_Close.TabIndex = 5;
            this.button_Close.Text = "Uždaryti";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(167, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pridėti routerį";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Routerio Id formatas : pvz 192.153.124.142";
            // 
            // AddRouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 244);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textBox_RouterName);
            this.Controls.Add(this.textBox_RouterId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RouterId);
            this.Name = "AddRouter";
            this.Text = "AddRoute";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RouterId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_RouterId;
        private System.Windows.Forms.TextBox textBox_RouterName;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}