using Avalonia.Media.Fonts;

namespace Fonts.Avalonia.ClearSans;

public class ClearSansFontCollection : EmbeddedFontCollection {
    public ClearSansFontCollection() : base(new Uri("fonts:ClearSans", UriKind.Absolute),
        new Uri("avares://Fonts.Avalonia.ClearSans/Assets", UriKind.Absolute)) { }
}
