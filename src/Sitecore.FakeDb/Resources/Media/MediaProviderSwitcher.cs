namespace Sitecore.FakeDb.Resources.Media
{
  using Sitecore.Resources.Media;

  public class MediaProviderSwitcher : ThreadLocalProviderSwitcher<MediaProvider>
  {
    public MediaProviderSwitcher(MediaProvider innerProvider)
#if SC90171002
      : base(null, innerProvider)
#else
      : base((IThreadLocalProvider<MediaProvider>)MediaManager.Provider, innerProvider)
#endif
    {
    }
  }
}