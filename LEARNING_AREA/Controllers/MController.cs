using System.Linq;
//using System.Data.Entity;

namespace LEARNING_AREA.Controllers
{
	public class MController : System.Web.Mvc.Controller
	{
		public MController() : base()
		{
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult N()
		{
			return View();
		}
	}
}
