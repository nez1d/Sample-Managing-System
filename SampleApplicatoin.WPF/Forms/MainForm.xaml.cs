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

namespace SampleApplicatoin.WPF.Forms
{
    /// <summary>
    /// Логика взаимодействия для MainForm.xaml
    /// </summary>
    public partial class MainForm : Window
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private int couter = 0;

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void fullScreenBtn_Click(object sender, RoutedEventArgs e)
        {
            if(couter % 2 != 0)
            {
                couter++;
                this.WindowState = WindowState.Normal;
            }
            else
            {
                couter++;
                this.WindowState = WindowState.Maximized;
            }
            
        }

        private void minimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void topPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
    }
}
