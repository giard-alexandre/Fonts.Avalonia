using Avalonia.Controls;

using Fonts.Avalonia.Samples.Models;

namespace Fonts.Avalonia.Samples;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();

        DataGrid1.ItemsSource = Countries.All;
    }
}
