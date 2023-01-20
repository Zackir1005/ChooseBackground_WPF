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

namespace ChooseBackground_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (comboBox1.Text=="Monkey")
            {
                BitmapImage bi3= new BitmapImage();
                bi3.BeginInit();
                bi3.UriSource = new Uri("/Снимок.PNG", UriKind.Relative);
                bi3.EndInit();
                Image1.Source=bi3;
            }
            else
            {
                if (comboBox1.Text == "Bugatti")
                {
                    BitmapImage bi3 = new BitmapImage();
                    bi3.BeginInit();
                    bi3.UriSource = new Uri("/32757-sportivnyiy_avtomobil_siniy_bugatti_chiron.jpg", UriKind.Relative);
                    bi3.EndInit();
                    Image1.Source = bi3;
                }
                else
                {
                    if (comboBox1.Text == "Audi")
                    {
                        BitmapImage bi3 = new BitmapImage();
                        bi3.BeginInit();
                        bi3.UriSource = new Uri("/141262-udachnyj_hod-sportkar-audi_r8-lambordzhini-dvigatel_v10-1920x1080.jpg", UriKind.Relative);
                        bi3.EndInit();
                        Image1.Source = bi3;
                    }
                    else
                    {
                        BitmapImage bi3 = new BitmapImage();
                        bi3.BeginInit();
                        bi3.UriSource = new Uri("/СерыйФон1.PNG", UriKind.Relative);
                        bi3.EndInit();
                        Image1.Source = bi3;
                    }
                }
            }
            
        }
    }
}
