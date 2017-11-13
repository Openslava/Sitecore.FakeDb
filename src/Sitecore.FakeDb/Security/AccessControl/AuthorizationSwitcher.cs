namespace Sitecore.FakeDb.Security.AccessControl
{
  using Sitecore.Security.AccessControl;

  public class AuthorizationSwitcher : ThreadLocalProviderSwitcher<AuthorizationProvider>
  {
    public AuthorizationSwitcher(AuthorizationProvider localProvider)
#if SC90171002
      : base(null, localProvider)
#else
      : base((IThreadLocalProvider<AuthorizationProvider>)AuthorizationManager.Provider, localProvider)
#endif
    {
    }
  }
}
