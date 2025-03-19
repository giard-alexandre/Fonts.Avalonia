using Avalonia;

namespace Fonts.Avalonia.Manrope;

public static class AppBuilderExtension {
    public static AppBuilder WithManropeFont(this AppBuilder appBuilder) {
        return appBuilder.ConfigureFonts(fontManager => {
            fontManager.AddFontCollection(new ManropeFontCollection());
        });
    }
}
