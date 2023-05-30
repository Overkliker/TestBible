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
using DesBible;
using Microsoft.Win32;

namespace TestBible
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SerBtn_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            TrueBike tb = new TrueBike();

            sf.ShowDialog();
            tb.diametr = Convert.ToInt32(DiamTbx.Text);
            tb.wheel = WheelTbx.Text;
            tb.chane = ChaneTbx.Text;
            tb.frame = FrameTbx.Text;


            DesBible.Class1.Ser<TrueBike>(tb, sf.FileName);
        }

        private void SesBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();

            TrueBike tb = DesBible.Class1.Des<TrueBike>(dialog.FileName);
            if (tb != null)
            {
                FrameTbx.Text = tb.frame;
                ChaneTbx.Text = tb.chane;
                DiamTbx.Text = tb.diametr.ToString();
                WheelTbx.Text = tb.wheel;

            }
        }
    }
}
