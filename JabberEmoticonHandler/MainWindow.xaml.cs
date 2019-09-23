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

namespace JabberEmoticonHandler
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SelectButton(B_Home);
        }

        public void toggle(object sender)
        {
            UnSelectButton(B_Home);
            UnSelectButton(B_Application);
            UnSelectButton(B_Download);
            UnSelectButton(B_PacketList);
            UnSelectButton(B_Settings);

            Button btn = sender as Button;
            SelectButton(btn);

            UserControlContainer.Children.Clear();

        }

        //Menubuttons
        private void B_Home_Click(object sender, RoutedEventArgs e)
        {
            toggle(sender);
            UserControls.Home UserControl = new UserControls.Home();
            UserControlContainer.Children.Add(UserControl);
        }
        private void B_Download_Click(object sender, RoutedEventArgs e)
        {
            toggle(sender);
            UserControls.Download UserControl = new UserControls.Download();
            UserControlContainer.Children.Add(UserControl);
        }
        private void B_Application_Click(object sender, RoutedEventArgs e)
        {
            toggle(sender);
            UserControls.Anwendung UserControl = new UserControls.Anwendung();
            UserControlContainer.Children.Add(UserControl);
        }
        private void B_PacketList_Click(object sender, RoutedEventArgs e)
        {
            toggle(sender);
            UserControls.Paketliste UserControl = new UserControls.Paketliste();
            UserControlContainer.Children.Add(UserControl);
        }
        private void B_Settings_Click(object sender, RoutedEventArgs e)
        {
            toggle(sender);
            UserControls.Settings UserControl = new UserControls.Settings();
            UserControlContainer.Children.Add(UserControl);
        }

        private void DockPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        private void Topbar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        public void SelectButton(Button btn)
        {
            btn.Background = new SolidColorBrush(Color.FromArgb(255, 35, 35, 35));
        }
        public void UnSelectButton(Button btn)
        {
            btn.Background = null;
        }

        //
        private void B_Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void B_Min_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
