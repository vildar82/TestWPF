﻿namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
           InitializeComponent();
           DataContext = new MainVm();
        }
    }
}
