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

namespace SudokuScylla
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnNew_Click(object sender, RoutedEventArgs e)
        {
            LevelWindow levelWindow = new LevelWindow();
            this.Hide();
            levelWindow.Show();
        }

        private void BtnScores_Click(object sender, RoutedEventArgs e)
        {
            ScoresWindow scoresWindow = new ScoresWindow();
            this.Hide();
            scoresWindow.Show();
        }

        private void BtnOpt_Click(object sender, RoutedEventArgs e)
        {
            OptionsWindow optionsWindow = new OptionsWindow();
            this.Hide();
            optionsWindow.Show();
        }

        private void BtnHelp_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();
            this.Hide();
            helpWindow.Show();
        }

        private void BtnAbout_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow aboutWindow = new AboutWindow();
            this.Hide();
            aboutWindow.Show();
        }
    }
}
