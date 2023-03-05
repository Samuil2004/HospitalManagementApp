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
using System.Data.SqlClient;
using System.Data;


namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

            //string username = this.username2.Text;
           // string password = this.password3.Password;

            SqlConnection sqlCon2 = new SqlConnection(@"Data Source=DESKTOP-EH77223; Initial Catalog = Project; Integrated Security = True");

            try
            {
                if (sqlCon2.State == ConnectionState.Closed)
                
                    sqlCon2.Open();


                    string query = "SELECT COUNT(1) FROM SignUp where Username=@username and Password=@Password";


                    SqlCommand cmd = new SqlCommand(query, sqlCon2);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Username", this.username2.Text);
                    cmd.Parameters.AddWithValue("@Password", this.password3.Password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count == 1)
                    {
                        CheckPage r = new CheckPage();
                        r.Welcome.Content = $"Welcome, {username2.Text}";
                        r.Show();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("The username or the password are not correct");
                    }
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            finally
            {

                sqlCon2.Close();

            }
        }
    }
}

