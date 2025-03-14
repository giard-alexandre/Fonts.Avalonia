using Avalonia.Media.Fonts;

namespace Fonts.Avalonia.FiraSansCondensed;

public class FiraSansCondensedFontCollection : EmbeddedFontCollection {
    public FiraSansCondensedFontCollection() : base(new Uri("fonts:FiraSansCondensed", UriKind.Absolute),
        new Uri("avares://Fonts.Avalonia.FiraSansCondensed/Assets", UriKind.Absolute)) { }
}
