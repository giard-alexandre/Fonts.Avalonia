using Avalonia.Media.Fonts;

namespace Fonts.Avalonia.Lato;

public class LatoFontCollection : EmbeddedFontCollection {
    public LatoFontCollection() : base(new Uri("fonts:Lato", UriKind.Absolute),
        new Uri("avares://Fonts.Avalonia.Lato/Assets", UriKind.Absolute)) { }
}
