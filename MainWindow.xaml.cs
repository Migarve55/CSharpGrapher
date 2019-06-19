using System.Windows;
using System.Windows.Controls;

namespace AStarVisualizer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GoBtn_OnClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is GridDataViewModel model)
                model.StartAStar(0, 0 , 9, 9);
        }

        private void ResetBtn_OnClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is GridDataViewModel model)
                model.ResetCells();
        }

        private void CanvasBtn_OnClick(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(XSize.Text, out int nx))
                nx = 10;
            if (!int.TryParse(YSize.Text, out int ny))
                ny = 10;
            if (DataContext is GridDataViewModel model)
                model.ResizeGrid(nx, ny);
        }
    }
}