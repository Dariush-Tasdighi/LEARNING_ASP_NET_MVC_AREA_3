namespace LEARNING_AREA.Controllers
{
	public class PageController : System.Web.Mvc.Controller
	{
		public PageController() : base()
		{
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Display(string name)
		{
			return View();
		}
	}
}
