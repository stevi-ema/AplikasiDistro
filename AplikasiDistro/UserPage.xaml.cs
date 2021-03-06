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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System.Data;

namespace AplikasiDistro
{
    /// <summary>
    /// Interaction logic for UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        //declare object untuk koneksi database
        private MySqlConnection mySql;

        public UserPage()
        {
            InitializeComponent();

            //get koneksi
            mySql = Koneksi.GetConnection();

            //get data user yg login
            lblID.Content = LoginWindow.id;
            txtName.Text = LoginWindow.nama;

            if(LoginWindow.jk == "Male")
            {
                rdbMale.IsChecked = true;
            }
            else
            {
                rdbFemale.IsChecked = true;
            }

            dtpBirthdate.Text = LoginWindow.tglLahir;
            txtEmail.Text = LoginWindow.email;
            lblDepartment.Content = LoginWindow.jabatan;
            txtHP.Text = LoginWindow.hp;
            txtUsername.Text = LoginWindow.username;
            txtPassword.Text = LoginWindow.password;
        }

        private void btnUpdateEmployee_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
}
