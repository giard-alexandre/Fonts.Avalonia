using Avalonia;

namespace Fonts.Avalonia.Figtree;

public static class AppBuilderExtension {
    public static AppBuilder WithFigtreeFont(this AppBuilder appBuilder) {
        return appBuilder.ConfigureFonts(fontManager => {
            fontManager.AddFontCollection(new FigtreeFontCollection());
        });
    }
}
