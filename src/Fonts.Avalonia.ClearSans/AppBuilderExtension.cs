using Avalonia;

namespace Fonts.Avalonia.ClearSans;

public static class AppBuilderExtension {
    public static AppBuilder WithClearSansFont(this AppBuilder appBuilder) {
        return appBuilder.ConfigureFonts(fontManager => {
            fontManager.AddFontCollection(new ClearSansFontCollection());
        });
    }
}
