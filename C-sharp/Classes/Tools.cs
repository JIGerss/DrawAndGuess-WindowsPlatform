using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace C_sharp.Classes
{
	public class Tools
	{
		/// <summary>
		/// MD5加密字符串
		/// </summary>
		/// <param name="strText">需要加密的字符串</param>
		/// <returns>加密过的字符串</returns>
		public static string ToMD5string(string strText)
		{
			string rule = "";
			MD5 md5 = MD5.Create();
			byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(strText));
			for (int i = 0; i < s.Length; i++)
			{
				rule = rule + s[i].ToString("x2"); // 将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符 
			}
			return rule;
		}
		/// <summary>
		/// 生成验证码
		/// </summary>
		/// <param name="length"></param>
		/// <param name="pictureBox"></param>
		public static void SetCode(int length, PictureBox pictureBox, ref string code)
		{
			code = "";
			Random r = new Random((int)DateTime.Now.Ticks);
			for (int i = 0; i < length; i++)
			{
				int type = r.Next(0, 2);//存在两次
				if (type == 0)
				{
					code += r.Next(0, 9);
				}
				else if (type == 1)
				{
					code += (char)r.Next(97, 123);
				}
			}
			if (string.IsNullOrWhiteSpace(code))
			{
				return;
			}
			Bitmap img = new Bitmap(code.Length * 20 + 10, 40);
			Graphics graphics = Graphics.FromImage(img);
			graphics.Clear(Color.White);
			Pen pen = new Pen(Color.Black, 1);
			graphics.DrawRectangle(pen, 0, 0, img.Width - 1, img.Height - 1);
			for (int i = 0; i < code.Length; i++)
			{
				Pen p = new Pen(Color.FromArgb(r.Next(255), r.Next(255), r.Next(255)), r.Next(1, 2));//画线
				graphics.DrawLine(p, r.Next(0, img.Width), r.Next(0, img.Height), r.Next(img.Width), r.Next(0, img.Height));//线段的两个点
			}
			graphics.DrawString(code, new Font("宋体", 20, FontStyle.Italic | FontStyle.Bold), new SolidBrush(Color.FromArgb(r.Next(255), r.Next(255), r.Next(255))), new Point(5, 5));
			for (int i = 0; i < code.Length * 20; i++)
			{
				graphics.FillEllipse(new SolidBrush(Color.FromArgb(r.Next(255), r.Next(255), r.Next(255))), r.Next(0, img.Width), r.Next(0, img.Height), 2, 2);//绘制小圆点
			}
			pictureBox.Image = img;
		}
		/// <summary>
		/// 比对不分大小写的验证码
		/// </summary>
		/// <param name="inputCode"></param>
		/// <param name="code"></param>
		/// <returns></returns>
		public static bool CompareCode(string inputCode, string code) => inputCode.ToUpper().Equals(code.ToUpper());
	}
}
