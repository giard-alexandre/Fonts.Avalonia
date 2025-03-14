using Avalonia.Media.Fonts;

namespace Fonts.Avalonia.Asap;

public class AsapFontCollection : EmbeddedFontCollection {
    public AsapFontCollection() : base(new Uri("fonts:Asap", UriKind.Absolute),
        new Uri("avares://Fonts.Avalonia.Asap/Assets", UriKind.Absolute)) { }
}
