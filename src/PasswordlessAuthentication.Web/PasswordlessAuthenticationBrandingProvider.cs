using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace PasswordlessAuthentication.Web;

[Dependency(ReplaceServices = true)]
public class PasswordlessAuthenticationBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "PasswordlessAuthentication";
}
