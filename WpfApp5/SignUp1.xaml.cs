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
    public partial class SignUp1 : Window
    {
        public SignUp1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-EH77223; Initial Catalog = Project; Integrated Security = True");


            if (password.Password != password2.Password)
            {
                MessageBox.Show("Different inputs of the password");
                this.Close();
            }
            else
            {
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();


                        string query = "INSERT INTO SignUp (Username, Password, RepeatPassword) values ('" + this.username.Text + "','" + this.password.Password + "','" + this.password2.Password + "')";


                        SqlCommand cmd = new SqlCommand(query, sqlCon);
                        cmd.ExecuteNonQuery();


                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                finally
                {
                    sqlCon.Close();


                    LogIn g = new LogIn();
                    g.Show();
                    this.Close();
                }
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            LogIn g = new LogIn();
            g.Show();
            this.Close();
        }
    }
}

