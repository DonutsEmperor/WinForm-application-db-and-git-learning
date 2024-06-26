﻿namespace MyWinFormsAppForDb
{
	partial class Entrance
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btn_entrance = new Button();
			txtBx_db = new TextBox();
			txtBx_login = new TextBox();
			txtBx_password = new TextBox();
			lbl_desc_1 = new Label();
			label1 = new Label();
			label2 = new Label();
			SuspendLayout();
			// 
			// btn_entrance
			// 
			btn_entrance.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btn_entrance.Location = new Point(244, 279);
			btn_entrance.Margin = new Padding(3, 2, 3, 2);
			btn_entrance.Name = "btn_entrance";
			btn_entrance.Size = new Size(175, 38);
			btn_entrance.TabIndex = 0;
			btn_entrance.Text = "Enter";
			btn_entrance.UseVisualStyleBackColor = true;
			btn_entrance.Click += btn_entrance_Click;
			// 
			// txtBx_db
			// 
			txtBx_db.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			txtBx_db.Location = new Point(164, 73);
			txtBx_db.Margin = new Padding(3, 2, 3, 2);
			txtBx_db.Name = "txtBx_db";
			txtBx_db.ReadOnly = true;
			txtBx_db.Size = new Size(335, 30);
			txtBx_db.TabIndex = 1;
			txtBx_db.TextAlign = HorizontalAlignment.Center;
			// 
			// txtBx_login
			// 
			txtBx_login.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			txtBx_login.Location = new Point(164, 148);
			txtBx_login.Margin = new Padding(3, 2, 3, 2);
			txtBx_login.Name = "txtBx_login";
			txtBx_login.Size = new Size(335, 30);
			txtBx_login.TabIndex = 2;
			txtBx_login.TextAlign = HorizontalAlignment.Center;
			// 
			// txtBx_password
			// 
			txtBx_password.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			txtBx_password.Location = new Point(164, 223);
			txtBx_password.Margin = new Padding(3, 2, 3, 2);
			txtBx_password.Name = "txtBx_password";
			txtBx_password.Size = new Size(335, 30);
			txtBx_password.TabIndex = 3;
			txtBx_password.TextAlign = HorizontalAlignment.Center;
			// 
			// lbl_desc_1
			// 
			lbl_desc_1.AutoSize = true;
			lbl_desc_1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_desc_1.Location = new Point(254, 47);
			lbl_desc_1.Name = "lbl_desc_1";
			lbl_desc_1.Size = new Size(155, 23);
			lbl_desc_1.TabIndex = 4;
			lbl_desc_1.Text = "Current database";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(252, 123);
			label1.Name = "label1";
			label1.Size = new Size(159, 23);
			label1.TabIndex = 5;
			label1.Text = "Inscribe you login";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(234, 197);
			label2.Name = "label2";
			label2.Size = new Size(195, 23);
			label2.TabIndex = 6;
			label2.Text = "Inscribe the password";
			// 
			// Entrance
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ButtonShadow;
			ClientSize = new Size(684, 361);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(lbl_desc_1);
			Controls.Add(txtBx_password);
			Controls.Add(txtBx_login);
			Controls.Add(txtBx_db);
			Controls.Add(btn_entrance);
			Margin = new Padding(3, 2, 3, 2);
			Name = "Entrance";
			Text = "Authorization";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btn_entrance;
		private TextBox txtBx_db;
		private TextBox txtBx_login;
		private TextBox txtBx_password;
		private Label lbl_desc_1;
		private Label label1;
		private Label label2;
	}
}