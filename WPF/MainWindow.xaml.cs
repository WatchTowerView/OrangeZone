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
using System.IO;

namespace Cars1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string[] stringlistofCars;

        public MainWindow()
        {
            InitializeComponent();


            stringlistofCars = File.ReadAllLines(@"ListofCars.txt");

            lv_gridView.Columns[0].
            for (int i = 0; i < stringlistofCars.Length; i++) {
                     
                //listView_cars.Items.Add(stringlistofCars[i]);
              
             listView_cars.

            }
            

        }

        private void tabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (  (tabControl.SelectedItem == TAB_ListOfCars)  && (statusBar_item1 != null))
            {
                statusBar_item1.Content = "List of Cars";
            }
            else {
                statusBar_item1.Content = "List of Prices";
            }
        }
    }
}
