using Avalonia.Media.Fonts;

namespace Fonts.Avalonia.AsapSemiCondensed;

public class AsapSemiCondensedFontCollection : EmbeddedFontCollection {
    public AsapSemiCondensedFontCollection() : base(new Uri("fonts:AsapSemiCondensed", UriKind.Absolute),
        new Uri("avares://Fonts.Avalonia.AsapSemiCondensed/Assets", UriKind.Absolute)) { }
}
