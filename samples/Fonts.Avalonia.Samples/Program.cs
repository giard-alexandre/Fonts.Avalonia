using Avalonia;

using System;

using Fonts.Avalonia.Asap;
using Fonts.Avalonia.AsapCondensed;
using Fonts.Avalonia.AsapSemiCondensed;
using Fonts.Avalonia.CascadiaCode;
using Fonts.Avalonia.ClearSans;
using Fonts.Avalonia.Figtree;
using Fonts.Avalonia.FiraSansCondensed;
using Fonts.Avalonia.FiraSansExtraCondensed;
using Fonts.Avalonia.IBMPlexSansCondensed;
using Fonts.Avalonia.Iosevka;
using Fonts.Avalonia.JetBrainsMono;
using Fonts.Avalonia.Lato;
using Fonts.Avalonia.Lexend;
using Fonts.Avalonia.Manrope;
using Fonts.Avalonia.Oswald;
using Fonts.Avalonia.PtRootUi;
using Fonts.Avalonia.RobotoCondensed;
using Fonts.Avalonia.SourceSans3;

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
            .WithAsapCondensedFont()
            .WithCascadiaCodeFont()
            .WithFiraSansExtraCondensedFont()
            .WithFiraSansCondensedFont()
            .WithIosevkaFont()
            .WithJetBrainsMonoFont()
            .WithLatoFont()
            .WithOswaldFont()
            .WithRobotoCondensedFont()
            .WithSourceSans3Font()
            .WithClearSansFont()
            .WithFigtreeFont()
            .WithIBMPlexSansCondensedFont()
            .WithLexendFont()
            .WithManropeFont()
            .WithPtRootUiFont()
            .LogToTrace();
}
