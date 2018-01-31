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

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// DataGridのﾃﾞｰﾀを保持するﾌﾟﾛﾊﾟﾃｨ
        /// </summary>
        public ObservableCollection<RowItem> Items { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Items = new ObservableCollection<RowItem>
            {
                new RowItem()
                {
                    Column1 = "Column1-1",
                    Column2 = "Column2-1",
                    Column3 = "Column3-1",
                    Column4 = "Column4-1",
                    Column5 = "Column5-1",
                },
                new RowItem()
                {
                    Column1 = "Column1-2",
                    Column2 = "Column2-2",
                    Column3 = "Column3-2",
                    Column4 = "Column4-2",
                    Column5 = "Column5-2",
                },
                new RowItem()
                {
                    Column1 = "Column1-3",
                    Column2 = "Column2-3",
                    Column3 = "Column3-3",
                    Column4 = "Column4-3",
                    Column5 = "Column5-3",
                }
            };
            dataGrid.ItemsSource = Items;
        }

        public class RowItem
        {
            public string Column1 { get; set; }
            public string Column2 { get; set; }
            public string Column3 { get; set; }
            public string Column4 { get; set; }
            public string Column5 { get; set; }
        }
    }
}
