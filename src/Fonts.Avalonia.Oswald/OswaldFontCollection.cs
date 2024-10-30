using Avalonia.Media.Fonts;

namespace Fonts.Avalonia.Oswald;

public class OswaldFontCollection : EmbeddedFontCollection {
    public OswaldFontCollection() : base(new Uri("fonts:Oswald", UriKind.Absolute),
        new Uri("avares://Fonts.Avalonia.Oswald/Assets", UriKind.Absolute)) { }
}
