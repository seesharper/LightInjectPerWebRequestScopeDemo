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
			var injected = WebApiConfig.ServiceContainer.GetInstance<IMessageProvider>();
			injected.Message = "From Global.asax Application_BeginRequest";
		}
	}
}
