using Avalonia.Media.Fonts;

namespace Fonts.Avalonia.Gidole;

public class GidoleFontCollection : EmbeddedFontCollection {
    public GidoleFontCollection() : base(new Uri("fonts:Gidole", UriKind.Absolute),
        new Uri("avares://Fonts.Avalonia.Gidole/Assets", UriKind.Absolute)) { }
}
