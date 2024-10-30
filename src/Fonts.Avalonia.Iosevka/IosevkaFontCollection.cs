using Avalonia.Media.Fonts;

namespace Fonts.Avalonia.Iosevka;

public class IosevkaFontCollection : EmbeddedFontCollection {
    public IosevkaFontCollection() : base(new Uri("fonts:Iosevka", UriKind.Absolute),
        new Uri("avares://Fonts.Avalonia.Iosevka/Assets", UriKind.Absolute)) { }
}
