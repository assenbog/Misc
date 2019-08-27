namespace Coderbyte
{
    public class ChessMoves
    {
        public ChessMoves(int row, int col)
        {
            Row = row;
            Col = col;

            if(row < 8)
            {
                Top = new ChessMoves(row + 1, col);
            }
            else
            {
                Top = null;
            }
            if(col < 8)
            {
                Right = new ChessMoves(row, col + 1);
            }
            else
            {
                Right = null;
            }
        }

        public void PathsToCell(int row, int col, ref int count)
        {
            if(Top != null)
            {
                if(Top.Row == row && Top.Col == col)
                {
                    count++;
                    return;
                }
                else
                {
                    Top.PathsToCell(row, col, ref count);
                }
            }
            if (Right != null)
            {
                if (Right.Row == row && Right.Col == col)
                {
                    count++;
                    return;
                }
                else
                {
                    Right.PathsToCell(row, col, ref count);
                }
            }
        }

        public int Row { get; set; }

        public int Col { get; set; }

        public ChessMoves Top { get; set; }

        public ChessMoves Right { get; set; }
    }
}
