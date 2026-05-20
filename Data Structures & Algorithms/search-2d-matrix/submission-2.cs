public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        if(matrix == null) { return false; }
        int row = matrix.Length;
        if(row == 0) { return false; }
        int col = matrix[0].Length;

        int left = 0;
        int right = row * col - 1;

        while(left <= right)
        {
            int mid = left + (right - left) / 2;
            int midCol = mid % col;
            int midRow = (mid - midCol) % row;
            if(matrix[midRow][midCol] == target)
            {
                return true;
            }
            if(matrix[midRow][midCol] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return false;
    }
}
