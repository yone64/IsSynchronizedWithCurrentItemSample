using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
    public class CustomDs
    {
        private ObservableCollection<ObservableCollection<Item>> list = 
                 new ObservableCollection<ObservableCollection<Item>>
                    {
                        new ObservableCollection<Item>{new Item{Key = "11", Value = "aaa"},new Item{Key = "12", Value = "bbb"},new Item{Key = "13", Value = "ccc"}},
                        new ObservableCollection<Item>{new Item{Key = "21", Value = "ddd"},new Item{Key = "22", Value = "eee"},new Item{Key = "23", Value = "fff"}},
                        new ObservableCollection<Item>{new Item{Key = "31", Value = "ggg"},new Item{Key = "32", Value = "hhh"},new Item{Key = "33", Value = "iii"}},
                        new ObservableCollection<Item>{new Item{Key = "41", Value = "jjj"},new Item{Key = "42", Value = "kkk"},new Item{Key = "43", Value = "lll"}},
                    };

        public ObservableCollection<ObservableCollection<Item>> ListSource
        {
            get
            {
                return list;
            }
        }
    }
    public class Item
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
