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

namespace WPFProject
{
    /// <summary>
    /// Logique d'interaction pour Student.xaml
    /// </summary>
    public partial class Student : Window
    {
        public Student()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            Debug.Print("btnQuit_Click");
            this.Close();
            
           
        }

        private void Control_MouseEnter(object sender, MouseEventArgs e)
        {
            Control? ctrl = sender as Control;
           
            if (ctrl != null)
            {
                ctrl.Background = Brushes.Aqua;
                Debug.Print(ctrl.GetType().ToString());
                e.Handled = true;
            }
        }
    }
}
