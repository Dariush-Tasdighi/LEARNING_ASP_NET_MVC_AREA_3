using System.Web.Mvc;

namespace LEARNING_AREA
{
	public static class RouteConfig
	{
		static RouteConfig()
		{
		}

		public static void RegisterRoutes(System.Web.Routing.RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			// ترتيب نوشتن اهميت دارد
			// و بايد دستورات استثناء ذيل، قبل از دستور پيش فرض اصلی نوشته شوند

			routes.MapRoute(
				name: "SomeName1",
				url: "A/B",
				defaults: new { controller = "M", action = "N" },
				namespaces: new[] { "LEARNING_AREA.Controllers" }
			);














			routes.MapRoute(
				name: "SomeName2",
				url: "Page/{name}",
				defaults: new { controller = "Page", action = "Display", name = System.Web.Mvc.UrlParameter.Optional },
				namespaces: new[] { "LEARNING_AREA.Controllers" }
			);

			//routes.MapRoute(
			//	name: "Default",
			//	url: "{controller}/{action}/{id}",
			//	defaults: new { controller = "Home", action = "Index", id = System.Web.Mvc.UrlParameter.Optional }
			//);

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = System.Web.Mvc.UrlParameter.Optional },
				namespaces: new[] { "LEARNING_AREA.Controllers" }
			);
		}
	}
}
