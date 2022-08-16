
namespace Tetris
{
    public class GameGrid
    {
        private readonly int[,] grid;
        public int Rows { get; }
        public int Columns { get; }

        public int this[int rows, int columns]
        {
            get => grid[rows, columns];
            set => grid[rows, columns] = value; 
        }

        public GameGrid(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            grid = new int[rows , columns];
        }

        public bool IsInside(int rows, int columns)
        {
            return rows >= 0 && rows < Rows && columns >= 0 && columns < Columns;
        }

        public bool IsEmpty(int rows, int columns)
        {
            return IsInside(rows, columns) && grid[rows, columns] == 0;
        }

        public bool IsRowFull(int row) 
        {
            for ( int column = 0; column < Columns; column++)
            {
                if (grid[row, column] == 0)
                {
                    return false;
                }
            }
            
            return true;
        }

        public bool IsRowEmpty(int row)
        {
            for ( int column = 0; column < Columns; column++)
            {
                if (grid[row,column] != 0 )
                {
                    return false;
                }
            }
            
            return true;
        }

        public void ClearRow(int rows)
        {
            for (int column = 0; column < Columns; column++)
            {
                grid[rows, column] = 0;
            }
        }

        public void MoveRowDown(int row, int numbRows)
        {
            for (int column = 0; column < Columns; column++)
            {
                grid[row + numbRows, column] = grid[row,column];
                grid[row, column] = 0;
            }
        }

    }
}
