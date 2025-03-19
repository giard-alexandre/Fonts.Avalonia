using Avalonia;

namespace Fonts.Avalonia.Lexend;

public static class AppBuilderExtension {
    public static AppBuilder WithLexendFont(this AppBuilder appBuilder) {
        return appBuilder.ConfigureFonts(fontManager => {
            fontManager.AddFontCollection(new LexendFontCollection());
        });
    }
}
