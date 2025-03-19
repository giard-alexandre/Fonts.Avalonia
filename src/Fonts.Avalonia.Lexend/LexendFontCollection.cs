using Avalonia.Media.Fonts;

namespace Fonts.Avalonia.Lexend;

public class LexendFontCollection : EmbeddedFontCollection {
    public LexendFontCollection() : base(new Uri("fonts:Lexend", UriKind.Absolute),
        new Uri("avares://Fonts.Avalonia.Lexend/Assets", UriKind.Absolute)) { }
}
