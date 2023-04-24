using Gecko;
using System;

namespace GeckofxUnitTests
{
    internal class GeckoWebBrowser : IDisposable
    {
        internal static string Handle;
        internal static class NavigateFinishedNotifier
        { 
        }

        internal static class Window
        {
            internal static GeckoWindow DomWindow;
        }

        internal void CreateControl()
        {
            throw new NotImplementedException();
        }

        internal void Dispose()
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }

        internal void Navigate(string v)
        {
            throw new NotImplementedException();
        }
    }
}