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
using System.Windows.Media.Media3D;
using HelixToolkit.Wpf;

namespace HelixTrial
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public VRotation vRotation;
        public MainWindow()
        {
            vRotation = new VRotation();
            InitializeComponent();

            ModelImporter importer = new ModelImporter();
            Model3D model = importer.Load("C:\\Users\\Valera\\source\\repos\\WpfApp5\\Gear OBJ\\gear.obj");
            Models.Content = model;
            DataContext = vRotation;

        }

        private void SliderY_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            vRotation.RotateY = (Int16)SliderY.Value;
        }

        private void SliderX_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            vRotation.RotateX = (Int16)SliderX.Value;
        }
    }
}
