using Avalonia;

namespace Fonts.Avalonia.JetbrainsMono;

public static class AppBuilderExtension {
    public static AppBuilder WithJetBrainsMonoFont(this AppBuilder appBuilder) {
        return appBuilder.ConfigureFonts(fontManager => {
            fontManager.AddFontCollection(new JetBrainsMonoFontCollection());
        });
    }
}
