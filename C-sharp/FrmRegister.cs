using C_sharp.Classes;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp
{
	public partial class FrmRegister : Form
	{
		public TextBox tbAccount;
		string Code;
		public FrmRegister()
		{
			InitializeComponent();
		}

		private void btConfirm_Click(object sender, EventArgs e)
		{
			btConfirm.Enabled = false;
			var account = tbRegisterAccount.Text.Trim();
			var password = tbRegisterPassword.Text.Trim();
			var repeat = tbRegisterRepeat.Text.Trim();
			var inputCode = tbCode.Text.Trim();
			Task<JsonResponse> httpRequest = Task.Run(() =>
			{
				if (!Tools.CompareCode(inputCode, Code)) return new JsonResponse(400, "验证码错误");
				else if (!password.Equals(repeat))
					return new JsonResponse(400, "密码不一致");
				else if (account == "" || password == "" || repeat == "")
					return new JsonResponse(400, "用户名或者密码不能为空");
				password = Tools.ToMD5string(password);
				return HttpRequest.Post("/users/reg/" + account + "/" + password, "");
			});
			var awaiter = httpRequest.GetAwaiter();
			awaiter.OnCompleted(() =>
			{
				var result = awaiter.GetResult();
				if (result.StatusCode == 200)
				{
					MessageBox.Show("注册成功！", "你画我猜 -注册提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					btBack_Click("",null);
				}
				else
				{
					MessageBox.Show(result.Json, "你画我猜 -注册提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					Tools.SetCode(4, pbCode, ref Code);
					tbCode.Text = null;
				}
				btConfirm.Enabled = true;
			});
		}

		private void btBack_Click(object sender, EventArgs e)
		{
			ParentForm.Size = new Size(Width, FrmMain.DEFAULTHEIGHT);
			tbAccount.Text = tbRegisterAccount.Text;
			Visible = false;
		}

		private void pbCode_Click(object sender, EventArgs e) => Tools.SetCode(4, pbCode, ref Code);

		public new void Show()
		{
			tbCode.Text = null;
			tbRegisterAccount.Text = null;
			tbRegisterPassword.Text = null;
			tbRegisterRepeat.Text = null;
			Tools.SetCode(4, pbCode, ref Code);
			Visible = true;
		}
	}
}
