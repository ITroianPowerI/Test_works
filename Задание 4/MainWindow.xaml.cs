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



namespace Задание_4
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


        string path = @"C:\Users\user\source\repos\Спасова\-\Ввод-вывод\Задание 4\Последний цвет.txt";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            label.Background = new SolidColorBrush((Color)colorpicker.SelectedColor);
            label.Content = colorpicker.SelectedColorText;
            

            using (FileStream fs = File.Create(path)) { }

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(colorpicker.SelectedColor.Value);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string col;
            using (StreamReader sr = new StreamReader(path))
            {
                col = sr.ReadToEnd();
            }

            Color c = (Color)ColorConverter.ConvertFromString(col);
            colorpicker.SelectedColor = c;
            label.Background = new SolidColorBrush((Color)colorpicker.SelectedColor);
            label.Content = colorpicker.SelectedColorText;
        }
    }
}
