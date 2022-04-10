using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace KnToolsHulftJpMon
{
    /// <summary>
    /// SelectServers.xaml の相互作用ロジック
    /// </summary>
    public partial class SelectServers : Window
    {
        public SelectServers()
        {
            InitializeComponent();

            var list = new PrefList();
            this.DataContext = list;

            list.AddNewItem("aaaaa");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           Debug.WriteLine( listBox.SelectedItems[0]);
           
        }
    }
}
