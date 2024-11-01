using System;
using System.Collections;
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

namespace Arraylist
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            int inputText = int.Parse(txt.Text);
            arrayList.Add(inputText);
            MessageBox.Show(inputText + " has Added!!!");
        }


        private void Button_Remove(object sender, RoutedEventArgs e)
        {
            int removeText = int.Parse(txt.Text);
            arrayList.Remove(removeText);
            MessageBox.Show(removeText + " has removed!!!");
        }

        private void Button_Show(object sender, RoutedEventArgs e)
        {
            arrayList.Sort();
            foreach (int data in arrayList)
            {
                MessageBox.Show(data.ToString());
            }
        }

    }
}
