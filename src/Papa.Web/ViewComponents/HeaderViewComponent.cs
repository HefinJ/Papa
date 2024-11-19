using Microsoft.AspNetCore.Mvc;
using Papa.Services.Abstractions;
using Papa.Web.ViewModels;

namespace Papa.Web.ViewComponents;
public class HeaderViewComponent : ViewComponent
{
    private readonly ISiteService _siteService;

    public HeaderViewComponent(ISiteService siteService)
    {
        _siteService = siteService;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var viewModel = new HeaderViewModel();

        viewModel.SiteName = _siteService.GetSiteName();

        return View(viewModel);
    }
}