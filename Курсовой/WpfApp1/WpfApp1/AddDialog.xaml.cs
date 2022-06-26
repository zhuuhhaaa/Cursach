using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Forms;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для AddDialog.xaml
    /// </summary>
    /// 

    public partial class AddDialog : Window
    {
        private BindingList<Vehicle> vehicles;
        int index;
        public void Acctivate(BindingList<Vehicle> c, int i)
        {
            vehicles = c;
            index = i;
            if (index != -1)
            {
                TBCondition.Text = vehicles[index].Condition;
                TBBrand.Text = vehicles[index].Brand;
                TBModel.Text = vehicles[index].Model;
                TBYear.Text = vehicles[index].YearOfIssue;
                TBCount.Text = vehicles[index].Count;
                TBEngine.Text = vehicles[index].TypeOfEngine;
                TBPower.Text = vehicles[index].PowerOfEngine;
                TBCost.Text = vehicles[index].Cost;
                TBSize.Text = vehicles[index].SizeOfEngine;
                TBImage.Text = vehicles[index].ImageAdr;
                TBColor.Text = vehicles[index].Color;
                
            }
            Activate();
            Show();
        }

        public AddDialog()
        {
            InitializeComponent();
        }



        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            if ((String.IsNullOrEmpty(TBBrand.Text) != false) || (String.IsNullOrEmpty(TBModel.Text) || (String.IsNullOrEmpty(TBYear.Text)
                || (String.IsNullOrEmpty(TBCount.Text) != false) || (String.IsNullOrEmpty(TBPower.Text) != false) || (String.IsNullOrEmpty(TBSize.Text) != false) ||
                 (String.IsNullOrEmpty(TBEngine.Text) != false) || (String.IsNullOrEmpty(TBCost.Text) != false) || (String.IsNullOrEmpty(TBColor.Text) != false) || (String.IsNullOrEmpty(TBCondition.Text) != false))))
            {
                System.Windows.MessageBox.Show("Не все поля заполнены", "Ошибка", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Error);
            }

            else
            {
                int numberId = 0;
                numberId = vehicles.Count;
                
                Vehicle vehicle = new Vehicle() { Id = numberId, Brand = TBBrand.Text, Model = TBModel.Text, YearOfIssue = TBYear.Text, Cost = TBCost.Text, Count = TBCount.Text,
                    PowerOfEngine = TBPower.Text, Color = TBColor.Text, Condition = TBCondition.Text,  ImageAdr = TBImage.Text, SizeOfEngine = TBSize.Text, TypeOfEngine = TBEngine
                .Text};
                if (index == -1 && vehicles.Count > index)
                {
                    vehicles.Add(vehicle);
                }
                else
                {
                    vehicles[index] = vehicle;
                }
                Close();
            }
        }

        private void buttonOpen_Click(object sender, RoutedEventArgs e)
        {   
            OpenFileDialog ofdPicture = new OpenFileDialog();
            ofdPicture.Filter =
                "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
            ofdPicture.FilterIndex = 1;
            ofdPicture.ShowDialog();

            if (TBImage.Text.Length >= 0 && ofdPicture.FileName.Length > 30)
            {
                TBImage.Text = null;            
                TBImage.Text = ofdPicture.FileName.Remove(0, 30);
            }
        }

        private void TBYear_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Regex.IsMatch(TBYear.Text, "[^0-9]") || TBYear.Text.Length == 5)
            {
                TBYear.Text = TBYear.Text.Remove(TBYear.Text.Length - 1);
                TBYear.SelectionStart = TBYear.Text.Length;
            }
        }

        private void TBPower_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Regex.IsMatch(TBPower.Text, "[^0-9]") || TBPower.Text.Length == 5)
            {
                TBPower.Text = TBPower.Text.Remove(TBPower.Text.Length - 1);
                TBPower.SelectionStart = TBPower.Text.Length;
            }
        }

        private void TBCost_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Regex.IsMatch(TBCost.Text, "[^0-9]") || TBCost.Text.Length == 8)
            {
                TBCost.Text = TBCost.Text.Remove(TBCost.Text.Length - 1);
                TBCost.SelectionStart = TBCost.Text.Length;
            }
        }

        private void TBCount_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Regex.IsMatch(TBCount.Text, @"""\w*"))
            {
                TBCount.Text = TBCount.Text.Remove(TBCount.Text.Length - 1);
                TBCount.SelectionStart = TBCount.Text.Length;
            }
        }

        private void TBImage_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Regex.IsMatch(TBImage.Text, @"\s"))
            {
                TBImage.Text = TBImage.Text.Remove(TBImage.Text.Length - 1);
                TBImage.SelectionStart = TBImage.Text.Length;
            }
        }

        private void TBBrand_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Regex.IsMatch(TBBrand.Text, @"""\w*"))
            {
                TBBrand.Text = TBBrand.Text.Remove(TBBrand.Text.Length - 1);
                TBBrand.SelectionStart = TBBrand.Text.Length;
            }
        }

        private void TBModel_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Regex.IsMatch(TBModel.Text, @"""\w*"))
            {
                TBModel.Text = TBModel.Text.Remove(TBModel.Text.Length - 1);
                TBModel.SelectionStart = TBModel.Text.Length;
            }
        }
    }
}
