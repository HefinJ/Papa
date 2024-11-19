using Papa.Services.Abstractions;
using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;
using Umbraco.Extensions;

namespace Papa.Services;

public class SiteService : ISiteService 
{
    private readonly IPublishedContentQuery _contentQuery;
    private readonly IVariationContextAccessor _variationContextAccessor;

    public SiteService(IPublishedContentQuery contentQuery, IVariationContextAccessor variationContextAccessor)
    {
        _contentQuery = contentQuery;
        _variationContextAccessor = variationContextAccessor;
    }

    public string? GetSiteName() 
    {
        var siteRoot = _contentQuery.ContentAtRoot().FirstOrDefault();
        var siteSettings = siteRoot?.FirstChild<Settings>(_variationContextAccessor);

        return siteSettings?.SiteName;
    }
}