namespace LEARNING_AREA.Areas.Administrator
{
	public class AdministratorAreaRegistration : System.Web.Mvc.AreaRegistration
	{
		public AdministratorAreaRegistration() : base()
		{
		}

		public override string AreaName
		{
			get
			{
				return "Administrator";
			}
		}

		public override void RegisterArea(System.Web.Mvc.AreaRegistrationContext context)
		{
			//context.MapRoute(
			//	name: "Administrator_Default",
			//	url: "Administrator/{controller}/{action}/{id}",
			//	defaults: new { action = "Index", id = System.Web.Mvc.UrlParameter.Optional }
			//);

			context.MapRoute(
				name: "Administrator_Default",
				url: "Administrator/{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = System.Web.Mvc.UrlParameter.Optional },
				namespaces: new[] { "LEARNING_AREA.Areas.Administrator.Controllers" }
			);
		}
	}
}
