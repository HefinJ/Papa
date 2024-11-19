using Microsoft.AspNetCore.Mvc;

namespace Papa.Web.ViewComponents;

public class NavigationViewComponent : ViewComponent 
{
    public async Task<IViewComponentResult> InvokeAsync() 
    {
        return View();
    }
}