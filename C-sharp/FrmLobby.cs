using System.Windows.Forms;
using C_sharp.Structures;
using C_sharp.Classes;
using Newtonsoft.Json;
using System;

namespace C_sharp
{
	public partial class FrmLobby : Form
	{
		User player;
		public FrmLobby(string json)
		{
			InitializeComponent();
			player = JsonConvert.DeserializeObject<User>(json);
		}

		private void FrmLobby_Load(object sender, EventArgs e)
		{

		}

		private void FrmLobby_FormClosed(object sender, FormClosedEventArgs e)
		{
			HttpRequest.DELETE("/users/logout/"  + player.UserName + "/" + player.UserId);
		}
	}
}
