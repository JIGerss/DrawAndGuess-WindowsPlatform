namespace C_sharp
{
	partial class FrmRegister
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
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbRegisterRepeat = new System.Windows.Forms.TextBox();
			this.tbRegisterPassword = new System.Windows.Forms.TextBox();
			this.tbRegisterAccount = new System.Windows.Forms.TextBox();
			this.btConfirm = new System.Windows.Forms.Button();
			this.btBack = new System.Windows.Forms.Button();
			this.pbCode = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbCode = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbCode)).BeginInit();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(52, 217);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 27);
			this.label3.TabIndex = 15;
			this.label3.Text = "确认密码：";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(70, 97);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 27);
			this.label1.TabIndex = 14;
			this.label1.Text = "用户名：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(90, 157);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 27);
			this.label2.TabIndex = 13;
			this.label2.Text = "密码：";
			// 
			// tbRegisterRepeat
			// 
			this.tbRegisterRepeat.Font = new System.Drawing.Font("等线", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tbRegisterRepeat.Location = new System.Drawing.Point(170, 217);
			this.tbRegisterRepeat.MaxLength = 20;
			this.tbRegisterRepeat.Multiline = true;
			this.tbRegisterRepeat.Name = "tbRegisterRepeat";
			this.tbRegisterRepeat.PasswordChar = '•';
			this.tbRegisterRepeat.ShortcutsEnabled = false;
			this.tbRegisterRepeat.Size = new System.Drawing.Size(239, 35);
			this.tbRegisterRepeat.TabIndex = 14;
			this.tbRegisterRepeat.WordWrap = false;
			// 
			// tbRegisterPassword
			// 
			this.tbRegisterPassword.Font = new System.Drawing.Font("等线", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tbRegisterPassword.Location = new System.Drawing.Point(168, 157);
			this.tbRegisterPassword.MaxLength = 20;
			this.tbRegisterPassword.Multiline = true;
			this.tbRegisterPassword.Name = "tbRegisterPassword";
			this.tbRegisterPassword.PasswordChar = '•';
			this.tbRegisterPassword.ShortcutsEnabled = false;
			this.tbRegisterPassword.Size = new System.Drawing.Size(239, 35);
			this.tbRegisterPassword.TabIndex = 13;
			this.tbRegisterPassword.WordWrap = false;
			// 
			// tbRegisterAccount
			// 
			this.tbRegisterAccount.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tbRegisterAccount.Location = new System.Drawing.Point(168, 97);
			this.tbRegisterAccount.MaxLength = 10;
			this.tbRegisterAccount.Multiline = true;
			this.tbRegisterAccount.Name = "tbRegisterAccount";
			this.tbRegisterAccount.Size = new System.Drawing.Size(239, 35);
			this.tbRegisterAccount.TabIndex = 12;
			this.tbRegisterAccount.WordWrap = false;
			// 
			// btConfirm
			// 
			this.btConfirm.BackColor = System.Drawing.SystemColors.Window;
			this.btConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btConfirm.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btConfirm.Location = new System.Drawing.Point(96, 414);
			this.btConfirm.Name = "btConfirm";
			this.btConfirm.Size = new System.Drawing.Size(121, 36);
			this.btConfirm.TabIndex = 10;
			this.btConfirm.Text = "注册";
			this.btConfirm.UseVisualStyleBackColor = false;
			this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
			// 
			// btBack
			// 
			this.btBack.BackColor = System.Drawing.SystemColors.Window;
			this.btBack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btBack.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btBack.Location = new System.Drawing.Point(288, 414);
			this.btBack.Name = "btBack";
			this.btBack.Size = new System.Drawing.Size(121, 36);
			this.btBack.TabIndex = 11;
			this.btBack.Text = "返回";
			this.btBack.UseVisualStyleBackColor = false;
			this.btBack.Click += new System.EventHandler(this.btBack_Click);
			// 
			// pbCode
			// 
			this.pbCode.Location = new System.Drawing.Point(170, 283);
			this.pbCode.Name = "pbCode";
			this.pbCode.Size = new System.Drawing.Size(116, 40);
			this.pbCode.TabIndex = 18;
			this.pbCode.TabStop = false;
			this.pbCode.Click += new System.EventHandler(this.pbCode_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label4.Location = new System.Drawing.Point(72, 283);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 27);
			this.label4.TabIndex = 20;
			this.label4.Text = "验证码：";
			// 
			// tbCode
			// 
			this.tbCode.Font = new System.Drawing.Font("等线", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tbCode.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tbCode.Location = new System.Drawing.Point(292, 288);
			this.tbCode.MaxLength = 4;
			this.tbCode.Multiline = true;
			this.tbCode.Name = "tbCode";
			this.tbCode.ShortcutsEnabled = false;
			this.tbCode.Size = new System.Drawing.Size(117, 35);
			this.tbCode.TabIndex = 15;
			this.tbCode.WordWrap = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label5.Location = new System.Drawing.Point(167, 328);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(161, 14);
			this.label5.TabIndex = 22;
			this.label5.Text = "看不清？点击图片换一张";
			// 
			// FrmRegister
			// 
			this.AcceptButton = this.btConfirm;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(521, 535);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbCode);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.pbCode);
			this.Controls.Add(this.btBack);
			this.Controls.Add(this.btConfirm);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbRegisterRepeat);
			this.Controls.Add(this.tbRegisterPassword);
			this.Controls.Add(this.tbRegisterAccount);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmRegister";
			this.Text = "FrmRegister";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.pbCode)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbRegisterRepeat;
		private System.Windows.Forms.TextBox tbRegisterPassword;
		private System.Windows.Forms.TextBox tbRegisterAccount;
		private System.Windows.Forms.Button btConfirm;
		private System.Windows.Forms.Button btBack;
		private System.Windows.Forms.PictureBox pbCode;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbCode;
		private System.Windows.Forms.Label label5;
	}
}