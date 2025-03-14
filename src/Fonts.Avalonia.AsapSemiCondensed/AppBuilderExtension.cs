using Avalonia;

namespace Fonts.Avalonia.AsapSemiCondensed;

public static class AppBuilderExtension {
    public static AppBuilder WithAsapSemiCondensedFont(this AppBuilder appBuilder) {
        return appBuilder.ConfigureFonts(fontManager => {
            fontManager.AddFontCollection(new AsapSemiCondensedFontCollection());
        });
    }
}
