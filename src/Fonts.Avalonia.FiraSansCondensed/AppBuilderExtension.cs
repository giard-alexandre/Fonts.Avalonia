using Avalonia;

namespace Fonts.Avalonia.FiraSansCondensed;

public static class AppBuilderExtension {
    public static AppBuilder WithFiraSansCondensedFont(this AppBuilder appBuilder) {
        return appBuilder.ConfigureFonts(fontManager => {
            fontManager.AddFontCollection(new FiraSansCondensedFontCollection());
        });
    }
}
