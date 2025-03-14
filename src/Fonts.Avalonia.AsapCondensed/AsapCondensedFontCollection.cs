using Avalonia.Media.Fonts;

namespace Fonts.Avalonia.AsapCondensed;

public class AsapCondensedFontCollection : EmbeddedFontCollection {
    public AsapCondensedFontCollection() : base(new Uri("fonts:AsapCondensed", UriKind.Absolute),
        new Uri("avares://Fonts.Avalonia.AsapCondensed/Assets", UriKind.Absolute)) { }
}
