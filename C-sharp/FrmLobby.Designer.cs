namespace C_sharp
{
	partial class FrmLobby
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLobby));
			this.SuspendLayout();
			// 
			// FrmLobby
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmLobby";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "你画我猜 -大厅";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLobby_FormClosed);
			this.Load += new System.EventHandler(this.FrmLobby_Load);
			this.ResumeLayout(false);

		}

		#endregion
	}
}