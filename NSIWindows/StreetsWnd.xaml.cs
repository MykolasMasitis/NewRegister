﻿using System;
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
using System.Windows.Shapes;

namespace Register.NSIWindows
{
    /// <summary>
    /// Логика взаимодействия для StreetsWnd.xaml
    /// </summary>
    public partial class StreetsWnd : Window
    {
        private MainWindow mainWindow;

        public StreetsWnd(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }
    }
}
