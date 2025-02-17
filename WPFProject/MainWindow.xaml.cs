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

namespace WPFProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MySmiley_Click(object sender, RoutedEventArgs e)
        {
            if (((Smiley)sender).Etat == "Content")
            { ((Smiley)sender).Etat = "Triste"; }
            else { ((Smiley)sender).Etat = "Content"; }
        }
    }


    #region "MyControl : Smiley"
    public class Smiley : Button
    {
        private string etat;
        public Smiley():base()
        {
            this.Background = new SolidColorBrush(Color.FromRgb(255, 255, 102));
            this.HorizontalAlignment = HorizontalAlignment.Left;
            this.VerticalAlignment = VerticalAlignment.Top;
            this.Margin = new Thickness(447, 250, 0, 0);
           
        }

        //public enum Humeur { Content, Triste}
        public string? Etat {
            get { return this.etat; }
            set {
                this.etat = value;
                if (this.etat == "Content")
                {
                    this.Content = ":-)";
                }
                else
                {
                    this.Content = ":-(";
                }
            } 
        }
        
    }


    #endregion


}