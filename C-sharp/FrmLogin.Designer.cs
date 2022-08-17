namespace C_sharp
{
	partial class FrmLogin
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
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.tbAccount = new System.Windows.Forms.TextBox();
			this.btRegister = new System.Windows.Forms.Button();
			this.btLogin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(90, 157);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 27);
			this.label2.TabIndex = 17;
			this.label2.Text = "密码：";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(70, 97);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 27);
			this.label1.TabIndex = 16;
			this.label1.Text = "用户名：";
			// 
			// tbPassword
			// 
			this.tbPassword.Font = new System.Drawing.Font("等线", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tbPassword.Location = new System.Drawing.Point(168, 157);
			this.tbPassword.MaxLength = 20;
			this.tbPassword.Multiline = true;
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '•';
			this.tbPassword.ShortcutsEnabled = false;
			this.tbPassword.Size = new System.Drawing.Size(239, 35);
			this.tbPassword.TabIndex = 14;
			this.tbPassword.WordWrap = false;
			// 
			// tbAccount
			// 
			this.tbAccount.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tbAccount.Location = new System.Drawing.Point(168, 97);
			this.tbAccount.MaxLength = 10;
			this.tbAccount.Multiline = true;
			this.tbAccount.Name = "tbAccount";
			this.tbAccount.Size = new System.Drawing.Size(239, 35);
			this.tbAccount.TabIndex = 15;
			this.tbAccount.WordWrap = false;
			// 
			// btRegister
			// 
			this.btRegister.BackColor = System.Drawing.SystemColors.Window;
			this.btRegister.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btRegister.Location = new System.Drawing.Point(300, 249);
			this.btRegister.Name = "btRegister";
			this.btRegister.Size = new System.Drawing.Size(121, 36);
			this.btRegister.TabIndex = 13;
			this.btRegister.Text = "注册";
			this.btRegister.UseVisualStyleBackColor = false;
			this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
			// 
			// btLogin
			// 
			this.btLogin.BackColor = System.Drawing.SystemColors.Window;
			this.btLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btLogin.Location = new System.Drawing.Point(119, 249);
			this.btLogin.Name = "btLogin";
			this.btLogin.Size = new System.Drawing.Size(121, 36);
			this.btLogin.TabIndex = 12;
			this.btLogin.Text = "登录";
			this.btLogin.UseVisualStyleBackColor = false;
			this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
			// 
			// FrmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(521, 372);
			this.Controls.Add(this.tbAccount);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.btRegister);
			this.Controls.Add(this.btLogin);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmLogin";
			this.Text = "FrmLogin";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.TextBox tbAccount;
		private System.Windows.Forms.Button btRegister;
		private System.Windows.Forms.Button btLogin;
	}
}