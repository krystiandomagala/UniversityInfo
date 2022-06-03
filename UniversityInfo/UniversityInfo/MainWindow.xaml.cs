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

namespace UniversityInfo
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StudentsBtn_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(Students);
        }
        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(Home);
        }
        private void EmployeesBtn_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(Employees);
        }
        private void ModulesBtn_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(Modules);
        }
        private void PositionsBtn_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(Positions);
        }
        private void GradesBtn_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(Grades);
        }
        private void GroupsBtn_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(Groups);
        }


        public void SetActiveUserControl(UserControl control)
        {
            Home.Visibility = Visibility.Collapsed;
            Students.Visibility = Visibility.Collapsed;
            Grades.Visibility = Visibility.Collapsed;
            Groups.Visibility = Visibility.Collapsed;
            Positions.Visibility = Visibility.Collapsed;
            Modules.Visibility = Visibility.Collapsed;
            Employees.Visibility = Visibility.Collapsed;
            control.Visibility = Visibility.Visible;
        }

        private void Home_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
