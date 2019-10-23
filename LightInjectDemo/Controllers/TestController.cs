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
			// I would expect that here, _messageProvider.Message would contain the value
			// that was set in Global.asax.cs Application_BeginRequest()
			return $"Message: '{_messageProvider.Message}'";
		}
	}
}
