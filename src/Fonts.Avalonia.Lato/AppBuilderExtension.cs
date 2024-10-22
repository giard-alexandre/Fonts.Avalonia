using Avalonia;

namespace Fonts.Avalonia.Lato;

public static class AppBuilderExtension {
    public static AppBuilder WithJetBrainsMonoFont(this AppBuilder appBuilder) {
        return appBuilder.ConfigureFonts(fontManager => {
            fontManager.AddFontCollection(new LatoFontCollection());
        });
    }
}
