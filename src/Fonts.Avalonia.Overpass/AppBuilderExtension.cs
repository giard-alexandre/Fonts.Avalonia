using Avalonia;

namespace Fonts.Avalonia.Overpass;

public static class AppBuilderExtension {
    public static AppBuilder WithOverpassFont(this AppBuilder appBuilder) {
        return appBuilder.ConfigureFonts(fontManager => {
            fontManager.AddFontCollection(new OverpassFontCollection());
        });
    }
}
