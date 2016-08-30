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
//using Register.ViewModels;
using Register.NSIWindows;

namespace Register
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //string curdir = System.IO.Directory.GetCurrentDirectory();
            //MessageBox.Show(curdir);
            InitializeComponent();
            //status.FillComboBox(cmdStatus, App.connectionString);
        }

        private void OpenStreetsWnd(object sender, RoutedEventArgs e)
        {
            StreetsWnd streetsWnd = new StreetsWnd(this);
            //streetsWnd.Show();
            streetsWnd.ShowDialog();
        }
    }
}
