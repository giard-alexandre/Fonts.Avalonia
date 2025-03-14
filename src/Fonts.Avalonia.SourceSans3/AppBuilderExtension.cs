using Avalonia;

namespace Fonts.Avalonia.SourceSans3;

public static class AppBuilderExtension {
    public static AppBuilder WithSourceSans3Font(this AppBuilder appBuilder) {
        return appBuilder.ConfigureFonts(fontManager => {
            fontManager.AddFontCollection(new SourceSans3FontCollection());
        });
    }
}
