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

namespace CustomMessageBox
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

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            new MessageBoxCustom("You have clicked button Ok.", MessageType.Info, MessageButtons.Ok).ShowDialog();
        }

        private void btnOkCancel_Click(object sender, RoutedEventArgs e)
        {
            bool? Result = new MessageBoxCustom("Are you sure, You want to close application ?", MessageType.Confirmation, MessageButtons.OkCancel).ShowDialog();
        }

        private void btnYesNo_Click(object sender, RoutedEventArgs e)
        {
            bool? Result = new MessageBoxCustom("Are you sure, You want to close application ?", MessageType.Confirmation, MessageButtons.YesNo).ShowDialog();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            bool? Result = new MessageBoxCustom("Are you sure, You want to close application ?", MessageType.Confirmation, MessageButtons.YesNo).ShowDialog();
            if (Result.Value)
            {
                Application.Current.Shutdown();
            }
        }

        private void btnOkWarning_Click(object sender, RoutedEventArgs e)
        {
            bool? Result = new MessageBoxCustom("Warning message from the application.", MessageType.Warning, MessageButtons.Ok).ShowDialog();
        }

        private void btnOkError(object sender, RoutedEventArgs e)
        {
            bool? Result = new MessageBoxCustom("Error message from the application.", MessageType.Error, MessageButtons.Ok).ShowDialog();
        }

        private void btnOkSuccessClick(object sender, RoutedEventArgs e)
        {
            bool? Result = new MessageBoxCustom("Operation Successfully Done.", MessageType.Success, MessageButtons.Ok).ShowDialog();
        }
    }
}
