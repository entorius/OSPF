namespace _3_Laboratorinis_OSPFWinForm
{
    partial class SendingMessageStates
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
            this.button_DeleteRouter = new System.Windows.Forms.Button();
            this.button_SendToOtherRouter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_DeletingRouterNumber = new System.Windows.Forms.TextBox();
            this.textBox_AllRoutes = new System.Windows.Forms.TextBox();
            this.textBox_AllRouters = new System.Windows.Forms.TextBox();
            this.button_DeleteRoute = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_DeletingRoute = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Way = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_DeleteRouter
            // 
            this.button_DeleteRouter.Location = new System.Drawing.Point(136, 303);
            this.button_DeleteRouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_DeleteRouter.Name = "button_DeleteRouter";
            this.button_DeleteRouter.Size = new System.Drawing.Size(127, 43);
            this.button_DeleteRouter.TabIndex = 0;
            this.button_DeleteRouter.Text = "Ištrinti routerį";
            this.button_DeleteRouter.UseVisualStyleBackColor = true;
            this.button_DeleteRouter.Click += new System.EventHandler(this.button_DeleteRouter_Click);
            // 
            // button_SendToOtherRouter
            // 
            this.button_SendToOtherRouter.Location = new System.Drawing.Point(569, 303);
            this.button_SendToOtherRouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_SendToOtherRouter.Name = "button_SendToOtherRouter";
            this.button_SendToOtherRouter.Size = new System.Drawing.Size(127, 43);
            this.button_SendToOtherRouter.TabIndex = 1;
            this.button_SendToOtherRouter.Text = "Siųsti į kitą routerį";
            this.button_SendToOtherRouter.UseVisualStyleBackColor = true;
            this.button_SendToOtherRouter.Click += new System.EventHandler(this.button_SendToOtherRouter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 226);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trinamo Routerio numeris";
            // 
            // textBox_DeletingRouterNumber
            // 
            this.textBox_DeletingRouterNumber.Location = new System.Drawing.Point(421, 223);
            this.textBox_DeletingRouterNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_DeletingRouterNumber.Name = "textBox_DeletingRouterNumber";
            this.textBox_DeletingRouterNumber.Size = new System.Drawing.Size(273, 22);
            this.textBox_DeletingRouterNumber.TabIndex = 3;
            // 
            // textBox_AllRoutes
            // 
            this.textBox_AllRoutes.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_AllRoutes.Enabled = false;
            this.textBox_AllRoutes.Location = new System.Drawing.Point(136, 100);
            this.textBox_AllRoutes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_AllRoutes.Multiline = true;
            this.textBox_AllRoutes.Name = "textBox_AllRoutes";
            this.textBox_AllRoutes.ReadOnly = true;
            this.textBox_AllRoutes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_AllRoutes.Size = new System.Drawing.Size(256, 115);
            this.textBox_AllRoutes.TabIndex = 4;
            // 
            // textBox_AllRouters
            // 
            this.textBox_AllRouters.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_AllRouters.Location = new System.Drawing.Point(421, 100);
            this.textBox_AllRouters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_AllRouters.Multiline = true;
            this.textBox_AllRouters.Name = "textBox_AllRouters";
            this.textBox_AllRouters.ReadOnly = true;
            this.textBox_AllRouters.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_AllRouters.Size = new System.Drawing.Size(273, 115);
            this.textBox_AllRouters.TabIndex = 5;
            // 
            // button_DeleteRoute
            // 
            this.button_DeleteRoute.Location = new System.Drawing.Point(355, 303);
            this.button_DeleteRoute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_DeleteRoute.Name = "button_DeleteRoute";
            this.button_DeleteRoute.Size = new System.Drawing.Size(127, 43);
            this.button_DeleteRoute.TabIndex = 6;
            this.button_DeleteRoute.Text = "Ištrinti kelią";
            this.button_DeleteRoute.UseVisualStyleBackColor = true;
            this.button_DeleteRoute.Click += new System.EventHandler(this.button_DeleteRoute_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Visi routeriai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Visi keliai";
            // 
            // textBox_DeletingRoute
            // 
            this.textBox_DeletingRoute.Location = new System.Drawing.Point(421, 255);
            this.textBox_DeletingRoute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_DeletingRoute.Name = "textBox_DeletingRoute";
            this.textBox_DeletingRoute.Size = new System.Drawing.Size(273, 22);
            this.textBox_DeletingRoute.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Trinamo kelio numeris";
            // 
            // textBox_Way
            // 
            this.textBox_Way.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_Way.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.textBox_Way.ForeColor = System.Drawing.Color.Black;
            this.textBox_Way.Location = new System.Drawing.Point(758, 100);
            this.textBox_Way.Multiline = true;
            this.textBox_Way.Name = "textBox_Way";
            this.textBox_Way.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Way.Size = new System.Drawing.Size(273, 115);
            this.textBox_Way.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(755, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dabartinis kelias";
            // 
            // SendingMessageStates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Way);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_DeletingRoute);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_DeleteRoute);
            this.Controls.Add(this.textBox_AllRouters);
            this.Controls.Add(this.textBox_AllRoutes);
            this.Controls.Add(this.textBox_DeletingRouterNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_SendToOtherRouter);
            this.Controls.Add(this.button_DeleteRouter);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SendingMessageStates";
            this.Text = "SendingMessageStates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_DeleteRouter;
        private System.Windows.Forms.Button button_SendToOtherRouter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_DeletingRouterNumber;
        private System.Windows.Forms.TextBox textBox_AllRoutes;
        private System.Windows.Forms.TextBox textBox_AllRouters;
        private System.Windows.Forms.Button button_DeleteRoute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_DeletingRoute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Way;
        private System.Windows.Forms.Label label5;
    }
}