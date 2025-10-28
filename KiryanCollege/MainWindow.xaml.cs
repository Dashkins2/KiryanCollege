using KiryanCollege.Page;
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

namespace KiryanCollege
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

        private void AddGroupBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AddGroupPage());
        }

        private void AddActivityBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AddActivityPage());
        }

        private void JournalBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate (new JournalPage()); 
        }

        private void Report1Btn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ReportPage());
        }

        private void Report2Btn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ReportPage2());
        }
    }
}
