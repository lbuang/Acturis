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

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Would you like to add the Name ?", " ", MessageBoxButton.YesNo, MessageBoxImage.Question);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    listBox1.Items.Add(informationBox.Text);
                    informationBox.Clear();
                    break;
                case MessageBoxResult.No:
                    informationBox.Clear();
                    break;
            }
        }
        //private void AddButton_Click(object sender, RoutedEventArgs e)

        //{

        //    listBox1.Items.Add(informationBox.Text);

        //}
        private void RemoveButton_Click(object sender, RoutedEventArgs e)

        {
            MessageBoxResult result2 = MessageBox.Show("Remove This Name ???", " ", MessageBoxButton.YesNo, MessageBoxImage.Question);
            switch (result2)
            {
                case MessageBoxResult.Yes:
                    listBox1.Items.RemoveAt(listBox1.Items.IndexOf(listBox1.SelectedItem));
                    informationBox.Clear();
                    break;
                case MessageBoxResult.No:
                    informationBox.Clear();
                    break;
            }


            //listBox1.Items.RemoveAt(listBox1.Items.IndexOf(listBox1.SelectedItem));

        }
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
