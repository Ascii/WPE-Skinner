/**
 * 
**/

using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Diagnostics;
using System.IO;

namespace WPE_Skinner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> itemsForBox = new List<string>();

        public MainWindow()
        {
            InitializeComponent();         
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            getList();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var runExplorer = new System.Diagnostics.ProcessStartInfo();
            runExplorer.FileName = "explorer";
            runExplorer.Arguments = @"C:\Program Files (x86)\Microsoft XDE\1.0\skin";
            Process.Start(runExplorer);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            string sourceFolder;

            if (this.skinListBox.SelectedItems.Count > 0)
            {
                sourceFolder = this.skinListBox.SelectedItem.ToString();
            }else{
                sourceFolder = "Default";
            }

            System.IO.File.Copy("C:\\Program Files (x86)\\Microsoft XDE\\1.0\\skin\\" + sourceFolder
                + "\\WM7_Skin.xml", "C:\\Program Files (x86)\\Microsoft XDE\\1.0\\WM7_Skin.xml",true);
        }

        private void skinListBox_Loaded(object sender, RoutedEventArgs e)
        {
            this.skinListBox.ItemsSource = itemsForBox;
        }

        private void getList()
        {
            string[] filePaths = Directory.GetFiles(@"C:\Program Files (x86)\Microsoft XDE\1.0\skin", "*.xml", SearchOption.AllDirectories);
            itemsForBox.Clear();

            foreach (String path in filePaths)
            {
                itemsForBox.Add(Directory.GetParent(path).Name);
            }
            this.skinListBox.Items.Refresh();
        }
    }
}
