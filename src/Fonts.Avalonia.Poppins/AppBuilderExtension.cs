using Avalonia;

namespace Fonts.Avalonia.Poppins;

public static class AppBuilderExtension {
    public static AppBuilder WithPoppinsFont(this AppBuilder appBuilder) {
        return appBuilder.ConfigureFonts(fontManager => {
            fontManager.AddFontCollection(new PoppinsFontCollection());
        });
    }
}
