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
    /// Interaction logic for CheckPage.xaml
    /// </summary>
    public partial class CheckPage : Window
    {
        public CheckPage()
        {
            InitializeComponent();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

            string dbsCon = @"Data Source=DESKTOP-EH77223; Initial Catalog = Project; Integrated Security = True";
            SqlConnection sqlCon_ = new SqlConnection(dbsCon);
            

            try
            {
                Tables t = new Tables();
                t.Show();
                sqlCon_.Open();
                string query = "Select IDs,Room,Bed1,TypeOfRoom from NursesAndWards";
                SqlCommand cmd = new SqlCommand(query, sqlCon_);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                t.table.ItemsSource = dt.DefaultView;
                adapter.Update(dt);
                this.Close();
                sqlCon_.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            string dbsCon = @"Data Source=DESKTOP-EH77223; Initial Catalog = Project; Integrated Security = True";
            SqlConnection sqlCon_ = new SqlConnection(dbsCon);


            try
            {
                Tables t = new Tables();
                t.Show();
                sqlCon_.Open();
                string query = "Select Id, fName, lName, issue, treatment, department from AllPatientsInfo1";
                SqlCommand cmd = new SqlCommand(query, sqlCon_);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                t.table.ItemsSource = dt.DefaultView;
                adapter.Update(dt);
                this.Close();
                sqlCon_.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


           
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string dbsCon = @"Data Source=DESKTOP-EH77223; Initial Catalog = Project; Integrated Security = True";
            SqlConnection sqlCon_ = new SqlConnection(dbsCon);


            try
            {
                Tables t = new Tables();
                t.Show();
                sqlCon_.Open();
                string query = "Select ID,fName,lName,department from AllDoctorsInfo";
                SqlCommand cmd = new SqlCommand(query, sqlCon_);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                t.table.ItemsSource = dt.DefaultView;
                adapter.Update(dt);
                this.Close();
                sqlCon_.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string dbsCon = @"Data Source=DESKTOP-EH77223; Initial Catalog = Project; Integrated Security = True";
            SqlConnection sqlCon_ = new SqlConnection(dbsCon);


            try
            {
                Tables t = new Tables();
                t.Show();
                sqlCon_.Open();
                string query = "Select ID,Periodbeginning,Periodfinal from Duty";
                SqlCommand cmd = new SqlCommand(query, sqlCon_);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                t.table.ItemsSource = dt.DefaultView;
                adapter.Update(dt);
                this.Close();
                sqlCon_.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string dbsCon = @"Data Source=DESKTOP-EH77223; Initial Catalog = Project; Integrated Security = True";
            SqlConnection sqlCon_ = new SqlConnection(dbsCon);


            try
            {
                Tables t = new Tables();
                t.Show();
                sqlCon_.Open();
                string query = "Select Medicines,HowManyAtOneTake,HowOften,DurationOfTheIntake from Pillsdetails";
                SqlCommand cmd = new SqlCommand(query, sqlCon_);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                t.table.ItemsSource = dt.DefaultView;
                adapter.Update(dt);
                this.Close();
                sqlCon_.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

            string dbsCon = @"Data Source=DESKTOP-EH77223; Initial Catalog = Project; Integrated Security = True";
            SqlConnection sqlCon_ = new SqlConnection(dbsCon);

            int id1 = int.Parse(this.id.Text);

            try
            {
                if (id1 < 31)
                {
                    Tables t = new Tables();
                    t.Show();
                    sqlCon_.Open();
                    string query = $"Select ID,fName,lName,department from AllDoctorsInfo where ID = {this.id.Text}";
                    SqlCommand cmd = new SqlCommand(query, sqlCon_);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    t.table.ItemsSource = dt.DefaultView;
                    adapter.Update(dt);
                    this.Close();
                    sqlCon_.Close();
                }
                else
                {
                    MessageBox.Show("A doctor with such an ID does not exist");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {


            string dbsCon = @"Data Source=DESKTOP-EH77223; Initial Catalog = Project; Integrated Security = True";
            SqlConnection sqlCon_ = new SqlConnection(dbsCon);

            int id3 = int.Parse(this.id2.Text);

            try
            {
                if (id3 < 41)
                {
                    Tables t = new Tables();
                    t.Show();
                    sqlCon_.Open();
                    string query = $"Select Id, fName, lName, issue, treatment, department from AllPatientsInfo1 where ID = {this.id2.Text}";
                    SqlCommand cmd = new SqlCommand(query, sqlCon_);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    t.table.ItemsSource = dt.DefaultView;
                    adapter.Update(dt);
                    this.Close();
                    sqlCon_.Close();
                }
                else
                {
                    MessageBox.Show("A patient with such an ID does not exist");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {

            LogIn l = new LogIn();
            l.Show();
            this.Close();

        }
    }
}
