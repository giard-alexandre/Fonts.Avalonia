using Avalonia;

namespace Fonts.Avalonia.Iosevka;

public static class AppBuilderExtension {
    public static AppBuilder WithIosevkaFont(this AppBuilder appBuilder) {
        return appBuilder.ConfigureFonts(fontManager => {
            fontManager.AddFontCollection(new IosevkaFontCollection());
        });
    }
}
