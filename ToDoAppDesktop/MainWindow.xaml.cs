using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ToDoAppDesktop;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
    }

    [DllImport("user32.dll")]
    private static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

    private void OnPnlControlBarMouseLeftButtonDown(object sender, MouseButtonEventArgs e) => SendMessage(new WindowInteropHelper(this).Handle, 161, 2, 0);

    private void OnPnlControlBarMouseEnter(object sender, MouseEventArgs e) => MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;

    private void OnBtnCloseClick(object sender, RoutedEventArgs e) => Application.Current.Shutdown();

    private void OnBtnMaximizeClick(object sender, RoutedEventArgs e) => WindowState = WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;

    private void OnBtnMinimizeClick(object sender, RoutedEventArgs e) => WindowState = WindowState.Minimized;
}