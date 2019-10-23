using System.Web.Http;
using LightInject;
using LightInjectDemo.Controllers;

namespace LightInjectDemo
{
	public static class AssemblyRegistry
	{
		public static ServiceContainer Register(ServiceContainer container)
		{
			container.RegisterApiControllers();
			container.Register<IMessageProvider, MessageProvider>(new PerScopeLifetime());

			container.EnablePerWebRequestScope();
			container.EnableWebApi(GlobalConfiguration.Configuration);

			return container;
		}
	}
}