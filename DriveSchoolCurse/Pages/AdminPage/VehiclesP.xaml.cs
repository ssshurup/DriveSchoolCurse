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

namespace DriveSchoolCurse.Pages.AdminPage
{
    /// <summary>
    /// Логика взаимодействия для VehiclesP.xaml
    /// </summary>
    public partial class VehiclesP : Page
    {
        public VehiclesP()
        {
            InitializeComponent();
            VehicleDG.ItemsSource = App.DB.vehicles.ToList();
        }

        private void BackBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminP());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var selectedCar = VehicleDG.SelectedItem as vehicles;
            if(selectedCar != null)
            {
                App.DB.vehicles.Remove(selectedCar);
                App.DB.SaveChanges();
                VehicleDG.ItemsSource = App.DB.vehicles.ToList();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var selectedCar = VehicleDG.SelectedItem as vehicles;
            if (selectedCar != null)
            {
                NavigationService.Navigate(new AddVehicleP(selectedCar));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vehicles veh = new vehicles();
            NavigationService.Navigate(new AddVehicleP(veh));
        }
    }
}
