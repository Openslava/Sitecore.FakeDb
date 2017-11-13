namespace Sitecore.FakeDb.Security.Accounts
{
  using Sitecore.Security.Accounts;

  public class RolesInRolesSwitcher : ThreadLocalProviderSwitcher<RolesInRolesProvider>
  {
    public RolesInRolesSwitcher(RolesInRolesProvider localProvider)
#if SC90171002
      : base(null, localProvider)
#else
      : base((IThreadLocalProvider<RolesInRolesProvider>)RolesInRolesManager.Provider, localProvider)
#endif
    {
    }
  }
}