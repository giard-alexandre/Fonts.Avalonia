using Avalonia.Media;

using ReactiveUI;

namespace Fonts.Avalonia.Samples;

public class MainWindowViewModel : ReactiveObject {
    public List<FontInfo> Fonts { get; } = [
        new("Inter", "fonts:Inter#Inter, $Default"),
        new("Asap", "fonts:Asap#Asap, $Default"),
        new("Asap Semi Condensed", "fonts:AsapSemiCondensed#Asap SemiCondensed, $Default"),
        new("Asap Condensed", "fonts:AsapCondensed#Asap Condensed, $Default"),
        new("CascadiaCode", "fonts:CascadiaCode#Cascadia Code, $Default"),
        new("FiraSansCondensed", "fonts:FiraSansCondensed#Fira Sans Condensed, $Default"),
        new("FiraSansExtraCondensed", "fonts:FiraSansExtraCondensed#Fira Sans Extra Condensed, $Default"),
        new("Iosevka", "fonts:Iosevka#Iosevka, $Default"),
        new("JetbrainsMono", "fonts:JetBrainsMono#JetBrains Mono, $Default"),
        new("Lato", "fonts:Lato#Lato, $Default"),
        new("Oswald", "fonts:Oswald#Oswald, $Default"),
        new("Roboto Condensed", "fonts:RobotoCondensed#Roboto Condensed"),
        new("SourceSans3", "fonts:SourceSans3#Source Sans 3, $Default"),
        new("ClearSans", "fonts:ClearSans#ClearSans, $Default"),
        new("Figtree", "fonts:Figtree#Figtree, $Default"),
        new("IBM Plex Sans Condensed", "fonts:IBMPlexSansCondensed#IBM Plex Sans Condensed, $Default"),
        new("Lexend", "fonts:Lexend#Lexend, $Default"),
        new("Manrope", "fonts:Manrope#Manrope, $Default"),
        new("PT Root UI", "fonts:PtRootUi#PT Root UI, $Default"),
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
