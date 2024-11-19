using Papa.Services;
using Papa.Services.Abstractions;
using Umbraco.Cms.Core.Composing;

namespace Papa.Web.Composers;

public class RegisterSiteServicesComposer : IComposer
{
    public void Compose(IUmbracoBuilder builder)
    {
        builder.Services.AddScoped<ISiteService, SiteService>();
    }
}