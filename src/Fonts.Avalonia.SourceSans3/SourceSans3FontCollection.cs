using Avalonia.Media.Fonts;

namespace Fonts.Avalonia.SourceSans3;

public class SourceSans3FontCollection : EmbeddedFontCollection {
    public SourceSans3FontCollection() : base(new Uri("fonts:SourceSans3", UriKind.Absolute),
        new Uri("avares://Fonts.Avalonia.SourceSans3/Assets", UriKind.Absolute)) { }
}
