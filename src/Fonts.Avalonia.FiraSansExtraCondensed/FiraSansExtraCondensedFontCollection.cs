using Avalonia.Media.Fonts;

namespace Fonts.Avalonia.FiraSansExtraCondensed;

public class FiraSansExtraCondensedFontCollection : EmbeddedFontCollection {
    public FiraSansExtraCondensedFontCollection() : base(new Uri("fonts:FiraSansExtraCondensed", UriKind.Absolute),
        new Uri("avares://Fonts.Avalonia.FiraSansExtraCondensed/Assets", UriKind.Absolute)) { }
}
