namespace MauiNet7Test;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("MyCustomization", (handler, view) =>
        {
#if ANDROID
            handler.PlatformView.SetPadding(0, 0, 0, 0);
#endif
        });

        MainPage = new AppShell();
	}
}
