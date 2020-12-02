using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace SudokuScylla
{
    public class GameCode
    {
        #region deneme
        //public int[,] s; // sudoku numbers
        //private int[,] f; // facts

        ////int[,] BoxNumbers = new int[9, 9]; //9satır,9sütun

        //int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //Random rnd = new Random();

        //public int GetNumber()
        //{
        //    return nums[rnd.Next(nums.Length)];
        //}

        //public void RowControl()
        //{
        //    if (nums.)
        //    {
        //        Console.WriteLine(nums);
        //    }

        //    else
        //    {
        //        GetNumber();
        //    }
        //}

        //public void ColumnControl ()
        //{
        //    if (nums != )
        //    {
        //        Console.WriteLine(nums);
        //    }

        //    else
        //    {
        //        GetNumber();
        //    }
        //}

        //public void BoxControl()
        //{
        //    if (nums != )
        //    {
        //        Console.WriteLine(nums);
        //    }

        //    else
        //    {
        //        GetNumber();
        //    }
        //}

        //public string GetGameString()
        //{
        //    string result = "";

        //    for (int i = 0; i < 9; i++)
        //    {
        //        for (int j = 0; j < 9; j++)
        //        {
        //            result += s[i, j].ToString();

        //        }
        //    }

        //    result = result.Replace("0", "X");

        //    return result;
        //}

        //public bool SetGameString(string game)
        //{
        //    if (game.Length != 81) return false;

        //    for (int n = 0; n < 81; n++)
        //    {
        //        char c = game[n];

        //        if ((c < '1' || c > '9') && c != 'X') return false;
        //    }

        //    for (int n = 0; n < 81; n++)
        //    {
        //        string c = game.Substring(n, 1);

        //        int i = n / 9;

        //        int j = n % 9;

        //        if (c == "X")
        //        {
        //            s[i, j] = 0;
        //            f[i, j] = 0;
        //        }
        //        else
        //        {
        //            s[i, j] = Convert.ToInt32(c);
        //            f[i, j] = 1;
        //        }
        //    }

        //    EnumeratePossibilities();

        //    DisplayMessage = false;

        //    return true;

        //}

        #endregion


        #region deneme2

        //public int[,] s; // sudoku numbers

        //private int[,] a; // aids

        //private int[,] f; // facts

        //private int[,] e; // errors

        //private Random R;

        //private float realx;

        //private float realy;

        //private float realw;

        //private int hitx = -1;

        //private int hity;

        //public int sw = 0;

        //private DateTime starttime;

        //private string duration;

        //private string msg_text1;

        //private string msg_text2;

        //private bool DisplayMessage = false;

        //private bool PriorityMessage = false;

        //public enum SudokuSound
        //{
        //    Stop = 0,
        //    Square = 1,
        //    No = 2,
        //    Fine = 3,
        //    Delete = 4,
        //    Solved = 5,
        //    NewPuzzle = 6,
        //};

        //public delegate void SudokuEvent(SudokuSound S);

        //public delegate void SudokuEvent2();

        //public event SudokuEvent PlaySound;

        //public event SudokuEvent2 RequestRepaint;

        //public bool ShowErrors = false;

        //public enum SolveMethods
        //{
        //    All = 65535,
        //    NakedSingles = 1,
        //    HiddenSingles = 2,
        //    BlockHiddenSingles = 4,

        //}

        //public class SolutionStep
        //{
        //    public int x;
        //    public int y;
        //    public int num;

        //    public SolutionStep()
        //    {
        //        x = 0; y = 0; num = 0;
        //    }

        //    public SolutionStep(int x, int y, int num)
        //    {
        //        this.x = x;
        //        this.y = y;
        //        this.num = num;
        //    }
        //};

        //public class SolutionStepList
        //{
        //    private List<SolutionStep> L;

        //    public SolutionStepList()
        //    {
        //        L = new List<SolutionStep>();
        //    }

        //    private bool Search(SolutionStep ss)
        //    {
        //        for (int i = 0; i < L.Count; i++)
        //        {
        //            SolutionStep present = L[i];

        //            if (ss.x == present.x && ss.y == present.y && ss.num == present.num) return true;
        //        }

        //        return false;
        //    }

        //    public void Add(SolutionStep ss)
        //    {
        //        // if (!Search(ss)) L.Add(ss);

        //        L.Add(ss);
        //    }

        //    public int Count()
        //    {
        //        return L.Count;
        //    }

        //    public SolutionStep getItem(int index)
        //    {
        //        return L[index];
        //    }


        //}



        //public GameCode()
        //{
        //    s = new int[9, 9];

        //    f = new int[9, 9];

        //    a = new int[9, 9];

        //    e = new int[9, 9];

        //    R = new Random();

        //    EnumeratePossibilities();

        //    return;
        //}

        //public void Deselect()
        //{
        //    hitx = -1;
        //}

        //public void DeleteCurrentSquare()
        //{
        //    if (hitx != -1)
        //    {
        //        s[hity, hitx] = 0;
        //        e[hity, hitx] = 0;
        //    }

        //    hitx = -1;

        //    EnumeratePossibilities();
        //}

        //public void KeyPress(char KeyCode)
        //{
        //    if (DisplayMessage & !PriorityMessage)
        //    {
        //        DisplayMessage = false;

        //        return;
        //    }

        //    if (KeyCode < '1' || KeyCode > '9') return;

        //    if (hitx == -1) return;

        //    s[hity, hitx] = KeyCode - '0';

        //    e[hity, hitx] = 0;

        //    hitx = -1;

        //    EnumeratePossibilities();

        //    // ComputeErrors();

        //    if (PlaySound != null) PlaySound(SudokuSound.Square);




        //}

        //public void UseTemplate()
        //{
        //    string game1 = "X6X1X4X5XXX83X56XX2XXXXXXX18XX4X7XX6XX6XXX3XX7XX9X1XX45XXXXXXX2XX72X69XXX4X5X8X7X"; // easy 1

        //    game1 = "XXXX7XX6X6XXXXXX42XXX89XX15XXXXX54XX769XXX521XX19XXXXX91XX42XXX28XXXXXX3X7XX8XXXX"; // easy 2

        //    // game1 = "XXXXXXXX547XXXXXXX85XX42XXX64X58XXXXXX79X41XXXXXX73X96XXX85XX34XXXXXXX673XXXXXXXX"; // hard 1

        //    game1 = "829173456713645298645298173381726945976514832452839617297381564168457329534962781"; //complete game

        //    SetGameString(game1);
        //}

        //public void RenderMessage(string line1, string line2, bool priority)
        //{
        //    if (!priority && DisplayMessage) return;

        //    msg_text1 = line1;
        //    msg_text2 = line2;
        //    PriorityMessage = priority;
        //    DisplayMessage = true;

        //    if (RequestRepaint != null) RequestRepaint();
        //}

        //public void ScrambleGame()
        //{
        //    //0 1, 1 2, 3 4, 4 5, 6 7 7 8

        //    int[] scramble_array = { 0, 1, 3, 4, 6, 7 };

        //    int scrambles = 10;

        //    for (int n = 0; n < scrambles; n++)
        //    {
        //        int index = R.Next(6);

        //        int val = scramble_array[index];

        //        SwapRows(val, val + 1);
        //    }

        //    for (int n = 0; n < scrambles; n++)
        //    {
        //        int index = R.Next(6);

        //        int val = scramble_array[index];

        //        SwapCols(val, val + 1);
        //    }

        //    ChangeSymbols();

        //    EnumeratePossibilities();

        //}

        //public string GetGameString()
        //{
        //    string result = "";

        //    for (int i = 0; i < 9; i++)
        //    {
        //        for (int j = 0; j < 9; j++)
        //        {
        //            result += s[i, j].ToString();

        //        }
        //    }

        //    result = result.Replace("0", "X");

        //    return result;
        //}

        //public bool SetGameString(string game)
        //{
        //    if (game.Length != 81) return false;

        //    for (int n = 0; n < 81; n++)
        //    {
        //        char c = game[n];

        //        if ((c < '1' || c > '9') && c != 'X') return false;
        //    }

        //    for (int n = 0; n < 81; n++)
        //    {
        //        string c = game.Substring(n, 1);

        //        int i = n / 9;

        //        int j = n % 9;

        //        if (c == "X")
        //        {
        //            s[i, j] = 0;
        //            f[i, j] = 0;
        //        }
        //        else
        //        {
        //            s[i, j] = Convert.ToInt32(c);
        //            f[i, j] = 1;
        //        }
        //    }

        //    EnumeratePossibilities();

        //    DisplayMessage = false;

        //    return true;

        //}

        //public bool CheckGame()
        //{

        //    List<int> L = new List<int>();

        //    for (int i = 0; i < 9; i++)
        //    {

        //        // Checking rows:

        //        L.Clear();

        //        for (int j = 0; j < 9; j++) L.Add(s[i, j]);

        //        if (CheckOneToNine(L) == false) return false;

        //        // Checking rolumns:

        //        L.Clear();

        //        for (int j = 0; j < 9; j++) L.Add(s[j, i]);

        //        if (CheckOneToNine(L) == false) return false;

        //        // Checking blocks:

        //        for (int x = 0; x < 9; x += 3)
        //        {
        //            for (int y = 0; y < 9; y += 3)
        //            {
        //                L.Clear();

        //                for (int j = 0; j < 3; j++)
        //                {
        //                    for (int k = 0; k < 3; k++)
        //                    {
        //                        L.Add(s[x + j, y + k]);

        //                    }
        //                }

        //                if (CheckOneToNine(L) == false) return false;

        //            }


        //        }

        //    }

        //    return true;
        //}

        //public SolutionStepList ComputePossibleSteps(SolveMethods M)
        //{
        //    EnumeratePossibilities();

        //    SolutionStepList L = new SolutionStepList();

        //    // Looking for naked singles

        //    if ((M & SolveMethods.NakedSingles) > 0)
        //    {

        //        for (int i = 0; i < 9; i++)
        //        {
        //            for (int j = 0; j < 9; j++)
        //            {
        //                double index = Math.Log(a[j, i], 2) + 1;

        //                if (index == Math.Floor(index) && a[j, i] > 0 && s[j, i] == 0)
        //                {
        //                    L.Add(new SolutionStep(i, j, Convert.ToInt32(index)));
        //                }
        //            }
        //        }
        //    }

        //    // Looking for hidden singles

        //    if ((M & SolveMethods.HiddenSingles) > 0)
        //    {
        //        for (int i = 0; i < 9; i++)
        //        {
        //            for (int j = 0; j < 9; j++)
        //            {
        //                int mask = 0;

        //                for (int m = 0; m < 9; m++)
        //                {
        //                    if (m != j) mask |= a[m, i];
        //                }

        //                int match = a[j, i] & (511 - mask);

        //                if (s[j, i] == 0 && match > 0)
        //                {
        //                    // Bingo

        //                    double index = Math.Log(match, 2) + 1;

        //                    L.Add(new SolutionStep(i, j, Convert.ToInt32(index)));
        //                }
        //            }
        //        }
        //    }

        //    // Looking for block-hidden singles

        //    if ((M & SolveMethods.BlockHiddenSingles) > 0)
        //    {
        //        for (int i = 0; i < 9; i++)
        //        {
        //            for (int j = 0; j < 9; j++)
        //            {

        //                int blockx = i / 3;

        //                int blocky = j / 3;

        //                int mask = 0;

        //                for (int m = 0; m < 3; m++)
        //                {
        //                    for (int n = 0; n < 3; n++)
        //                    {
        //                        int xindex = blockx * 3 + m;

        //                        int yindex = blocky * 3 + n;

        //                        if (yindex != j || xindex != i) mask |= a[yindex, xindex];
        //                    }
        //                }

        //                int match = a[j, i] & (511 - mask);

        //                if (s[j, i] == 0 && match > 0)
        //                {
        //                    // Bingo

        //                    double index = Math.Log(match, 2) + 1;

        //                    L.Add(new SolutionStep(i, j, Convert.ToInt32(index)));
        //                }
        //            }
        //        }
        //    }

        //    return L;
        //}

        //public bool SolveStep(SolveMethods M)
        //{
        //    SolutionStepList L = ComputePossibleSteps(M);

        //    if (L.Count() == 0) return false;

        //    ApplySolutionStep(L.getItem(0));

        //    return true;

        //}

        //public bool SolvePuzzle(SolveMethods M)
        //{
        //    while (SolveStep(M)) ;

        //    return (isFull());

        //}

        //private bool isFull()
        //{
        //    for (int i = 0; i < 9; i++)
        //        for (int j = 0; j < 9; j++)
        //        {
        //            if (s[i, j] == 0) return false;
        //        }
        //    return true;
        //}

        //private List<int> GenerateRandomList()
        //{
        //    Random R = new Random();

        //    List<int> L1 = new List<int>();

        //    List<int> L2 = new List<int>();

        //    for (int i = 1; i < 10; i++) L1.Add(i);

        //    while (L1.Count > 0)
        //    {
        //        int index = R.Next(L1.Count);

        //        L2.Add(L1[index]);

        //        L1.RemoveAt(index);
        //    }

        //    return L2;


        //}
        //private bool CheckOneToNine(List<int> L)
        //{
        //    if (L.Count != 9) MessageBox.Show("Problem here!");

        //    int[] vals = new int[10];

        //    for (int i = 0; i < 9; i++)
        //    {
        //        int item = L[i];

        //        if (item > 0)
        //        {
        //            vals[item]++;

        //            if (vals[L[i]] > 1) return false;
        //        }
        //    }
        //    return true;
        //}

        //private void EnumeratePossibilities()
        //{
        //    for (int i = 0; i < 9; i++)
        //        for (int j = 0; j < 9; j++)
        //        {
        //            a[j, i] = 511;
        //        }

        //    for (int i = 0; i < 9; i++)
        //    {
        //        for (int j = 0; j < 9; j++)
        //        {
        //            if (s[j, i] > 0)
        //            {
        //                a[j, i] = (1 << (s[j, i]) - 1);

        //                int mask = 511 - (1 << (s[j, i]) - 1);

        //                int blockx = i / 3;

        //                int blocky = j / 3;

        //                for (int k = 0; k < 3; k++)
        //                {
        //                    for (int l = 0; l < 3; l++)
        //                    {
        //                        if (blocky * 3 + k != j || blockx * 3 + l != i) a[blocky * 3 + k, blockx * 3 + l] &= mask;
        //                    }
        //                }

        //                for (int n = 0; n < 9; n++)
        //                {
        //                    // Removing entries from row and column squares

        //                    if (n != i) a[j, n] &= mask;

        //                    if (n != j) a[n, i] &= mask;
        //                }
        //            }
        //        }
        //    }
        //}

        //private void SwapRows(int r1, int r2)
        //{
        //    int temp;

        //    for (int n = 0; n < 9; n++)
        //    {
        //        temp = s[r1, n];

        //        s[r1, n] = s[r2, n];

        //        s[r2, n] = temp;

        //        temp = f[r1, n];

        //        f[r1, n] = f[r2, n];

        //        f[r2, n] = temp;

        //        temp = a[r1, n];

        //        a[r1, n] = a[r2, n];

        //        a[r2, n] = temp;


        //    }
        //}

        //private void SwapCols(int c1, int c2)
        //{
        //    int temp;

        //    for (int n = 0; n < 9; n++)
        //    {
        //        temp = s[n, c1];

        //        s[n, c1] = s[n, c2];

        //        s[n, c2] = temp;

        //        temp = f[n, c1];

        //        f[n, c1] = f[n, c2];

        //        f[n, c2] = temp;

        //        temp = a[n, c1];

        //        a[n, c1] = a[n, c2];

        //        a[n, c2] = temp;
        //    }
        //}

        //private void ChangeSymbols()
        //{
        //    int[] symbols = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //    int scrambles = 10;

        //    for (int n = 0; n < scrambles; n++)
        //    {
        //        int index1 = R.Next(9) + 1;

        //        int index2 = R.Next(9) + 1;

        //        int temp = symbols[index1];

        //        symbols[index1] = symbols[index2];

        //        symbols[index2] = temp;
        //    }

        //    for (int i = 0; i < 9; i++)
        //    {
        //        for (int j = 0; j < 9; j++)
        //        {
        //            s[i, j] = symbols[s[i, j]];
        //        }
        //    }
        //}

        //private void ApplySolutionStep(SolutionStep ss)
        //{
        //    s[ss.y, ss.x] = ss.num;

        //    f[ss.y, ss.x] = 0;
        //}




        #endregion deneme2

        #region deneme3 -OK

        private long moves;
        private TimeSpan time;

        private int?[][] board;
        private int[][] solution;

        public long Moves => moves;
        public TimeSpan Time => time;

        public int?[][] Board => board;
        public int[][] Solution => solution;

        public GameCode()
        {
            time = new TimeSpan();
            board = new int?[9][];
        }

        private static readonly Random random = new Random();
        public void GenerateGame(SudokuLevels level)
        {
            GenerateSolution();

            SetupBoard(level);
        }

        /// <summary>
        /// Removes fields from the full solution.
        /// </summary>
        /// <param name="level"></param>
        private void SetupBoard(SudokuLevels level)
        {
            for (int i = 0; i < 9; i++)
            {
                board[i] = new int?[9];
                for (int j = 0; j < 9; j++)
                    board[i][j] = solution[i][j];
            }

            int remainingItems = ((int)level + 1) * 15;
            while (remainingItems > 0)
            {
                int posX = random.Next(9);
                int posY = random.Next(9);
                if (board[posX][posY] == null)
                    continue;
                board[posX][posY] = null;
                remainingItems--;
            }
        }

        readonly int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        private void GenerateSolution()
        {
            solution = new int[9][];
            var availableNumbers = new List<int>[9];

            for (int x = 0; x < availableNumbers.Length; x++)
                availableNumbers[x] = new List<int>(numbers);

            solution[0] = numbers.Shuffle();
            for (int i = 0; i < 9; i++)
                availableNumbers[i].Remove(solution[0][i]);

            int row = 1;
            int rowTries = 0;

            while (row < 9)
            {
                var rowAvailableNumbers = new List<int>(numbers.Shuffle());
                int[] currentRow = new int[9];
                List<int>[] used = new List<int>[9];
                for (var i = 0; i < used.Length; i++)
                    used[i] = new List<int>(2);
                int pos = 0;
                while (pos < 9)
                {
                    int num = rowAvailableNumbers.FirstOrDefault(
                        x => availableNumbers[pos].Contains(x) && !used[pos].Contains(x));
                    if (num != 0)
                    {
                        currentRow[pos] = num;
                        used[pos].Add(num);
                        rowAvailableNumbers.Remove(num);
                        pos++;
                    }
                    else
                    {
                        used[pos].Clear();
                        pos--;
                        rowAvailableNumbers.Add(currentRow[pos]);
                        currentRow[pos] = 0;
                    }
                }
                solution[row] = currentRow;
                for (int i = 0; i < 9; i++)
                    availableNumbers[i].Remove(solution[row][i]);
                row++;
                if (row % 3 == 0)
                    if (!BoxCheck(row / 3 - 1))
                    {
                        row--;
                        for (int i = 0; i < solution[row].Length; i++)
                            availableNumbers[i].Add(solution[row][i]);
                        rowTries++;
                        if (rowTries > 9)
                        {
                            row--;
                            for (int i = 0; i < solution[row].Length; i++)
                                availableNumbers[i].Add(solution[row][i]);
                            rowTries = 0;
                        }
                    }
                    else
                        rowTries = 0;
            }
        }

        private bool BoxCheck(int i)
        {
            for (int j = 0; j < 3; j++)
            {
                var freeNumbers = new List<int>(numbers);
                for (int x = 0; x < 3; x++)
                    for (int y = 0; y < 3; y++)
                        freeNumbers.Remove(solution[i * 3 + x][j * 3 + y]);
                if (freeNumbers.Count > 0)
                    return false;
            }
            return true;
        }

        #endregion deneme3


    }
}
