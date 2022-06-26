using System;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для More.xaml
    /// </summary>
    public partial class More : Window
    {
        private Vehicle vehicle;
        public void Acctivate(Vehicle c)
        {
            vehicle = c;

            TBBrand.Text = vehicle.Brand;
            TBModel.Text = vehicle.Model;
            TBYear.Text = vehicle.YearOfIssue;
            TBCount.Text = vehicle.Count;
            TBEngine.Text = vehicle.TypeOfEngine;
            TBPower.Text = vehicle.PowerOfEngine;
            TBCost.Text = vehicle.Cost;
            TBSize.Text = vehicle.SizeOfEngine;
            TBCondition.Text = vehicle.Condition;
            TBColor.Text = vehicle.Color;
            var uri = new Uri(vehicle.ImageAdr, UriKind.Relative);
            var bitmap = new BitmapImage(uri);
            TBImage.Source = bitmap;
            Activate();
            Show();
        }

            public More()
        {
            InitializeComponent();

        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
