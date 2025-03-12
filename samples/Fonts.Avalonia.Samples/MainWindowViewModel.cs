using Avalonia.Media;

using ReactiveUI;

namespace Fonts.Avalonia.Samples;

public class MainWindowViewModel : ReactiveObject {
    public List<FontInfo> Fonts { get; } = [
        new("Inter", "fonts:Inter#Inter, $Default"),
        new("CascadiaCode", "fonts:CascadiaCode#CascadiaCode, $Default"),
        new("FiraSansExtraCondensed", "fonts:FiraSansExtraCondensed#Fira Sans Extra Condensed, $Default"),
        new("Iosevka", "fonts:Iosevka#Iosevka, $Default"),
        new("JetbrainsMono", "fonts:JetBrainsMono#JetBrains Mono, $Default"),
        new("Lato", "fonts:Lato#Lato, $Default"),
        new("Oswald", "fonts:Oswald#Oswald, $Default")
    ];

    private FontInfo _selectedFont;

    public FontInfo SelectedFont {
        get => _selectedFont;
        set {
            this.RaiseAndSetIfChanged(ref _selectedFont, value);
        }
    }

    public MainWindowViewModel() {
        _selectedFont = Fonts[0];
    }
}

public record FontInfo(string Name, FontFamily Font);
