namespace C_sharp.Classes
{
	public class JsonResponse
	{
		public int StatusCode { get; set; }
		public string Json { get; set; }
		public JsonResponse(int statusCode, string json)
		{
			StatusCode = statusCode;
			Json = json;
		}

		public JsonResponse()
		{

		}
	}
}
