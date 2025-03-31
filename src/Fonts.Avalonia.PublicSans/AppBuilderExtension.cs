using Avalonia;

namespace Fonts.Avalonia.PublicSans;

public static class AppBuilderExtension {
    public static AppBuilder WithPublicSansFont(this AppBuilder appBuilder) {
        return appBuilder.ConfigureFonts(fontManager => {
            fontManager.AddFontCollection(new PublicSansFontCollection());
        });
    }
}
