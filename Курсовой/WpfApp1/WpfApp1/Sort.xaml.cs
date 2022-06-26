using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Sort.xaml
    /// </summary>
    public partial class Sort : Window
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

        public Sort()
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
            DGClothes.ItemsSource = vehicles;
            
            Novoe.IsChecked = false;
            Xoroshee.IsChecked = false;
            Diezel.IsChecked = false;
            Electro.IsChecked = false;
            Belii.IsChecked = false;
            Gray.IsChecked = false;
            Green.IsChecked = false;
            Black.IsChecked = false;

            if (Benzin.IsChecked == true)
            {
                bList.Clear();
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
        }

        private void Diezel_Click(object sender, RoutedEventArgs e)
        {

            DGClothes.ItemsSource = vehicles;
            Novoe.IsChecked = false;
            Xoroshee.IsChecked = false;
            Benzin.IsChecked = false;
            Electro.IsChecked = false;
            Belii.IsChecked = false;
            Gray.IsChecked = false;
            Green.IsChecked = false;
            Black.IsChecked = false;

            if (Diezel.IsChecked == true)
            {
                bList.Clear();
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
        }

        private void Electro_Click(object sender, RoutedEventArgs e)
        {
            DGClothes.ItemsSource = vehicles;
            
            Novoe.IsChecked = false;
            Xoroshee.IsChecked = false;
            Diezel.IsChecked = false;
            Benzin.IsChecked = false;
            Belii.IsChecked = false;
            Gray.IsChecked = false;
            Green.IsChecked = false;
            Black.IsChecked = false;

            if (Electro.IsChecked == true)
            {
                bList.Clear();
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
        }

        private void Xoroshee_Click(object sender, RoutedEventArgs e)
        {
            DGClothes.ItemsSource = vehicles;

            Novoe.IsChecked = false;
            Diezel.IsChecked = false;
            Benzin.IsChecked = false;
            Electro.IsChecked = false;
            Belii.IsChecked = false;
            Gray.IsChecked = false;
            Green.IsChecked = false;
            Black.IsChecked = false;

            if (Xoroshee.IsChecked == true)
            {
                bList.Clear();
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
        }

        private void Novoe_Click(object sender, RoutedEventArgs e)
        {

            DGClothes.ItemsSource = vehicles;

            Xoroshee.IsChecked = false;
            Diezel.IsChecked = false;
            Benzin.IsChecked = false;
            Ploxoe.IsChecked = false;
            Electro.IsChecked = false;
            Belii.IsChecked = false;
            Gray.IsChecked = false;
            Green.IsChecked = false;
            Black.IsChecked = false;
            if (Novoe.IsChecked == true)
            {
                bList.Clear();
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
        }

        private void Ploxoe_Click(object sender, RoutedEventArgs e)
        {
            DGClothes.ItemsSource = vehicles;

            Novoe.IsChecked = false;
            Xoroshee.IsChecked = false;
            Diezel.IsChecked = false;
            Benzin.IsChecked = false;
            Electro.IsChecked = false;
            Belii.IsChecked = false;
            Gray.IsChecked = false;
            Green.IsChecked = false;
            Black.IsChecked = false;

            if (Ploxoe.IsChecked == true)
            {
                bList.Clear();
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

        private void Belii_Click(object sender, RoutedEventArgs e)
        {
            DGClothes.ItemsSource = vehicles;
            
            Novoe.IsChecked = false;
            Xoroshee.IsChecked = false;
            Diezel.IsChecked = false;
            Benzin.IsChecked = false;
            Electro.IsChecked = false;
            Gray.IsChecked = false;
            Green.IsChecked = false;
            Black.IsChecked = false;
            Ploxoe.IsChecked = false;

            if (Belii.IsChecked == true)
            {
                bList.Clear();
                foreach (var item in vehicles)
                {

                    if (item.Color == "Белый")
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
        }

        private void Green_Click(object sender, RoutedEventArgs e)
        {
            DGClothes.ItemsSource = vehicles;
            
            Novoe.IsChecked = false;
            Xoroshee.IsChecked = false;
            Diezel.IsChecked = false;
            Benzin.IsChecked = false;
            Electro.IsChecked = false;
            Belii.IsChecked = false;
            Gray.IsChecked = false;
            Ploxoe.IsChecked = false;
            Black.IsChecked = false;

            if (Green.IsChecked == true)
            {
                bList.Clear();
                foreach (var item in vehicles)
                {

                    if (item.Color == "Зеленый")
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
        }

        private void Black_Click(object sender, RoutedEventArgs e)
        {
            DGClothes.ItemsSource = vehicles;
            
            Novoe.IsChecked = false;
            Xoroshee.IsChecked = false;
            Diezel.IsChecked = false;
            Benzin.IsChecked = false;
            Electro.IsChecked = false;
            Belii.IsChecked = false;
            Gray.IsChecked = false;
            Green.IsChecked = false;
            Ploxoe.IsChecked = false;

            if (Black.IsChecked == true)
            {
                bList.Clear();
                foreach (var item in vehicles)
                {

                    if (item.Color == "Черный")
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
        }

        private void Gray_Click(object sender, RoutedEventArgs e)
        {
            DGClothes.ItemsSource = vehicles;
           
            Novoe.IsChecked = false;
            Xoroshee.IsChecked = false;
            Diezel.IsChecked = false;
            Benzin.IsChecked = false;
            Electro.IsChecked = false;
            Belii.IsChecked = false;
            Ploxoe.IsChecked = false;
            Green.IsChecked = false;
            Black.IsChecked = false;

            if (Gray.IsChecked == true)
            {
                bList.Clear();
                foreach (var item in vehicles)
                {

                    if (item.Color == "Серый")
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
        }

        //private void Benzin_Click(object sender, RoutedEventArgs e)
        //{           
        //    if (Benzin.IsChecked == true)
        //    {
        //        Diezel.IsChecked = false;
        //        Electro.IsChecked = false;

        //        if (Xoroshee.IsChecked == true || Ploxoe.IsChecked == true || Novoe.IsChecked == true)
        //        {   
        //            var newlist = new BindingList<Vehicle>();
        //            foreach (var item in bList)
        //            {
        //                if (item.TypeOfEngine == "Бензиновый")
        //                {
        //                    newlist.Add(new Vehicle()
        //                    {
        //                        Id = item.Id,
        //                        Brand = item.Brand,
        //                        Color = item.Color,
        //                        Cost = item.Cost,
        //                        Count = item.Count,
        //                        HyperlinkText = item.HyperlinkText,
        //                        ImageAdr = item.ImageAdr,
        //                        Model = item.Model,
        //                        PowerOfEngine = item.PowerOfEngine,
        //                        SizeOfEngine = item.SizeOfEngine,
        //                        TypeOfEngine = item.TypeOfEngine,
        //                        YearOfIssue = item.YearOfIssue,
        //                        Condition = item.Condition
        //                    });
        //                }
        //            }
        //            DGClothes.ItemsSource = newlist;
        //        }
        //        else
        //        {
        //            bList.Clear();
        //            foreach (var item in vehicles)
        //            {
        //                if (item.TypeOfEngine == "Бензиновый")
        //                {
        //                    bList.Add(new Vehicle()
        //                    {
        //                        Id = item.Id,
        //                        Brand = item.Brand,
        //                        Color = item.Color,
        //                        Cost = item.Cost,
        //                        Count = item.Count,
        //                        HyperlinkText = item.HyperlinkText,
        //                        ImageAdr = item.ImageAdr,
        //                        Model = item.Model,
        //                        PowerOfEngine = item.PowerOfEngine,
        //                        SizeOfEngine = item.SizeOfEngine,
        //                        TypeOfEngine = item.TypeOfEngine,
        //                        YearOfIssue = item.YearOfIssue,
        //                        Condition = item.Condition
        //                    });
        //                }
        //            }
        //            DGClothes.ItemsSource = bList;
        //        }
        //    }
        //}

        //private void Diezel_Click(object sender, RoutedEventArgs e)
        //{
        //    if (Diezel.IsChecked == true)
        //    {
        //        Benzin.IsChecked = false;
        //        Electro.IsChecked = false;
        //        if (Xoroshee.IsChecked == true || Ploxoe.IsChecked == true || Novoe.IsChecked == true)
        //        {
        //            var newlist = new BindingList<Vehicle>();
        //            foreach (var item in bList)
        //            {
        //                if (item.TypeOfEngine == "Дизель")
        //                {
        //                    newlist.Add(new Vehicle()
        //                    {
        //                        Id = item.Id,
        //                        Brand = item.Brand,
        //                        Color = item.Color,
        //                        Cost = item.Cost,
        //                        Count = item.Count,
        //                        HyperlinkText = item.HyperlinkText,
        //                        ImageAdr = item.ImageAdr,
        //                        Model = item.Model,
        //                        PowerOfEngine = item.PowerOfEngine,
        //                        SizeOfEngine = item.SizeOfEngine,
        //                        TypeOfEngine = item.TypeOfEngine,
        //                        YearOfIssue = item.YearOfIssue,
        //                        Condition = item.Condition
        //                    });
        //                }
        //            }
        //            DGClothes.ItemsSource = newlist;
        //        }
        //        else
        //        {
        //            bList.Clear();
        //            foreach (var item in vehicles)
        //            {
        //                if (item.TypeOfEngine == "Дизель")
        //                {
        //                    bList.Add(new Vehicle()
        //                    {
        //                        Id = item.Id,
        //                        Brand = item.Brand,
        //                        Color = item.Color,
        //                        Cost = item.Cost,
        //                        Count = item.Count,
        //                        HyperlinkText = item.HyperlinkText,
        //                        ImageAdr = item.ImageAdr,
        //                        Model = item.Model,
        //                        PowerOfEngine = item.PowerOfEngine,
        //                        SizeOfEngine = item.SizeOfEngine,
        //                        TypeOfEngine = item.TypeOfEngine,
        //                        YearOfIssue = item.YearOfIssue,
        //                        Condition = item.Condition
        //                    });
        //                }
        //            }
        //            DGClothes.ItemsSource = bList;
        //        }
        //    }
        //}

        //private void Electro_Click(object sender, RoutedEventArgs e)
        //{  

        //    if (Electro.IsChecked == true)
        //    {
        //        Benzin.IsChecked = false;
        //        Diezel.IsChecked = false;
        //        if (Xoroshee.IsChecked == true || Ploxoe.IsChecked == true || Novoe.IsChecked == true)
        //        {
        //            var newlist = new BindingList<Vehicle>();
        //            foreach (var item in bList)
        //            {
        //                if (item.TypeOfEngine == "Электрический")
        //                {
        //                    newlist.Add(new Vehicle()
        //                    {
        //                        Id = item.Id,
        //                        Brand = item.Brand,
        //                        Color = item.Color,
        //                        Cost = item.Cost,
        //                        Count = item.Count,
        //                        HyperlinkText = item.HyperlinkText,
        //                        ImageAdr = item.ImageAdr,
        //                        Model = item.Model,
        //                        PowerOfEngine = item.PowerOfEngine,
        //                        SizeOfEngine = item.SizeOfEngine,
        //                        TypeOfEngine = item.TypeOfEngine,
        //                        YearOfIssue = item.YearOfIssue,
        //                        Condition = item.Condition
        //                    });
        //                }
        //            }
        //            DGClothes.ItemsSource = newlist;
        //        }
        //        else
        //        {
        //            bList.Clear();
        //            foreach (var item in vehicles)
        //            {
        //                if (item.TypeOfEngine == "Электрический")
        //                {
        //                    bList.Add(new Vehicle()
        //                    {
        //                        Id = item.Id,
        //                        Brand = item.Brand,
        //                        Color = item.Color,
        //                        Cost = item.Cost,
        //                        Count = item.Count,
        //                        HyperlinkText = item.HyperlinkText,
        //                        ImageAdr = item.ImageAdr,
        //                        Model = item.Model,
        //                        PowerOfEngine = item.PowerOfEngine,
        //                        SizeOfEngine = item.SizeOfEngine,
        //                        TypeOfEngine = item.TypeOfEngine,
        //                        YearOfIssue = item.YearOfIssue,
        //                        Condition = item.Condition
        //                    });
        //                }
        //            }
        //            DGClothes.ItemsSource = bList;
        //        }
        //    }
        //}

        //private void Xoroshee_Click(object sender, RoutedEventArgs e)
        //{

        //    if (Xoroshee.IsChecked == true)
        //    {
        //        Ploxoe.IsChecked = false;
        //        Novoe.IsChecked = false;
        //        if (Diezel.IsChecked == true || Benzin.IsChecked == true || Electro.IsChecked == true)
        //        {
        //            var newlist = new BindingList<Vehicle>();
        //            foreach (var item in bList)
        //            {
        //                if (item.Condition == "Хорошее")
        //                {
        //                    newlist.Add(new Vehicle()
        //                    {
        //                        Id = item.Id,
        //                        Brand = item.Brand,
        //                        Color = item.Color,
        //                        Cost = item.Cost,
        //                        Count = item.Count,
        //                        HyperlinkText = item.HyperlinkText,
        //                        ImageAdr = item.ImageAdr,
        //                        Model = item.Model,
        //                        PowerOfEngine = item.PowerOfEngine,
        //                        SizeOfEngine = item.SizeOfEngine,
        //                        TypeOfEngine = item.TypeOfEngine,
        //                        YearOfIssue = item.YearOfIssue,
        //                        Condition = item.Condition
        //                    });
        //                }
        //            }
        //            DGClothes.ItemsSource = newlist;
        //        }
        //        else
        //        {
        //            bList.Clear();
        //            foreach (var item in vehicles)
        //            {

        //                if (item.Condition == "Хорошее")
        //                {
        //                    bList.Add(new Vehicle()
        //                    {
        //                        Id = item.Id,
        //                        Brand = item.Brand,
        //                        Color = item.Color,
        //                        Cost = item.Cost,
        //                        Count = item.Count,
        //                        HyperlinkText = item.HyperlinkText,
        //                        ImageAdr = item.ImageAdr,
        //                        Model = item.Model,
        //                        PowerOfEngine = item.PowerOfEngine,
        //                        SizeOfEngine = item.SizeOfEngine,
        //                        TypeOfEngine = item.TypeOfEngine,
        //                        YearOfIssue = item.YearOfIssue,
        //                        Condition = item.Condition
        //                    });
        //                }

        //            }
        //            DGClothes.ItemsSource = bList;
        //        }
        //    }
        //}

        //private void Novoe_Click(object sender, RoutedEventArgs e)
        //{  
        //    if (Novoe.IsChecked == true)
        //    {   
        //        Ploxoe.IsChecked = false;
        //        Xoroshee.IsChecked = false;

        //        if (Diezel.IsChecked == true || Benzin.IsChecked == true || Electro.IsChecked == true)
        //        {
        //            var newlist = new BindingList<Vehicle>();
        //            foreach (var item in bList)
        //            {
        //                if (item.Condition == "Новое")
        //                {
        //                    newlist.Add(new Vehicle()
        //                    {
        //                        Id = item.Id,
        //                        Brand = item.Brand,
        //                        Color = item.Color,
        //                        Cost = item.Cost,
        //                        Count = item.Count,
        //                        HyperlinkText = item.HyperlinkText,
        //                        ImageAdr = item.ImageAdr,
        //                        Model = item.Model,
        //                        PowerOfEngine = item.PowerOfEngine,
        //                        SizeOfEngine = item.SizeOfEngine,
        //                        TypeOfEngine = item.TypeOfEngine,
        //                        YearOfIssue = item.YearOfIssue,
        //                        Condition = item.Condition
        //                    });
        //                }
        //            }
        //            DGClothes.ItemsSource = newlist;
        //        }
        //        else
        //        {
        //            bList.Clear();
        //            foreach (var item in vehicles)
        //            {

        //                if (item.Condition == "Новое")
        //                {
        //                    bList.Add(new Vehicle()
        //                    {
        //                        Id = item.Id,
        //                        Brand = item.Brand,
        //                        Color = item.Color,
        //                        Cost = item.Cost,
        //                        Count = item.Count,
        //                        HyperlinkText = item.HyperlinkText,
        //                        ImageAdr = item.ImageAdr,
        //                        Model = item.Model,
        //                        PowerOfEngine = item.PowerOfEngine,
        //                        SizeOfEngine = item.SizeOfEngine,
        //                        TypeOfEngine = item.TypeOfEngine,
        //                        YearOfIssue = item.YearOfIssue,
        //                        Condition = item.Condition
        //                    });
        //                }

        //            }
        //            DGClothes.ItemsSource = bList;
        //        }
        //    }
        //}

        //private void Ploxoe_Click(object sender, RoutedEventArgs e)
        //{       
        //    if (Ploxoe.IsChecked == true)
        //    {
        //        Xoroshee.IsChecked = false;
        //        Novoe.IsChecked = false;

        //        if (Diezel.IsChecked == true || Benzin.IsChecked == true || Electro.IsChecked == true)
        //        {
        //            var newlist = new BindingList<Vehicle>();
        //            foreach (var item in bList)
        //            {
        //                if (item.Condition == "Плохое")
        //                {
        //                    newlist.Add(new Vehicle()
        //                    {
        //                        Id = item.Id,
        //                        Brand = item.Brand,
        //                        Color = item.Color,
        //                        Cost = item.Cost,
        //                        Count = item.Count,
        //                        HyperlinkText = item.HyperlinkText,
        //                        ImageAdr = item.ImageAdr,
        //                        Model = item.Model,
        //                        PowerOfEngine = item.PowerOfEngine,
        //                        SizeOfEngine = item.SizeOfEngine,
        //                        TypeOfEngine = item.TypeOfEngine,
        //                        YearOfIssue = item.YearOfIssue,
        //                        Condition = item.Condition
        //                    });
        //                }
        //            }
        //            DGClothes.ItemsSource = newlist;
        //        }
        //        else
        //        {
        //            bList.Clear();

        //            foreach (var item in vehicles)
        //            {           
        //                if (item.Condition == "Плохое")
        //                {
        //                    bList.Add(new Vehicle()
        //                    {
        //                        Id = item.Id,
        //                        Brand = item.Brand,
        //                        Color = item.Color,
        //                        Cost = item.Cost,
        //                        Count = item.Count,
        //                        HyperlinkText = item.HyperlinkText,
        //                        ImageAdr = item.ImageAdr,
        //                        Model = item.Model,
        //                        PowerOfEngine = item.PowerOfEngine,
        //                        SizeOfEngine = item.SizeOfEngine,
        //                        TypeOfEngine = item.TypeOfEngine,
        //                        YearOfIssue = item.YearOfIssue,
        //                        Condition = item.Condition
        //                    });
        //                }
        //            }
        //            DGClothes.ItemsSource = bList;
        //        }
        //    }
        //}
    }
}
