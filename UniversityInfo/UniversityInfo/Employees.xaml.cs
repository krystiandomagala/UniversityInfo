namespace UniversityInfo
{
    using System.Data;
    using System.Data.SqlClient;
    using System.Text.RegularExpressions;
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// Logika interakcji dla klasy Employees.xaml.
    /// </summary>
    public partial class Employees : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Employees"/> class.
        /// </summary>
        public Employees()
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
            SqlCommand command = new SqlCommand("SELECT * FROM employees", conn);
            DataTable dataTable = new DataTable();
            conn.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);
            conn.Close();
            StudentsTable.ItemsSource = dataTable.DefaultView;
        }

        /// <summary>
        /// The InsertEmployee.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="RoutedEventArgs"/>.</param>
        private void InsertEmployee(object sender, RoutedEventArgs e)
        {
            try
            {
                if (isValid())
                {
                    SqlCommand command = new SqlCommand("INSERT INTO employees VALUES(@surname, @first_name, @employment_date, @PESEL)", conn);
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@surname", EmployeesSurname.Text);
                    command.Parameters.AddWithValue("@first_name", EmployeesName.Text);
                    command.Parameters.AddWithValue("@employment_date", EmployeesEmploymentDate.Text);
                    command.Parameters.AddWithValue("@PESEL", EmployeesPESEL.Text);
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
        /// The ReadEmployees.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="RoutedEventArgs"/>.</param>
        private void ReadEmployees(object sender, RoutedEventArgs e)
        {
            SqlCommand command = new SqlCommand($"SELECT * FROM employees WHERE employee_id like '{EmployeesID.Text}'", conn);

            if (EmployeesID.Text == string.Empty)
                command = new SqlCommand($"SELECT * FROM employees", conn);

            DataTable dataTable = new DataTable();
            conn.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);
            conn.Close();
            StudentsTable.ItemsSource = dataTable.DefaultView;
            ClearData();
        }

        /// <summary>
        /// The isValid.
        /// </summary>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool isValid()
        {
            if (EmployeesSurname.Text == string.Empty)
            {
                MessageBox.Show("Surname is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (EmployeesName.Text == string.Empty)
            {
                MessageBox.Show("Name is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            return true;
        }

        /// <summary>
        /// The ClearData.
        /// </summary>
        public void ClearData()
        {
            EmployeesID.Clear();
            EmployeesName.Clear();
            EmployeesSurname.Clear();
            EmployeesPESEL.Clear();
        }

        /// <summary>
        /// The DeleteEmployee.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="RoutedEventArgs"/>.</param>
        private void DeleteEmployee(object sender, RoutedEventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand($"DELETE FROM employees WHERE employee_id like '{EmployeesID.Text}'", conn);
            try
            {
                if (EmployeesID.Text != string.Empty)
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
        /// The UpdateEmployee.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="RoutedEventArgs"/>.</param>
        private void UpdateEmployee(object sender, RoutedEventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand($"UPDATE employees SET " +
                $"surname = '{EmployeesSurname.Text}'," +
                $"first_name = '{EmployeesName.Text}'," +
                $"employment_date = '{EmployeesEmploymentDate.Text}'," +
                $"PESEL = '{EmployeesPESEL.Text}'" +
                $"WHERE employee_id like '{EmployeesID.Text}'", conn);

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

        private void EmployeesIDValidation(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void EmployeesNameValidation(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^A-Za-zZàáâäãåąčćęèéêëėįìíîïłńòóôöõøùúûüųūÿýżźñçčšžÀÁÂÄÃÅĄĆČĖĘÈÉÊËÌÍÎÏĮŁŃÒÓÔÖÕØÙÚÛÜŲŪŸÝŻŹÑßÇŒÆČŠŽ∂ð]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void EmployeesPESELValidation(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
