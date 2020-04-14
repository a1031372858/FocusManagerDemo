using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FocusManagerDemo
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private HomeView _homeView = new HomeView();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ControlA_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (_homeView == null)
            {
                _homeView=new HomeView();
            }
            _homeView.Show();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            ControlA.Focus();
        }
    }
}
