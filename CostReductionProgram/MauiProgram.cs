using Microsoft.Maui.LifecycleEvents;

namespace CostReductionProgram
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

//#if WINDOWS
//            builder.ConfigureLifecycleEvents(events =>
//            {
//                events.AddWindows(wndLifeCycleBuilder =>
//                {
//                    wndLifeCycleBuilder.OnWindowCreated(window =>
//                    {
//                        window.ExtendsContentIntoTitleBar = false;
//                        IntPtr hWnd = WinRT.Interop.WindowNative.GetWindowHandle(window);
//                        Microsoft.UI.WindowId myWndId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hWnd);
//                        var _appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(myWndId);
//                        _appWindow.SetPresenter(Microsoft.UI.Windowing.AppWindowPresenterKind.FullScreen);
//                    });
//                });
//            });
//#endif

//#if DEBUG
//            builder.Logging.AddDebug();
//#endif

            return builder.Build();
        }
    }
}
