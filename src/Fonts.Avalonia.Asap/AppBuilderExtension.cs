using Avalonia;

namespace Fonts.Avalonia.Asap;

public static class AppBuilderExtension {
    public static AppBuilder WithAsapFont(this AppBuilder appBuilder) {
        return appBuilder.ConfigureFonts(fontManager => {
            fontManager.AddFontCollection(new AsapFontCollection());
        });
    }
}
