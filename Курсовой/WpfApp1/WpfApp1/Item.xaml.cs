using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Cart.UserControls
{
    public partial class Item : UserControl
    {
        public Item()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty SourceProperty = DependencyProperty.Register("Source", typeof(ImageSource), typeof(Item));

        public string Count
        {
            get { return (string)GetValue(CountProperty); }
            set { SetValue(CountProperty, value); }
        }

        public static readonly DependencyProperty CountProperty = DependencyProperty.Register("Count", typeof(string), typeof(Item));

        public void Button_MouseDownPlusCounter(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            int temp = int.Parse(Count);
            temp++;
            Count = temp.ToString();
        }
        public void Button_MouseDownMinusCounter(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            int temp = int.Parse(Count);
            if (temp != 1)
            {
                temp--;
                Count = temp.ToString();
            }
        }
    }
}