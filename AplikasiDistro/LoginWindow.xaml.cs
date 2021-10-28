using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System.Data;

namespace AplikasiDistro
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        //declare static variabel
        public static string id, nama, jk, tglLahir, email, jabatan, hp,
                            username, password;

        //declare object untuk koneksi database
        private MySqlConnection mySql;
        public LoginWindow()
        {
            InitializeComponent();

            //check koneksi
            mySql = Koneksi.GetConnection();

            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //login check
            //prepare query
            string query = "SELECT * FROM karyawan WHERE username = '"+ txtUsername.Text +"' AND password = '"+ txtPassword.Password +"'";
            //open connection
            mySql.Open();
            //execute query
            MySqlCommand command = mySql.CreateCommand();
            command.CommandText = query;
            //result
            MySqlDataReader dataReader = command.ExecuteReader();

            //check
            while (dataReader.Read())
            {
                id = dataReader.GetString(0);
                nama = dataReader.GetString(1);
                jk = dataReader.GetString(2);
                tglLahir = dataReader.GetString(3);
                email = dataReader.GetString(4);
                jabatan = dataReader.GetString(5);
                hp = dataReader.GetString(6);
                username = dataReader.GetString(7);
                password = dataReader.GetString(8);
            }

            if (nama == "")
            {
                MessageBox.Show("Username/Password salah !");
                txtUsername.Text = "";
                txtPassword.Password = "";
                txtUsername.Focus();
            }
            else
            {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

            mySql.Close();
        }
    }
}
