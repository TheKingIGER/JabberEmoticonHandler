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

namespace JabberEmoticonHandler.UserControls
{
    /// <summary>
    /// Interaktionslogik für Download.xaml
    /// </summary>
    public partial class Download : UserControl
    {
        public Download()
        {
            InitializeComponent();
        }

        private void B_Download_Click(object sender, RoutedEventArgs e)
        {
            TextRange textRange = new TextRange(RTB_Output.Document.ContentStart, RTB_Output.Document.ContentEnd);
            textRange.Text = "Another world, another text!";
        }
    }
}
