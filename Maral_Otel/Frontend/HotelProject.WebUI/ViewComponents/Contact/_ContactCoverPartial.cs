using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HotelProject.WebUI.ViewComponents.Contact
{
    public class _ContactCoverPartial:ViewComponent
    {
        public  IViewComponentResult Invoke()
        {
            return View();

        }
    }
}
