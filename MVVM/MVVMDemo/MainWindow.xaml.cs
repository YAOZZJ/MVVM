using MVVMDemo.ViewModel;
using System.Windows;

namespace MVVMDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new CustomerViewModel();
        }
    }
}
