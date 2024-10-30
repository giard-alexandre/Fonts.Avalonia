using Avalonia;

namespace Fonts.Avalonia.FiraSansExtraCondensed;

public static class AppBuilderExtension {
    public static AppBuilder WithFiraSansExtraCondensedFont(this AppBuilder appBuilder) {
        return appBuilder.ConfigureFonts(fontManager => {
            fontManager.AddFontCollection(new FiraSansExtraCondensedFontCollection());
        });
    }
}
