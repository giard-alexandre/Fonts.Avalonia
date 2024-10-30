using Avalonia;

namespace Fonts.Avalonia.Oswald;

public static class AppBuilderExtension {
    public static AppBuilder WithOswaldFont(this AppBuilder appBuilder) {
        return appBuilder.ConfigureFonts(fontManager => {
            fontManager.AddFontCollection(new OswaldFontCollection());
        });
    }
}
