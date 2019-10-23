using System.Web.Http;
using LightInject;

namespace LightInjectDemo
{
	public static class WebApiConfig
	{
		private static ServiceContainer _serviceContainer;
		public static ServiceContainer ServiceContainer => _serviceContainer;

		public static void Register(HttpConfiguration config)
		{
			config.MapHttpAttributeRoutes();
			if (_serviceContainer == null)
			{
				_serviceContainer = new ServiceContainer();
			}
			_serviceContainer = AssemblyRegistry.Register(_serviceContainer);
		}
	}
}
