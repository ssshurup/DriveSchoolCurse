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
    /// Логика взаимодействия для AddVehicleP.xaml
    /// </summary>
    public partial class AddVehicleP : Page
    {
        vehicles context;
        public AddVehicleP(vehicles veh)
        {
            InitializeComponent();
            CategoryCB.ItemsSource = App.DB.category.ToList();
            MakeCB.ItemsSource = App.DB.carMake.ToList();
            ModelCB.ItemsSource = App.DB.carModel.ToList();
            StatusCB.ItemsSource = App.DB.status.ToList();
            context = veh;
            DataContext = context;
        }

        private void AddBT_Click(object sender, RoutedEventArgs e)
        {
            if(context.id == 0)
                App.DB.vehicles.Add(context);
            App.DB.SaveChanges();
            NavigationService.Navigate(new VehiclesP());
        }

        private void BackBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new VehiclesP());
        }
    }
}
