using Avalonia.Media.Fonts;

namespace Fonts.Avalonia.CascadiaCode;

public class CascadiaCodeFontCollection : EmbeddedFontCollection {
    public CascadiaCodeFontCollection() : base(new Uri("fonts:Cascadia Code", UriKind.Absolute),
        new Uri("avares://Fonts.Avalonia.CascadiaCode/Assets", UriKind.Absolute)) { }
}
