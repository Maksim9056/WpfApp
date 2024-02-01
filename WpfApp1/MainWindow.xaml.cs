using System.DirectoryServices.ActiveDirectory;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Boton.Content = "Кнопка первая";
        }
        private void Boton_Click(object sender, RoutedEventArgs e)
        {
            Boton.Content = "Кнопка вторая";

            Thickness currentMargin = Boton.Margin;
            double newTopValue = currentMargin.Top + 20;
            double newBottomValue = newTopValue + Boton.ActualHeight;
            double newLeftValue = currentMargin.Left;
            double newRightValue = newLeftValue + Boton.ActualWidth;

            var s = Forms.Top;

            var Heaht = Forms.ActualHeight - 60;
            if (Heaht <= newTopValue || Heaht > newTopValue)
            {
                if(Heaht < newTopValue)
                {
                    currentMargin.Top = newTopValue -40;
                    Boton.Margin = currentMargin;
                }
                else
                {
                    currentMargin.Top = newTopValue;
                    Boton.Margin = currentMargin;
                }
              
            }

        }


    }
}