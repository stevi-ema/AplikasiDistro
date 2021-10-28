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

namespace AplikasiDistro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //get nama user yg login
            lblUser.Content = LoginWindow.nama;
        }

        private void menuHome_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new HomePage());
        }

        private void menuProduk_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new ProdukPage());
        }

        private void menuExit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void menuPenjualan_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new TransactionPage());
        }

        private void menuLaporan_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new ReportPage());
        }

        private void menuKaryawan_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new EmployeePage());
        }

        private void lblUser_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmMain.Navigate(new UserPage());
        }
    }
}
