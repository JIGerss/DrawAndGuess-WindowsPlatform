using System;
using System.Drawing;
using System.Windows.Forms;

namespace C_sharp
{
	public partial class FrmMain : Form
	{
		public static int DEFAULTHEIGHT;
		public FrmMain()
		{
			InitializeComponent();
			DEFAULTHEIGHT = Size.Height;
		}

		private void FrmLogin_Load(object sender, EventArgs e)
		{
			var frmRegister = new FrmRegister
			{
				MdiParent = this,
				Parent = plMain
			};
			var frmLogin = new FrmLogin(frmRegister)
			{
				MdiParent = this,
				Parent = plMain
			};
			frmLogin.Show();
		}
	}
}
