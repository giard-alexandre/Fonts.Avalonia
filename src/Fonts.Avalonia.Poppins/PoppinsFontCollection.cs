using Avalonia.Media.Fonts;

namespace Fonts.Avalonia.Poppins;

public class PoppinsFontCollection : EmbeddedFontCollection {
    public PoppinsFontCollection() : base(new Uri("fonts:Poppins", UriKind.Absolute),
        new Uri("avares://Fonts.Avalonia.Poppins/Assets", UriKind.Absolute)) { }
}
