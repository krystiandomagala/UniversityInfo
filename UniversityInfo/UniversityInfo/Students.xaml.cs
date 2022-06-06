namespace UniversityInfo
{
    using System.Data;
    using System.Data.SqlClient;
    using System.Text.RegularExpressions;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;

    /// <summary>
    /// Logika interakcji dla klasy Students.xaml.
    /// </summary>
    public partial class Students : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Students"/> class.
        /// </summary>
        public Students()
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
            SqlCommand command = new SqlCommand("SELECT * FROM students", conn);
            DataTable dataTable = new DataTable();
            conn.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);
            conn.Close();
            StudentsTable.ItemsSource = dataTable.DefaultView;
        }
        /// <summary>
        /// The InsertStudent.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="RoutedEventArgs"/>.</param>
        private void InsertStudent(object sender, RoutedEventArgs e)
        {
            try
            {
                if (isValid())
                {
                    SqlCommand command = new SqlCommand("INSERT INTO Students VALUES(@surname, @first_name, @date_of_birth, @group_no)", conn);
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@surname", StudentsSurname.Text);
                    command.Parameters.AddWithValue("@first_name", StudentsName.Text);
                    command.Parameters.AddWithValue("@date_of_birth", StudentsBirthDate.Text);
                    command.Parameters.AddWithValue("@group_no", StudentsGroup.Text);
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                    LoadGrid();
                    MessageBox.Show("Successfully added", "Saved", MessageBoxButton.OK, MessageBoxImage.Information);
                    ClearData();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// The ReadStudents.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="RoutedEventArgs"/>.</param>
        private void ReadStudents(object sender, RoutedEventArgs e)
        {
            SqlCommand command = new SqlCommand($"SELECT * FROM students WHERE student_id like '{StudentsID.Text}'", conn);

            if (StudentsID.Text == string.Empty)
                command = new SqlCommand($"SELECT * FROM students", conn);

            DataTable dataTable = new DataTable();
            conn.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);
            conn.Close();
            StudentsTable.ItemsSource = dataTable.DefaultView;
            ClearData();
        }
        /// <summary>
        /// The DeleteStudent.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="RoutedEventArgs"/>.</param>
        private void DeleteStudent(object sender, RoutedEventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand($"DELETE FROM students WHERE student_id like '{StudentsID.Text}'", conn);
            try
            {
                if (StudentsID.Text != string.Empty)
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Record has been deleted", "Deleted", MessageBoxButton.OK, MessageBoxImage.Information);
                    conn.Close();
                    ClearData();
                    LoadGrid();
                    conn.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Not deleted: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// The UpdateStudent.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="RoutedEventArgs"/>.</param>
        private void UpdateStudent(object sender, RoutedEventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand($"UPDATE students SET " +
                $"surname = '{StudentsSurname.Text}'," +
                $"first_name = '{StudentsName.Text}'," +
                $"date_of_birth = '{StudentsBirthDate.Text}'," +
                $"group_no = '{StudentsGroup.Text}'" +
                $"WHERE student_id like '{StudentsID.Text}'", conn);

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
        /// The isValid.
        /// </summary>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool isValid()
        {
            if (StudentsSurname.Text == string.Empty)
            {
                MessageBox.Show("Surname is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }
        /// <summary>
        /// The ClearData.
        /// </summary>
        public void ClearData()
        {
            StudentsID.Clear();
            StudentsName.Clear();
            StudentsSurname.Clear();
        }
        /// <summary>
        /// The StudentsIDInputValidation.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="TextCompositionEventArgs"/>.</param>
        private void StudentsIDInputValidation(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        /// <summary>
        /// The StudentsNameInputValidation.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="TextCompositionEventArgs"/>.</param>
        private void StudentsNameInputValidation(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^A-Za-zZàáâäãåąčćęèéêëėįìíîïłńòóôöõøùúûüųūÿýżźñçčšžÀÁÂÄÃÅĄĆČĖĘÈÉÊËÌÍÎÏĮŁŃÒÓÔÖÕØÙÚÛÜŲŪŸÝŻŹÑßÇŒÆČŠŽ∂ð]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
