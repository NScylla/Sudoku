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
using System.Windows.Shapes;

namespace SudokuScylla
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class LevelWindow : Window
    {
        public LevelWindow()
        {
            InitializeComponent();
        }

        private TextBlock[,] sudokuBlocks;

      

        private void EasyBtn_Click(object sender, RoutedEventArgs e)
        {
            NewGameWindow newGameWindow = new NewGameWindow(SudokuLevels.Easy);
            this.Hide();
            newGameWindow.Show();
        }

        private void MediumBtn_Click(object sender, RoutedEventArgs e)
        {
            NewGameWindow newGameWindow = new NewGameWindow(SudokuLevels.Medium);
            this.Hide();
            newGameWindow.Show();
        }

        private void HardBtn_Click(object sender, RoutedEventArgs e)
        {
            NewGameWindow newGameWindow = new NewGameWindow(SudokuLevels.Hard);
            this.Hide();
            newGameWindow.Show();
        }

        private void AdvanceBtn_Click(object sender, RoutedEventArgs e)
        {
            NewGameWindow newGameWindow = new NewGameWindow(SudokuLevels.Advance);
            this.Hide();
            newGameWindow.Show();
        }

        private void NerdBtn_Click(object sender, RoutedEventArgs e)
        {
            NewGameWindow newGameWindow = new NewGameWindow(SudokuLevels.Nerd);
            this.Hide();
            newGameWindow.Show();
        }
    }
}
