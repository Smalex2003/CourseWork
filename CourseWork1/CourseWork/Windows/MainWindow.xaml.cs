using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CourseWork
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {
            Windows.RegisterWindow regwind = new Windows.RegisterWindow();
            regwind.Show();
            this.Close();

        }


        private void AutorizationBtn_Click(object sender, RoutedEventArgs e)
        {
            Windows.AutorizationWindow autorizwind=new Windows.AutorizationWindow();
            autorizwind.Show();
            this.Close();
        }
    }
    }

