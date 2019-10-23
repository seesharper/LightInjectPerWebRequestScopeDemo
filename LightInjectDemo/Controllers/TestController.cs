using System.Web.Http;

namespace LightInjectDemo.Controllers
{
	[RoutePrefix("api")]
	public class TestController : ApiController
	{
		private readonly IMessageProvider _messageProvider;

		public TestController(IMessageProvider messageProvider)
		{
			_messageProvider = messageProvider;
		}

		[Route("message")]
		[HttpGet]
		public string Message()
		{
			return $"Message: '{_messageProvider.Message}'";
		}
	}
}
