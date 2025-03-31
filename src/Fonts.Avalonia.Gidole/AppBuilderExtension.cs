using Avalonia;

namespace Fonts.Avalonia.Gidole;

public static class AppBuilderExtension {
    public static AppBuilder WithGidoleFont(this AppBuilder appBuilder) {
        return appBuilder.ConfigureFonts(fontManager => {
            fontManager.AddFontCollection(new GidoleFontCollection());
        });
    }
}
