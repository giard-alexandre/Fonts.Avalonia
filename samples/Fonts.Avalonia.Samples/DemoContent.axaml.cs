using Avalonia.Controls;

using Fonts.Avalonia.Samples.Models;

namespace Fonts.Avalonia.Samples;

public partial class DemoContent : UserControl {
    public DemoContent() {
        InitializeComponent();
        
        DataGrid1.ItemsSource = Countries.All;
    }
}

