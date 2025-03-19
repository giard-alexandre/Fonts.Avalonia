using Avalonia.Media.Fonts;

namespace Fonts.Avalonia.PtRootUi;

public class PtRootUiFontCollection : EmbeddedFontCollection {
    public PtRootUiFontCollection() : base(new Uri("fonts:PtRootUi", UriKind.Absolute),
        new Uri("avares://Fonts.Avalonia.PtRootUi/Assets", UriKind.Absolute)) { }
}
