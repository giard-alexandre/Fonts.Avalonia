using Avalonia;

using System;

using Fonts.Avalonia.Asap;
using Fonts.Avalonia.AsapSemiCondensed;
using Fonts.Avalonia.CascadiaCode;
using Fonts.Avalonia.FiraSansCondensed;
using Fonts.Avalonia.FiraSansExtraCondensed;
using Fonts.Avalonia.Iosevka;
using Fonts.Avalonia.JetBrainsMono;
using Fonts.Avalonia.Lato;
using Fonts.Avalonia.Oswald;
using Fonts.Avalonia.RobotoCondensed;

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
            .WithAsapFont()
            .WithAsapSemiCondensedFont()
            .WithCascadiaCodeFont()
            .WithFiraSansExtraCondensedFont()
            .WithFiraSansCondensedFont()
            .WithIosevkaFont()
            .WithJetBrainsMonoFont()
            .WithLatoFont()
            .WithOswaldFont()
            .WithRobotoCondensedFont()
            .LogToTrace();
}
