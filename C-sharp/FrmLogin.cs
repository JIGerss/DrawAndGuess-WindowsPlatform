using C_sharp.Classes;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp
{
	public partial class FrmLogin : Form
	{
		FrmRegister frmRegister;
		public FrmLogin(FrmRegister frmRegister)
		{
			InitializeComponent();
			this.frmRegister = frmRegister;
			this.frmRegister.tbAccount = tbAccount;
		}

		private void btLogin_Click(object sender, EventArgs e)
		{
			btLogin.Enabled = false;
			var account = tbAccount.Text.Trim();
			var password = tbPassword.Text.Trim();
			Task<JsonResponse> httpRequest = Task.Run(() =>
			{
				if (account == "" || password == "")
					return new JsonResponse(400, "用户名或者密码不能为空");
				password = Tools.ToMD5string(password);
				return HttpRequest.Post("/users/login/" + account + "/" + password, "");
			});
			var awaiter = httpRequest.GetAwaiter();
			awaiter.OnCompleted(() =>
			{
				var result = awaiter.GetResult();
				if (result.StatusCode == 200)
				{
					var frmLobby = new FrmLobby(result.Json);
					new Thread(() =>
					{
						frmLobby.ShowDialog();
					}).Start();
					ParentForm.Close();
				}
				else
				{
					MessageBox.Show(result.Json, "你画我猜 -登录提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					tbPassword.Text = null;
				}
				btLogin.Enabled = true;
			});
		}

		private void btRegister_Click(object sender, EventArgs e)
		{
			ParentForm.Size = new Size(Width, frmRegister.Height);
			frmRegister.Show();
		}
	}
}
