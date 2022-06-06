namespace UniversityInfo
{
    using System.Data;
    using System.Data.SqlClient;
    using System.Text.RegularExpressions;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;

    /// <summary>
    /// Logika interakcji dla klasy Modules.xaml.
    /// </summary>
    public partial class Modules : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Modules"/> class.
        /// </summary>
        public Modules()
        {
            InitializeComponent();
            LoadGrid();
        }

        /// <summary>
        /// Defines the conn.
        /// </summary>
        internal SqlConnection conn = new SqlConnection(@"Data Source=K-KRYSTIAN\SQLEXPRESS;Initial Catalog=university;Integrated Security=True");

        /// <summary>
        /// The LoadGrid.
        /// </summary>
        public void LoadGrid()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM modules", conn);
            DataTable dataTable = new DataTable();
            conn.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);
            conn.Close();
            StudentsTable.ItemsSource = dataTable.DefaultView;
        }

        /// <summary>
        /// The ReadModules.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="RoutedEventArgs"/>.</param>
        private void ReadModules(object sender, RoutedEventArgs e)
        {
            SqlCommand command = new SqlCommand($"SELECT * FROM modules WHERE module_id like '{ModulesID.Text}'", conn);

            if (ModulesID.Text == string.Empty)
                command = new SqlCommand($"SELECT * FROM modules", conn);

            DataTable dataTable = new DataTable();
            conn.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);
            conn.Close();
            StudentsTable.ItemsSource = dataTable.DefaultView;
            ClearData();
        }

        /// <summary>
        /// The UpdateModules.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="RoutedEventArgs"/>.</param>
        private void UpdateModules(object sender, RoutedEventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand($"UPDATE modules SET " +
                $"module_name = '{ModulesName.Text}'," +
                $"no_of_hours = '{ModulesNoOfHours.Text}'," +
                $"lecturer_id = '{ModulesLecturersID.Text}'," +
                $"preceding_module = '{PrecedingModulesID.Text}'," +
                $"department = '{ModulesDepartment.Text}'" +
                $"WHERE module_id like '{ModulesID.Text}'", conn);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Record has been updated successfully", "Updated", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                ClearData();
                LoadGrid();
            }
        }

        /// <summary>
        /// The ClearData.
        /// </summary>
        public void ClearData()
        {
            ModulesID.Clear();
            ModulesNoOfHours.Clear();
            ModulesLecturersID.Clear();
            PrecedingModulesID.Clear();
        }

        /// <summary>
        /// The ModulesIDValidation.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="TextCompositionEventArgs"/>.</param>
        private void ModulesIDValidation(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
