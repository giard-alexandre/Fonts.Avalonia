using Avalonia.Media.Fonts;

namespace Fonts.Avalonia.Manrope;

public class ManropeFontCollection : EmbeddedFontCollection {
    public ManropeFontCollection() : base(new Uri("fonts:Manrope", UriKind.Absolute),
        new Uri("avares://Fonts.Avalonia.Manrope/Assets", UriKind.Absolute)) { }
}
