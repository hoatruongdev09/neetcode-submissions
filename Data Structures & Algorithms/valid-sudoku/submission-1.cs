public class Solution {
    public bool IsValidSudoku(char[][] board) {

        for(int i = 0; i < 9; i++)
        {
            if(!IsValidRow(board, i))
            {
                return false;
            }
            if(!IsValidCol(board, i))
            {
                return false;
            }
        }
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                if(!IsValidBlock(board, i, j)) {
                    return false;
                }
            }
        }
        return true;
    }

    private bool IsValidRow(char[][] board, int index)
    {
        HashSet<char> temp = new();
        for(int i = 0; i < 9; i++)
        {
            if(board[index][i] == '.'){ continue ;}
            if(temp.Contains(board[index][i]))
            {
                return false;
            }
            temp.Add(board[index][i]);
        }
        return true;
    }
    private bool IsValidCol(char[][] board, int index)
    {
        HashSet<char> temp = new();
        for(int i = 0; i < 9; i++)
        {
            if(board[i][index] == '.'){ continue ;}
            if(temp.Contains(board[i][index]))
            {
                return false;
            }
            temp.Add(board[i][index]);
        }
        return true;
    }
    private bool IsValidBlock(char[][] board, int r, int c) {
        int startRow = r * 3;
        int startCol = c * 3;
        HashSet<char> temp = new();
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                int row = i + startRow;
                int col = j + startCol;
                if(board[row][col] == '.'){ continue ;}
                if(temp.Contains(board[row][col]))
                {
                    return false;
                }
                temp.Add(board[row][col]);
            }
        }
        return true;
    }
}
//[".",".",".",".","5",".",".","1","."]
//[".","4",".","3",".",".",".",".","."]
//[".",".",".",".",".","3",".",".","1"]
//["8",".",".",".",".",".",".","2","."]
//[".",".","2",".","7",".",".",".","."]
//[".","1","5",".",".",".",".",".","."]
//[".",".",".",".",".","2",".",".","."]
//[".","2",".","9",".",".",".",".","."]
//[".",".","4",".",".",".",".",".","."]]
