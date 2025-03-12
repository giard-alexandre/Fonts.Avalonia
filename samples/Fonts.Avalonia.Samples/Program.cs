using Avalonia;

using System;

using Fonts.Avalonia.CascadiaCode;
using Fonts.Avalonia.FiraSansExtraCondensed;
using Fonts.Avalonia.Iosevka;
using Fonts.Avalonia.JetBrainsMono;
using Fonts.Avalonia.Lato;
using Fonts.Avalonia.Oswald;

namespace Fonts.Avalonia.Samples;

class Program {
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void Main(string[] args) => BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp() =>
        AppBuilder.Configure<App>().UsePlatformDetect()
            .WithInterFont()
            .WithCascadiaCodeFont()
            .WithFiraSansExtraCondensedFont()
            .WithIosevkaFont()
            .WithJetBrainsMonoFont()
            .WithLatoFont()
            .WithOswaldFont()
            .LogToTrace();
}
