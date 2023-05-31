using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace TestBible
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static string locale;
        public static string Locale
        {
            get { return locale; }
            set { locale = value;
                var dict = new ResourceDictionary { Source = new Uri($"pack://application:,,,/SetLoc;component/Themes/{value}.xaml") };
                Current.Resources.MergedDictionaries.RemoveAt(0);
                Current.Resources.MergedDictionaries.Insert(0, dict);
            }
        }

        public App()
        {
            InitializeComponent();
        }
    }
}

