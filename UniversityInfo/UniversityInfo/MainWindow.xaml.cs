namespace UniversityInfo
{
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The StudentsBtn_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="RoutedEventArgs"/>.</param>
        private void StudentsBtn_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(Students);
        }

        /// <summary>
        /// The HomeBtn_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="RoutedEventArgs"/>.</param>
        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(Home);
        }

        /// <summary>
        /// The EmployeesBtn_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="RoutedEventArgs"/>.</param>
        private void EmployeesBtn_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(Employees);
        }

        /// <summary>
        /// The ModulesBtn_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="RoutedEventArgs"/>.</param>
        private void ModulesBtn_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(Modules);
        }

        /// <summary>
        /// The PositionsBtn_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="RoutedEventArgs"/>.</param>
        private void PositionsBtn_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(Positions);
        }

        /// <summary>
        /// The GradesBtn_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="RoutedEventArgs"/>.</param>
        private void GradesBtn_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(Grades);
        }

        /// <summary>
        /// The SetActiveUserControl.
        /// </summary>
        /// <param name="control">The control<see cref="UserControl"/>.</param>
        public void SetActiveUserControl(UserControl control)
        {
            Home.Visibility = Visibility.Collapsed;
            Students.Visibility = Visibility.Collapsed;
            Grades.Visibility = Visibility.Collapsed;
            Positions.Visibility = Visibility.Collapsed;
            Modules.Visibility = Visibility.Collapsed;
            Employees.Visibility = Visibility.Collapsed;
            control.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// The Home_Loaded.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="RoutedEventArgs"/>.</param>
        private void Home_Loaded(object sender, RoutedEventArgs e)
        {
        }
    }
}
