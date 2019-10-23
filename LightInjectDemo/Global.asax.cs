using System.Web.Http;
using LightInject;
using LightInjectDemo.Controllers;

namespace LightInjectDemo
{
	public class WebApiApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			GlobalConfiguration.Configure(WebApiConfig.Register);
		}

		protected void Application_BeginRequest()
		{
			// I would expect that this value would be consistently anywhere that I get
			// an instance of `IMessageProvider` (assuming it's not re-set elsewhere)
			var injected = WebApiConfig.ServiceContainer.GetInstance<IMessageProvider>();
			injected.Message = "From Global.asax Application_BeginRequest";
		}
	}
}
