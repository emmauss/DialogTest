using Avalonia.Controls;

namespace AvaloniaApplication4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            await new MainWindow().ShowDialog(this);
        }
    }
}