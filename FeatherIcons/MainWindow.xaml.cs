using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace FeatherIcons
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ResourceDictionary rd = Application.Current.Resources.MergedDictionaries.FirstOrDefault();

            List<FeatherIcon> Icons = new();

            foreach (string key in rd.Keys)
            {
                DataTemplate dt = rd[key] as DataTemplate;
                Icons.Add(new FeatherIcon(key, dt));
            }

            Icons.Sort();
            FeatherIcon = Icons.Find(n => n.KeyName == "Feather");
            SetAppIcon();
            ViewControl.Items.Clear();
            IconControl.ItemsSource = Icons;
        }

        private void Clicked(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            ViewControl.ItemsSource = GetIcon((string)b.Tag);
        }

        private List<FeatherIcon> GetIcon(string KeyName)
        {
            List<FeatherIcon> fi = new();

            foreach (object o in IconControl.ItemsSource)
            {
                if (((FeatherIcon)o).KeyName == KeyName) { fi.Add((FeatherIcon)o); }
            }

            return fi;
        }

        private FeatherIcon FeatherIcon { get; set; }

        private void SetAppIcon()
        {
            Viewbox v = (Viewbox)FeatherIcon.IconData.LoadContent();
            Size s = new(96, 96);
            ((Canvas)v.Child).Measure(s);
            ((Canvas)v.Child).Arrange(new Rect(s));
            v.Measure(s);
            v.Arrange(new Rect(s));
            v.UpdateLayout();
            RenderTargetBitmap rtb = new(96, 96, 96, 96, PixelFormats.Pbgra32);
            rtb.Render(v);
            PngBitmapEncoder png = new();
            png.Frames.Add(BitmapFrame.Create(rtb));
            Icon = png.Frames[0];
        }
    }
}