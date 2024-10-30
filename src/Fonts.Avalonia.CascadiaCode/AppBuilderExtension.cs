using Avalonia;

namespace Fonts.Avalonia.CascadiaCode;

public static class AppBuilderExtension {
    public static AppBuilder WithCascadiaCodeFont(this AppBuilder appBuilder) {
        return appBuilder.ConfigureFonts(fontManager => {
            fontManager.AddFontCollection(new CascadiaCodeFontCollection());
        });
    }
}
