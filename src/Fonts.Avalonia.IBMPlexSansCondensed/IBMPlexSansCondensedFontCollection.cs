using Avalonia.Media.Fonts;

namespace Fonts.Avalonia.IBMPlexSansCondensed;

public class IBMPlexSansCondensedFontCollection : EmbeddedFontCollection {
    public IBMPlexSansCondensedFontCollection() : base(new Uri("fonts:IBMPlexSansCondensed", UriKind.Absolute),
        new Uri("avares://Fonts.Avalonia.IBMPlexSansCondensed/Assets", UriKind.Absolute)) { }
}
