using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для FindItem.xaml
    /// </summary>
    public partial class FindItem : Window
    {
        private BindingList<Vehicle> bList = new BindingList<Vehicle>();
        private BindingList<Vehicle> vehicles;
        int index;
        public void Acctivate(BindingList<Vehicle> c, int i)
        {
            index = i;
            if (index == -1)
            {
                vehicles = c;
                DGClothes.ItemsSource = vehicles;
                Activate();
                Show();
            }
        }

        public FindItem()
        {
            InitializeComponent();
        }

        private void DataGridHyperlinkColumn_Click(object sender, RoutedEventArgs e)
        {
            int index = DGClothes.SelectedIndex;

            More dlg = new More();
            dlg.Acctivate(vehicles[index]);
        }

        private void Benzin_Click(object sender, RoutedEventArgs e)
        {
            bList.Clear();
            Diezel.IsChecked = false;
            Electro.IsChecked = false;
            Ploxoe.IsChecked = false;
            Novoe.IsChecked = false;
            Xoroshee.IsChecked = false;

            foreach (var item in vehicles)
            {

                if (item.TypeOfEngine == "Бензиновый")
                {
                    bList.Add(new Vehicle()
                    {
                        Id = item.Id,
                        Brand = item.Brand,
                        Color = item.Color,
                        Cost = item.Cost,
                        Count = item.Count,
                        HyperlinkText = item.HyperlinkText,
                        ImageAdr = item.ImageAdr,
                        Model = item.Model,
                        PowerOfEngine = item.PowerOfEngine,
                        SizeOfEngine = item.SizeOfEngine,
                        TypeOfEngine = item.TypeOfEngine,
                        YearOfIssue = item.YearOfIssue,
                        Condition = item.Condition
                    });
                }
                DGClothes.ItemsSource = bList;
            }
        }

        private void Diezel_Click(object sender, RoutedEventArgs e)
        {

            bList.Clear();
            Benzin.IsChecked = false;
            Electro.IsChecked = false;
            Ploxoe.IsChecked = false;
            Novoe.IsChecked = false;
            Xoroshee.IsChecked = false;

            foreach (var item in vehicles)
            {

                if (item.TypeOfEngine == "Дизель")
                {
                    bList.Add(new Vehicle()
                    {
                        Id = item.Id,
                        Brand = item.Brand,
                        Color = item.Color,
                        Cost = item.Cost,
                        Count = item.Count,
                        HyperlinkText = item.HyperlinkText,
                        ImageAdr = item.ImageAdr,
                        Model = item.Model,
                        PowerOfEngine = item.PowerOfEngine,
                        SizeOfEngine = item.SizeOfEngine,
                        TypeOfEngine = item.TypeOfEngine,
                        YearOfIssue = item.YearOfIssue,
                        Condition = item.Condition
                    });

                }
                DGClothes.ItemsSource = bList;
            }
        }

        private void Electro_Click(object sender, RoutedEventArgs e)
        {

            bList.Clear();
            Diezel.IsChecked = false;
            Benzin.IsChecked = false;
            Ploxoe.IsChecked = false;
            Novoe.IsChecked = false;
            Xoroshee.IsChecked = false;

            foreach (var item in vehicles)
            {

                if (item.TypeOfEngine == "Электрический")
                {
                    bList.Add(new Vehicle()
                    {
                        Id = item.Id,
                        Brand = item.Brand,
                        Color = item.Color,
                        Cost = item.Cost,
                        Count = item.Count,
                        HyperlinkText = item.HyperlinkText,
                        ImageAdr = item.ImageAdr,
                        Model = item.Model,
                        PowerOfEngine = item.PowerOfEngine,
                        SizeOfEngine = item.SizeOfEngine,
                        TypeOfEngine = item.TypeOfEngine,
                        YearOfIssue = item.YearOfIssue,
                        Condition = item.Condition
                    });
                }
                DGClothes.ItemsSource = bList;
            }
        }

        private void Xoroshee_Click(object sender, RoutedEventArgs e)
        {

            bList.Clear();
            Ploxoe.IsChecked = false;
            Novoe.IsChecked = false;
            Diezel.IsChecked = false;
            Benzin.IsChecked = false;
            Electro.IsChecked = false;

            foreach (var item in vehicles)
            {

                if (item.Condition == "Хорошее")
                {
                    bList.Add(new Vehicle()
                    {
                        Id = item.Id,
                        Brand = item.Brand,
                        Color = item.Color,
                        Cost = item.Cost,
                        Count = item.Count,
                        HyperlinkText = item.HyperlinkText,
                        ImageAdr = item.ImageAdr,
                        Model = item.Model,
                        PowerOfEngine = item.PowerOfEngine,
                        SizeOfEngine = item.SizeOfEngine,
                        TypeOfEngine = item.TypeOfEngine,
                        YearOfIssue = item.YearOfIssue,
                        Condition = item.Condition
                    });
                }
                DGClothes.ItemsSource = bList;
            }
        }

        private void Novoe_Click(object sender, RoutedEventArgs e)
        {

            bList.Clear();
            Ploxoe.IsChecked = false;
            Xoroshee.IsChecked = false;
            Diezel.IsChecked = false;
            Benzin.IsChecked = false;
            Electro.IsChecked = false;

            foreach (var item in vehicles)
            {

                if (item.Condition == "Новое")
                {
                    bList.Add(new Vehicle()
                    {
                        Id = item.Id,
                        Brand = item.Brand,
                        Color = item.Color,
                        Cost = item.Cost,
                        Count = item.Count,
                        HyperlinkText = item.HyperlinkText,
                        ImageAdr = item.ImageAdr,
                        Model = item.Model,
                        PowerOfEngine = item.PowerOfEngine,
                        SizeOfEngine = item.SizeOfEngine,
                        TypeOfEngine = item.TypeOfEngine,
                        YearOfIssue = item.YearOfIssue,
                        Condition = item.Condition
                    });
                }
                DGClothes.ItemsSource = bList;
            }
        }

        private void Ploxoe_Click(object sender, RoutedEventArgs e)
        {

            bList.Clear();
            Novoe.IsChecked = false;
            Xoroshee.IsChecked = false;
            Diezel.IsChecked = false;
            Benzin.IsChecked = false;
            Electro.IsChecked = false;

            foreach (var item in vehicles)
            {
                if (item.Condition == "Плохое")
                {
                    bList.Add(new Vehicle()
                    {
                        Id = item.Id,
                        Brand = item.Brand,
                        Color = item.Color,
                        Cost = item.Cost,
                        Count = item.Count,
                        HyperlinkText = item.HyperlinkText,
                        ImageAdr = item.ImageAdr,
                        Model = item.Model,
                        PowerOfEngine = item.PowerOfEngine,
                        SizeOfEngine = item.SizeOfEngine,
                        TypeOfEngine = item.TypeOfEngine,
                        YearOfIssue = item.YearOfIssue,
                        Condition = item.Condition
                    });
                }
            }
            DGClothes.ItemsSource = bList;
        }
    }
}
