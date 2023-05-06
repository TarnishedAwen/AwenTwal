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

namespace SplatoonFanGame
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Agent1Button_Click(object sender, RoutedEventArgs e)
        {
            // Implement the logic for choosing Agent 1.
            MessageBox.Show("You have chosen Agent 1!");
        }

        private void Agent2Button_Click(object sender, RoutedEventArgs e)
        {
            // Implement the logic for choosing Agent 2.
            MessageBox.Show("You have chosen Agent 2!");
        }

        private void Agent3Button_Click(object sender, RoutedEventArgs e)
        {
            // Implement the logic for choosing Agent 3.
            MessageBox.Show("You have chosen Agent 3!");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}