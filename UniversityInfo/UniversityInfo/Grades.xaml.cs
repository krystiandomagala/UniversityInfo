namespace UniversityInfo
{
    using System.Data;
    using System.Data.SqlClient;
    using System.Text.RegularExpressions;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;

    /// <summary>
    /// Logika interakcji dla klasy Grades.xaml.
    /// </summary>
    public partial class Grades : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Grades"/> class.
        /// </summary>
        public Grades()
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
            SqlCommand command = new SqlCommand("SELECT * FROM student_grades", conn);
            DataTable dataTable = new DataTable();
            conn.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);
            conn.Close();
            StudentsTable.ItemsSource = dataTable.DefaultView;
        }

        /// <summary>
        /// The isValid.
        /// </summary>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool isValid()
        {
            if (GradesModuleID.Text == string.Empty)
            {
                MessageBox.Show("ID is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// The ClearData.
        /// </summary>
        public void ClearData()
        {
            GradesStudentID.Clear();
            GradesModuleID.Clear();
        }

        /// <summary>
        /// The ReadGrades.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="RoutedEventArgs"/>.</param>
        private void ReadGrades(object sender, RoutedEventArgs e)
        {
            SqlCommand command = new SqlCommand($"SELECT * FROM student_grades WHERE student_id like '{GradesStudentID.Text}'", conn);

            if (GradesStudentID.Text == string.Empty)
                command = new SqlCommand($"SELECT * FROM student_grades", conn);

            DataTable dataTable = new DataTable();
            conn.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);
            conn.Close();
            StudentsTable.ItemsSource = dataTable.DefaultView;
            ClearData();
        }

        /// <summary>
        /// The UpdateGrades.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="RoutedEventArgs"/>.</param>
        private void UpdateGrades(object sender, RoutedEventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand($"UPDATE student_grades SET " +
                $"grade = '{GradesGrade.Text}'," +
                $"module_id = '{GradesModuleID.Text}'," +
                $"exam_date = '{GradesExamDate.Text}'" +
                $"WHERE student_id like '{GradesStudentID.Text}' and module_id like '{GradesModuleID.Text}'", conn);

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
        /// The IDValidation.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="TextCompositionEventArgs"/>.</param>
        private void IDValidation(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
