using Avalonia;

namespace Fonts.Avalonia.PtRootUi;

public static class AppBuilderExtension {
    public static AppBuilder WithPtRootUiFont(this AppBuilder appBuilder) {
        return appBuilder.ConfigureFonts(fontManager => {
            fontManager.AddFontCollection(new PtRootUiFontCollection());
        });
    }
}
