﻿namespace CarParkingManagementSystem
{
    partial class formChangePassword
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.cboxShowPass = new System.Windows.Forms.CheckBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtReenterPwd = new System.Windows.Forms.TextBox();
			this.txtNewPwd = new System.Windows.Forms.TextBox();
			this.txtOldPwd = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnMinimize = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.cboxShowPass);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.txtReenterPwd);
			this.panel1.Controls.Add(this.txtNewPwd);
			this.panel1.Controls.Add(this.txtOldPwd);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(550, 337);
			this.panel1.TabIndex = 0;
			// 
			// cboxShowPass
			// 
			this.cboxShowPass.AutoSize = true;
			this.cboxShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboxShowPass.Location = new System.Drawing.Point(392, 245);
			this.cboxShowPass.Name = "cboxShowPass";
			this.cboxShowPass.Size = new System.Drawing.Size(111, 20);
			this.cboxShowPass.TabIndex = 17;
			this.cboxShowPass.Text = "Hiện mật khẩu";
			this.cboxShowPass.UseVisualStyleBackColor = true;
			this.cboxShowPass.CheckedChanged += new System.EventHandler(this.cboxShowPass_CheckedChanged);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnCancel);
			this.panel3.Controls.Add(this.btnSave);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 297);
			this.panel3.Margin = new System.Windows.Forms.Padding(0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(546, 36);
			this.panel3.TabIndex = 16;
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCancel.FlatAppearance.BorderSize = 2;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.btnCancel.Location = new System.Drawing.Point(0, 0);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(273, 36);
			this.btnCancel.TabIndex = 13;
			this.btnCancel.Text = "Hủy";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
			this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnSave.Location = new System.Drawing.Point(273, 0);
			this.btnSave.Margin = new System.Windows.Forms.Padding(0);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(273, 36);
			this.btnSave.TabIndex = 12;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtReenterPwd
			// 
			this.txtReenterPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtReenterPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtReenterPwd.Location = new System.Drawing.Point(230, 185);
			this.txtReenterPwd.Margin = new System.Windows.Forms.Padding(0);
			this.txtReenterPwd.Name = "txtReenterPwd";
			this.txtReenterPwd.Size = new System.Drawing.Size(282, 26);
			this.txtReenterPwd.TabIndex = 13;
			// 
			// txtNewPwd
			// 
			this.txtNewPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtNewPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNewPwd.Location = new System.Drawing.Point(230, 126);
			this.txtNewPwd.Margin = new System.Windows.Forms.Padding(0);
			this.txtNewPwd.Name = "txtNewPwd";
			this.txtNewPwd.Size = new System.Drawing.Size(282, 26);
			this.txtNewPwd.TabIndex = 14;
			// 
			// txtOldPwd
			// 
			this.txtOldPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtOldPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOldPwd.Location = new System.Drawing.Point(230, 68);
			this.txtOldPwd.Margin = new System.Windows.Forms.Padding(0);
			this.txtOldPwd.Name = "txtOldPwd";
			this.txtOldPwd.Size = new System.Drawing.Size(282, 26);
			this.txtOldPwd.TabIndex = 15;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(32, 188);
			this.label3.Margin = new System.Windows.Forms.Padding(0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(153, 20);
			this.label3.TabIndex = 10;
			this.label3.Text = "Nhập lại mật khẩu";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(32, 129);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 20);
			this.label1.TabIndex = 11;
			this.label1.Text = "Mật khẩu mới";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(32, 71);
			this.label4.Margin = new System.Windows.Forms.Padding(0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(107, 20);
			this.label4.TabIndex = 12;
			this.label4.Text = "Mật khẩu cũ";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.SeaGreen;
			this.panel2.Controls.Add(this.btnMinimize);
			this.panel2.Controls.Add(this.btnExit);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(546, 36);
			this.panel2.TabIndex = 0;
			// 
			// btnMinimize
			// 
			this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
			this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Image = global::CarParkingManagementSystem.Properties.Resources.minimize_white;
			this.btnMinimize.Location = new System.Drawing.Point(456, 0);
			this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(45, 36);
			this.btnMinimize.TabIndex = 8;
			this.btnMinimize.UseVisualStyleBackColor = true;
			this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
			// 
			// btnExit
			// 
			this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnExit.FlatAppearance.BorderSize = 0;
			this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Image = global::CarParkingManagementSystem.Properties.Resources.exit_white;
			this.btnExit.Location = new System.Drawing.Point(501, 0);
			this.btnExit.Margin = new System.Windows.Forms.Padding(0);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(45, 36);
			this.btnExit.TabIndex = 7;
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// formChangePassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(550, 337);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "formChangePassword";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "formChangePassword";
			this.Load += new System.EventHandler(this.formChangePassword_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtReenterPwd;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.TextBox txtOldPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cboxShowPass;
    }
}