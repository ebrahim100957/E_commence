namespace univercity_management_system
{
    partial class Mainform
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_pass = new System.Windows.Forms.Label();
            this.lb_role = new System.Windows.Forms.Label();
            this.txb_username = new System.Windows.Forms.TextBox();
            this.txb_role = new System.Windows.Forms.TextBox();
            this.txb_pass = new System.Windows.Forms.TextBox();
            this.but_add = new System.Windows.Forms.Button();
            this.but_update = new System.Windows.Forms.Button();
            this.but_delete = new System.Windows.Forms.Button();
            this.but_clear = new System.Windows.Forms.Button();
            this.dvg_user_info = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_controls = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_user_info)).BeginInit();
            this.pnl_controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Users Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "users informations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID:";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(20, 0);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(69, 17);
            this.lb_id.TabIndex = 4;
            this.lb_id.Text = "automatic";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(25, 113);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(89, 17);
            this.lb_username.TabIndex = 5;
            this.lb_username.Text = "USERNAME:";
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.Location = new System.Drawing.Point(25, 173);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(88, 17);
            this.lb_pass.TabIndex = 6;
            this.lb_pass.Text = "PASSWORD";
            this.lb_pass.Click += new System.EventHandler(this.Label6_Click);
            // 
            // lb_role
            // 
            this.lb_role.AutoSize = true;
            this.lb_role.Location = new System.Drawing.Point(25, 233);
            this.lb_role.Name = "lb_role";
            this.lb_role.Size = new System.Drawing.Size(46, 17);
            this.lb_role.TabIndex = 7;
            this.lb_role.Text = "ROLE";
            // 
            // txb_username
            // 
            this.txb_username.Location = new System.Drawing.Point(23, 43);
            this.txb_username.Name = "txb_username";
            this.txb_username.Size = new System.Drawing.Size(481, 22);
            this.txb_username.TabIndex = 8;
            // 
            // txb_role
            // 
            this.txb_role.Location = new System.Drawing.Point(23, 160);
            this.txb_role.Name = "txb_role";
            this.txb_role.Size = new System.Drawing.Size(481, 22);
            this.txb_role.TabIndex = 9;
            // 
            // txb_pass
            // 
            this.txb_pass.Location = new System.Drawing.Point(23, 103);
            this.txb_pass.Name = "txb_pass";
            this.txb_pass.Size = new System.Drawing.Size(481, 22);
            this.txb_pass.TabIndex = 10;
            // 
            // but_add
            // 
            this.but_add.Location = new System.Drawing.Point(142, 284);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(75, 23);
            this.but_add.TabIndex = 11;
            this.but_add.Text = "add";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.But_add_Click);
            // 
            // but_update
            // 
            this.but_update.Location = new System.Drawing.Point(254, 284);
            this.but_update.Name = "but_update";
            this.but_update.Size = new System.Drawing.Size(75, 23);
            this.but_update.TabIndex = 12;
            this.but_update.Text = "update";
            this.but_update.UseVisualStyleBackColor = true;
            this.but_update.Click += new System.EventHandler(this.But_update_Click);
            // 
            // but_delete
            // 
            this.but_delete.Location = new System.Drawing.Point(370, 284);
            this.but_delete.Name = "but_delete";
            this.but_delete.Size = new System.Drawing.Size(75, 23);
            this.but_delete.TabIndex = 13;
            this.but_delete.Text = "delete";
            this.but_delete.UseVisualStyleBackColor = true;
            this.but_delete.Click += new System.EventHandler(this.But_delete_Click);
            // 
            // but_clear
            // 
            this.but_clear.Location = new System.Drawing.Point(495, 284);
            this.but_clear.Name = "but_clear";
            this.but_clear.Size = new System.Drawing.Size(75, 23);
            this.but_clear.TabIndex = 14;
            this.but_clear.Text = "clear";
            this.but_clear.UseVisualStyleBackColor = true;
            this.but_clear.Click += new System.EventHandler(this.But_clear_Click);
            // 
            // dvg_user_info
            // 
            this.dvg_user_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_user_info.Location = new System.Drawing.Point(28, 361);
            this.dvg_user_info.Name = "dvg_user_info";
            this.dvg_user_info.RowTemplate.Height = 24;
            this.dvg_user_info.Size = new System.Drawing.Size(882, 172);
            this.dvg_user_info.TabIndex = 15;
            this.dvg_user_info.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dvg_user_info_RowHeaderMouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(309, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "choose which user you want to update or delete";
            // 
            // pnl_controls
            // 
            this.pnl_controls.Controls.Add(this.lb_id);
            this.pnl_controls.Controls.Add(this.txb_username);
            this.pnl_controls.Controls.Add(this.txb_role);
            this.pnl_controls.Controls.Add(this.txb_pass);
            this.pnl_controls.Location = new System.Drawing.Point(119, 70);
            this.pnl_controls.Name = "pnl_controls";
            this.pnl_controls.Size = new System.Drawing.Size(509, 191);
            this.pnl_controls.TabIndex = 17;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 629);
            this.Controls.Add(this.pnl_controls);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dvg_user_info);
            this.Controls.Add(this.but_clear);
            this.Controls.Add(this.but_delete);
            this.Controls.Add(this.but_update);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.lb_role);
            this.Controls.Add(this.lb_pass);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mainform";
            this.Text = "Mainform";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainform_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_user_info)).EndInit();
            this.pnl_controls.ResumeLayout(false);
            this.pnl_controls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.Label lb_role;
        private System.Windows.Forms.TextBox txb_username;
        private System.Windows.Forms.TextBox txb_role;
        private System.Windows.Forms.TextBox txb_pass;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Button but_update;
        private System.Windows.Forms.Button but_delete;
        private System.Windows.Forms.Button but_clear;
        private System.Windows.Forms.DataGridView dvg_user_info;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnl_controls;
    }
}

