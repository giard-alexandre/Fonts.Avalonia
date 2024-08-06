using Avalonia.Media.Fonts;

namespace Fonts.Avalonia.JetBrainsMono;

public class JetBrainsMonoFontCollection : EmbeddedFontCollection {
    public JetBrainsMonoFontCollection() : base(new Uri("fonts:JetBrainsMono", UriKind.Absolute),
        new Uri("avares://Fonts.Avalonia.JetBrainsMono/Assets", UriKind.Absolute)) { }
}
