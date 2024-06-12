using Avalonia.Media.Fonts;

namespace Fonts.Avalonia.JetbrainsMono;

public class JetBrainsMonoFontCollection : EmbeddedFontCollection {
	public JetBrainsMonoFontCollection() : base(new Uri("fonts:JetBrainsMono", UriKind.Absolute),
		new Uri("avares://Fonts.Avalonia.JetbrainsMono/Assets", UriKind.Absolute)) { }
}
