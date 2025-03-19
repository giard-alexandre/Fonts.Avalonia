using Avalonia;

namespace Fonts.Avalonia.IBMPlexSansCondensed;

public static class AppBuilderExtension {
    // ReSharper disable once InconsistentNaming
    public static AppBuilder WithIBMPlexSansCondensedFont(this AppBuilder appBuilder) {
        return appBuilder.ConfigureFonts(fontManager => {
            fontManager.AddFontCollection(new IBMPlexSansCondensedFontCollection());
        });
    }
}
