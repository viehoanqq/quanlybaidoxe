﻿namespace CarParkingManagementSystem
{
	partial class formCustomer
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dtgChitietCanhan = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnReload = new System.Windows.Forms.Button();
			this.btnFind = new System.Windows.Forms.Button();
			this.txtFind = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgChitietCanhan)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dtgChitietCanhan);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(9, 20);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(737, 533);
			this.panel1.TabIndex = 18;
			// 
			// dtgChitietCanhan
			// 
			this.dtgChitietCanhan.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgChitietCanhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dtgChitietCanhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgChitietCanhan.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtgChitietCanhan.Location = new System.Drawing.Point(0, 34);
			this.dtgChitietCanhan.Margin = new System.Windows.Forms.Padding(0);
			this.dtgChitietCanhan.Name = "dtgChitietCanhan";
			this.dtgChitietCanhan.RowHeadersWidth = 51;
			this.dtgChitietCanhan.Size = new System.Drawing.Size(737, 499);
			this.dtgChitietCanhan.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnSave);
			this.panel2.Controls.Add(this.btnAdd);
			this.panel2.Controls.Add(this.btnEdit);
			this.panel2.Controls.Add(this.btnDelete);
			this.panel2.Controls.Add(this.btnReload);
			this.panel2.Controls.Add(this.btnFind);
			this.panel2.Controls.Add(this.txtFind);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(737, 34);
			this.panel2.TabIndex = 0;
			// 
			// btnSave
			// 
			this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
			this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnSave.Image = global::CarParkingManagementSystem.Properties.Resources.save1;
			this.btnSave.Location = new System.Drawing.Point(598, 0);
			this.btnSave.Margin = new System.Windows.Forms.Padding(0);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(35, 27);
			this.btnSave.TabIndex = 21;
			this.btnSave.Text = "+";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
			this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnAdd.Location = new System.Drawing.Point(632, 0);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(35, 27);
			this.btnAdd.TabIndex = 19;
			this.btnAdd.Text = "+";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnEdit.BackColor = System.Drawing.Color.SeaGreen;
			this.btnEdit.FlatAppearance.BorderSize = 0;
			this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
			this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnEdit.Image = global::CarParkingManagementSystem.Properties.Resources.edit__1_;
			this.btnEdit.Location = new System.Drawing.Point(667, 0);
			this.btnEdit.Margin = new System.Windows.Forms.Padding(0);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(35, 27);
			this.btnEdit.TabIndex = 19;
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
			this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnDelete.Image = global::CarParkingManagementSystem.Properties.Resources.delete__1_;
			this.btnDelete.Location = new System.Drawing.Point(702, 0);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(35, 27);
			this.btnDelete.TabIndex = 19;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnReload
			// 
			this.btnReload.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnReload.BackColor = System.Drawing.Color.SeaGreen;
			this.btnReload.FlatAppearance.BorderSize = 0;
			this.btnReload.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
			this.btnReload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
			this.btnReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
			this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReload.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReload.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnReload.Image = global::CarParkingManagementSystem.Properties.Resources.reload;
			this.btnReload.Location = new System.Drawing.Point(345, 0);
			this.btnReload.Margin = new System.Windows.Forms.Padding(0);
			this.btnReload.Name = "btnReload";
			this.btnReload.Size = new System.Drawing.Size(35, 27);
			this.btnReload.TabIndex = 19;
			this.btnReload.UseVisualStyleBackColor = false;
			this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
			// 
			// btnFind
			// 
			this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnFind.BackColor = System.Drawing.Color.SeaGreen;
			this.btnFind.FlatAppearance.BorderSize = 0;
			this.btnFind.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
			this.btnFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
			this.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
			this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFind.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFind.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnFind.Image = global::CarParkingManagementSystem.Properties.Resources.find;
			this.btnFind.Location = new System.Drawing.Point(307, 0);
			this.btnFind.Margin = new System.Windows.Forms.Padding(0);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(35, 27);
			this.btnFind.TabIndex = 19;
			this.btnFind.UseVisualStyleBackColor = false;
			// 
			// txtFind
			// 
			this.txtFind.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFind.Location = new System.Drawing.Point(50, 0);
			this.txtFind.Margin = new System.Windows.Forms.Padding(0);
			this.txtFind.Name = "txtFind";
			this.txtFind.Size = new System.Drawing.Size(254, 26);
			this.txtFind.TabIndex = 18;
			this.txtFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyUp);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
			this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(0, 5);
			this.label4.Margin = new System.Windows.Forms.Padding(0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 18);
			this.label4.TabIndex = 17;
			this.label4.Text = "tìm";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// formCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(774, 587);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "formCustomer";
			this.Text = "formCustomer";
			this.Load += new System.EventHandler(this.formCustomer_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtgChitietCanhan)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dtgChitietCanhan;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnReload;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.TextBox txtFind;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnSave;
	}
}