using Avalonia;

namespace Fonts.Avalonia.RobotoCondensed;

public static class AppBuilderExtension {
    public static AppBuilder WithRobotoCondensedFont(this AppBuilder appBuilder) {
        return appBuilder.ConfigureFonts(fontManager => {
            fontManager.AddFontCollection(new RobotoCondensedFontCollection());
        });
    }
}
