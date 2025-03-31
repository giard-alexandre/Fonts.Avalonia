using Avalonia.Media.Fonts;

namespace Fonts.Avalonia.Overpass;

public class OverpassFontCollection : EmbeddedFontCollection {
    public OverpassFontCollection() : base(new Uri("fonts:Overpass", UriKind.Absolute),
        new Uri("avares://Fonts.Avalonia.Overpass/Assets", UriKind.Absolute)) { }
}
