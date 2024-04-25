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

namespace Weather
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

        private void Hozzaadas_Click(object sender, RoutedEventArgs e)
        {
            if (textbox.Text != "")
            {
                listbox.Items.Add(textbox.Text);
            }
            else
            {
                MessageBox.Show("Valamit írj be!");
            }
        }

        private void Törlés_Click(object sender, RoutedEventArgs e)
        {
            if(listbox.SelectedItem != null)
            {
                listbox.Items.Remove(listbox.SelectedItem);
            }
        }
    }
}