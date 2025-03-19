using Avalonia.Media.Fonts;

namespace Fonts.Avalonia.Figtree;

public class FigtreeFontCollection : EmbeddedFontCollection {
    public FigtreeFontCollection() : base(new Uri("fonts:Figtree", UriKind.Absolute),
        new Uri("avares://Fonts.Avalonia.Figtree/Assets", UriKind.Absolute)) { }
}
