using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.IO;
using WpfApp1.Services;
using System.Windows.Input;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Data;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class Main : Window
    {
        private int ind;
        private List<BindingList<Vehicle>> vehicle_Data;
        private bool bUp;
        Model1Container db = new Model1Container();
        List<Table> tables;

        public BindingList<Vehicle> DeepCopy(BindingList<Vehicle> list)
        {
            var bList = new BindingList<Vehicle>();

            foreach (var item in list)
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
            return bList;
        }

        public Main()
        {
            InitializeComponent();
            ind = 0;
            BtnRedo.IsEnabled = false;
            BtnUndo.IsEnabled = false;

            vehicle_Data = new List<BindingList<Vehicle>>
            {
                new BindingList<Vehicle>()
            };

            tables = db.Table.Where(c => c != null).ToList();
            int counfOfAuto = 0;
            foreach (var iter in tables)
            {
                vehicle_Data[ind].Add(new Vehicle
                {
                    Id = (int)iter.id,
                    Brand = iter.Brand,
                    Model = iter.Model,
                    YearOfIssue = iter.YearOfIssue,
                    Color = iter.Color,
                    Condition = iter.Condition,
                    Cost = iter.Cost,
                    Count = iter.Count,
                    ImageAdr = iter.Image,
                    TypeOfEngine = iter.TypeOfEngine,
                    SizeOfEngine = iter.SizeOfEngine,
                    PowerOfEngine = iter.PowerOfEngine,
                });            
            }

            DGClothes.ItemsSource = vehicle_Data[ind];
            DGClothes.UpdateLayout();
            TBFind.Text = "Введите элемент";
            ToVib.Text = "До";
            FromVib.Text = "От";
            

            CountOf.Text = $"Всего авто: {vehicle_Data[ind].Count}";

            CommandBinding commandBinding = new CommandBinding();
            commandBinding.Command = ApplicationCommands.Help;
            commandBinding.Executed += CommandBinding_Executed;
            AddButton.Command = ApplicationCommands.Help;
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            int index = DGClothes.SelectedIndex;
            AddDialog dlg = new AddDialog();

            vehicle_Data.Add(DeepCopy(vehicle_Data[ind]));
            ind++;
            if (index > vehicle_Data[ind].Count - 1 && vehicle_Data[ind].Count <= 15)
            {
                dlg.Acctivate(vehicle_Data[ind], -1);
                DGClothes.ItemsSource = vehicle_Data[ind];
                BtnUndo.IsEnabled = true;
                CountOf.Text = $"Всего авто: {vehicle_Data[ind].Count + 1}";
            }
            else if (vehicle_Data[ind].Count > 15)
            {
                MessageBox.Show("Автопарк переполнен", "Ошибка", (MessageBoxButton)System.Windows.Forms.MessageBoxButtons.OK, (MessageBoxImage)System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void Viborka_Click(object sender, RoutedEventArgs e)
        {
            if (UInt32.TryParse(ToVib.Text, out uint to) && UInt32.TryParse(FromVib.Text, out uint from))
            {
                FindItem find = new FindItem();
                string findVehicleAttr = BoxViborka.Text;
                var bList = new BindingList<Vehicle>();
                foreach (var item in vehicle_Data[ind])
                {
                    switch (findVehicleAttr)
                    {
                        
                        case "Цена":
                            if (Int32.Parse(item.Cost) > from && Int32.Parse(item.Cost) < to)
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
                            break;

                        case "Год":
                            if (Int32.Parse(item.YearOfIssue) > from && Int32.Parse(item.YearOfIssue) < to)
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
                            break;
                    }
                }
                find.Acctivate(bList, -1);
            }
        }
        private void FindVehicle_Click(object sender, RoutedEventArgs e)
        {
            if (TBFind.Text != null && TBFind.Text != "Введите элемент" && TBFind.Text != "")
            {
                string findVehicleAttr = Box.Text;
                string outString = TBFind.Text.Substring(0, 1).ToUpper() + TBFind.Text.Substring(1).ToLower();

                FindItem find = new FindItem();
                var bList = new BindingList<Vehicle>();
                bList.Clear();

                foreach (var item in vehicle_Data[ind])
                {
                    switch (findVehicleAttr)
                    {
                        case "Поиск двигателю":
                            if (item.TypeOfEngine == outString)
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
                            break;

                        case "Поиск по марке":
                            if (item.Brand == outString)
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
                            break;
                        case "Поиск цвету":
                            if (item.Color == outString)
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
                            break;
                        case "Поиск по объему":
                            if (item.SizeOfEngine.StartsWith(outString))
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
                            break;
                        case "Поиск по гос номеру":
                            if (item.Count.StartsWith(outString))
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
                            break;
                    }
                }
                find.Acctivate(bList, -1);
            }
            else
            {
                MessageBox.Show("Заполните поле поиска", "Ошибка", (MessageBoxButton)System.Windows.Forms.MessageBoxButtons.OK, (MessageBoxImage)System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            for (int i = 0; i < db.Table.Count(); i++)
            {
                db.Table.RemoveRange(tables);

            }
            int h = 0;
            foreach (var iter in vehicle_Data[ind])
            {
                db.Table.Add(new Table
                {
                    id = h++,
                    Brand = iter.Brand,
                    Model = iter.Model,
                    YearOfIssue = iter.YearOfIssue,
                    Color = iter.Color,
                    Condition = iter.Condition,
                    Cost = iter.Cost,
                    Count = iter.Count,
                    Image = iter.ImageAdr,
                    TypeOfEngine = iter.TypeOfEngine,
                    SizeOfEngine = iter.SizeOfEngine,
                    PowerOfEngine = iter.PowerOfEngine,
                });
            }
            db.SaveChanges();
        }


        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            int index = DGClothes.SelectedIndex;
            vehicle_Data.Add(DeepCopy(vehicle_Data[ind]));
            ind++;

            if (vehicle_Data[ind].Count > index && index > -1)
            {
                vehicle_Data[ind].RemoveAt(index);
                DGClothes.ItemsSource = vehicle_Data[ind];
                BtnUndo.IsEnabled = true;
                CountOf.Text = $"Всего авто: {vehicle_Data[ind].Count}";
            }

        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            int index = DGClothes.SelectedIndex;

            vehicle_Data.Add(DeepCopy(vehicle_Data[ind]));

            ind++;

            if (vehicle_Data[ind].Count > index && index > -1)
            {
                DGClothes.ItemsSource = vehicle_Data[ind];
                AddDialog dlg = new AddDialog();
                dlg.Acctivate(vehicle_Data[ind], index);
            }
            BtnUndo.IsEnabled = true;
        }


        private void DataGridHyperlinkColumn_Click(object sender, RoutedEventArgs e)
        {
            int index = DGClothes.SelectedIndex;

            More dlg = new More();
            dlg.Acctivate(vehicle_Data[ind][index]);
        }

        private void BtnUndo_Click(object sender, RoutedEventArgs e)
        {
            if (ind != 0)
            {
                ind--;
                DGClothes.ItemsSource = vehicle_Data[ind];
                if (ind == 0)
                {
                    BtnUndo.IsEnabled = false;
                }
                BtnRedo.IsEnabled = true;
                CountOf.Text = $"Всего авто: {vehicle_Data[ind].Count}";
            }
        }

        private void BtnRedo_Click(object sender, RoutedEventArgs e)
        {
            if (ind < vehicle_Data.Count - 1)
            {
                ind++;
                DGClothes.ItemsSource = vehicle_Data[ind];
                if (ind == vehicle_Data.Count - 1)
                {
                    BtnRedo.IsEnabled = false;
                }
                BtnUndo.IsEnabled = true;
                CountOf.Text = $"Всего авто: {vehicle_Data[ind].Count}";
            }
        }

        private void DGClothes_Sorting(object sender, System.Windows.Controls.DataGridSortingEventArgs e)
        {
            for (int i = 0; i < vehicle_Data[ind].Count; i++)
            {
                for (int j = i; j < vehicle_Data[ind].Count; j++)
                {
                    if (bUp)
                    {
                        if (Int32.Parse(vehicle_Data[ind][i].Count) > Int32.Parse(vehicle_Data[ind][j].Count))
                        {
                            var temp = vehicle_Data[ind][i];
                            vehicle_Data[ind][i] = vehicle_Data[ind][j];
                            vehicle_Data[ind][j] = temp;
                        }

                    }
                    else
                    {
                        if (Int32.Parse(vehicle_Data[ind][i].Count) < Int32.Parse(vehicle_Data[ind][j].Count))
                        {
                            var temp = vehicle_Data[ind][i];
                            vehicle_Data[ind][i] = vehicle_Data[ind][j];
                            vehicle_Data[ind][j] = temp;
                        }
                    }
                }
            }
            bUp = !bUp;
        }

        private void TBFind_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            TBFind.Text = null;
        }

        private void TBFind_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Regex.IsMatch(TBFind.Text, @"""\w*"))
            {
                TBFind.Text = TBFind.Text.Remove(TBFind.Text.Length - 1);
                TBFind.SelectionStart = TBFind.Text.Length;
            }
            
        }

        private void ToVib_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            ToVib.Text = null;
        }

        private void FromVib_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            FromVib.Text = null;
        }

        private void Sort_Click(object sender, RoutedEventArgs e)
        {
            Sort sort = new Sort();
            sort.Acctivate(vehicle_Data[ind], -1);
        }
    }
}
