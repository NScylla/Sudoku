using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Threading;

namespace SudokuScylla
{
    /// <summary>
    /// NewGameWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class NewGameWindow : Window
    {
        private GameCode game;
        private TextBlock[,] sudokuBlocks;
        public NewGameWindow(SudokuLevels level)
        {
            InitializeComponent();
            GenerateSudokuGrid();
            StartGane(level);
        }


        private void StartGane(SudokuLevels level)
        {
            var game = new GameCode();
            game.GenerateGame(level);
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    sudokuBlocks[i, j].SetBinding(TextBlock.TextProperty, new Binding($"Board[{i}][{j}]"));
                }

                DataContext = game;
            }
        }


        private void GenerateSudokuGrid()
        {
            sudokuBlocks = new TextBlock[9, 9];
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                {

                    var border = new Border
                    {
                        BorderBrush = Brushes.Black,
                        BorderThickness = GetThickness(i, j, 0.1, 0.3)
                    };
                    sudokuBlocks[i, j] = new TextBlock
                    {
                        FontSize = 5,
                        VerticalAlignment = VerticalAlignment.Center,
                        HorizontalAlignment = HorizontalAlignment.Center
                    };
                    border.Child = sudokuBlocks[i, j];
                    Grid.SetRow(border, i);
                    Grid.SetColumn(border, j);
                    SudokuGrid.Children.Add(border);
                }
        }

        private Thickness GetThickness(int i, int j, double thin, double thick)
        {
            var top = i % 3 == 0 ? thick : thin;
            var bottom = i % 3 == 2 ? thick : thin;
            var left = j % 3 == 0 ? thick : thin;
            var right = j % 3 == 2 ? thick : thin;
            return new Thickness(left, top, right, bottom);
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void HintBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PauseBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void No1Btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void No2Btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void No3Btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void No4Btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void No5Btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void No6Btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void No7Btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void No8Btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void No9Btn_Click(object sender, RoutedEventArgs e)
        {

        }



        //private void Window_Loaded(object sender, RoutedEventArgs e)
        //{
        //    DispatcherTimer dispatcherTimer = new DispatcherTimer();
        //    dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
        //    dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
        //    dispatcherTimer.Start();
    }
        //private void dispatcherTimer_Tick(object sender, EventArgs e)
        //{
        //    Timer.Items.Add(DateTime.Now.ToString("HH:mm:ss"));
        //    CommandManager.InvalidateRequerySuggested();
        //    Timer.Items.MoveCurrentToLast();
        //    Timer.SelectedItem = Timer.Items.CurrentItem;
        //    Timer.ScrollIntoView(Timer.Items.CurrentItem);
        //}


    }

