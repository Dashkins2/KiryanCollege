using KiryanCollege.Model;
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

namespace KiryanCollege.Page
{
    /// <summary>
    /// Логика взаимодействия для AddActivityPage.xaml
    /// </summary>
    public partial class AddActivityPage : System.Windows.Controls.Page
    {
        public AddActivityPage()
        {
            InitializeComponent();

            ChangeDirectionCmb.SelectedValue = "IdDirection";
            ChangeDirectionCmb.DisplayMemberPath = "Name";
            ChangeDirectionCmb.ItemsSource = App.context.Direction.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(ActivityTb.Text) && string.IsNullOrEmpty(ChangeDirectionCmb.Text))
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                Activity direction = new Activity()
                {
                    Name = ActivityTb.Text,
                    Direction = ChangeDirectionCmb.SelectedItem as Direction
                };

                App.context.Activity.Add(direction);
                App.context.SaveChanges();
                MessageBox.Show("Активность добавлена");
                ActivityTb.Text = "";
                ChangeDirectionCmb.Text = "";
                ChangeDirectionCmb.Text = "";
            }
        }
    }
}
