using System;
using System.IO;
using System.Net;
using System.Text;

namespace C_sharp.Classes
{
	public class HttpRequest
	{
		private static string mainUrl = "http://www.franky.pro:8090";
		/// <summary>
		/// 发送Get请求
		/// </summary>
		/// <param name="Url"></param>
		/// <returns></returns>
		public static JsonResponse Get(string Url)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(mainUrl + Url);
			request.Method = "GET";
			HttpWebResponse response;
			try { response = (HttpWebResponse)request.GetResponse(); }
			catch (WebException ex) { response = (HttpWebResponse)ex.Response; }
			int statusCode = Convert.ToInt32(response.StatusCode);
			string json = null;
			using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
			{
				json = reader.ReadToEnd();
			}
			response.Close();
			return new JsonResponse(statusCode, json);
		}
		/// <summary>
		/// 发送POST请求
		/// </summary>
		/// <param name="Url"></param>
		/// <param name="body"></param>
		/// <returns></returns>
		public static JsonResponse Post(string Url, string body)
		{
			try
			{
				HttpWebRequest request = WebRequest.Create(mainUrl + Url) as HttpWebRequest;
				request.Method = "POST";
				byte[] data = Encoding.UTF8.GetBytes(body);
				using (Stream stream = request.GetRequestStream())
				{
					stream.Write(data, 0, data.Length);
				}
				HttpWebResponse response;
				try { response = (HttpWebResponse)request.GetResponse(); }
				catch (WebException ex) { response = (HttpWebResponse)ex.Response; }
				int statusCode = Convert.ToInt32(response.StatusCode);
				string json = null;
				using (StreamReader myStreamReader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
				{
					json = myStreamReader.ReadToEnd();
				}
				response.Close();
				return new JsonResponse(statusCode, json);
			}
			catch (WebException e)
			{
				return new JsonResponse(404, e.Message);
			}
		}
		/// <summary>
		/// 发送DELETE请求
		/// </summary>
		/// <param name="url"></param>
		/// <param name="body"></param>
		/// <returns></returns>
		public static JsonResponse DELETE(string url)
		{
			try
			{
				HttpWebRequest request = WebRequest.Create(mainUrl + url) as HttpWebRequest;
				request.Method = "DELETE";
				HttpWebResponse response;
				try { response = (HttpWebResponse)request.GetResponse(); }
				catch (WebException ex) { response = (HttpWebResponse)ex.Response; }
				int statusCode = Convert.ToInt32(response.StatusCode);
				string json = null;
				using (StreamReader myStreamReader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
				{
					json = myStreamReader.ReadToEnd();
				}
				response.Close();
				return new JsonResponse(statusCode, json);
			}
			catch (WebException e)
			{
				return new JsonResponse(404, e.Message);
			}
		}
	}
}
