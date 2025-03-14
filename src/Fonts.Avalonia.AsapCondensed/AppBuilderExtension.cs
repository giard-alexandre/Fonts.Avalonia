using Avalonia;

namespace Fonts.Avalonia.AsapCondensed;

public static class AppBuilderExtension {
    public static AppBuilder WithAsapCondensedFont(this AppBuilder appBuilder) {
        return appBuilder.ConfigureFonts(fontManager => {
            fontManager.AddFontCollection(new AsapCondensedFontCollection());
        });
    }
}
