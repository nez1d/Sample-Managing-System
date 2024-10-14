using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SampleApplicatoin.WPFCore.Pages.Notifications
{
    /// <summary>
    /// Логика взаимодействия для DataFormIsNullNotification.xaml
    /// </summary>
    public partial class DataFormIsNullNotification : Page
    {
        public DataFormIsNullNotification()
        {
            InitializeComponent();
        }

        private void closeDataInfoNotifiactionBtn_Click(object sender, RoutedEventArgs e)
        {
            notificationBorder.Visibility = Visibility.Hidden;
        }
    }
}
