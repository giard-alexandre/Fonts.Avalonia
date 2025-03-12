using Avalonia.Media.Fonts;

namespace Fonts.Avalonia.RobotoCondensed;

public class RobotoCondensedFontCollection : EmbeddedFontCollection {
    public RobotoCondensedFontCollection() : base(new Uri("fonts:RobotoCondensed", UriKind.Absolute),
        new Uri("avares://Fonts.Avalonia.RobotoCondensed/Assets", UriKind.Absolute)) { }
}
