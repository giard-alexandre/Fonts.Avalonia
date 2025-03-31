using Avalonia.Media.Fonts;

namespace Fonts.Avalonia.PublicSans;

public class PublicSansFontCollection : EmbeddedFontCollection {
    public PublicSansFontCollection() : base(new Uri("fonts:PublicSans", UriKind.Absolute),
        new Uri("avares://Fonts.Avalonia.PublicSans/Assets", UriKind.Absolute)) { }
}
