namespace univercity_management_system
{
    partial class Login
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
            this.txb_LoginId = new System.Windows.Forms.TextBox();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.but_reset = new System.Windows.Forms.Button();
            this.but_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "password";
            // 
            // txb_LoginId
            // 
            this.txb_LoginId.Location = new System.Drawing.Point(151, 84);
            this.txb_LoginId.Name = "txb_LoginId";
            this.txb_LoginId.Size = new System.Drawing.Size(100, 22);
            this.txb_LoginId.TabIndex = 3;
            // 
            // txb_password
            // 
            this.txb_password.Location = new System.Drawing.Point(151, 148);
            this.txb_password.Name = "txb_password";
            this.txb_password.PasswordChar = '*';
            this.txb_password.Size = new System.Drawing.Size(100, 22);
            this.txb_password.TabIndex = 4;
            // 
            // but_reset
            // 
            this.but_reset.Location = new System.Drawing.Point(31, 285);
            this.but_reset.Name = "but_reset";
            this.but_reset.Size = new System.Drawing.Size(75, 23);
            this.but_reset.TabIndex = 5;
            this.but_reset.Text = "reset";
            this.but_reset.UseVisualStyleBackColor = true;
            this.but_reset.Click += new System.EventHandler(this.But_reset_Click);
            // 
            // but_login
            // 
            this.but_login.Location = new System.Drawing.Point(235, 285);
            this.but_login.Name = "but_login";
            this.but_login.Size = new System.Drawing.Size(185, 23);
            this.but_login.TabIndex = 6;
            this.but_login.Text = "Login";
            this.but_login.UseVisualStyleBackColor = false;
            this.but_login.Click += new System.EventHandler(this.But_login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.but_login);
            this.Controls.Add(this.but_reset);
            this.Controls.Add(this.txb_password);
            this.Controls.Add(this.txb_LoginId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_LoginId;
        private System.Windows.Forms.TextBox txb_password;
        private System.Windows.Forms.Button but_reset;
        private System.Windows.Forms.Button but_login;
    }
}