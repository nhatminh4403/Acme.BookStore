using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Acme.BookStore.Blazor.Client;

public class BookStoreStyleBundleContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        context.Files.Add(new BundleFile("main.css", true));
    }
}
