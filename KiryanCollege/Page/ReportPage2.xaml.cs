using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

namespace SulejmanovaCollege1.Pages
{
    /// <summary>
    /// Логика взаимодействия для Report2Pages.xaml
    /// </summary>
    public partial class Report2Pages : Page
    {
        public Report2Pages()
        {
            InitializeComponent();
        }

        private void UpdateReportBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(DateStartDp.Text) && string.IsNullOrEmpty(DateFinishDp.Text))
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                var a = (DateTime)DateStartDp.SelectedDate;
                var b = (DateTime)DateFinishDp.SelectedDate;

                var qwety = App.context.View_1.Where(v => v.Date_event >= b).GroupBy(x => x.Name).Select(g =>
                new { Группа = g.Key, Балл = g.Sum(s => s.Mark) }).OrderBy(n => n.Группа);

                ReportDg.ItemsSource = qwety.ToList();
            }
        }
    }